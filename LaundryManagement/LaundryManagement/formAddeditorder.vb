Imports MySql.Data.MySqlClient
Public Class formAddeditorder
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet
    Dim match

    Public Class globalvariable
        Public Shared status, id, name, address, contact As String
    End Class

    Public Sub setnull()
        globalvariable.id = ""
        globalvariable.name = ""
        globalvariable.address = ""
        globalvariable.contact = ""
        match = vbNull
    End Sub

    Private Sub formAddorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123456; database=laundrymanagement; port=3306"
        btnCancel.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtMachine.Text = "" Or txtMachine.Text = "Machine" Or txtService.Text = "" Or txtService.Text = "Service" Or txtName.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Or txtWeight.Text = "" Or comboColor.Text = "" Or comboStains.Text = "" Then
            MsgBox("Please fill-out all fields", vbOKOnly + vbExclamation, "Empty Fields")
        ElseIf txtWeight.Text > 8.0 Then
            MsgBox("Weight limit exceeded", vbOKOnly + vbExclamation, "Invalid Weight")
        Else

            'Checks if machine is available for "Add" and "Edit" buttons at "Orders" tab'==================================================
            If formMain.globalvariable.adminaddedit = True And globalvariable.status <> "For Pick Up" Then
                If (txtMachine.Text <= 8 And txtMachine.Text >= 1) And (txtService.Text = "Wash" Or txtService.Text = "Dry" Or txtService.Text = "Wash & Dry") Then
                    Try
                        mycon.Open()
                        If mycon.State = ConnectionState.Open Then
                            myadap.SelectCommand = mycon.CreateCommand
                            myadap.SelectCommand.CommandText = "SELECT * FROM tblorders WHERE Machine=" & txtMachine.Text & " AND Status <> 'For Pick Up'"
                            myadap.SelectCommand.ExecuteReader()
                            mycon.Close()
                            myset = New DataSet
                            myadap.Fill(myset, "1")
                            dgridAddeditorder.DataSource = myset
                            dgridAddeditorder.DataMember = "1"
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    Finally
                        mycon.Close()
                    End Try
                    Dim count = dgridAddeditorder.RowCount() - 1
                    Dim index = 0
                    While count <> 0 And index <> count
                        If (formMain.globalvariable.orderno = 0 Or dgridAddeditorder.Rows(index).Cells(0).Value <> formMain.globalvariable.orderno) And (txtService.Text = dgridAddeditorder.Rows(index).Cells(3).Value Or txtService.Text = "Wash & Dry" Or dgridAddeditorder.Rows(index).Cells(3).Value = "Wash & Dry") Then
                            MsgBox("Machine is occupied by order no. " & dgridAddeditorder.Rows(index).Cells(0).Value & vbCrLf & "Please select an available washer/dryer/washer and dryer", vbOKOnly + vbExclamation, "Machine Unavailable")
                            txtMachine.Text = "Machine"
                            txtService.Text = "Service"
                            mycon.Close()
                            Exit Sub
                        End If
                        index = index + 1
                    End While
                Else
                    MsgBox("Machine or service type invalid", vbOKOnly + vbExclamation, "Invalid Input")
                    txtMachine.Text = "Machine"
                    txtService.Text = "Service"
                    Exit Sub
                End If
            End If

            'Handles customer information'================================================================================================
            If match = vbYes Or formMain.globalvariable.adminaddedit = True Then 'For existing customers'
                'Checks for any info changes'
                If txtName.Text <> globalvariable.name Or txtAddress.Text <> globalvariable.address Or txtContact.Text <> globalvariable.contact Then
                    Dim update = MsgBox("Do you wish to update the customer's personal information into this? " & vbCrLf & vbCrLf & txtName.Text & vbCrLf & txtAddress.Text & vbCrLf & txtContact.Text, vbYesNoCancel + vbQuestion, "Customer Information Update")
                    If update = vbYes Then
                        Try
                            mycon.Open()
                            If mycon.State = ConnectionState.Open Then
                                myadap.SelectCommand = mycon.CreateCommand
                                myadap.SelectCommand.CommandText = "UPDATE tblcustomers SET Name='" & txtName.Text & "', Address='" & txtAddress.Text & "', Contact='" & txtContact.Text & "' WHERE CustomerID =" & globalvariable.id & ""
                                myadap.SelectCommand.ExecuteReader()
                                mycon.Close()
                                MsgBox("Update successful", vbOKOnly + vbInformation, "Customer Information Update")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        Finally
                            mycon.Close()
                        End Try
                    ElseIf update = vbNo Then
                        txtName.Text = globalvariable.name
                        txtAddress.Text = globalvariable.address
                        txtContact.Text = globalvariable.contact
                        MsgBox("Changes discarded", vbOKOnly + vbInformation, "Customer Information Update")
                    Else
                        Exit Sub
                    End If
                End If
            Else 'For new customers'
                Try
                    mycon.Open()
                    If mycon.State = ConnectionState.Open Then
                        myadap.SelectCommand = mycon.CreateCommand
                        myadap.SelectCommand.CommandText = "INSERT INTO tblcustomers(Name, Address, Contact) VALUES ('" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtContact.Text & "')"
                        myadap.SelectCommand.ExecuteReader()
                        mycon.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    mycon.Close()
                End Try
            End If


            'Processing of order'=========================================================================================================
            Dim customer, order As Integer
            Try
                'Retrieves "CustomerID'
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    Dim query = "SELECT * FROM tblcustomers WHERE Name='" & txtName.Text & "' AND Address='" & txtAddress.Text & "' AND Contact='" & txtContact.Text & "'"
                    command = New MySqlCommand(query, mycon)
                    reader = command.ExecuteReader
                    With reader
                        .Read()
                        customer = .Item("CustomerID")
                    End With
                    mycon.Close()
                End If

                'Adds/edit the customer's order'
                If formMain.globalvariable.orderno <> 0 Then
                    mycon.Open()
                    If mycon.State = ConnectionState.Open Then
                        myadap.SelectCommand = mycon.CreateCommand
                        myadap.SelectCommand.CommandText = "UPDATE tblorders SET CustomerID='" & customer & "', Machine=" & txtMachine.Text & ", Service='" & txtService.Text & "', Status='" & globalvariable.status & "', Weight=" & txtWeight.Text & ", Color='" & comboColor.Text & "', Stains='" & comboStains.Text & "' WHERE OrderNo=" & formMain.globalvariable.orderno & ""
                        myadap.SelectCommand.ExecuteReader()
                        mycon.Close()
                        MsgBox("Order successfully updated", vbOKOnly + vbInformation, "Order Update")
                    End If
                Else
                    mycon.Open()
                    If mycon.State = ConnectionState.Open Then
                        myadap.SelectCommand = mycon.CreateCommand
                        myadap.SelectCommand.CommandText = "INSERT INTO tblorders(CustomerID, Machine, Service, Status, Weight, Color, Stains) VALUES ('" & customer & "', " & txtMachine.Text & ", '" & txtService.Text & "', '" & globalvariable.status & "', " & txtWeight.Text & ", '" & comboColor.Text & "', '" & comboStains.Text & "')"
                        myadap.SelectCommand.ExecuteReader()
                        mycon.Close()
                        MsgBox("Order successfully added", vbOKOnly + vbInformation, "Order Successful")
                    End If
                End If

                'Exits'
                If formMain.globalvariable.adminaddedit = True Then
                    setnull()
                    formMain.globalvariable.adminaddedit = False
                    formMain.globalvariable.orderno = 0
                    Me.Close()
                    formMain.exitaddedit()
                Else
                    'Prints order details'
                    mycon.Open()
                    If mycon.State = ConnectionState.Open Then
                        Dim query = "SELECT * FROM tblorders WHERE Machine=" & txtMachine.Text & " AND Service='" & txtService.Text & "' AND Status='" & globalvariable.status & "'"
                        command = New MySqlCommand(query, mycon)
                        reader = command.ExecuteReader
                        With reader
                            .Read()
                            order = .Item("OrderNo")
                        End With
                        mycon.Close()
                    End If
                    MsgBox("Order No: " & order & vbCrLf & "Customer ID: " & customer & vbCrLf & "Machine No: " & txtMachine.Text & vbCrLf & "Service: " & txtService.Text & vbCrLf & "Weight(kg): " & txtWeight.Text & vbCrLf & "Color: " & comboColor.Text & vbCrLf & "Stains: " & comboStains.Text, vbOKOnly + vbInformation, "Order Details")
                    setnull()
                    Me.Close()
                    If formMain.globalvariable.adminhome = True Then
                        formMain.btnHome.PerformClick()
                        formMain.globalvariable.adminhome = False
                    Else
                        formCustomer.loadmachine()
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                mycon.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        setnull()
        Me.Close()
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus

        'Recognizes existing customers'
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "SELECT * FROM tblcustomers WHERE Name='" & txtName.Text & "'"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                dgridAddeditorder.DataSource = myset
                dgridAddeditorder.DataMember = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try
        Dim count = dgridAddeditorder.RowCount() - 1
        Dim index = 0
        While count <> 0 And index <> count
            match = MsgBox("Is this the same customer? " & vbCrLf & vbCrLf & dgridAddeditorder.Rows(index).Cells(1).Value & vbCrLf & dgridAddeditorder.Rows(index).Cells(2).Value & vbCrLf & dgridAddeditorder.Rows(index).Cells(3).Value, vbYesNo + vbQuestion, "Customer Matched")
            If match = vbYes Then
                txtName.Text = dgridAddeditorder.Rows(index).Cells(1).Value
                txtAddress.Text = dgridAddeditorder.Rows(index).Cells(2).Value
                txtContact.Text = dgridAddeditorder.Rows(index).Cells(3).Value
                globalvariable.id = dgridAddeditorder.Rows(index).Cells(0).Value
                globalvariable.name = txtName.Text
                globalvariable.address = txtAddress.Text
                globalvariable.contact = txtContact.Text
                Exit While
            End If
            index = index + 1
        End While

    End Sub

    Private Sub txtMachine_GotFocus(sender As Object, e As EventArgs) Handles txtMachine.GotFocus
        txtMachine.Text = ""
    End Sub

    Private Sub txtMachine_LostFocus(sender As Object, e As EventArgs) Handles txtMachine.LostFocus
        If txtMachine.Text = "" Then
            txtMachine.Text = "Machine"
        End If
    End Sub
    Private Sub txtService_GotFocus(sender As Object, e As EventArgs) Handles txtService.GotFocus
        txtService.Text = ""
    End Sub

    Private Sub txtService_LostFocus(sender As Object, e As EventArgs) Handles txtService.LostFocus
        If txtService.Text = "" Then
            txtService.Text = "Service"
        End If
    End Sub
End Class