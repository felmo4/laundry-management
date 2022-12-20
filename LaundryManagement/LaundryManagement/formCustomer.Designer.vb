<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCustomer))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideShowMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgridHome = New System.Windows.Forms.DataGridView()
        Me.btnDry8 = New System.Windows.Forms.Button()
        Me.btnWash8 = New System.Windows.Forms.Button()
        Me.btnWashDry8 = New System.Windows.Forms.Button()
        Me.btnDry7 = New System.Windows.Forms.Button()
        Me.btnWash7 = New System.Windows.Forms.Button()
        Me.btnWashDry7 = New System.Windows.Forms.Button()
        Me.btnDry6 = New System.Windows.Forms.Button()
        Me.btnWash6 = New System.Windows.Forms.Button()
        Me.btnWashDry6 = New System.Windows.Forms.Button()
        Me.btnDry5 = New System.Windows.Forms.Button()
        Me.btnWash5 = New System.Windows.Forms.Button()
        Me.btnWashDry5 = New System.Windows.Forms.Button()
        Me.btnDry4 = New System.Windows.Forms.Button()
        Me.btnWash4 = New System.Windows.Forms.Button()
        Me.btnWashDry4 = New System.Windows.Forms.Button()
        Me.btnDry3 = New System.Windows.Forms.Button()
        Me.btnWash3 = New System.Windows.Forms.Button()
        Me.btnWashDry3 = New System.Windows.Forms.Button()
        Me.btnDry2 = New System.Windows.Forms.Button()
        Me.btnWash2 = New System.Windows.Forms.Button()
        Me.btnWashDry2 = New System.Windows.Forms.Button()
        Me.btnDry1 = New System.Windows.Forms.Button()
        Me.btnWash1 = New System.Windows.Forms.Button()
        Me.btnWashDry1 = New System.Windows.Forms.Button()
        Me.panelBottom.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.dgridHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(733, 18)
        Me.panelTop.TabIndex = 2
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelBottom.Controls.Add(Me.btnHelp)
        Me.panelBottom.Controls.Add(Me.lblHelp)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 620)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(733, 27)
        Me.panelBottom.TabIndex = 6
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(704, 1)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(26, 24)
        Me.btnHelp.TabIndex = 18
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(8, 7)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(0, 16)
        Me.lblHelp.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 18)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip.TabIndex = 7
        Me.MenuStrip.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideShowMenuToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HideShowMenuToolStripMenuItem
        '
        Me.HideShowMenuToolStripMenuItem.Name = "HideShowMenuToolStripMenuItem"
        Me.HideShowMenuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.HideShowMenuToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.HideShowMenuToolStripMenuItem.Text = "Hide/Show Menu"
        '
        'dgridHome
        '
        Me.dgridHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridHome.Location = New System.Drawing.Point(693, 582)
        Me.dgridHome.Name = "dgridHome"
        Me.dgridHome.Size = New System.Drawing.Size(35, 33)
        Me.dgridHome.TabIndex = 71
        Me.dgridHome.Visible = False
        '
        'btnDry8
        '
        Me.btnDry8.BackColor = System.Drawing.Color.Transparent
        Me.btnDry8.BackgroundImage = CType(resources.GetObject("btnDry8.BackgroundImage"), System.Drawing.Image)
        Me.btnDry8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry8.FlatAppearance.BorderSize = 0
        Me.btnDry8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry8.ForeColor = System.Drawing.Color.White
        Me.btnDry8.Location = New System.Drawing.Point(524, 335)
        Me.btnDry8.Name = "btnDry8"
        Me.btnDry8.Size = New System.Drawing.Size(93, 119)
        Me.btnDry8.TabIndex = 67
        Me.btnDry8.UseVisualStyleBackColor = False
        '
        'btnWash8
        '
        Me.btnWash8.BackColor = System.Drawing.Color.Transparent
        Me.btnWash8.BackgroundImage = CType(resources.GetObject("btnWash8.BackgroundImage"), System.Drawing.Image)
        Me.btnWash8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash8.FlatAppearance.BorderSize = 0
        Me.btnWash8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash8.ForeColor = System.Drawing.Color.White
        Me.btnWash8.Location = New System.Drawing.Point(524, 453)
        Me.btnWash8.Name = "btnWash8"
        Me.btnWash8.Size = New System.Drawing.Size(93, 118)
        Me.btnWash8.TabIndex = 68
        Me.btnWash8.UseVisualStyleBackColor = False
        '
        'btnWashDry8
        '
        Me.btnWashDry8.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry8.FlatAppearance.BorderSize = 0
        Me.btnWashDry8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry8.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry8.Location = New System.Drawing.Point(517, 325)
        Me.btnWashDry8.Name = "btnWashDry8"
        Me.btnWashDry8.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry8.TabIndex = 69
        Me.btnWashDry8.Text = "8"
        Me.btnWashDry8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry8.UseVisualStyleBackColor = False
        '
        'btnDry7
        '
        Me.btnDry7.BackColor = System.Drawing.Color.Transparent
        Me.btnDry7.BackgroundImage = CType(resources.GetObject("btnDry7.BackgroundImage"), System.Drawing.Image)
        Me.btnDry7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry7.FlatAppearance.BorderSize = 0
        Me.btnDry7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry7.ForeColor = System.Drawing.Color.White
        Me.btnDry7.Location = New System.Drawing.Point(388, 335)
        Me.btnDry7.Name = "btnDry7"
        Me.btnDry7.Size = New System.Drawing.Size(93, 119)
        Me.btnDry7.TabIndex = 64
        Me.btnDry7.UseVisualStyleBackColor = False
        '
        'btnWash7
        '
        Me.btnWash7.BackColor = System.Drawing.Color.Transparent
        Me.btnWash7.BackgroundImage = CType(resources.GetObject("btnWash7.BackgroundImage"), System.Drawing.Image)
        Me.btnWash7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash7.FlatAppearance.BorderSize = 0
        Me.btnWash7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash7.ForeColor = System.Drawing.Color.White
        Me.btnWash7.Location = New System.Drawing.Point(388, 453)
        Me.btnWash7.Name = "btnWash7"
        Me.btnWash7.Size = New System.Drawing.Size(93, 118)
        Me.btnWash7.TabIndex = 65
        Me.btnWash7.UseVisualStyleBackColor = False
        '
        'btnWashDry7
        '
        Me.btnWashDry7.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry7.FlatAppearance.BorderSize = 0
        Me.btnWashDry7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry7.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry7.Location = New System.Drawing.Point(381, 325)
        Me.btnWashDry7.Name = "btnWashDry7"
        Me.btnWashDry7.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry7.TabIndex = 66
        Me.btnWashDry7.Text = "7"
        Me.btnWashDry7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry7.UseVisualStyleBackColor = False
        '
        'btnDry6
        '
        Me.btnDry6.BackColor = System.Drawing.Color.Transparent
        Me.btnDry6.BackgroundImage = CType(resources.GetObject("btnDry6.BackgroundImage"), System.Drawing.Image)
        Me.btnDry6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry6.FlatAppearance.BorderSize = 0
        Me.btnDry6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry6.ForeColor = System.Drawing.Color.White
        Me.btnDry6.Location = New System.Drawing.Point(253, 335)
        Me.btnDry6.Name = "btnDry6"
        Me.btnDry6.Size = New System.Drawing.Size(93, 119)
        Me.btnDry6.TabIndex = 61
        Me.btnDry6.UseVisualStyleBackColor = False
        '
        'btnWash6
        '
        Me.btnWash6.BackColor = System.Drawing.Color.Transparent
        Me.btnWash6.BackgroundImage = CType(resources.GetObject("btnWash6.BackgroundImage"), System.Drawing.Image)
        Me.btnWash6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash6.FlatAppearance.BorderSize = 0
        Me.btnWash6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash6.ForeColor = System.Drawing.Color.White
        Me.btnWash6.Location = New System.Drawing.Point(253, 453)
        Me.btnWash6.Name = "btnWash6"
        Me.btnWash6.Size = New System.Drawing.Size(93, 118)
        Me.btnWash6.TabIndex = 62
        Me.btnWash6.UseVisualStyleBackColor = False
        '
        'btnWashDry6
        '
        Me.btnWashDry6.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry6.FlatAppearance.BorderSize = 0
        Me.btnWashDry6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry6.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry6.Location = New System.Drawing.Point(245, 325)
        Me.btnWashDry6.Name = "btnWashDry6"
        Me.btnWashDry6.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry6.TabIndex = 63
        Me.btnWashDry6.Text = "6"
        Me.btnWashDry6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry6.UseVisualStyleBackColor = False
        '
        'btnDry5
        '
        Me.btnDry5.BackColor = System.Drawing.Color.Transparent
        Me.btnDry5.BackgroundImage = CType(resources.GetObject("btnDry5.BackgroundImage"), System.Drawing.Image)
        Me.btnDry5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry5.FlatAppearance.BorderSize = 0
        Me.btnDry5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry5.ForeColor = System.Drawing.Color.White
        Me.btnDry5.Location = New System.Drawing.Point(116, 335)
        Me.btnDry5.Name = "btnDry5"
        Me.btnDry5.Size = New System.Drawing.Size(93, 119)
        Me.btnDry5.TabIndex = 58
        Me.btnDry5.UseVisualStyleBackColor = False
        '
        'btnWash5
        '
        Me.btnWash5.BackColor = System.Drawing.Color.Transparent
        Me.btnWash5.BackgroundImage = CType(resources.GetObject("btnWash5.BackgroundImage"), System.Drawing.Image)
        Me.btnWash5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash5.FlatAppearance.BorderSize = 0
        Me.btnWash5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash5.ForeColor = System.Drawing.Color.White
        Me.btnWash5.Location = New System.Drawing.Point(116, 453)
        Me.btnWash5.Name = "btnWash5"
        Me.btnWash5.Size = New System.Drawing.Size(93, 118)
        Me.btnWash5.TabIndex = 59
        Me.btnWash5.UseVisualStyleBackColor = False
        '
        'btnWashDry5
        '
        Me.btnWashDry5.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry5.FlatAppearance.BorderSize = 0
        Me.btnWashDry5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry5.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry5.Location = New System.Drawing.Point(109, 325)
        Me.btnWashDry5.Name = "btnWashDry5"
        Me.btnWashDry5.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry5.TabIndex = 60
        Me.btnWashDry5.Text = "5"
        Me.btnWashDry5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry5.UseVisualStyleBackColor = False
        '
        'btnDry4
        '
        Me.btnDry4.BackColor = System.Drawing.Color.Transparent
        Me.btnDry4.BackgroundImage = CType(resources.GetObject("btnDry4.BackgroundImage"), System.Drawing.Image)
        Me.btnDry4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry4.FlatAppearance.BorderSize = 0
        Me.btnDry4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry4.ForeColor = System.Drawing.Color.White
        Me.btnDry4.Location = New System.Drawing.Point(524, 49)
        Me.btnDry4.Name = "btnDry4"
        Me.btnDry4.Size = New System.Drawing.Size(93, 119)
        Me.btnDry4.TabIndex = 55
        Me.btnDry4.UseVisualStyleBackColor = False
        '
        'btnWash4
        '
        Me.btnWash4.BackColor = System.Drawing.Color.Transparent
        Me.btnWash4.BackgroundImage = CType(resources.GetObject("btnWash4.BackgroundImage"), System.Drawing.Image)
        Me.btnWash4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash4.FlatAppearance.BorderSize = 0
        Me.btnWash4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash4.ForeColor = System.Drawing.Color.White
        Me.btnWash4.Location = New System.Drawing.Point(524, 167)
        Me.btnWash4.Name = "btnWash4"
        Me.btnWash4.Size = New System.Drawing.Size(93, 118)
        Me.btnWash4.TabIndex = 56
        Me.btnWash4.UseVisualStyleBackColor = False
        '
        'btnWashDry4
        '
        Me.btnWashDry4.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry4.FlatAppearance.BorderSize = 0
        Me.btnWashDry4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry4.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry4.Location = New System.Drawing.Point(517, 39)
        Me.btnWashDry4.Name = "btnWashDry4"
        Me.btnWashDry4.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry4.TabIndex = 57
        Me.btnWashDry4.Text = "4"
        Me.btnWashDry4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry4.UseVisualStyleBackColor = False
        '
        'btnDry3
        '
        Me.btnDry3.BackColor = System.Drawing.Color.Transparent
        Me.btnDry3.BackgroundImage = CType(resources.GetObject("btnDry3.BackgroundImage"), System.Drawing.Image)
        Me.btnDry3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry3.FlatAppearance.BorderSize = 0
        Me.btnDry3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry3.ForeColor = System.Drawing.Color.White
        Me.btnDry3.Location = New System.Drawing.Point(388, 49)
        Me.btnDry3.Name = "btnDry3"
        Me.btnDry3.Size = New System.Drawing.Size(93, 119)
        Me.btnDry3.TabIndex = 53
        Me.btnDry3.UseVisualStyleBackColor = False
        '
        'btnWash3
        '
        Me.btnWash3.BackColor = System.Drawing.Color.Transparent
        Me.btnWash3.BackgroundImage = CType(resources.GetObject("btnWash3.BackgroundImage"), System.Drawing.Image)
        Me.btnWash3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash3.FlatAppearance.BorderSize = 0
        Me.btnWash3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash3.ForeColor = System.Drawing.Color.White
        Me.btnWash3.Location = New System.Drawing.Point(388, 167)
        Me.btnWash3.Name = "btnWash3"
        Me.btnWash3.Size = New System.Drawing.Size(93, 118)
        Me.btnWash3.TabIndex = 54
        Me.btnWash3.UseVisualStyleBackColor = False
        '
        'btnWashDry3
        '
        Me.btnWashDry3.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry3.FlatAppearance.BorderSize = 0
        Me.btnWashDry3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry3.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry3.Location = New System.Drawing.Point(381, 39)
        Me.btnWashDry3.Name = "btnWashDry3"
        Me.btnWashDry3.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry3.TabIndex = 70
        Me.btnWashDry3.Text = "3"
        Me.btnWashDry3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry3.UseVisualStyleBackColor = False
        '
        'btnDry2
        '
        Me.btnDry2.BackColor = System.Drawing.Color.Transparent
        Me.btnDry2.BackgroundImage = CType(resources.GetObject("btnDry2.BackgroundImage"), System.Drawing.Image)
        Me.btnDry2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry2.FlatAppearance.BorderSize = 0
        Me.btnDry2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry2.ForeColor = System.Drawing.Color.White
        Me.btnDry2.Location = New System.Drawing.Point(253, 49)
        Me.btnDry2.Name = "btnDry2"
        Me.btnDry2.Size = New System.Drawing.Size(93, 119)
        Me.btnDry2.TabIndex = 50
        Me.btnDry2.UseVisualStyleBackColor = False
        '
        'btnWash2
        '
        Me.btnWash2.BackColor = System.Drawing.Color.Transparent
        Me.btnWash2.BackgroundImage = CType(resources.GetObject("btnWash2.BackgroundImage"), System.Drawing.Image)
        Me.btnWash2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash2.FlatAppearance.BorderSize = 0
        Me.btnWash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash2.ForeColor = System.Drawing.Color.White
        Me.btnWash2.Location = New System.Drawing.Point(253, 167)
        Me.btnWash2.Name = "btnWash2"
        Me.btnWash2.Size = New System.Drawing.Size(93, 118)
        Me.btnWash2.TabIndex = 51
        Me.btnWash2.UseVisualStyleBackColor = False
        '
        'btnWashDry2
        '
        Me.btnWashDry2.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry2.FlatAppearance.BorderSize = 0
        Me.btnWashDry2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry2.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry2.Location = New System.Drawing.Point(245, 39)
        Me.btnWashDry2.Name = "btnWashDry2"
        Me.btnWashDry2.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry2.TabIndex = 52
        Me.btnWashDry2.Text = "2"
        Me.btnWashDry2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry2.UseVisualStyleBackColor = False
        '
        'btnDry1
        '
        Me.btnDry1.BackColor = System.Drawing.Color.Transparent
        Me.btnDry1.BackgroundImage = CType(resources.GetObject("btnDry1.BackgroundImage"), System.Drawing.Image)
        Me.btnDry1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDry1.FlatAppearance.BorderSize = 0
        Me.btnDry1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDry1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDry1.ForeColor = System.Drawing.Color.White
        Me.btnDry1.Location = New System.Drawing.Point(116, 49)
        Me.btnDry1.Name = "btnDry1"
        Me.btnDry1.Size = New System.Drawing.Size(93, 119)
        Me.btnDry1.TabIndex = 47
        Me.btnDry1.UseVisualStyleBackColor = False
        '
        'btnWash1
        '
        Me.btnWash1.BackColor = System.Drawing.Color.Transparent
        Me.btnWash1.BackgroundImage = CType(resources.GetObject("btnWash1.BackgroundImage"), System.Drawing.Image)
        Me.btnWash1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWash1.FlatAppearance.BorderSize = 0
        Me.btnWash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWash1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWash1.ForeColor = System.Drawing.Color.White
        Me.btnWash1.Location = New System.Drawing.Point(116, 167)
        Me.btnWash1.Name = "btnWash1"
        Me.btnWash1.Size = New System.Drawing.Size(93, 118)
        Me.btnWash1.TabIndex = 48
        Me.btnWash1.UseVisualStyleBackColor = False
        '
        'btnWashDry1
        '
        Me.btnWashDry1.BackColor = System.Drawing.Color.Transparent
        Me.btnWashDry1.FlatAppearance.BorderSize = 0
        Me.btnWashDry1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWashDry1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWashDry1.ForeColor = System.Drawing.Color.Black
        Me.btnWashDry1.Location = New System.Drawing.Point(109, 39)
        Me.btnWashDry1.Name = "btnWashDry1"
        Me.btnWashDry1.Size = New System.Drawing.Size(107, 283)
        Me.btnWashDry1.TabIndex = 49
        Me.btnWashDry1.Text = "1"
        Me.btnWashDry1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWashDry1.UseVisualStyleBackColor = False
        '
        'formCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 647)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.dgridHome)
        Me.Controls.Add(Me.btnDry8)
        Me.Controls.Add(Me.btnWash8)
        Me.Controls.Add(Me.btnWashDry8)
        Me.Controls.Add(Me.btnDry7)
        Me.Controls.Add(Me.btnWash7)
        Me.Controls.Add(Me.btnWashDry7)
        Me.Controls.Add(Me.btnDry6)
        Me.Controls.Add(Me.btnWash6)
        Me.Controls.Add(Me.btnWashDry6)
        Me.Controls.Add(Me.btnDry5)
        Me.Controls.Add(Me.btnWash5)
        Me.Controls.Add(Me.btnWashDry5)
        Me.Controls.Add(Me.btnDry4)
        Me.Controls.Add(Me.btnWash4)
        Me.Controls.Add(Me.btnWashDry4)
        Me.Controls.Add(Me.btnDry3)
        Me.Controls.Add(Me.btnWash3)
        Me.Controls.Add(Me.btnWashDry3)
        Me.Controls.Add(Me.btnDry2)
        Me.Controls.Add(Me.btnWash2)
        Me.Controls.Add(Me.btnWashDry2)
        Me.Controls.Add(Me.btnDry1)
        Me.Controls.Add(Me.btnWash1)
        Me.Controls.Add(Me.btnWashDry1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "formCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formCustomer"
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.dgridHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents panelBottom As System.Windows.Forms.Panel
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideShowMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgridHome As System.Windows.Forms.DataGridView
    Friend WithEvents btnDry8 As System.Windows.Forms.Button
    Friend WithEvents btnWash8 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry8 As System.Windows.Forms.Button
    Friend WithEvents btnDry7 As System.Windows.Forms.Button
    Friend WithEvents btnWash7 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry7 As System.Windows.Forms.Button
    Friend WithEvents btnDry6 As System.Windows.Forms.Button
    Friend WithEvents btnWash6 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry6 As System.Windows.Forms.Button
    Friend WithEvents btnDry5 As System.Windows.Forms.Button
    Friend WithEvents btnWash5 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry5 As System.Windows.Forms.Button
    Friend WithEvents btnDry4 As System.Windows.Forms.Button
    Friend WithEvents btnWash4 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry4 As System.Windows.Forms.Button
    Friend WithEvents btnDry3 As System.Windows.Forms.Button
    Friend WithEvents btnWash3 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry3 As System.Windows.Forms.Button
    Friend WithEvents btnDry2 As System.Windows.Forms.Button
    Friend WithEvents btnWash2 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry2 As System.Windows.Forms.Button
    Friend WithEvents btnDry1 As System.Windows.Forms.Button
    Friend WithEvents btnWash1 As System.Windows.Forms.Button
    Friend WithEvents btnWashDry1 As System.Windows.Forms.Button
End Class
