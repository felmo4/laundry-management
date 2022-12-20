Imports MySql.Data.MySqlClient
Public Class formLogin
    Dim mycon As New MySqlConnection
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand

    Private Sub formLoginvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123456; database=laundrymanagement; port=3306"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim count = 0
        Dim access As String
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                Dim query = "SELECT * FROM tblusers WHERE Username = '" & txtLoginusername.Text & "' AND Password ='" & txtLoginpassword.Text & "'"
                command = New MySqlCommand(query, mycon)
                reader = command.ExecuteReader
                While reader.Read
                    count = count + 1
                End While
            End If
            If count > 0 Then
                With reader
                    .Read()
                    access = .Item("Type")
                End With
                mycon.Close()
                If access = "admin" Then
                    formMain.Show()
                    Me.Close()
                Else
                    formCustomer.Show()
                    Me.Close()
                End If
            Else
                MsgBox("Invalid username or password", vbOKOnly + vbInformation, "Login Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtLoginpassword.PasswordChar = "*" Then
            txtLoginpassword.PasswordChar = ""
        Else
            txtLoginpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtLoginusername_LostFocus(sender As Object, e As EventArgs) Handles txtLoginusername.LostFocus
        If txtLoginusername.Text = "" Then
            txtLoginusername.Text = "Username"
            txtLoginusername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtLoginusername_GotFocus(sender As Object, e As EventArgs) Handles txtLoginusername.GotFocus
        If txtLoginusername.ForeColor = Color.Gray Then
            txtLoginusername.Text = ""
            txtLoginusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLoginpassword_LostFocus(sender As Object, e As EventArgs) Handles txtLoginpassword.LostFocus
        If txtLoginpassword.Text = "" Then
            txtLoginpassword.PasswordChar = ""
            txtLoginpassword.Text = "Password"
            txtLoginpassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtLoginpassword_GotFocus(sender As Object, e As EventArgs) Handles txtLoginpassword.GotFocus
        If txtLoginpassword.ForeColor = Color.Gray Then
            txtLoginpassword.Text = ""
            txtLoginpassword.ForeColor = Color.Black
            txtLoginpassword.PasswordChar = "*"
        End If
    End Sub
End Class