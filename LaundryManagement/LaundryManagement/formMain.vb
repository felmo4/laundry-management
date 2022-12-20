Imports MySql.Data.MySqlClient
Public Class formMain
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet
    Dim aboutus, customeruseradd As Boolean
    Dim sqlcommandquery, orderservice As String
    Dim customerinfoid, ordermachine As Integer

    Public Class globalvariable
        Public Shared adminaddedit, adminhome As Boolean
        Public Shared orderno = 0
    End Class

    Public Sub showpannel()
        If aboutus = False Then
            panelOnButton.Visible = True
        End If
        panelHome.Visible = False
        panelOrdersmenu.Visible = False
        panelTopay.Visible = False
        panelOngoing.Visible = False
        panelForpickup.Visible = False
        panelHistory.Visible = False
        panelCustomers.Visible = False
        panelAccount.Visible = False
        panelAboutUs.Visible = False
        aboutus = False
    End Sub

    Public Sub addorder()
        globalvariable.adminhome = True
        formAddeditorder.txtMachine.Text = ordermachine
        formAddeditorder.txtService.Text = orderservice
        formAddeditorder.txtMachine.ReadOnly = True
        formAddeditorder.txtService.ReadOnly = True
        formAddeditorder.globalvariable.status = "To pay"
        formAddeditorder.Show()
    End Sub

    Public Sub exitaddedit()
        Select Case formAddeditorder.globalvariable.status
            Case "To Pay"
                btnOrders.PerformClick()
            Case "On Going"
                btnOngoing.PerformClick()
            Case "For Pick Up"
                btnForpickup.PerformClick()
        End Select
        formAddeditorder.globalvariable.status = ""
    End Sub

    Public Sub sqlcommand()
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = sqlcommandquery
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try
    End Sub


    Public Sub customerinfo()
        Dim name, address, contact As String
        Dim id As Integer
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                Dim query = "SELECT * FROM tblcustomers WHERE CustomerID =" & customerinfoid & ""
                command = New MySqlCommand(query, mycon)
                reader = command.ExecuteReader
                With reader
                    .Read()
                    id = .Item("CustomerID")
                    name = .Item("Name")
                    address = .Item("Address")
                    contact = .Item("Contact")
                End With
                mycon.Close()
                formAddeditorder.txtName.Text = name
                formAddeditorder.txtAddress.Text = address
                formAddeditorder.txtContact.Text = contact
                formAddeditorder.globalvariable.id = id
                formAddeditorder.globalvariable.name = name
                formAddeditorder.globalvariable.address = address
                formAddeditorder.globalvariable.contact = contact
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try
    End Sub

    Public Sub customeraddedit()
        txtCustomersname.Enabled = True
        txtCustomersaddress.Enabled = True
        txtCustomerscontact.Enabled = True
        txtCustomersname.BackColor = SystemColors.Window
        txtCustomersaddress.BackColor = SystemColors.Window
        txtCustomerscontact.BackColor = SystemColors.Window
        dgridCustomers.Enabled = False
        txtCustomerssearch.Enabled = False
        txtCustomerssearch.BackColor = SystemColors.ControlLight
        btnCustomersclear.Enabled = False
        btnCustomersrefresh.Enabled = False
        btnCustomersadd.Enabled = False
        btnCustomersedit.Enabled = False
        btnCustomersdelete.Enabled = False
        btnCustomerssave.Visible = True
        btnCustomerscancel.Visible = True
    End Sub

    Public Sub useraddedit()
        txtAccountusername.Enabled = True
        txtAccountpassword.Enabled = True
        comboAccounttype.Enabled = True
        txtAccountusername.BackColor = SystemColors.Window
        txtAccountpassword.BackColor = SystemColors.Window
        comboAccounttype.BackColor = SystemColors.Window
        dgridAccount.Enabled = False
        txtAccountsearch.Enabled = False
        txtAccountsearch.BackColor = SystemColors.ControlLight
        btnAccountclear.Enabled = False
        btnAccountrefresh.Enabled = False
        btnAccountadd.Enabled = False
        btnAccountedit.Enabled = False
        btnAccountdelete.Enabled = False
        btnAccountsave.Visible = True
        btnAccountcancel.Visible = True
    End Sub


    

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123456; database=laundrymanagement; port=3306"
        btnHome.PerformClick()
    End Sub


    'NAVIGATION=================================================================================================================
    '===========================================================================================================================

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        panelOnButton.Height = btnHome.Height
        panelOnButton.Top = btnHome.Top
        showpannel()
        panelHome.Visible = True
        lblHelp.Text = "Please select an available washer/dryer/washer and dryer"

        'Shows availability of machines at "Home"'

        'Enables all machines'
        Dim x = 1
        While x <= 8
            panelHome.Controls("btnWash" & x).Enabled = True
            panelHome.Controls("btnDry" & x).Enabled = True
            panelHome.Controls("btnWashDry" & x).Enabled = True
            panelHome.Controls("btnWash" & x).BackColor = Color.PaleGreen
            panelHome.Controls("btnDry" & x).BackColor = Color.PaleGreen
            panelHome.Controls("btnWashDry" & x).BackColor = Color.PaleGreen
            x = x + 1
        End While

        'Reads "tblorders" and excludes "For Pick Up" orders'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status <> 'For Pick Up'"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridHome.DataSource = myset
                dgridHome.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

        'Disables machines in terms of service'
        Dim machine(50) As Integer
        Dim service(50) As String
        Dim count = dgridHome.RowCount() - 1
        Dim index = 0

        While count <> 0 And index <> count
            machine(index) = dgridHome.Rows(index).Cells(2).Value
            service(index) = dgridHome.Rows(index).Cells(3).Value
            Select Case service(index)
                Case "Wash"
                    panelHome.Controls("btnWash" & machine(index)).Enabled = False
                    panelHome.Controls("btnWash" & machine(index)).BackColor = Color.Pink
                    panelHome.Controls("btnWashDry" & machine(index)).Enabled = False
                    panelHome.Controls("btnWashDry" & machine(index)).BackColor = Color.Pink
                Case "Dry"
                    panelHome.Controls("btnDry" & machine(index)).Enabled = False
                    panelHome.Controls("btnDry" & machine(index)).BackColor = Color.Pink
                    panelHome.Controls("btnWashDry" & machine(index)).Enabled = False
                    panelHome.Controls("btnWashDry" & machine(index)).BackColor = Color.Pink

                Case "Wash & Dry"
                    panelHome.Controls("btnWash" & machine(index)).Enabled = False
                    panelHome.Controls("btnWash" & machine(index)).BackColor = Color.Pink
                    panelHome.Controls("btnDry" & machine(index)).Enabled = False
                    panelHome.Controls("btnDry" & machine(index)).BackColor = Color.Pink
                    panelHome.Controls("btnWashDry" & machine(index)).Enabled = False
                    panelHome.Controls("btnWashDry" & machine(index)).BackColor = Color.Pink
            End Select
            index = index + 1
        End While

    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click

        panelOnButton.Height = btnOrders.Height
        panelOnButton.Top = btnOrders.Top
        showpannel()
        panelOrdersmenu.Visible = True
        panelTopay.Visible = True
        btnTopay.PerformClick()


    End Sub

    Private Sub btnTopay_Click(sender As Object, e As EventArgs) Handles btnTopay.Click


        btnTopay.BackColor = SystemColors.Control
        btnOngoing.BackColor = Color.Transparent
        btnForpickup.BackColor = Color.Transparent
        showpannel()
        panelOrdersmenu.Visible = True
        panelTopay.Visible = True
        btnTopayclear.PerformClick()
        lblHelp.Text = "Orders shown above are pending for payment"

        'Displays "To Pay" orders'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status = 'To Pay'"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridTopay.DataSource = myset
                dgridTopay.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnOngoing_Click(sender As Object, e As EventArgs) Handles btnOngoing.Click

        btnTopay.BackColor = Color.Transparent
        btnOngoing.BackColor = SystemColors.Control
        btnForpickup.BackColor = Color.Transparent
        showpannel()
        panelOrdersmenu.Visible = True
        panelOngoing.Visible = True
        btnOngoingclear.PerformClick()
        lblHelp.Text = "Orders shown above are on going"

        'Displays "On Going" orders'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status = 'On Going'"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridOngoing.DataSource = myset
                dgridOngoing.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnForpickup_Click(sender As Object, e As EventArgs) Handles btnForpickup.Click

        btnTopay.BackColor = Color.Transparent
        btnOngoing.BackColor = Color.Transparent
        btnForpickup.BackColor = SystemColors.Control
        showpannel()
        panelOrdersmenu.Visible = True
        panelForpickup.Visible = True
        btnForpickupclear.PerformClick()
        lblHelp.Text = "Orders shown above are done and ready for pick up"

        'Displays "For Pick Up" orders'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status = 'For Pick Up'"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridForpickup.DataSource = myset
                dgridForpickup.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

        panelOnButton.Height = btnHistory.Height
        panelOnButton.Top = btnHistory.Top
        showpannel()
        panelHistory.Visible = True
        comboHistoryfilter.Text = "All"
        comboHistoryfilter.ForeColor = Color.Gray
        btnHistoryclear.PerformClick()
        lblHelp.Text = "Orders shown above are completed"

        'Displays "tblhistory" orders inner join with "tblcustomers"'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID "
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridHistory.DataSource = myset
                dgridHistory.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click

        panelOnButton.Height = btnCustomers.Height
        panelOnButton.Top = btnCustomers.Top
        showpannel()
        panelCustomers.Visible = True
        btnCustomersclear.PerformClick()
        lblHelp.Text = "Existing customers"

        'Displays "tblcustomers"'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblcustomers"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridCustomers.DataSource = myset
                dgridCustomers.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click

        panelOnButton.Height = btnAccount.Height
        panelOnButton.Top = btnAccount.Top
        showpannel()
        panelAccount.Visible = True
        btnAccountclear.PerformClick()
        lblHelp.Text = "User accounts"

        'Displays "tblusers"'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblusers"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridAccount.DataSource = myset
                dgridAccount.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub


    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click

        aboutus = True
        panelOnButton.Visible = False
        showpannel()
        panelAboutUs.Visible = True
        lblHelp.Text = "About us"

    End Sub





    'HOME TAB====================================================================================================================
    '============================================================================================================================

    Private Sub btnWashDry1_Click(sender As Object, e As EventArgs) Handles btnWashDry1.Click
        ordermachine = 1
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash1_Click(sender As Object, e As EventArgs) Handles btnWash1.Click
        ordermachine = 1
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry1_Click(sender As Object, e As EventArgs) Handles btnDry1.Click
        ordermachine = 1
        orderservice = "Dry"
        addorder()
    End Sub
    Private Sub btnWashDry2_Click(sender As Object, e As EventArgs) Handles btnWashDry2.Click
        ordermachine = 2
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash2_Click(sender As Object, e As EventArgs) Handles btnWash2.Click
        ordermachine = 2
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry2_Click(sender As Object, e As EventArgs) Handles btnDry2.Click
        ordermachine = 2
        orderservice = "Dry"
        addorder()
    End Sub

    Private Sub btnWashDry3_Click(sender As Object, e As EventArgs) Handles btnWashDry3.Click
        ordermachine = 3
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash3_Click(sender As Object, e As EventArgs) Handles btnWash3.Click
        ordermachine = 3
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry3_Click(sender As Object, e As EventArgs) Handles btnDry3.Click
        ordermachine = 3
        orderservice = "Dry"
        addorder()
    End Sub

    Private Sub btnWashDry4_Click(sender As Object, e As EventArgs) Handles btnWashDry4.Click
        ordermachine = 4
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash4_Click(sender As Object, e As EventArgs) Handles btnWash4.Click
        ordermachine = 4
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry4_Click(sender As Object, e As EventArgs) Handles btnDry4.Click
        ordermachine = 4
        orderservice = "Dry"
        addorder()
    End Sub

    Private Sub btnWashDry5_Click(sender As Object, e As EventArgs) Handles btnWashDry5.Click
        ordermachine = 5
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash5_Click(sender As Object, e As EventArgs) Handles btnWash5.Click
        ordermachine = 5
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry5_Click(sender As Object, e As EventArgs) Handles btnDry5.Click
        ordermachine = 5
        orderservice = "Dry"
        addorder()
    End Sub

    Private Sub btnWashDry6_Click(sender As Object, e As EventArgs) Handles btnWashDry6.Click
        ordermachine = 6
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash6_Click(sender As Object, e As EventArgs) Handles btnWash6.Click
        ordermachine = 6
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry6_Click(sender As Object, e As EventArgs) Handles btnDry6.Click
        ordermachine = 6
        orderservice = "Dry"
        addorder()
    End Sub

    Private Sub btnWashDry7_Click(sender As Object, e As EventArgs) Handles btnWashDry7.Click
        ordermachine = 7
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash7_Click(sender As Object, e As EventArgs) Handles btnWash7.Click
        ordermachine = 7
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry7_Click(sender As Object, e As EventArgs) Handles btnDry7.Click
        ordermachine = 7
        orderservice = "Dry"
        addorder()
    End Sub

    Private Sub btnWashDry8_Click(sender As Object, e As EventArgs) Handles btnWashDry8.Click
        ordermachine = 8
        orderservice = "Wash & Dry"
        addorder()
    End Sub

    Private Sub btnWash8_Click(sender As Object, e As EventArgs) Handles btnWash8.Click
        ordermachine = 8
        orderservice = "Wash"
        addorder()
    End Sub

    Private Sub btnDry8_Click(sender As Object, e As EventArgs) Handles btnDry8.Click
        ordermachine = 8
        orderservice = "Dry"
        addorder()
    End Sub


    'TO PAY======================================================================================================================
    '============================================================================================================================

    Private Sub btnTopayrefresh_Click(sender As Object, e As EventArgs) Handles btnTopayrefresh.Click
        btnTopay.PerformClick()
    End Sub

    Private Sub txtTopaysearch_LostFocus(sender As Object, e As EventArgs) Handles txtTopaysearch.LostFocus
        If txtTopaysearch.Text = "" Then
            txtTopaysearch.Text = "Search"
            txtTopaysearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtTopaysearch_GotFocus(sender As Object, e As EventArgs) Handles txtTopaysearch.GotFocus
        If txtTopaysearch.ForeColor = Color.Gray Then
            txtTopaysearch.Text = ""
            txtTopaysearch.ForeColor = Color.Black
        End If
    End Sub


    Private Sub txtTopaysearch_TextChanged(sender As Object, e As EventArgs) Handles txtTopaysearch.TextChanged

        'Searches every single cell using search bar'
        If txtTopaysearch.Text <> "Search" Then
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status = 'To Pay' AND (OrderNo LIKE '" & txtTopaysearch.Text & "%' OR CustomerID LIKE '" & txtTopaysearch.Text & "%' OR Machine LIKE '" & txtTopaysearch.Text & "%' OR Service LIKE '" & txtTopaysearch.Text & "%' OR Status LIKE '" & txtTopaysearch.Text & "%' OR Weight LIKE '" & txtTopaysearch.Text & "%' OR Color LIKE '" & txtTopaysearch.Text & "%' OR Stains LIKE '" & txtTopaysearch.Text & "%')"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    dgridTopay.DataSource = myset
                    dgridTopay.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If

    End Sub

    Private Sub btnTopayclear_Click(sender As Object, e As EventArgs) Handles btnTopayclear.Click
        txtTopaysearch.Text = ""
        txtTopaysearch.Text = "Search"
        txtTopaysearch.ForeColor = Color.Gray
    End Sub

    Private Sub btnTopaypaid_Click(sender As Object, e As EventArgs) Handles btnTopaypaid.Click

        'Marks an order as "On Going"'
        Dim paid = MsgBox("Mark order no. " & dgridTopay.CurrentRow.Cells(0).Value & " as 'On Going'?", vbYesNo + vbQuestion, "Confirm Order")
        If paid = vbYes Then
            sqlcommandquery = "UPDATE tblorders SET Status = 'On Going' WHERE OrderNo =" & dgridTopay.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnTopay.PerformClick()
        End If

    End Sub

    Private Sub btnTopayadd_Click(sender As Object, e As EventArgs) Handles btnTopayadd.Click
        globalvariable.adminaddedit = True
        formAddeditorder.globalvariable.status = "To pay"
        formAddeditorder.Show()
    End Sub

    Private Sub btnTopayedit_Click(sender As Object, e As EventArgs) Handles btnTopayedit.Click

        'Retrieve customer info using "CustomerID"'
        customerinfoid = dgridTopay.CurrentRow.Cells(1).Value
        customerinfo()

        'Retrieves order info from "dgridToPay"'
        formAddeditorder.txtMachine.Text = dgridTopay.CurrentRow.Cells(2).Value
        formAddeditorder.txtService.Text = dgridTopay.CurrentRow.Cells(3).Value
        formAddeditorder.txtWeight.Text = dgridTopay.CurrentRow.Cells(5).Value
        formAddeditorder.comboColor.Text = dgridTopay.CurrentRow.Cells(6).Value
        formAddeditorder.comboStains.Text = dgridTopay.CurrentRow.Cells(7).Value
        globalvariable.orderno = dgridTopay.CurrentRow.Cells(0).Value
        formAddeditorder.btnAdd.Text = "Save"
        btnTopayadd.PerformClick()

    End Sub

    Private Sub btnTopaydelete_Click(sender As Object, e As EventArgs) Handles btnTopaydelete.Click

        'Deletes selected order'
        Dim delete = MsgBox("Are you sure you want to delete order no. " & dgridTopay.CurrentRow.Cells(0).Value & "?", vbYesNo + vbExclamation + MsgBoxStyle.DefaultButton2, "Delete Order")
        If delete = vbYes Then
            sqlcommandquery = "DELETE FROM tblorders WHERE OrderNo =" & dgridTopay.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnTopay.PerformClick()
        End If

    End Sub


    'ON GOING====================================================================================================================
    '============================================================================================================================

    Private Sub btnOngoingrefresh_Click(sender As Object, e As EventArgs) Handles btnOngoingrefresh.Click
        btnOngoing.PerformClick()
    End Sub

    Private Sub txtOngoingsearch_LostFocus(sender As Object, e As EventArgs) Handles txtOngoingsearch.LostFocus
        If txtOngoingsearch.Text = "" Then
            txtOngoingsearch.Text = "Search"
            txtOngoingsearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtOngoingsearch_GotFocus(sender As Object, e As EventArgs) Handles txtOngoingsearch.GotFocus
        If txtOngoingsearch.ForeColor = Color.Gray Then
            txtOngoingsearch.Text = ""
            txtOngoingsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtOngoingsearch_TextChanged(sender As Object, e As EventArgs) Handles txtOngoingsearch.TextChanged

        'Searches every single cell using search bar'
        If txtOngoingsearch.Text <> "Search" Then
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status = 'On Going' AND (OrderNo LIKE '" & txtOngoingsearch.Text & "%' OR CustomerID LIKE '" & txtOngoingsearch.Text & "%' OR Machine LIKE '" & txtOngoingsearch.Text & "%' OR Service LIKE '" & txtOngoingsearch.Text & "%' OR Status LIKE '" & txtOngoingsearch.Text & "%' OR Weight LIKE '" & txtOngoingsearch.Text & "%' OR Color LIKE '" & txtOngoingsearch.Text & "%' OR Stains LIKE '" & txtOngoingsearch.Text & "%')"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    dgridOngoing.DataSource = myset
                    dgridOngoing.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If

    End Sub

    Private Sub btnOngoingclear_Click(sender As Object, e As EventArgs) Handles btnOngoingclear.Click
        txtOngoingsearch.Text = ""
        txtOngoingsearch.Text = "Search"
        txtOngoingsearch.ForeColor = Color.Gray
    End Sub

    Private Sub btnOngoingdone_Click(sender As Object, e As EventArgs) Handles btnOngoingdone.Click

        'Transfers order info to "tblhistory" as successful order'
        Dim done = MsgBox("Mark order no. " & dgridOngoing.CurrentRow.Cells(0).Value & " as a completed order?" & vbCrLf & "You can view this order later on the 'History' tab", vbYesNo + vbQuestion, "Order Done")
        If done = vbYes Then
            sqlcommandquery = "INSERT INTO tblhistory VALUES (" & dgridOngoing.CurrentRow.Cells(0).Value & ", '" & Format(Now, "yyyy-MM-dd") & "', '" & dgridOngoing.CurrentRow.Cells(1).Value & "', " & dgridOngoing.CurrentRow.Cells(2).Value & ", '" & dgridOngoing.CurrentRow.Cells(3).Value & "', " & dgridOngoing.CurrentRow.Cells(5).Value & ", '" & dgridOngoing.CurrentRow.Cells(6).Value & "', '" & dgridOngoing.CurrentRow.Cells(7).Value & "')"
            sqlcommand()
            sqlcommandquery = "DELETE FROM tblorders WHERE OrderNo =" & dgridOngoing.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnOngoing.PerformClick()
        End If

    End Sub

    Private Sub btnOngoingforpickup_Click(sender As Object, e As EventArgs) Handles btnOngoingforpickup.Click

        'Marks an order as "For Pick Up"'
        Dim done = MsgBox("Mark order no. " & dgridOngoing.CurrentRow.Cells(0).Value & " as 'For Pick Up'?", vbYesNo + vbQuestion, "Order Done")
        If done = vbYes Then
            sqlcommandquery = "UPDATE tblorders SET Status = 'For Pick Up' WHERE OrderNo =" & dgridOngoing.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnOngoing.PerformClick()
        End If

    End Sub

    Private Sub btnOngoingadd_Click(sender As Object, e As EventArgs) Handles btnOngoingadd.Click
        globalvariable.adminaddedit = True
        formAddeditorder.globalvariable.status = "On Going"
        formAddeditorder.Show()
    End Sub

    Private Sub btnOngoingedit_Click(sender As Object, e As EventArgs) Handles btnOngoingedit.Click

        'Retrieve customer info using "CustomerID"'
        customerinfoid = dgridOngoing.CurrentRow.Cells(1).Value
        customerinfo()

        'Retrieves order info from "dgridToPay"'
        formAddeditorder.txtMachine.Text = dgridOngoing.CurrentRow.Cells(2).Value
        formAddeditorder.txtService.Text = dgridOngoing.CurrentRow.Cells(3).Value
        formAddeditorder.txtWeight.Text = dgridOngoing.CurrentRow.Cells(5).Value
        formAddeditorder.comboColor.Text = dgridOngoing.CurrentRow.Cells(6).Value
        formAddeditorder.comboStains.Text = dgridOngoing.CurrentRow.Cells(7).Value
        globalvariable.orderno = dgridOngoing.CurrentRow.Cells(0).Value
        formAddeditorder.btnAdd.Text = "Save"
        btnOngoingadd.PerformClick()

    End Sub

    Private Sub btnOngoingdelete_Click(sender As Object, e As EventArgs) Handles btnOngoingdelete.Click

        'Deletes selected order'
        Dim delete = MsgBox("Are you sure you want to delete order no. " & dgridOngoing.CurrentRow.Cells(0).Value & "?", vbYesNo + vbExclamation + MsgBoxStyle.DefaultButton2, "Delete Order")
        If delete = vbYes Then
            sqlcommandquery = "DELETE FROM tblorders WHERE OrderNo =" & dgridOngoing.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnOngoing.PerformClick()
        End If

    End Sub


    'FOR PICK UP================================================================================================================
    '===========================================================================================================================

    Private Sub btnForpickuprefresh_Click(sender As Object, e As EventArgs) Handles btnForpickuprefresh.Click
        btnForpickup.PerformClick()
    End Sub

    Private Sub txtForpickupsearch_LostFocus(sender As Object, e As EventArgs) Handles txtForpickupsearch.LostFocus
        If txtForpickupsearch.Text = "" Then
            txtForpickupsearch.Text = "Search"
            txtForpickupsearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtForpickupsearch_GotFocus(sender As Object, e As EventArgs) Handles txtForpickupsearch.GotFocus
        If txtForpickupsearch.ForeColor = Color.Gray Then
            txtForpickupsearch.Text = ""
            txtForpickupsearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtForpickupsearch_TextChanged(sender As Object, e As EventArgs) Handles txtForpickupsearch.TextChanged

        'Searches every single cell using search bar'
        If txtForpickupsearch.Text <> "Search" Then
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Status = 'For Pick Up' AND (OrderNo LIKE '" & txtForpickupsearch.Text & "%' OR CustomerID LIKE '" & txtForpickupsearch.Text & "%' OR Machine LIKE '" & txtForpickupsearch.Text & "%' OR Service LIKE '" & txtForpickupsearch.Text & "%' OR Status LIKE '" & txtForpickupsearch.Text & "%' OR Weight LIKE '" & txtForpickupsearch.Text & "%' OR Color LIKE '" & txtForpickupsearch.Text & "%' OR Stains LIKE '" & txtForpickupsearch.Text & "%')"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    dgridForpickup.DataSource = myset
                    dgridForpickup.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If

    End Sub

    Private Sub btnForpickclear_Click(sender As Object, e As EventArgs) Handles btnForpickupclear.Click
        txtForpickupsearch.Text = ""
        txtForpickupsearch.Text = "Search"
        txtForpickupsearch.ForeColor = Color.Gray
    End Sub

    Private Sub btnForpickuppickedup_Click(sender As Object, e As EventArgs) Handles btnForpickuppickedup.Click

        'Transfers order info to "tblhistory" as successful order'
        Dim done = MsgBox("Mark order no. " & dgridForpickup.CurrentRow.Cells(0).Value & " as a completed order?" & vbCrLf & "You can view this order later on the 'History' tab", vbYesNo + vbQuestion, "Order Done")
        If done = vbYes Then
            sqlcommandquery = "INSERT INTO tblhistory VALUES (" & dgridForpickup.CurrentRow.Cells(0).Value & ", '" & Format(Now, "yyyy-MM-dd") & "', '" & dgridForpickup.CurrentRow.Cells(1).Value & "', " & dgridForpickup.CurrentRow.Cells(2).Value & ", '" & dgridForpickup.CurrentRow.Cells(3).Value & "', " & dgridForpickup.CurrentRow.Cells(5).Value & ", '" & dgridForpickup.CurrentRow.Cells(6).Value & "', '" & dgridForpickup.CurrentRow.Cells(7).Value & "')"
            sqlcommand()
            sqlcommandquery = "DELETE FROM tblorders WHERE OrderNo =" & dgridForpickup.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnForpickup.PerformClick()
        End If

    End Sub

    Private Sub btnForpickupAdd_Click(sender As Object, e As EventArgs) Handles btnForpickupAdd.Click
        globalvariable.adminaddedit = True
        formAddeditorder.globalvariable.status = "For Pick Up"
        formAddeditorder.Show()
    End Sub

    Private Sub btnForpickupedit_Click(sender As Object, e As EventArgs) Handles btnForpickupedit.Click

        'Retrieves customer info using "CustomerID"'
        customerinfoid = dgridForpickup.CurrentRow.Cells(1).Value
        customerinfo()

        'Retrieves order info from "dgridToPay"'
        formAddeditorder.txtMachine.Text = dgridForpickup.CurrentRow.Cells(2).Value
        formAddeditorder.txtService.Text = dgridForpickup.CurrentRow.Cells(3).Value
        formAddeditorder.txtWeight.Text = dgridForpickup.CurrentRow.Cells(5).Value
        formAddeditorder.comboColor.Text = dgridForpickup.CurrentRow.Cells(6).Value
        formAddeditorder.comboStains.Text = dgridForpickup.CurrentRow.Cells(7).Value
        globalvariable.orderno = dgridForpickup.CurrentRow.Cells(0).Value
        formAddeditorder.btnAdd.Text = "Save"
        btnForpickupAdd.PerformClick()

    End Sub

    Private Sub btnForpickupDelete_Click(sender As Object, e As EventArgs) Handles btnForpickupDelete.Click

        'Deletes selected order'
        Dim delete = MsgBox("Are you sure you want to delete order no. " & dgridForpickup.CurrentRow.Cells(0).Value & "?", vbYesNo + vbExclamation + MsgBoxStyle.DefaultButton2, "Delete Order")
        If delete = vbYes Then
            sqlcommandquery = "DELETE FROM tblorders WHERE OrderNo =" & dgridForpickup.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnForpickup.PerformClick()
        End If

    End Sub


    'HISTORY TAB================================================================================================================
    '===========================================================================================================================

    Private Sub btnHistoryrefresh_Click(sender As Object, e As EventArgs) Handles btnHistoryrefresh.Click
        btnHistory.PerformClick()
    End Sub

    Private Sub txtHistorysearch_LostFocus(sender As Object, e As EventArgs) Handles txtHistorysearch.LostFocus
        If txtHistorysearch.Text = "" Then
            txtHistorysearch.Text = "Search"
            txtHistorysearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtHistorysearch_GotFocus(sender As Object, e As EventArgs) Handles txtHistorysearch.GotFocus
        If txtHistorysearch.ForeColor = Color.Gray Then
            txtHistorysearch.Text = ""
            txtHistorysearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtHistorysearch_TextChanged(sender As Object, e As EventArgs) Handles txtHistorysearch.TextChanged

        'Searches every single cell using search bar'
        Dim filter As String
        If txtHistorysearch.Text <> "Search" Then
            If comboHistoryfilter.Text <> "All" Then
                filter = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID  WHERE tblhistory.Date LIKE '%" & comboHistoryfilter.Text & "%' AND (tblhistory.OrderNo LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.CustomerID LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Name LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Address LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Contact LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Machine LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Service LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Weight LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Color LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Stains LIKE '" & txtHistorysearch.Text & "%')"
            Else
                filter = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID  WHERE tblhistory.OrderNo LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.CustomerID LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Name LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Address LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Contact LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Machine LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Service LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Weight LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Color LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Stains LIKE '" & txtHistorysearch.Text & "%'"
            End If
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = filter
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    dgridHistory.DataSource = myset
                    dgridHistory.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If

    End Sub

    Private Sub comboHistorysort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboHistoryfilter.SelectedIndexChanged

        'Filters history by year'
        comboHistoryfilter.ForeColor = Color.Black
        Dim filter As String
        If txtHistorysearch.Text = "Search" Then
            If comboHistoryfilter.Text <> "All" Then
                filter = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID WHERE tblhistory.Date LIKE '%" & comboHistoryfilter.Text & "%'"
            Else
                filter = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID"
            End If
        Else
            If comboHistoryfilter.Text <> "All" Then
                filter = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID  WHERE tblhistory.Date LIKE '%" & comboHistoryfilter.Text & "%' AND (tblhistory.OrderNo LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.CustomerID LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Name LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Address LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Contact LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Machine LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Service LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Weight LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Color LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Stains LIKE '" & txtHistorysearch.Text & "%')"
            Else
                filter = "SELECT tblhistory.Date, tblhistory.OrderNo, tblcustomers.Name, tblcustomers.Address, tblcustomers.Contact, tblhistory.Machine, tblhistory.Service, tblhistory.Weight, tblhistory.Color, tblhistory.Stains FROM tblhistory INNER JOIN tblcustomers ON tblhistory.CustomerID = tblcustomers.CustomerID  WHERE tblhistory.OrderNo LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.CustomerID LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Name LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Address LIKE '" & txtHistorysearch.Text & "%' OR tblcustomers.Contact LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Machine LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Service LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Weight LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Color LIKE '" & txtHistorysearch.Text & "%' OR tblhistory.Stains LIKE '" & txtHistorysearch.Text & "%'"
            End If
        End If
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = filter
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridHistory.DataSource = myset
                dgridHistory.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnHistoryclear_Click(sender As Object, e As EventArgs) Handles btnHistoryclear.Click
        txtHistorysearch.Text = ""
        txtHistorysearch.Text = "Search"
        txtHistorysearch.ForeColor = Color.Gray
    End Sub


    'CUSTOMERS TAB===============================================================================================================
    '============================================================================================================================

    Private Sub btnCustomersrefresh_Click(sender As Object, e As EventArgs) Handles btnCustomersrefresh.Click
        btnCustomers.PerformClick()
    End Sub

    Private Sub txtCustomerssearch_LostFocus(sender As Object, e As EventArgs) Handles txtCustomerssearch.LostFocus
        If txtCustomerssearch.Text = "" Then
            txtCustomerssearch.Text = "Search"
            txtCustomerssearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtCustomerssearch_GotFocus(sender As Object, e As EventArgs) Handles txtCustomerssearch.GotFocus

        If txtCustomerssearch.ForeColor = Color.Gray Then
            txtCustomerssearch.Text = ""
            txtCustomerssearch.ForeColor = Color.Black
        End If
        txtCustomersname.Text = "Name"
        txtCustomersaddress.Text = "Address"
        txtCustomerscontact.Text = "Contact"
        txtCustomersname.ForeColor = Color.Gray
        txtCustomersaddress.ForeColor = Color.Gray
        txtCustomerscontact.ForeColor = Color.Gray
        btnCustomersedit.Enabled = False
        btnCustomersdelete.Enabled = False

    End Sub

    Private Sub txtCustomerssearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerssearch.TextChanged

        'Searches every single cell using search bar'
        If txtCustomerssearch.Text <> "Search" Then
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "SELECT * FROM tblcustomers WHERE CustomerID LIKE '" & txtCustomerssearch.Text & "%' OR Name LIKE '" & txtCustomerssearch.Text & "%' OR Address LIKE '" & txtCustomerssearch.Text & "%' OR Contact LIKE '" & txtCustomerssearch.Text & "%'"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    dgridCustomers.DataSource = myset
                    dgridCustomers.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If

    End Sub

    Private Sub btnCustomersclear_Click(sender As Object, e As EventArgs) Handles btnCustomersclear.Click

        txtCustomerssearch.Text = ""
        txtCustomerssearch.Text = "Search"
        txtCustomerssearch.ForeColor = Color.Gray
        txtCustomersname.Text = "Name"
        txtCustomersaddress.Text = "Address"
        txtCustomerscontact.Text = "Contact"
        txtCustomersname.ForeColor = Color.Gray
        txtCustomersaddress.ForeColor = Color.Gray
        txtCustomerscontact.ForeColor = Color.Gray
        btnCustomersedit.Enabled = False
        btnCustomersdelete.Enabled = False

    End Sub

    Private Sub dgridCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridCustomers.CellClick

        btnCustomersedit.Enabled = True
        btnCustomersdelete.Enabled = True
        txtCustomersname.Text = dgridCustomers.CurrentRow.Cells(1).Value
        txtCustomersaddress.Text = dgridCustomers.CurrentRow.Cells(2).Value
        txtCustomerscontact.Text = dgridCustomers.CurrentRow.Cells(3).Value
        txtCustomersname.ForeColor = Color.DimGray
        txtCustomersaddress.ForeColor = Color.DimGray
        txtCustomerscontact.ForeColor = Color.DimGray

    End Sub

    Private Sub btnCustomersadd_Click(sender As Object, e As EventArgs) Handles btnCustomersadd.Click

        customeruseradd = True
        btnCustomersclear.PerformClick()
        customeraddedit()

    End Sub

    Private Sub btnCustomersedit_Click(sender As Object, e As EventArgs) Handles btnCustomersedit.Click

        txtCustomersname.ForeColor = Color.Black
        txtCustomersaddress.ForeColor = Color.Black
        txtCustomerscontact.ForeColor = Color.Black
        customeraddedit()

    End Sub

    Private Sub btnCustomerssave_Click(sender As Object, e As EventArgs) Handles btnCustomerssave.Click

        If txtCustomersname.ForeColor = Color.Gray Or txtCustomersaddress.ForeColor = Color.Gray Or txtCustomerscontact.ForeColor = Color.Gray Then
            MsgBox("Please fill-out all fields", vbOKOnly + vbExclamation, "Empty Fields")
        Else
            Dim query As String
            If customeruseradd = True Then
                query = "INSERT INTO tblcustomers(Name, Address, Contact) VALUES ('" & txtCustomersname.Text & "', '" & txtCustomersaddress.Text & "', '" & txtCustomerscontact.Text & "')"
                MsgBox("Customer added", vbOKOnly + vbInformation, "Customer Information Update")
                customeruseradd = False
            Else
                query = "UPDATE tblcustomers SET Name='" & txtCustomersname.Text & "', Address='" & txtCustomersaddress.Text & "', Contact='" & txtCustomerscontact.Text & "' WHERE CustomerID =" & dgridCustomers.CurrentRow.Cells(0).Value & ""
                MsgBox("Update successful", vbOKOnly + vbInformation, "Customer Information Update")
            End If
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = query
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
            btnCustomerscancel.PerformClick()
        End If

    End Sub

    Private Sub btnCustomerscancel_Click(sender As Object, e As EventArgs) Handles btnCustomerscancel.Click

        customeruseradd = False
        txtCustomersname.Enabled = False
        txtCustomersaddress.Enabled = False
        txtCustomerscontact.Enabled = False
        txtCustomersname.BackColor = SystemColors.ControlLight
        txtCustomersaddress.BackColor = SystemColors.ControlLight
        txtCustomerscontact.BackColor = SystemColors.ControlLight
        dgridCustomers.Enabled = True
        txtCustomerssearch.Enabled = True
        txtCustomerssearch.BackColor = SystemColors.Window
        btnCustomersclear.Enabled = True
        btnCustomersrefresh.Enabled = True
        btnCustomersadd.Enabled = True
        btnCustomersedit.Enabled = True
        btnCustomersdelete.Enabled = True
        btnCustomerssave.Visible = False
        btnCustomerscancel.Visible = False
        btnCustomers.PerformClick()

    End Sub

    Private Sub txtCustomersname_LostFocus(sender As Object, e As EventArgs) Handles txtCustomersname.LostFocus
        If txtCustomersname.Text = "" Then
            txtCustomersname.Text = "Name"
            txtCustomersname.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtCustomersname_GotFocus(sender As Object, e As EventArgs) Handles txtCustomersname.GotFocus
        If txtCustomersname.ForeColor = Color.Gray Then
            txtCustomersname.Text = ""
            txtCustomersname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCustomersaddress_LostFocus(sender As Object, e As EventArgs) Handles txtCustomersaddress.LostFocus
        If txtCustomersaddress.Text = "" Then
            txtCustomersaddress.Text = "Address"
            txtCustomersaddress.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtCustomersaddress_GotFocus(sender As Object, e As EventArgs) Handles txtCustomersaddress.GotFocus
        If txtCustomersaddress.ForeColor = Color.Gray Then
            txtCustomersaddress.Text = ""
            txtCustomersaddress.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCustomerscontact_LostFocus(sender As Object, e As EventArgs) Handles txtCustomerscontact.LostFocus
        If txtCustomerscontact.Text = "" Then
            txtCustomerscontact.Text = "Contact"
            txtCustomerscontact.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtCustomerscontact_GotFocus(sender As Object, e As EventArgs) Handles txtCustomerscontact.GotFocus
        If txtCustomerscontact.ForeColor = Color.Gray Then
            txtCustomerscontact.Text = ""
            txtCustomerscontact.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnCustomersdelete_Click(sender As Object, e As EventArgs) Handles btnCustomersdelete.Click

        'Checks if customer has some existing or completed order'
        Dim count = 0
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                Dim query = "select * from tblorders where customerid = " & dgridCustomers.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query, mycon)
                reader = command.ExecuteReader
                While reader.Read
                    count = count + 1
                End While
                mycon.Close()
            End If
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                Dim query = "select * from tblhistory where customerid = " & dgridCustomers.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query, mycon)
                reader = command.ExecuteReader
                While reader.Read
                    count = count + 1
                End While
                mycon.Close()
            End If
            If count > 0 Then
                MsgBox("customer " & dgridCustomers.CurrentRow.Cells(0).Value & " cannot be deleted due to an existing or completed order", vbOKOnly + vbExclamation, "customer info")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

        'Deletes selected customer'
        Dim delete = MsgBox("Are you sure you want to delete customer " & dgridCustomers.CurrentRow.Cells(0).Value & "?", vbYesNo + vbExclamation + MsgBoxStyle.DefaultButton2, "Delete Customer")
        If delete = vbYes Then
            sqlcommandquery = "DELETE FROM tblcustomers WHERE CustomerID =" & dgridCustomers.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnCustomersclear.PerformClick()
        End If

    End Sub


    'ACCOUNT TAB=================================================================================================================
    '============================================================================================================================

    Private Sub btnAccountrefresh_Click(sender As Object, e As EventArgs) Handles btnAccountrefresh.Click
        btnAccount.PerformClick()
    End Sub

    Private Sub txtAccountsearch_LostFocus(sender As Object, e As EventArgs) Handles txtAccountsearch.LostFocus
        If txtAccountsearch.Text = "" Then
            txtAccountsearch.Text = "Search"
            txtAccountsearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtAccountsearch_GotFocus(sender As Object, e As EventArgs) Handles txtAccountsearch.GotFocus
        If txtAccountsearch.ForeColor = Color.Gray Then
            txtAccountsearch.Text = ""
            txtAccountsearch.ForeColor = Color.Black
        End If
        txtAccountusername.Text = "Username"
        txtAccountpassword.Text = "Password"
        comboAccounttype.Text = "Type"
        txtAccountusername.ForeColor = Color.Gray
        txtAccountpassword.ForeColor = Color.Gray
        comboAccounttype.ForeColor = Color.Gray
        btnAccountedit.Enabled = False
        btnAccountdelete.Enabled = False
    End Sub

    Private Sub txtAccountsearch_TextChanged(sender As Object, e As EventArgs) Handles txtAccountsearch.TextChanged

        'Searches every single cell using search bar'
        If txtAccountsearch.Text <> "Search" Then
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "SELECT * FROM tblusers WHERE UserID LIKE '" & txtAccountsearch.Text & "%' OR Username LIKE '" & txtAccountsearch.Text & "%' OR Type LIKE '" & txtAccountsearch.Text & "%'"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    dgridAccount.DataSource = myset
                    dgridAccount.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If

    End Sub

    Private Sub btnAccountclear_Click(sender As Object, e As EventArgs) Handles btnAccountclear.Click

        txtAccountsearch.Text = ""
        txtAccountsearch.Text = "Search"
        txtAccountsearch.ForeColor = Color.Gray
        txtAccountusername.Text = "Username"
        txtAccountpassword.Text = "Password"
        comboAccounttype.Text = "Type"
        txtAccountusername.ForeColor = Color.Gray
        txtAccountpassword.ForeColor = Color.Gray
        comboAccounttype.ForeColor = Color.Gray
        btnAccountedit.Enabled = False
        btnAccountdelete.Enabled = False

    End Sub

    Private Sub dgridAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridAccount.CellClick

        '"admin" cannot be deleted'
        If dgridAccount.CurrentRow.Cells(0).Value <> 1 Then
            btnAccountdelete.Enabled = True
            btnAccountedit.Enabled = True
        Else
            btnAccountdelete.Enabled = False
            btnAccountedit.Enabled = False
        End If

        txtAccountusername.Text = dgridAccount.CurrentRow.Cells(1).Value
        txtAccountpassword.Text = dgridAccount.CurrentRow.Cells(2).Value
        comboAccounttype.Text = dgridAccount.CurrentRow.Cells(3).Value
        txtAccountusername.ForeColor = Color.DimGray
        txtAccountpassword.ForeColor = Color.DimGray
        comboAccounttype.ForeColor = Color.DimGray

    End Sub

    Private Sub btnAccountadd_Click(sender As Object, e As EventArgs) Handles btnAccountadd.Click

        customeruseradd = True
        btnAccountclear.PerformClick()
        useraddedit()

    End Sub

    Private Sub btnAccountedit_Click(sender As Object, e As EventArgs) Handles btnAccountedit.Click

        txtAccountusername.ForeColor = Color.Black
        txtAccountpassword.ForeColor = Color.Black
        comboAccounttype.ForeColor = Color.Black
        useraddedit()

    End Sub

    Private Sub btnAccountsave_Click(sender As Object, e As EventArgs) Handles btnAccountsave.Click

        If txtAccountusername.ForeColor = Color.Gray Or txtAccountpassword.ForeColor = Color.Gray Or comboAccounttype.ForeColor = Color.Gray Then
            MsgBox("Please fill-out all fields", vbOKOnly + vbExclamation, "Empty Fields")
        Else
            Dim query As String
            If customeruseradd = True Then
                query = "INSERT INTO tblusers(Username, Password, Type) VALUES ('" & txtAccountusername.Text & "', '" & txtAccountpassword.Text & "', '" & comboAccounttype.Text & "')"
                MsgBox("User added", vbOKOnly + vbInformation, "Account Information Update")
                customeruseradd = False
            Else
                query = "UPDATE tblusers SET Username='" & txtAccountusername.Text & "', Password='" & txtAccountpassword.Text & "', Type='" & comboAccounttype.Text & "' WHERE UserID =" & dgridAccount.CurrentRow.Cells(0).Value & ""
                MsgBox("Update successful", vbOKOnly + vbInformation, "Account Information Update")
            End If
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = query
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
            btnAccountcancel.PerformClick()
        End If

    End Sub

    Private Sub btnAccountcancel_Click(sender As Object, e As EventArgs) Handles btnAccountcancel.Click

        customeruseradd = False
        txtAccountusername.Enabled = False
        txtAccountpassword.Enabled = False
        comboAccounttype.Enabled = False
        txtAccountusername.BackColor = SystemColors.ControlLight
        txtAccountpassword.BackColor = SystemColors.ControlLight
        comboAccounttype.BackColor = SystemColors.ControlLight
        dgridAccount.Enabled = True
        txtAccountsearch.Enabled = True
        txtAccountsearch.BackColor = SystemColors.Window
        btnAccountclear.Enabled = True
        btnAccountrefresh.Enabled = True
        btnAccountadd.Enabled = True
        btnAccountedit.Enabled = True
        btnAccountdelete.Enabled = True
        btnAccountsave.Visible = False
        btnAccountcancel.Visible = False
        btnAccount.PerformClick()

    End Sub

    Private Sub txtAccountusername_LostFocus(sender As Object, e As EventArgs) Handles txtAccountusername.LostFocus
        If txtAccountusername.Text = "" Then
            txtAccountusername.Text = "Username"
            txtAccountusername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtAccountusername_GotFocus(sender As Object, e As EventArgs) Handles txtAccountusername.GotFocus
        If txtAccountusername.ForeColor = Color.Gray Then
            txtAccountusername.Text = ""
            txtAccountusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAccountpassword_LostFocus(sender As Object, e As EventArgs) Handles txtAccountpassword.LostFocus
        If txtAccountpassword.Text = "" Then
            txtAccountpassword.Text = "Username"
            txtAccountpassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtAccountpassword_GotFocus(sender As Object, e As EventArgs) Handles txtAccountpassword.GotFocus
        If txtAccountpassword.ForeColor = Color.Gray Then
            txtAccountpassword.Text = ""
            txtAccountpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub comboAccounttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAccounttype.SelectedIndexChanged
        comboAccounttype.ForeColor = Color.Black
    End Sub

    Private Sub btnAccountdelete_Click(sender As Object, e As EventArgs) Handles btnAccountdelete.Click

        'Deletes selected user'
        Dim delete = MsgBox("Are you sure you want to delete user " & dgridAccount.CurrentRow.Cells(0).Value & "?", vbYesNo + vbExclamation + MsgBoxStyle.DefaultButton2, "Delete User")
        If delete = vbYes Then
            sqlcommandquery = "DELETE FROM tblusers WHERE UserID =" & dgridAccount.CurrentRow.Cells(0).Value & ""
            sqlcommand()
            btnAccountclear.PerformClick()
        End If

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        formHelp.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim logout = MsgBox("Are you sure you want to log out?", vbYesNo + vbExclamation + MsgBoxStyle.DefaultButton2, "Logout")
        If logout = vbYes Then
            formLogin.Show()
            Me.Close()
        End If
    End Sub


End Class