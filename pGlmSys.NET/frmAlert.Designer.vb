<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAlert
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
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents dgEquipment As AxMSDataGridLib.AxDataGrid
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents dgVendor As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgService As AxMSDataGridLib.AxDataGrid
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents txtMessage As System.Windows.Forms.TextBox
	Public WithEvents dtFrom As AxMSComCtl2.AxDTPicker
	Public WithEvents Toolbar2 As System.Windows.Forms.ToolStrip
	Public WithEvents dgNotes As AxMSDataGridLib.AxDataGrid
	Public WithEvents dtTo As AxMSComCtl2.AxDTPicker
	Public WithEvents tmpRitchTxt As System.Windows.Forms.RichTextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public WithEvents cbStoreNo As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents txtStoreCoCode As System.Windows.Forms.TextBox
	Public WithEvents txtStoreFolder As System.Windows.Forms.TextBox
	Public WithEvents txtStoreZip As System.Windows.Forms.TextBox
	Public WithEvents cbStoreStatus As System.Windows.Forms.ComboBox
	Public WithEvents txtStoreContact As System.Windows.Forms.TextBox
	Public WithEvents txtStoreCity As System.Windows.Forms.TextBox
	Public WithEvents txtStoreAddress As System.Windows.Forms.TextBox
	Public WithEvents txtStoreName As System.Windows.Forms.TextBox
	Public WithEvents txtOccupants As System.Windows.Forms.TextBox
	Public WithEvents mtxtStorePhone1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtStorePhone2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtStoreFax1 As System.Windows.Forms.MaskedTextBox
	Public WithEvents mtxtStoreFax2 As System.Windows.Forms.MaskedTextBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label30 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents imlToolbarIcons As System.Windows.Forms.ImageList
	Public WithEvents ImageList2 As System.Windows.Forms.ImageList
	Public WithEvents lblMessage As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAlert))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripSeparator
		Me.SSTab1 = New System.Windows.Forms.TabControl
		Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
		Me.dgEquipment = New AxMSDataGridLib.AxDataGrid
		Me.Command1 = New System.Windows.Forms.Button
		Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
		Me.dgVendor = New AxMSDataGridLib.AxDataGrid
		Me.dgService = New AxMSDataGridLib.AxDataGrid
		Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage
		Me.txtMessage = New System.Windows.Forms.TextBox
		Me.dtFrom = New AxMSComCtl2.AxDTPicker
		Me.Toolbar2 = New System.Windows.Forms.ToolStrip
		Me.dgNotes = New AxMSDataGridLib.AxDataGrid
		Me.dtTo = New AxMSComCtl2.AxDTPicker
		Me.tmpRitchTxt = New System.Windows.Forms.RichTextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cbStoreNo = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.txtStoreCoCode = New System.Windows.Forms.TextBox
		Me.txtStoreFolder = New System.Windows.Forms.TextBox
		Me.txtStoreZip = New System.Windows.Forms.TextBox
		Me.cbStoreStatus = New System.Windows.Forms.ComboBox
		Me.txtStoreContact = New System.Windows.Forms.TextBox
		Me.txtStoreCity = New System.Windows.Forms.TextBox
		Me.txtStoreAddress = New System.Windows.Forms.TextBox
		Me.txtStoreName = New System.Windows.Forms.TextBox
		Me.txtOccupants = New System.Windows.Forms.TextBox
		Me.mtxtStorePhone1 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtStorePhone2 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtStoreFax1 = New System.Windows.Forms.MaskedTextBox
		Me.mtxtStoreFax2 = New System.Windows.Forms.MaskedTextBox
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label18 = New System.Windows.Forms.Label
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label20 = New System.Windows.Forms.Label
		Me.Label21 = New System.Windows.Forms.Label
		Me.Label22 = New System.Windows.Forms.Label
		Me.Label23 = New System.Windows.Forms.Label
		Me.Label24 = New System.Windows.Forms.Label
		Me.Label25 = New System.Windows.Forms.Label
		Me.Label26 = New System.Windows.Forms.Label
		Me.Label27 = New System.Windows.Forms.Label
		Me.Label28 = New System.Windows.Forms.Label
		Me.Label29 = New System.Windows.Forms.Label
		Me.Label30 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.imlToolbarIcons = New System.Windows.Forms.ImageList
		Me.ImageList2 = New System.Windows.Forms.ImageList
		Me.lblMessage = New System.Windows.Forms.Label
		Me.Toolbar1.SuspendLayout()
		Me.SSTab1.SuspendLayout()
		Me._SSTab1_TabPage0.SuspendLayout()
		Me._SSTab1_TabPage1.SuspendLayout()
		Me._SSTab1_TabPage2.SuspendLayout()
		Me.Toolbar2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgVendor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgService, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgNotes, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtTo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Stores"
		Me.ClientSize = New System.Drawing.Size(820, 588)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "frmAlert"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(820, 28)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 37
		Me.Toolbar1.ImageList = imlToolbarIcons
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button3.Size = New System.Drawing.Size(24, 22)
		Me._Toolbar1_Button3.AutoSize = False
		Me._Toolbar1_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.SSTab1.Size = New System.Drawing.Size(777, 297)
		Me.SSTab1.Location = New System.Drawing.Point(16, 280)
		Me.SSTab1.TabIndex = 34
		Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SSTab1.Name = "SSTab1"
		Me._SSTab1_TabPage0.Text = "Equipment"
		dgEquipment.OcxState = CType(resources.GetObject("dgEquipment.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgEquipment.Size = New System.Drawing.Size(729, 177)
		Me.dgEquipment.Location = New System.Drawing.Point(24, 32)
		Me.dgEquipment.TabIndex = 35
		Me.dgEquipment.Name = "dgEquipment"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Vendor Accounts"
		Me.Command1.Size = New System.Drawing.Size(89, 33)
		Me.Command1.Location = New System.Drawing.Point(24, 232)
		Me.Command1.TabIndex = 40
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me._SSTab1_TabPage1.Text = "Vendor"
		dgVendor.OcxState = CType(resources.GetObject("dgVendor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgVendor.Size = New System.Drawing.Size(745, 121)
		Me.dgVendor.Location = New System.Drawing.Point(16, 32)
		Me.dgVendor.TabIndex = 36
		Me.dgVendor.Name = "dgVendor"
		dgService.OcxState = CType(resources.GetObject("dgService.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgService.Size = New System.Drawing.Size(745, 113)
		Me.dgService.Location = New System.Drawing.Point(16, 168)
		Me.dgService.TabIndex = 38
		Me.dgService.Name = "dgService"
		Me._SSTab1_TabPage2.Text = "Notes"
		Me.txtMessage.AutoSize = False
		Me.txtMessage.Size = New System.Drawing.Size(465, 19)
		Me.txtMessage.Location = New System.Drawing.Point(72, 80)
		Me.txtMessage.TabIndex = 45
		Me.txtMessage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMessage.AcceptsReturn = True
		Me.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMessage.BackColor = System.Drawing.SystemColors.Window
		Me.txtMessage.CausesValidation = True
		Me.txtMessage.Enabled = True
		Me.txtMessage.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMessage.HideSelection = True
		Me.txtMessage.ReadOnly = False
		Me.txtMessage.Maxlength = 0
		Me.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMessage.MultiLine = False
		Me.txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMessage.TabStop = True
		Me.txtMessage.Visible = True
		Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMessage.Name = "txtMessage"
		dtFrom.OcxState = CType(resources.GetObject("dtFrom.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtFrom.Size = New System.Drawing.Size(105, 21)
		Me.dtFrom.Location = New System.Drawing.Point(72, 104)
		Me.dtFrom.TabIndex = 43
		Me.dtFrom.Name = "dtFrom"
		Me.Toolbar2.ShowItemToolTips = True
		Me.Toolbar2.Size = New System.Drawing.Size(137, 42)
		Me.Toolbar2.Location = New System.Drawing.Point(8, 24)
		Me.Toolbar2.TabIndex = 41
		Me.Toolbar2.ImageList = ImageList2
		Me.Toolbar2.Name = "Toolbar2"
		dgNotes.OcxState = CType(resources.GetObject("dgNotes.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgNotes.Size = New System.Drawing.Size(761, 153)
		Me.dgNotes.Location = New System.Drawing.Point(8, 128)
		Me.dgNotes.TabIndex = 39
		Me.dgNotes.Name = "dgNotes"
		dtTo.OcxState = CType(resources.GetObject("dtTo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtTo.Size = New System.Drawing.Size(105, 21)
		Me.dtTo.Location = New System.Drawing.Point(288, 104)
		Me.dtTo.TabIndex = 47
		Me.dtTo.Name = "dtTo"
		Me.tmpRitchTxt.Size = New System.Drawing.Size(33, 25)
		Me.tmpRitchTxt.Location = New System.Drawing.Point(672, 136)
		Me.tmpRitchTxt.TabIndex = 49
		Me.tmpRitchTxt.Visible = False
		Me.tmpRitchTxt.RTF = resources.GetString("tmpRitchTxt.TextRTF")
		Me.tmpRitchTxt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tmpRitchTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.tmpRitchTxt.Name = "tmpRitchTxt"
		Me.Label3.Text = "To"
		Me.Label3.Size = New System.Drawing.Size(41, 17)
		Me.Label3.Location = New System.Drawing.Point(256, 104)
		Me.Label3.TabIndex = 46
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
		Me.Label2.Text = "Regarding"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 80)
		Me.Label2.TabIndex = 44
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
		Me.Label1.Text = "From"
		Me.Label1.Size = New System.Drawing.Size(25, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 104)
		Me.Label1.TabIndex = 42
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
		Me.Frame1.Size = New System.Drawing.Size(777, 225)
		Me.Frame1.Location = New System.Drawing.Point(16, 48)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbStoreNo.Size = New System.Drawing.Size(193, 21)
		Me.cbStoreNo.Location = New System.Drawing.Point(408, 40)
		Me.cbStoreNo.TabIndex = 33
		Me.cbStoreNo.Text = "Combo1"
		Me.cbStoreNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStoreNo.BackColor = System.Drawing.SystemColors.Window
		Me.cbStoreNo.CausesValidation = True
		Me.cbStoreNo.Enabled = True
		Me.cbStoreNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStoreNo.IntegralHeight = True
		Me.cbStoreNo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStoreNo.Sorted = False
		Me.cbStoreNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cbStoreNo.TabStop = True
		Me.cbStoreNo.Visible = True
		Me.cbStoreNo.Name = "cbStoreNo"
		Me.cbCustId.Size = New System.Drawing.Size(153, 21)
		Me.cbCustId.Location = New System.Drawing.Point(96, 16)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 32
		Me.cbCustId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustId.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustId.CausesValidation = True
		Me.cbCustId.Enabled = True
		Me.cbCustId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustId.IntegralHeight = True
		Me.cbCustId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustId.Sorted = False
		Me.cbCustId.TabStop = True
		Me.cbCustId.Visible = True
		Me.cbCustId.Name = "cbCustId"
		Me.cbCustName.Size = New System.Drawing.Size(233, 21)
		Me.cbCustName.Location = New System.Drawing.Point(96, 40)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 31
		Me.cbCustName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbCustName.BackColor = System.Drawing.SystemColors.Window
		Me.cbCustName.CausesValidation = True
		Me.cbCustName.Enabled = True
		Me.cbCustName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbCustName.IntegralHeight = True
		Me.cbCustName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbCustName.Sorted = False
		Me.cbCustName.TabStop = True
		Me.cbCustName.Visible = True
		Me.cbCustName.Name = "cbCustName"
		Me.cbState.Size = New System.Drawing.Size(57, 21)
		Me.cbState.Location = New System.Drawing.Point(408, 88)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 11
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
		Me.txtStoreCoCode.AutoSize = False
		Me.txtStoreCoCode.Size = New System.Drawing.Size(97, 19)
		Me.txtStoreCoCode.Location = New System.Drawing.Point(408, 184)
		Me.txtStoreCoCode.Maxlength = 15
		Me.txtStoreCoCode.TabIndex = 10
		Me.txtStoreCoCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreCoCode.AcceptsReturn = True
		Me.txtStoreCoCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreCoCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreCoCode.CausesValidation = True
		Me.txtStoreCoCode.Enabled = True
		Me.txtStoreCoCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreCoCode.HideSelection = True
		Me.txtStoreCoCode.ReadOnly = False
		Me.txtStoreCoCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreCoCode.MultiLine = False
		Me.txtStoreCoCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreCoCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreCoCode.TabStop = True
		Me.txtStoreCoCode.Visible = True
		Me.txtStoreCoCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreCoCode.Name = "txtStoreCoCode"
		Me.txtStoreFolder.AutoSize = False
		Me.txtStoreFolder.Size = New System.Drawing.Size(97, 19)
		Me.txtStoreFolder.Location = New System.Drawing.Point(96, 184)
		Me.txtStoreFolder.Maxlength = 20
		Me.txtStoreFolder.TabIndex = 9
		Me.txtStoreFolder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreFolder.AcceptsReturn = True
		Me.txtStoreFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreFolder.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreFolder.CausesValidation = True
		Me.txtStoreFolder.Enabled = True
		Me.txtStoreFolder.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreFolder.HideSelection = True
		Me.txtStoreFolder.ReadOnly = False
		Me.txtStoreFolder.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreFolder.MultiLine = False
		Me.txtStoreFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreFolder.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreFolder.TabStop = True
		Me.txtStoreFolder.Visible = True
		Me.txtStoreFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreFolder.Name = "txtStoreFolder"
		Me.txtStoreZip.AutoSize = False
		Me.txtStoreZip.Size = New System.Drawing.Size(113, 19)
		Me.txtStoreZip.Location = New System.Drawing.Point(608, 88)
		Me.txtStoreZip.Maxlength = 11
		Me.txtStoreZip.TabIndex = 8
		Me.txtStoreZip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreZip.AcceptsReturn = True
		Me.txtStoreZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreZip.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreZip.CausesValidation = True
		Me.txtStoreZip.Enabled = True
		Me.txtStoreZip.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreZip.HideSelection = True
		Me.txtStoreZip.ReadOnly = False
		Me.txtStoreZip.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreZip.MultiLine = False
		Me.txtStoreZip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreZip.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreZip.TabStop = True
		Me.txtStoreZip.Visible = True
		Me.txtStoreZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreZip.Name = "txtStoreZip"
		Me.cbStoreStatus.Size = New System.Drawing.Size(97, 21)
		Me.cbStoreStatus.Location = New System.Drawing.Point(408, 160)
		Me.cbStoreStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbStoreStatus.TabIndex = 7
		Me.cbStoreStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbStoreStatus.BackColor = System.Drawing.SystemColors.Window
		Me.cbStoreStatus.CausesValidation = True
		Me.cbStoreStatus.Enabled = True
		Me.cbStoreStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbStoreStatus.IntegralHeight = True
		Me.cbStoreStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbStoreStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbStoreStatus.Sorted = False
		Me.cbStoreStatus.TabStop = True
		Me.cbStoreStatus.Visible = True
		Me.cbStoreStatus.Name = "cbStoreStatus"
		Me.txtStoreContact.AutoSize = False
		Me.txtStoreContact.Size = New System.Drawing.Size(185, 19)
		Me.txtStoreContact.Location = New System.Drawing.Point(96, 160)
		Me.txtStoreContact.Maxlength = 60
		Me.txtStoreContact.TabIndex = 6
		Me.txtStoreContact.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreContact.AcceptsReturn = True
		Me.txtStoreContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreContact.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreContact.CausesValidation = True
		Me.txtStoreContact.Enabled = True
		Me.txtStoreContact.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreContact.HideSelection = True
		Me.txtStoreContact.ReadOnly = False
		Me.txtStoreContact.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreContact.MultiLine = False
		Me.txtStoreContact.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreContact.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreContact.TabStop = True
		Me.txtStoreContact.Visible = True
		Me.txtStoreContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreContact.Name = "txtStoreContact"
		Me.txtStoreCity.AutoSize = False
		Me.txtStoreCity.Size = New System.Drawing.Size(233, 19)
		Me.txtStoreCity.Location = New System.Drawing.Point(96, 88)
		Me.txtStoreCity.Maxlength = 20
		Me.txtStoreCity.TabIndex = 5
		Me.txtStoreCity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreCity.AcceptsReturn = True
		Me.txtStoreCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreCity.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreCity.CausesValidation = True
		Me.txtStoreCity.Enabled = True
		Me.txtStoreCity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreCity.HideSelection = True
		Me.txtStoreCity.ReadOnly = False
		Me.txtStoreCity.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreCity.MultiLine = False
		Me.txtStoreCity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreCity.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreCity.TabStop = True
		Me.txtStoreCity.Visible = True
		Me.txtStoreCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreCity.Name = "txtStoreCity"
		Me.txtStoreAddress.AutoSize = False
		Me.txtStoreAddress.Size = New System.Drawing.Size(313, 19)
		Me.txtStoreAddress.Location = New System.Drawing.Point(408, 64)
		Me.txtStoreAddress.Maxlength = 80
		Me.txtStoreAddress.TabIndex = 4
		Me.txtStoreAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreAddress.AcceptsReturn = True
		Me.txtStoreAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreAddress.CausesValidation = True
		Me.txtStoreAddress.Enabled = True
		Me.txtStoreAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreAddress.HideSelection = True
		Me.txtStoreAddress.ReadOnly = False
		Me.txtStoreAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreAddress.MultiLine = False
		Me.txtStoreAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreAddress.TabStop = True
		Me.txtStoreAddress.Visible = True
		Me.txtStoreAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreAddress.Name = "txtStoreAddress"
		Me.txtStoreName.AutoSize = False
		Me.txtStoreName.Size = New System.Drawing.Size(233, 19)
		Me.txtStoreName.Location = New System.Drawing.Point(96, 64)
		Me.txtStoreName.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.txtStoreName, "Store Name")
		Me.txtStoreName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStoreName.AcceptsReturn = True
		Me.txtStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStoreName.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreName.CausesValidation = True
		Me.txtStoreName.Enabled = True
		Me.txtStoreName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreName.HideSelection = True
		Me.txtStoreName.ReadOnly = False
		Me.txtStoreName.Maxlength = 0
		Me.txtStoreName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreName.MultiLine = False
		Me.txtStoreName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStoreName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreName.TabStop = True
		Me.txtStoreName.Visible = True
		Me.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreName.Name = "txtStoreName"
		Me.txtOccupants.AutoSize = False
		Me.txtOccupants.Size = New System.Drawing.Size(113, 19)
		Me.txtOccupants.Location = New System.Drawing.Point(608, 184)
		Me.txtOccupants.TabIndex = 1
		Me.txtOccupants.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOccupants.AcceptsReturn = True
		Me.txtOccupants.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtOccupants.BackColor = System.Drawing.SystemColors.Window
		Me.txtOccupants.CausesValidation = True
		Me.txtOccupants.Enabled = True
		Me.txtOccupants.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOccupants.HideSelection = True
		Me.txtOccupants.ReadOnly = False
		Me.txtOccupants.Maxlength = 0
		Me.txtOccupants.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOccupants.MultiLine = False
		Me.txtOccupants.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOccupants.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOccupants.TabStop = True
		Me.txtOccupants.Visible = True
		Me.txtOccupants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOccupants.Name = "txtOccupants"
		Me.mtxtStorePhone1.AllowPromptAsInput = False
		Me.mtxtStorePhone1.Size = New System.Drawing.Size(113, 20)
		Me.mtxtStorePhone1.Location = New System.Drawing.Point(96, 112)
		Me.mtxtStorePhone1.TabIndex = 2
		Me.mtxtStorePhone1.MaxLength = 14
		Me.mtxtStorePhone1.Mask = "(###)-###-####"
		Me.mtxtStorePhone1.PromptChar = "_"
		Me.mtxtStorePhone1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtStorePhone1.Name = "mtxtStorePhone1"
		Me.mtxtStorePhone2.AllowPromptAsInput = False
		Me.mtxtStorePhone2.Size = New System.Drawing.Size(113, 20)
		Me.mtxtStorePhone2.Location = New System.Drawing.Point(96, 136)
		Me.mtxtStorePhone2.TabIndex = 12
		Me.mtxtStorePhone2.MaxLength = 14
		Me.mtxtStorePhone2.Mask = "(###)-###-####"
		Me.mtxtStorePhone2.PromptChar = "_"
		Me.mtxtStorePhone2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtStorePhone2.Name = "mtxtStorePhone2"
		Me.mtxtStoreFax1.AllowPromptAsInput = False
		Me.mtxtStoreFax1.Size = New System.Drawing.Size(113, 20)
		Me.mtxtStoreFax1.Location = New System.Drawing.Point(408, 112)
		Me.mtxtStoreFax1.TabIndex = 13
		Me.mtxtStoreFax1.MaxLength = 14
		Me.mtxtStoreFax1.Mask = "(###)-###-####"
		Me.mtxtStoreFax1.PromptChar = "_"
		Me.mtxtStoreFax1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtStoreFax1.Name = "mtxtStoreFax1"
		Me.mtxtStoreFax2.AllowPromptAsInput = False
		Me.mtxtStoreFax2.Size = New System.Drawing.Size(113, 20)
		Me.mtxtStoreFax2.Location = New System.Drawing.Point(408, 136)
		Me.mtxtStoreFax2.TabIndex = 14
		Me.mtxtStoreFax2.MaxLength = 14
		Me.mtxtStoreFax2.Mask = "(###)-###-####"
		Me.mtxtStoreFax2.PromptChar = "_"
		Me.mtxtStoreFax2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mtxtStoreFax2.Name = "mtxtStoreFax2"
		Me.Label16.Text = "Company Code"
		Me.Label16.Size = New System.Drawing.Size(49, 33)
		Me.Label16.Location = New System.Drawing.Point(344, 184)
		Me.Label16.TabIndex = 30
		Me.Label16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.BackColor = System.Drawing.SystemColors.Control
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label17.Text = "Folder No"
		Me.Label17.Size = New System.Drawing.Size(49, 17)
		Me.Label17.Location = New System.Drawing.Point(40, 184)
		Me.Label17.TabIndex = 29
		Me.Label17.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.BackColor = System.Drawing.SystemColors.Control
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = False
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me.Label18.Text = "Status"
		Me.Label18.Size = New System.Drawing.Size(41, 17)
		Me.Label18.Location = New System.Drawing.Point(352, 160)
		Me.Label18.TabIndex = 28
		Me.Label18.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label18.BackColor = System.Drawing.SystemColors.Control
		Me.Label18.Enabled = True
		Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label18.UseMnemonic = True
		Me.Label18.Visible = True
		Me.Label18.AutoSize = False
		Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label18.Name = "Label18"
		Me.Label19.Text = "Contact"
		Me.Label19.Size = New System.Drawing.Size(41, 25)
		Me.Label19.Location = New System.Drawing.Point(40, 160)
		Me.Label19.TabIndex = 27
		Me.Label19.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label19.BackColor = System.Drawing.SystemColors.Control
		Me.Label19.Enabled = True
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.UseMnemonic = True
		Me.Label19.Visible = True
		Me.Label19.AutoSize = False
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Name = "Label19"
		Me.Label20.Text = "Zip Code"
		Me.Label20.Size = New System.Drawing.Size(49, 17)
		Me.Label20.Location = New System.Drawing.Point(552, 88)
		Me.Label20.TabIndex = 26
		Me.Label20.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label20.BackColor = System.Drawing.SystemColors.Control
		Me.Label20.Enabled = True
		Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label20.UseMnemonic = True
		Me.Label20.Visible = True
		Me.Label20.AutoSize = False
		Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label20.Name = "Label20"
		Me.Label21.Text = "State"
		Me.Label21.Size = New System.Drawing.Size(41, 17)
		Me.Label21.Location = New System.Drawing.Point(352, 88)
		Me.Label21.TabIndex = 25
		Me.Label21.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label21.BackColor = System.Drawing.SystemColors.Control
		Me.Label21.Enabled = True
		Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label21.UseMnemonic = True
		Me.Label21.Visible = True
		Me.Label21.AutoSize = False
		Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label21.Name = "Label21"
		Me.Label22.Text = "City"
		Me.Label22.Size = New System.Drawing.Size(33, 17)
		Me.Label22.Location = New System.Drawing.Point(40, 88)
		Me.Label22.TabIndex = 24
		Me.Label22.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label22.BackColor = System.Drawing.SystemColors.Control
		Me.Label22.Enabled = True
		Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label22.UseMnemonic = True
		Me.Label22.Visible = True
		Me.Label22.AutoSize = False
		Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label22.Name = "Label22"
		Me.Label23.Text = "Address"
		Me.Label23.Size = New System.Drawing.Size(49, 17)
		Me.Label23.Location = New System.Drawing.Point(352, 64)
		Me.Label23.TabIndex = 23
		Me.Label23.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label23.BackColor = System.Drawing.SystemColors.Control
		Me.Label23.Enabled = True
		Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label23.UseMnemonic = True
		Me.Label23.Visible = True
		Me.Label23.AutoSize = False
		Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label23.Name = "Label23"
		Me.Label24.Text = "Fax 2"
		Me.Label24.Size = New System.Drawing.Size(41, 17)
		Me.Label24.Location = New System.Drawing.Point(352, 136)
		Me.Label24.TabIndex = 22
		Me.Label24.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label24.BackColor = System.Drawing.SystemColors.Control
		Me.Label24.Enabled = True
		Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label24.UseMnemonic = True
		Me.Label24.Visible = True
		Me.Label24.AutoSize = False
		Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label24.Name = "Label24"
		Me.Label25.Text = "Fax 1"
		Me.Label25.Size = New System.Drawing.Size(41, 17)
		Me.Label25.Location = New System.Drawing.Point(352, 112)
		Me.Label25.TabIndex = 21
		Me.Label25.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label25.BackColor = System.Drawing.SystemColors.Control
		Me.Label25.Enabled = True
		Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label25.UseMnemonic = True
		Me.Label25.Visible = True
		Me.Label25.AutoSize = False
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label25.Name = "Label25"
		Me.Label26.Text = "Phone2"
		Me.Label26.Size = New System.Drawing.Size(49, 17)
		Me.Label26.Location = New System.Drawing.Point(40, 136)
		Me.Label26.TabIndex = 20
		Me.Label26.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label26.BackColor = System.Drawing.SystemColors.Control
		Me.Label26.Enabled = True
		Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label26.UseMnemonic = True
		Me.Label26.Visible = True
		Me.Label26.AutoSize = False
		Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label26.Name = "Label26"
		Me.Label27.Text = "Phone1"
		Me.Label27.Size = New System.Drawing.Size(49, 17)
		Me.Label27.Location = New System.Drawing.Point(40, 112)
		Me.Label27.TabIndex = 19
		Me.Label27.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label27.BackColor = System.Drawing.SystemColors.Control
		Me.Label27.Enabled = True
		Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label27.UseMnemonic = True
		Me.Label27.Visible = True
		Me.Label27.AutoSize = False
		Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label27.Name = "Label27"
		Me.Label28.Text = "Name"
		Me.Label28.Size = New System.Drawing.Size(41, 17)
		Me.Label28.Location = New System.Drawing.Point(40, 64)
		Me.Label28.TabIndex = 18
		Me.Label28.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label28.BackColor = System.Drawing.SystemColors.Control
		Me.Label28.Enabled = True
		Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label28.UseMnemonic = True
		Me.Label28.Visible = True
		Me.Label28.AutoSize = False
		Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label28.Name = "Label28"
		Me.Label29.Text = "Store No"
		Me.Label29.Size = New System.Drawing.Size(49, 17)
		Me.Label29.Location = New System.Drawing.Point(352, 40)
		Me.Label29.TabIndex = 17
		Me.Label29.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label29.BackColor = System.Drawing.SystemColors.Control
		Me.Label29.Enabled = True
		Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label29.UseMnemonic = True
		Me.Label29.Visible = True
		Me.Label29.AutoSize = False
		Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label29.Name = "Label29"
		Me.Label30.Text = "Customer"
		Me.Label30.Size = New System.Drawing.Size(49, 17)
		Me.Label30.Location = New System.Drawing.Point(40, 40)
		Me.Label30.TabIndex = 16
		Me.Label30.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label30.BackColor = System.Drawing.SystemColors.Control
		Me.Label30.Enabled = True
		Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label30.UseMnemonic = True
		Me.Label30.Visible = True
		Me.Label30.AutoSize = False
		Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label30.Name = "Label30"
		Me.Label7.Text = "Occupancy"
		Me.Label7.Size = New System.Drawing.Size(57, 17)
		Me.Label7.Location = New System.Drawing.Point(544, 184)
		Me.Label7.TabIndex = 15
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.imlToolbarIcons.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlToolbarIcons.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.imlToolbarIcons.ImageStream = CType(resources.GetObject("imlToolbarIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imlToolbarIcons.Images.SetKeyName(0, "Find")
		Me.imlToolbarIcons.Images.SetKeyName(1, "Forward")
		Me.imlToolbarIcons.Images.SetKeyName(2, "Back")
		Me.ImageList2.ImageSize = New System.Drawing.Size(32, 32)
		Me.ImageList2.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList2.Images.SetKeyName(0, "new")
		Me.ImageList2.Images.SetKeyName(1, "")
		Me.ImageList2.Images.SetKeyName(2, "save")
		Me.ImageList2.Images.SetKeyName(3, "search")
		Me.ImageList2.Images.SetKeyName(4, "print")
		Me.ImageList2.Images.SetKeyName(5, "exit")
		Me.ImageList2.Images.SetKeyName(6, "")
		Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.ForeColor = System.Drawing.Color.Red
		Me.lblMessage.Size = New System.Drawing.Size(489, 17)
		Me.lblMessage.Location = New System.Drawing.Point(16, 32)
		Me.lblMessage.TabIndex = 48
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMessage.BackColor = System.Drawing.SystemColors.Control
		Me.lblMessage.Enabled = True
		Me.lblMessage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMessage.UseMnemonic = True
		Me.lblMessage.Visible = True
		Me.lblMessage.AutoSize = False
		Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMessage.Name = "lblMessage"
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(SSTab1)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lblMessage)
		Me.Toolbar1.Items.Add(_Toolbar1_Button3)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage0)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage1)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage2)
		Me._SSTab1_TabPage0.Controls.Add(dgEquipment)
		Me._SSTab1_TabPage0.Controls.Add(Command1)
		Me._SSTab1_TabPage1.Controls.Add(dgVendor)
		Me._SSTab1_TabPage1.Controls.Add(dgService)
		Me._SSTab1_TabPage2.Controls.Add(txtMessage)
		Me._SSTab1_TabPage2.Controls.Add(dtFrom)
		Me._SSTab1_TabPage2.Controls.Add(Toolbar2)
		Me._SSTab1_TabPage2.Controls.Add(dgNotes)
		Me._SSTab1_TabPage2.Controls.Add(dtTo)
		Me._SSTab1_TabPage2.Controls.Add(tmpRitchTxt)
		Me._SSTab1_TabPage2.Controls.Add(Label3)
		Me._SSTab1_TabPage2.Controls.Add(Label2)
		Me._SSTab1_TabPage2.Controls.Add(Label1)
		Me.Frame1.Controls.Add(cbStoreNo)
		Me.Frame1.Controls.Add(cbCustId)
		Me.Frame1.Controls.Add(cbCustName)
		Me.Frame1.Controls.Add(cbState)
		Me.Frame1.Controls.Add(txtStoreCoCode)
		Me.Frame1.Controls.Add(txtStoreFolder)
		Me.Frame1.Controls.Add(txtStoreZip)
		Me.Frame1.Controls.Add(cbStoreStatus)
		Me.Frame1.Controls.Add(txtStoreContact)
		Me.Frame1.Controls.Add(txtStoreCity)
		Me.Frame1.Controls.Add(txtStoreAddress)
		Me.Frame1.Controls.Add(txtStoreName)
		Me.Frame1.Controls.Add(txtOccupants)
		Me.Frame1.Controls.Add(mtxtStorePhone1)
		Me.Frame1.Controls.Add(mtxtStorePhone2)
		Me.Frame1.Controls.Add(mtxtStoreFax1)
		Me.Frame1.Controls.Add(mtxtStoreFax2)
		Me.Frame1.Controls.Add(Label16)
		Me.Frame1.Controls.Add(Label17)
		Me.Frame1.Controls.Add(Label18)
		Me.Frame1.Controls.Add(Label19)
		Me.Frame1.Controls.Add(Label20)
		Me.Frame1.Controls.Add(Label21)
		Me.Frame1.Controls.Add(Label22)
		Me.Frame1.Controls.Add(Label23)
		Me.Frame1.Controls.Add(Label24)
		Me.Frame1.Controls.Add(Label25)
		Me.Frame1.Controls.Add(Label26)
		Me.Frame1.Controls.Add(Label27)
		Me.Frame1.Controls.Add(Label28)
		Me.Frame1.Controls.Add(Label29)
		Me.Frame1.Controls.Add(Label30)
		Me.Frame1.Controls.Add(Label7)
		CType(Me.dtTo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgNotes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtFrom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgService, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgVendor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgEquipment, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Toolbar1.ResumeLayout(False)
		Me.SSTab1.ResumeLayout(False)
		Me._SSTab1_TabPage0.ResumeLayout(False)
		Me._SSTab1_TabPage1.ResumeLayout(False)
		Me._SSTab1_TabPage2.ResumeLayout(False)
		Me.Toolbar2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class