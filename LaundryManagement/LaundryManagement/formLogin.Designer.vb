<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtLoginpassword = New System.Windows.Forms.TextBox()
        Me.txtLoginusername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(256, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 24)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtLoginpassword
        '
        Me.txtLoginpassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoginpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoginpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginpassword.ForeColor = System.Drawing.Color.Gray
        Me.txtLoginpassword.Location = New System.Drawing.Point(22, 199)
        Me.txtLoginpassword.Name = "txtLoginpassword"
        Me.txtLoginpassword.Size = New System.Drawing.Size(240, 19)
        Me.txtLoginpassword.TabIndex = 33
        Me.txtLoginpassword.Text = "Password"
        '
        'txtLoginusername
        '
        Me.txtLoginusername.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoginusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoginusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginusername.ForeColor = System.Drawing.Color.Gray
        Me.txtLoginusername.Location = New System.Drawing.Point(22, 174)
        Me.txtLoginusername.Name = "txtLoginusername"
        Me.txtLoginusername.Size = New System.Drawing.Size(240, 19)
        Me.txtLoginusername.TabIndex = 32
        Me.txtLoginusername.Text = "Username"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Silver
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(51, 253)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(182, 33)
        Me.btnLogin.TabIndex = 31
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), System.Drawing.Image)
        Me.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogo.FlatAppearance.BorderSize = 0
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.Wheat
        Me.btnLogo.Location = New System.Drawing.Point(78, 33)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(129, 124)
        Me.btnLogo.TabIndex = 34
        Me.btnLogo.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.Window
        Me.btnShow.BackgroundImage = CType(resources.GetObject("btnShow.BackgroundImage"), System.Drawing.Image)
        Me.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShow.FlatAppearance.BorderSize = 0
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Wheat
        Me.btnShow.Location = New System.Drawing.Point(240, 201)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(18, 15)
        Me.btnShow.TabIndex = 35
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(284, 338)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.txtLoginpassword)
        Me.Controls.Add(Me.txtLoginusername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLoginvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtLoginpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginusername As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnLogo As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
