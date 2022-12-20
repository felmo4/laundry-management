Imports MySql.Data.MySqlClient
Public Class formCustomer
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim myset As DataSet
    Dim orderservice As String
    Dim ordermachine As Integer

    Public Sub addorder()
        formAddeditorder.txtMachine.Text = ordermachine
        formAddeditorder.txtService.Text = orderservice
        formAddeditorder.txtMachine.ReadOnly = True
        formAddeditorder.txtService.ReadOnly = True
        formAddeditorder.globalvariable.status = "To pay"
        formAddeditorder.Show()
    End Sub

    Public Sub loadmachine()

        'Enables all machines'
        Dim x = 1
        While x <= 8
            Me.Controls("btnWash" & x).Enabled = True
            Me.Controls("btnDry" & x).Enabled = True
            Me.Controls("btnWashDry" & x).Enabled = True
            Me.Controls("btnWash" & x).BackColor = Color.PaleGreen
            Me.Controls("btnDry" & x).BackColor = Color.PaleGreen
            Me.Controls("btnWashDry" & x).BackColor = Color.PaleGreen
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
                    Me.Controls("btnWash" & machine(index)).Enabled = False
                    Me.Controls("btnWash" & machine(index)).BackColor = Color.Pink
                    Me.Controls("btnWashDry" & machine(index)).Enabled = False
                    Me.Controls("btnWashDry" & machine(index)).BackColor = Color.Pink
                Case "Dry"
                    Me.Controls("btnDry" & machine(index)).Enabled = False
                    Me.Controls("btnDry" & machine(index)).BackColor = Color.Pink
                    Me.Controls("btnWashDry" & machine(index)).Enabled = False
                    Me.Controls("btnWashDry" & machine(index)).BackColor = Color.Pink

                Case "Wash & Dry"
                    Me.Controls("btnWash" & machine(index)).Enabled = False
                    Me.Controls("btnWash" & machine(index)).BackColor = Color.Pink
                    Me.Controls("btnDry" & machine(index)).Enabled = False
                    Me.Controls("btnDry" & machine(index)).BackColor = Color.Pink
                    Me.Controls("btnWashDry" & machine(index)).Enabled = False
                    Me.Controls("btnWashDry" & machine(index)).BackColor = Color.Pink
            End Select
            index = index + 1
        End While

    End Sub


    Private Sub formCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123456; database=laundrymanagement; port=3306"
        lblHelp.Text = "Please select an available washer/dryer/washer and dryer"
        loadmachine()
    End Sub


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

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        formHelp.Show()
    End Sub

    Private Sub HideShowMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideShowMenuToolStripMenuItem.Click
        If MenuStrip.Visible = False Then
            MenuStrip.Visible = True
        Else
            MenuStrip.Visible = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        formLogin.Show()
        Me.Close()
    End Sub


End Class