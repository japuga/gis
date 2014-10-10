<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmStoreAddressEntry
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
	Public WithEvents txtCustId As System.Windows.Forms.TextBox
	Public WithEvents txtStoreNo As System.Windows.Forms.TextBox
	Public WithEvents txtCustName As System.Windows.Forms.TextBox
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtZip As System.Windows.Forms.TextBox
	Public WithEvents txtCity As System.Windows.Forms.TextBox
	Public WithEvents txtAddress As System.Windows.Forms.TextBox
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStoreAddressEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtCustId = New System.Windows.Forms.TextBox
		Me.txtStoreNo = New System.Windows.Forms.TextBox
		Me.txtCustName = New System.Windows.Forms.TextBox
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtZip = New System.Windows.Forms.TextBox
		Me.txtCity = New System.Windows.Forms.TextBox
		Me.txtAddress = New System.Windows.Forms.TextBox
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Store Address Entry"
		Me.ClientSize = New System.Drawing.Size(493, 330)
		Me.Location = New System.Drawing.Point(406, 386)
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmStoreAddressEntry"
		Me.txtCustId.AutoSize = False
		Me.txtCustId.Size = New System.Drawing.Size(49, 21)
		Me.txtCustId.Location = New System.Drawing.Point(440, 80)
		Me.txtCustId.TabIndex = 13
		Me.txtCustId.Visible = False
		Me.txtCustId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustId.AcceptsReturn = True
		Me.txtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustId.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustId.CausesValidation = True
		Me.txtCustId.Enabled = True
		Me.txtCustId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustId.HideSelection = True
		Me.txtCustId.ReadOnly = False
		Me.txtCustId.Maxlength = 0
		Me.txtCustId.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustId.MultiLine = False
		Me.txtCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustId.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustId.TabStop = True
		Me.txtCustId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustId.Name = "txtCustId"
		Me.txtStoreNo.AutoSize = False
		Me.txtStoreNo.Size = New System.Drawing.Size(321, 21)
		Me.txtStoreNo.Location = New System.Drawing.Point(96, 96)
		Me.txtStoreNo.TabIndex = 12
		Me.txtStoreNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreNo.AcceptsReturn = True
		Me.txtStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreNo.CausesValidation = True
		Me.txtStoreNo.Enabled = True
		Me.txtStoreNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreNo.HideSelection = True
		Me.txtStoreNo.ReadOnly = False
		Me.txtStoreNo.Maxlength = 0
		Me.txtStoreNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreNo.MultiLine = False
		Me.txtStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreNo.TabStop = True
		Me.txtStoreNo.Visible = True
		Me.txtStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreNo.Name = "txtStoreNo"
		Me.txtCustName.AutoSize = False
		Me.txtCustName.Size = New System.Drawing.Size(321, 21)
		Me.txtCustName.Location = New System.Drawing.Point(96, 64)
		Me.txtCustName.TabIndex = 11
		Me.txtCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCustName.AcceptsReturn = True
		Me.txtCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCustName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCustName.CausesValidation = True
		Me.txtCustName.Enabled = True
		Me.txtCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCustName.HideSelection = True
		Me.txtCustName.ReadOnly = False
		Me.txtCustName.Maxlength = 0
		Me.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCustName.MultiLine = False
		Me.txtCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCustName.TabStop = True
		Me.txtCustName.Visible = True
		Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCustName.Name = "txtCustName"
		Me.cbState.Size = New System.Drawing.Size(185, 21)
		Me.cbState.Location = New System.Drawing.Point(96, 192)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 7
		Me.cbState.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbState.BackColor = System.Drawing.SystemColors.Window
		Me.cbState.CausesValidation = True
		Me.cbState.Enabled = True
		Me.cbState.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbState.IntegralHeight = True
		Me.cbState.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbState.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbState.Sorted = False
		Me.cbState.TabStop = True
		Me.cbState.Visible = True
		Me.cbState.Name = "cbState"
		Me.txtZip.AutoSize = False
		Me.txtZip.Size = New System.Drawing.Size(185, 21)
		Me.txtZip.Location = New System.Drawing.Point(96, 224)
		Me.txtZip.TabIndex = 8
		Me.txtZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtZip.AcceptsReturn = True
		Me.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtZip.CausesValidation = True
		Me.txtZip.Enabled = True
		Me.txtZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtZip.HideSelection = True
		Me.txtZip.ReadOnly = False
		Me.txtZip.Maxlength = 0
		Me.txtZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtZip.MultiLine = False
		Me.txtZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtZip.TabStop = True
		Me.txtZip.Visible = True
		Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtZip.Name = "txtZip"
		Me.txtCity.AutoSize = False
		Me.txtCity.Size = New System.Drawing.Size(265, 21)
		Me.txtCity.Location = New System.Drawing.Point(96, 160)
		Me.txtCity.TabIndex = 6
		Me.txtCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCity.AcceptsReturn = True
		Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtCity.CausesValidation = True
		Me.txtCity.Enabled = True
		Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCity.HideSelection = True
		Me.txtCity.ReadOnly = False
		Me.txtCity.Maxlength = 0
		Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCity.MultiLine = False
		Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCity.TabStop = True
		Me.txtCity.Visible = True
		Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCity.Name = "txtCity"
		Me.txtAddress.AutoSize = False
		Me.txtAddress.Size = New System.Drawing.Size(313, 21)
		Me.txtAddress.Location = New System.Drawing.Point(96, 128)
		Me.txtAddress.TabIndex = 5
		Me.txtAddress.Text = " "
		Me.txtAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.AcceptsReturn = True
		Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtAddress.CausesValidation = True
		Me.txtAddress.Enabled = True
		Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAddress.HideSelection = True
		Me.txtAddress.ReadOnly = False
		Me.txtAddress.Maxlength = 0
		Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAddress.MultiLine = False
		Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAddress.TabStop = True
		Me.txtAddress.Visible = True
		Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAddress.Name = "txtAddress"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(493, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 0
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me.Label6.Text = "Store"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(16, 96)
		Me.Label6.TabIndex = 10
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Customer"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 64)
		Me.Label5.TabIndex = 9
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Zip"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 232)
		Me.Label4.TabIndex = 4
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "State"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 197)
		Me.Label3.TabIndex = 3
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "City"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 163)
		Me.Label2.TabIndex = 2
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Address"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 128)
		Me.Label1.TabIndex = 1
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(txtCustId)
		Me.Controls.Add(txtStoreNo)
		Me.Controls.Add(txtCustName)
		Me.Controls.Add(cbState)
		Me.Controls.Add(txtZip)
		Me.Controls.Add(txtCity)
		Me.Controls.Add(txtAddress)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class