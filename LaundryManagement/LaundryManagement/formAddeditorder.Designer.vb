<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddeditorder
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.comboColor = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.comboStains = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMachine = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.dgridAddeditorder = New System.Windows.Forms.DataGridView()
        CType(Me.dgridAddeditorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(51, 305)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(182, 27)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(256, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(26, 24)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'comboColor
        '
        Me.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboColor.FormattingEnabled = True
        Me.comboColor.Items.AddRange(New Object() {"White", "Light", "Dark", "Black", "White+Light", "Dark+Black", "Light+Dark"})
        Me.comboColor.Location = New System.Drawing.Point(69, 226)
        Me.comboColor.Name = "comboColor"
        Me.comboColor.Size = New System.Drawing.Size(94, 28)
        Me.comboColor.TabIndex = 40
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(16, 110)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(206, 19)
        Me.txtName.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(16, 144)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(192, 19)
        Me.txtAddress.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Contact"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(16, 178)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(192, 19)
        Me.txtContact.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "  kg  "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(16, 231)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(42, 19)
        Me.txtWeight.TabIndex = 45
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comboStains
        '
        Me.comboStains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboStains.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboStains.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStains.FormattingEnabled = True
        Me.comboStains.Items.AddRange(New Object() {"None", "Light", "Medium", "Heavy"})
        Me.comboStains.Location = New System.Drawing.Point(175, 226)
        Me.comboStains.Name = "comboStains"
        Me.comboStains.Size = New System.Drawing.Size(94, 28)
        Me.comboStains.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "      Color      "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "     Stains     "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMachine
        '
        Me.txtMachine.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtMachine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.txtMachine.ForeColor = System.Drawing.Color.PaleGreen
        Me.txtMachine.Location = New System.Drawing.Point(14, 13)
        Me.txtMachine.Name = "txtMachine"
        Me.txtMachine.Size = New System.Drawing.Size(183, 55)
        Me.txtMachine.TabIndex = 50
        Me.txtMachine.Text = "Machine"
        '
        'txtService
        '
        Me.txtService.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtService.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtService.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtService.ForeColor = System.Drawing.Color.PaleGreen
        Me.txtService.Location = New System.Drawing.Point(16, 68)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(119, 22)
        Me.txtService.TabIndex = 51
        Me.txtService.Text = "Service"
        '
        'dgridAddeditorder
        '
        Me.dgridAddeditorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridAddeditorder.Location = New System.Drawing.Point(247, 326)
        Me.dgridAddeditorder.Name = "dgridAddeditorder"
        Me.dgridAddeditorder.Size = New System.Drawing.Size(35, 33)
        Me.dgridAddeditorder.TabIndex = 52
        Me.dgridAddeditorder.Visible = False
        '
        'formAddeditorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(284, 362)
        Me.Controls.Add(Me.dgridAddeditorder)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.txtMachine)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboStains)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.comboColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formAddeditorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgridAddeditorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents comboColor As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents comboStains As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMachine As System.Windows.Forms.TextBox
    Friend WithEvents txtService As System.Windows.Forms.TextBox
    Friend WithEvents dgridAddeditorder As System.Windows.Forms.DataGridView
End Class
