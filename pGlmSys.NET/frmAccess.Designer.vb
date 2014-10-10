<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAccess
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents picLogo As System.Windows.Forms.PictureBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents txtUser As System.Windows.Forms.TextBox
	Public WithEvents cbServername As System.Windows.Forms.ComboBox
	Public WithEvents cmdOptions As System.Windows.Forms.Button
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _imgKey_3 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_2 As System.Windows.Forms.PictureBox
	Public WithEvents _imgKey_1 As System.Windows.Forms.PictureBox
	Public WithEvents imgUnlock As System.Windows.Forms.PictureBox
	Public WithEvents imgLock As System.Windows.Forms.PictureBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.Panel
	Public WithEvents lVersion As System.Windows.Forms.Label
	Public WithEvents lblGlm As System.Windows.Forms.Label
	Public WithEvents imgKey As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAccess))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.picLogo = New System.Windows.Forms.PictureBox
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.txtUser = New System.Windows.Forms.TextBox
		Me.Frame1 = New System.Windows.Forms.Panel
		Me.cbServername = New System.Windows.Forms.ComboBox
		Me.cmdOptions = New System.Windows.Forms.Button
		Me.Label3 = New System.Windows.Forms.Label
		Me._imgKey_3 = New System.Windows.Forms.PictureBox
		Me._imgKey_2 = New System.Windows.Forms.PictureBox
		Me._imgKey_1 = New System.Windows.Forms.PictureBox
		Me.imgUnlock = New System.Windows.Forms.PictureBox
		Me.imgLock = New System.Windows.Forms.PictureBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lVersion = New System.Windows.Forms.Label
		Me.lblGlm = New System.Windows.Forms.Label
		Me.imgKey = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.imgKey, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.Info
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Access Window"
		Me.ClientSize = New System.Drawing.Size(470, 307)
		Me.Location = New System.Drawing.Point(259, 184)
		Me.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAccess"
		Me.picLogo.BackColor = System.Drawing.SystemColors.Info
		Me.picLogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picLogo.Size = New System.Drawing.Size(145, 161)
		Me.picLogo.Location = New System.Drawing.Point(16, 88)
		Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
		Me.picLogo.TabIndex = 9
		Me.picLogo.Dock = System.Windows.Forms.DockStyle.None
		Me.picLogo.CausesValidation = True
		Me.picLogo.Enabled = True
		Me.picLogo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picLogo.Cursor = System.Windows.Forms.Cursors.Default
		Me.picLogo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picLogo.TabStop = True
		Me.picLogo.Visible = True
		Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picLogo.Name = "picLogo"
		Me.Timer1.Interval = 300
		Me.Timer1.Enabled = True
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Size = New System.Drawing.Size(57, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(240, 240)
		Me.cmdCancel.TabIndex = 5
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "Ok"
		Me.AcceptButton = Me.cmdOk
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.Size = New System.Drawing.Size(57, 25)
		Me.cmdOk.Location = New System.Drawing.Point(176, 240)
		Me.cmdOk.TabIndex = 4
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.Size = New System.Drawing.Size(145, 21)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(272, 152)
		Me.txtPassword.Maxlength = 14
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 2
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me.txtUser.AutoSize = False
		Me.txtUser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUser.Size = New System.Drawing.Size(145, 21)
		Me.txtUser.Location = New System.Drawing.Point(272, 112)
		Me.txtUser.Maxlength = 14
		Me.txtUser.TabIndex = 0
		Me.txtUser.AcceptsReturn = True
		Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUser.BackColor = System.Drawing.SystemColors.Window
		Me.txtUser.CausesValidation = True
		Me.txtUser.Enabled = True
		Me.txtUser.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUser.HideSelection = True
		Me.txtUser.ReadOnly = False
		Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUser.MultiLine = False
		Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUser.TabStop = True
		Me.txtUser.Visible = True
		Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUser.Name = "txtUser"
		Me.Frame1.BackColor = System.Drawing.SystemColors.Desktop
		Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Frame1.Text = "Security Access"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.SystemColors.Desktop
		Me.Frame1.Size = New System.Drawing.Size(289, 201)
		Me.Frame1.Location = New System.Drawing.Point(168, 88)
		Me.Frame1.TabIndex = 1
		Me.Frame1.Enabled = True
		Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbServername.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServername.Size = New System.Drawing.Size(121, 21)
		Me.cbServername.Location = New System.Drawing.Point(104, 104)
		Me.cbServername.TabIndex = 3
		Me.cbServername.Text = "cbServername"
		Me.cbServername.BackColor = System.Drawing.SystemColors.Window
		Me.cbServername.CausesValidation = True
		Me.cbServername.Enabled = True
		Me.cbServername.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServername.IntegralHeight = True
		Me.cbServername.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServername.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServername.Sorted = False
		Me.cbServername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cbServername.TabStop = True
		Me.cbServername.Visible = True
		Me.cbServername.Name = "cbServername"
		Me.cmdOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOptions.Text = "Options>"
		Me.cmdOptions.Enabled = False
		Me.cmdOptions.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOptions.Size = New System.Drawing.Size(73, 25)
		Me.cmdOptions.Location = New System.Drawing.Point(136, 152)
		Me.cmdOptions.TabIndex = 6
		Me.cmdOptions.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOptions.CausesValidation = True
		Me.cmdOptions.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOptions.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOptions.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOptions.TabStop = True
		Me.cmdOptions.Name = "cmdOptions"
		Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
		Me.Label3.Text = "Server"
		Me.Label3.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label3.Size = New System.Drawing.Size(73, 25)
		Me.Label3.Location = New System.Drawing.Point(8, 112)
		Me.Label3.TabIndex = 11
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me._imgKey_3.Size = New System.Drawing.Size(32, 32)
		Me._imgKey_3.Location = New System.Drawing.Point(224, 160)
		Me._imgKey_3.Image = CType(resources.GetObject("_imgKey_3.Image"), System.Drawing.Image)
		Me._imgKey_3.Enabled = True
		Me._imgKey_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgKey_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgKey_3.Visible = True
		Me._imgKey_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgKey_3.Name = "_imgKey_3"
		Me._imgKey_2.Size = New System.Drawing.Size(32, 32)
		Me._imgKey_2.Location = New System.Drawing.Point(240, 160)
		Me._imgKey_2.Image = CType(resources.GetObject("_imgKey_2.Image"), System.Drawing.Image)
		Me._imgKey_2.Enabled = True
		Me._imgKey_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgKey_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgKey_2.Visible = True
		Me._imgKey_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgKey_2.Name = "_imgKey_2"
		Me._imgKey_1.Size = New System.Drawing.Size(32, 32)
		Me._imgKey_1.Location = New System.Drawing.Point(256, 160)
		Me._imgKey_1.Image = CType(resources.GetObject("_imgKey_1.Image"), System.Drawing.Image)
		Me._imgKey_1.Enabled = True
		Me._imgKey_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgKey_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgKey_1.Visible = True
		Me._imgKey_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgKey_1.Name = "_imgKey_1"
		Me.imgUnlock.Size = New System.Drawing.Size(32, 32)
		Me.imgUnlock.Location = New System.Drawing.Point(208, 152)
		Me.imgUnlock.Image = CType(resources.GetObject("imgUnlock.Image"), System.Drawing.Image)
		Me.imgUnlock.Enabled = True
		Me.imgUnlock.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgUnlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgUnlock.Visible = True
		Me.imgUnlock.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgUnlock.Name = "imgUnlock"
		Me.imgLock.Size = New System.Drawing.Size(32, 32)
		Me.imgLock.Location = New System.Drawing.Point(208, 152)
		Me.imgLock.Image = CType(resources.GetObject("imgLock.Image"), System.Drawing.Image)
		Me.imgLock.Enabled = True
		Me.imgLock.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgLock.Visible = True
		Me.imgLock.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgLock.Name = "imgLock"
		Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
		Me.Label2.Text = "Password"
		Me.Label2.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label2.Size = New System.Drawing.Size(73, 25)
		Me.Label2.Location = New System.Drawing.Point(8, 72)
		Me.Label2.TabIndex = 8
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
		Me.Label1.Text = "User"
		Me.Label1.ForeColor = System.Drawing.SystemColors.highlightText
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.TabIndex = 7
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.lVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lVersion.BackColor = System.Drawing.SystemColors.Info
		Me.lVersion.Text = "Release"
		Me.lVersion.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lVersion.Size = New System.Drawing.Size(137, 25)
		Me.lVersion.Location = New System.Drawing.Point(16, 264)
		Me.lVersion.TabIndex = 12
		Me.lVersion.Enabled = True
		Me.lVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lVersion.Cursor = System.Windows.Forms.Cursors.Default
		Me.lVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lVersion.UseMnemonic = True
		Me.lVersion.Visible = True
		Me.lVersion.AutoSize = False
		Me.lVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lVersion.Name = "lVersion"
		Me.lblGlm.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblGlm.BackColor = System.Drawing.Color.White
		Me.lblGlm.Text = "GLM  Inc."
		Me.lblGlm.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGlm.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblGlm.Size = New System.Drawing.Size(433, 45)
		Me.lblGlm.Location = New System.Drawing.Point(8, 24)
		Me.lblGlm.TabIndex = 10
		Me.lblGlm.Enabled = True
		Me.lblGlm.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGlm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGlm.UseMnemonic = True
		Me.lblGlm.Visible = True
		Me.lblGlm.AutoSize = False
		Me.lblGlm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGlm.Name = "lblGlm"
		Me.Controls.Add(picLogo)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtPassword)
		Me.Controls.Add(txtUser)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lVersion)
		Me.Controls.Add(lblGlm)
		Me.Frame1.Controls.Add(cbServername)
		Me.Frame1.Controls.Add(cmdOptions)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(_imgKey_3)
		Me.Frame1.Controls.Add(_imgKey_2)
		Me.Frame1.Controls.Add(_imgKey_1)
		Me.Frame1.Controls.Add(imgUnlock)
		Me.Frame1.Controls.Add(imgLock)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.imgKey.SetIndex(_imgKey_3, CType(3, Short))
		Me.imgKey.SetIndex(_imgKey_2, CType(2, Short))
		Me.imgKey.SetIndex(_imgKey_1, CType(1, Short))
		CType(Me.imgKey, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class