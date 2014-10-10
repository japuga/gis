<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInvoiceBookingDet
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
	Public WithEvents txtGlmRateDet As System.Windows.Forms.TextBox
	Public WithEvents cmdDetail As System.Windows.Forms.Button
	Public WithEvents cbBillSavingFlag As System.Windows.Forms.ComboBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents txtCommentsDet As System.Windows.Forms.TextBox
	Public WithEvents txtRateDet As System.Windows.Forms.TextBox
	Public WithEvents txtOldRateDet As System.Windows.Forms.TextBox
	Public WithEvents txtUnitsDet As System.Windows.Forms.TextBox
	Public WithEvents txtUsageDet As System.Windows.Forms.TextBox
	Public WithEvents cbServDet As System.Windows.Forms.ComboBox
	Public WithEvents cbEquipDet As System.Windows.Forms.ComboBox
	Public WithEvents dtServDate As AxMSComCtl2.AxDTPicker
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents lbContent As System.Windows.Forms.Label
	Public WithEvents lbServTypeDet As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInvoiceBookingDet))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtGlmRateDet = New System.Windows.Forms.TextBox
		Me.cmdDetail = New System.Windows.Forms.Button
		Me.cbBillSavingFlag = New System.Windows.Forms.ComboBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.ImageList1 = New System.Windows.Forms.ImageList
		Me.txtCommentsDet = New System.Windows.Forms.TextBox
		Me.txtRateDet = New System.Windows.Forms.TextBox
		Me.txtOldRateDet = New System.Windows.Forms.TextBox
		Me.txtUnitsDet = New System.Windows.Forms.TextBox
		Me.txtUsageDet = New System.Windows.Forms.TextBox
		Me.cbServDet = New System.Windows.Forms.ComboBox
		Me.cbEquipDet = New System.Windows.Forms.ComboBox
		Me.dtServDate = New AxMSComCtl2.AxDTPicker
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.lbContent = New System.Windows.Forms.Label
		Me.lbServTypeDet = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtServDate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Invoice Detail"
		Me.ClientSize = New System.Drawing.Size(344, 425)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
		Me.Name = "frmInvoiceBookingDet"
		Me.txtGlmRateDet.AutoSize = False
		Me.txtGlmRateDet.Size = New System.Drawing.Size(81, 21)
		Me.txtGlmRateDet.Location = New System.Drawing.Point(88, 256)
		Me.txtGlmRateDet.TabIndex = 15
		Me.txtGlmRateDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGlmRateDet.AcceptsReturn = True
		Me.txtGlmRateDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGlmRateDet.BackColor = System.Drawing.SystemColors.Window
		Me.txtGlmRateDet.CausesValidation = True
		Me.txtGlmRateDet.Enabled = True
		Me.txtGlmRateDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGlmRateDet.HideSelection = True
		Me.txtGlmRateDet.ReadOnly = False
		Me.txtGlmRateDet.Maxlength = 0
		Me.txtGlmRateDet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGlmRateDet.MultiLine = False
		Me.txtGlmRateDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGlmRateDet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGlmRateDet.TabStop = True
		Me.txtGlmRateDet.Visible = True
		Me.txtGlmRateDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGlmRateDet.Name = "txtGlmRateDet"
		Me.cmdDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDetail.Text = "Weights"
		Me.cmdDetail.Size = New System.Drawing.Size(65, 33)
		Me.cmdDetail.Location = New System.Drawing.Point(224, 376)
		Me.cmdDetail.TabIndex = 23
		Me.cmdDetail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDetail.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDetail.CausesValidation = True
		Me.cmdDetail.Enabled = True
		Me.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDetail.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDetail.TabStop = True
		Me.cmdDetail.Name = "cmdDetail"
		Me.cbBillSavingFlag.Size = New System.Drawing.Size(81, 21)
		Me.cbBillSavingFlag.Location = New System.Drawing.Point(88, 336)
		Me.cbBillSavingFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbBillSavingFlag.TabIndex = 17
		Me.cbBillSavingFlag.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbBillSavingFlag.BackColor = System.Drawing.SystemColors.Window
		Me.cbBillSavingFlag.CausesValidation = True
		Me.cbBillSavingFlag.Enabled = True
		Me.cbBillSavingFlag.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbBillSavingFlag.IntegralHeight = True
		Me.cbBillSavingFlag.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbBillSavingFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbBillSavingFlag.Sorted = False
		Me.cbBillSavingFlag.TabStop = True
		Me.cbBillSavingFlag.Visible = True
		Me.cbBillSavingFlag.Name = "cbBillSavingFlag"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(65, 33)
		Me.cmdClose.Location = New System.Drawing.Point(136, 377)
		Me.cmdClose.TabIndex = 20
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save"
		Me.cmdSave.Size = New System.Drawing.Size(65, 33)
		Me.cmdSave.Location = New System.Drawing.Point(48, 377)
		Me.cmdSave.TabIndex = 19
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.Images.SetKeyName(0, "")
		Me.ImageList1.Images.SetKeyName(1, "")
		Me.ImageList1.Images.SetKeyName(2, "")
		Me.ImageList1.Images.SetKeyName(3, "")
		Me.ImageList1.Images.SetKeyName(4, "")
		Me.ImageList1.Images.SetKeyName(5, "")
		Me.txtCommentsDet.AutoSize = False
		Me.txtCommentsDet.Size = New System.Drawing.Size(209, 21)
		Me.txtCommentsDet.Location = New System.Drawing.Point(88, 296)
		Me.txtCommentsDet.Maxlength = 30
		Me.txtCommentsDet.TabIndex = 16
		Me.txtCommentsDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCommentsDet.AcceptsReturn = True
		Me.txtCommentsDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCommentsDet.BackColor = System.Drawing.SystemColors.Window
		Me.txtCommentsDet.CausesValidation = True
		Me.txtCommentsDet.Enabled = True
		Me.txtCommentsDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCommentsDet.HideSelection = True
		Me.txtCommentsDet.ReadOnly = False
		Me.txtCommentsDet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCommentsDet.MultiLine = False
		Me.txtCommentsDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCommentsDet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCommentsDet.TabStop = True
		Me.txtCommentsDet.Visible = True
		Me.txtCommentsDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCommentsDet.Name = "txtCommentsDet"
		Me.txtRateDet.AutoSize = False
		Me.txtRateDet.Size = New System.Drawing.Size(81, 21)
		Me.txtRateDet.Location = New System.Drawing.Point(88, 216)
		Me.txtRateDet.TabIndex = 14
		Me.txtRateDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRateDet.AcceptsReturn = True
		Me.txtRateDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtRateDet.BackColor = System.Drawing.SystemColors.Window
		Me.txtRateDet.CausesValidation = True
		Me.txtRateDet.Enabled = True
		Me.txtRateDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRateDet.HideSelection = True
		Me.txtRateDet.ReadOnly = False
		Me.txtRateDet.Maxlength = 0
		Me.txtRateDet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRateDet.MultiLine = False
		Me.txtRateDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRateDet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtRateDet.TabStop = True
		Me.txtRateDet.Visible = True
		Me.txtRateDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtRateDet.Name = "txtRateDet"
		Me.txtOldRateDet.AutoSize = False
		Me.txtOldRateDet.Size = New System.Drawing.Size(81, 21)
		Me.txtOldRateDet.Location = New System.Drawing.Point(88, 184)
		Me.txtOldRateDet.TabIndex = 13
		Me.txtOldRateDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOldRateDet.AcceptsReturn = True
		Me.txtOldRateDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtOldRateDet.BackColor = System.Drawing.SystemColors.Window
		Me.txtOldRateDet.CausesValidation = True
		Me.txtOldRateDet.Enabled = True
		Me.txtOldRateDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOldRateDet.HideSelection = True
		Me.txtOldRateDet.ReadOnly = False
		Me.txtOldRateDet.Maxlength = 0
		Me.txtOldRateDet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOldRateDet.MultiLine = False
		Me.txtOldRateDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOldRateDet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOldRateDet.TabStop = True
		Me.txtOldRateDet.Visible = True
		Me.txtOldRateDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOldRateDet.Name = "txtOldRateDet"
		Me.txtUnitsDet.AutoSize = False
		Me.txtUnitsDet.Size = New System.Drawing.Size(81, 21)
		Me.txtUnitsDet.Location = New System.Drawing.Point(88, 152)
		Me.txtUnitsDet.TabIndex = 12
		Me.txtUnitsDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUnitsDet.AcceptsReturn = True
		Me.txtUnitsDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUnitsDet.BackColor = System.Drawing.SystemColors.Window
		Me.txtUnitsDet.CausesValidation = True
		Me.txtUnitsDet.Enabled = True
		Me.txtUnitsDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUnitsDet.HideSelection = True
		Me.txtUnitsDet.ReadOnly = False
		Me.txtUnitsDet.Maxlength = 0
		Me.txtUnitsDet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUnitsDet.MultiLine = False
		Me.txtUnitsDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUnitsDet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUnitsDet.TabStop = True
		Me.txtUnitsDet.Visible = True
		Me.txtUnitsDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUnitsDet.Name = "txtUnitsDet"
		Me.txtUsageDet.AutoSize = False
		Me.txtUsageDet.Size = New System.Drawing.Size(81, 21)
		Me.txtUsageDet.Location = New System.Drawing.Point(88, 120)
		Me.txtUsageDet.TabIndex = 11
		Me.txtUsageDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsageDet.AcceptsReturn = True
		Me.txtUsageDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUsageDet.BackColor = System.Drawing.SystemColors.Window
		Me.txtUsageDet.CausesValidation = True
		Me.txtUsageDet.Enabled = True
		Me.txtUsageDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUsageDet.HideSelection = True
		Me.txtUsageDet.ReadOnly = False
		Me.txtUsageDet.Maxlength = 0
		Me.txtUsageDet.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUsageDet.MultiLine = False
		Me.txtUsageDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUsageDet.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsageDet.TabStop = True
		Me.txtUsageDet.Visible = True
		Me.txtUsageDet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUsageDet.Name = "txtUsageDet"
		Me.cbServDet.Size = New System.Drawing.Size(209, 21)
		Me.cbServDet.Location = New System.Drawing.Point(88, 88)
		Me.cbServDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbServDet.TabIndex = 10
		Me.cbServDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbServDet.BackColor = System.Drawing.SystemColors.Window
		Me.cbServDet.CausesValidation = True
		Me.cbServDet.Enabled = True
		Me.cbServDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbServDet.IntegralHeight = True
		Me.cbServDet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbServDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbServDet.Sorted = False
		Me.cbServDet.TabStop = True
		Me.cbServDet.Visible = True
		Me.cbServDet.Name = "cbServDet"
		Me.cbEquipDet.Size = New System.Drawing.Size(153, 21)
		Me.cbEquipDet.Location = New System.Drawing.Point(88, 56)
		Me.cbEquipDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbEquipDet.TabIndex = 9
		Me.cbEquipDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbEquipDet.BackColor = System.Drawing.SystemColors.Window
		Me.cbEquipDet.CausesValidation = True
		Me.cbEquipDet.Enabled = True
		Me.cbEquipDet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbEquipDet.IntegralHeight = True
		Me.cbEquipDet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbEquipDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbEquipDet.Sorted = False
		Me.cbEquipDet.TabStop = True
		Me.cbEquipDet.Visible = True
		Me.cbEquipDet.Name = "cbEquipDet"
		dtServDate.OcxState = CType(resources.GetObject("dtServDate.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtServDate.Size = New System.Drawing.Size(89, 20)
		Me.dtServDate.Location = New System.Drawing.Point(88, 24)
		Me.dtServDate.TabIndex = 8
		Me.dtServDate.Name = "dtServDate"
		Me.Label10.Text = "GLM Rate"
		Me.Label10.Size = New System.Drawing.Size(57, 25)
		Me.Label10.Location = New System.Drawing.Point(24, 256)
		Me.Label10.TabIndex = 24
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label9.Text = "Billable Saving"
		Me.Label9.Size = New System.Drawing.Size(49, 33)
		Me.Label9.Location = New System.Drawing.Point(24, 336)
		Me.Label9.TabIndex = 22
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.lbContent.Text = "Content"
		Me.lbContent.Size = New System.Drawing.Size(81, 17)
		Me.lbContent.Location = New System.Drawing.Point(248, 56)
		Me.lbContent.TabIndex = 21
		Me.lbContent.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbContent.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbContent.BackColor = System.Drawing.SystemColors.Control
		Me.lbContent.Enabled = True
		Me.lbContent.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbContent.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbContent.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbContent.UseMnemonic = True
		Me.lbContent.Visible = True
		Me.lbContent.AutoSize = False
		Me.lbContent.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbContent.Name = "lbContent"
		Me.lbServTypeDet.Text = " "
		Me.lbServTypeDet.Size = New System.Drawing.Size(89, 21)
		Me.lbServTypeDet.Location = New System.Drawing.Point(176, 152)
		Me.lbServTypeDet.TabIndex = 18
		Me.lbServTypeDet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbServTypeDet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbServTypeDet.BackColor = System.Drawing.SystemColors.Control
		Me.lbServTypeDet.Enabled = True
		Me.lbServTypeDet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbServTypeDet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbServTypeDet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbServTypeDet.UseMnemonic = True
		Me.lbServTypeDet.Visible = True
		Me.lbServTypeDet.AutoSize = False
		Me.lbServTypeDet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbServTypeDet.Name = "lbServTypeDet"
		Me.Label8.Text = "Comments"
		Me.Label8.Size = New System.Drawing.Size(57, 17)
		Me.Label8.Location = New System.Drawing.Point(24, 296)
		Me.Label8.TabIndex = 7
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label7.Text = "Current Rate"
		Me.Label7.Size = New System.Drawing.Size(49, 25)
		Me.Label7.Location = New System.Drawing.Point(24, 216)
		Me.Label7.TabIndex = 6
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
		Me.Label6.Text = "Benchmark Rate"
		Me.Label6.Size = New System.Drawing.Size(57, 25)
		Me.Label6.Location = New System.Drawing.Point(24, 184)
		Me.Label6.TabIndex = 5
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
		Me.Label5.Text = "Units"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(24, 152)
		Me.Label5.TabIndex = 4
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
		Me.Label4.Text = "Usage"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 120)
		Me.Label4.TabIndex = 3
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
		Me.Label3.Text = "Service"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 88)
		Me.Label3.TabIndex = 2
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
		Me.Label2.Text = "Equipment"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 56)
		Me.Label2.TabIndex = 1
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
		Me.Label1.Text = "Date"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 24)
		Me.Label1.TabIndex = 0
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
		Me.Controls.Add(txtGlmRateDet)
		Me.Controls.Add(cmdDetail)
		Me.Controls.Add(cbBillSavingFlag)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(txtCommentsDet)
		Me.Controls.Add(txtRateDet)
		Me.Controls.Add(txtOldRateDet)
		Me.Controls.Add(txtUnitsDet)
		Me.Controls.Add(txtUsageDet)
		Me.Controls.Add(cbServDet)
		Me.Controls.Add(cbEquipDet)
		Me.Controls.Add(dtServDate)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label9)
		Me.Controls.Add(lbContent)
		Me.Controls.Add(lbServTypeDet)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		CType(Me.dtServDate, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class