<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGroupStoreEntry
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
	Public WithEvents txtText As System.Windows.Forms.TextBox
	Public WithEvents txtContractNo As System.Windows.Forms.TextBox
	Public WithEvents txtAttention As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbTypeId As System.Windows.Forms.ComboBox
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents cmdRemove As System.Windows.Forms.Button
	Public WithEvents txtGroupName As System.Windows.Forms.TextBox
	Public WithEvents txtCustName As System.Windows.Forms.TextBox
	Public WithEvents cmdFilter As System.Windows.Forms.Button
	Public WithEvents cmdShowAll As System.Windows.Forms.Button
	Public WithEvents dgGroupStore As AxMSDataGridLib.AxDataGrid
	Public WithEvents dgStores As AxMSDataGridLib.AxDataGrid
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lbMessage As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGroupStoreEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtText = New System.Windows.Forms.TextBox
		Me.txtContractNo = New System.Windows.Forms.TextBox
		Me.txtAttention = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.cbTypeId = New System.Windows.Forms.ComboBox
		Me.cmdAdd = New System.Windows.Forms.Button
		Me.cmdRemove = New System.Windows.Forms.Button
		Me.txtGroupName = New System.Windows.Forms.TextBox
		Me.txtCustName = New System.Windows.Forms.TextBox
		Me.cmdFilter = New System.Windows.Forms.Button
		Me.cmdShowAll = New System.Windows.Forms.Button
		Me.dgGroupStore = New AxMSDataGridLib.AxDataGrid
		Me.dgStores = New AxMSDataGridLib.AxDataGrid
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripSeparator
		Me.Label3 = New System.Windows.Forms.Label
		Me.lbMessage = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.Toolbar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgGroupStore, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgStores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Group Store Data Entry"
		Me.ClientSize = New System.Drawing.Size(702, 536)
		Me.Location = New System.Drawing.Point(4, 23)
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
		Me.Name = "frmGroupStoreEntry"
		Me.Frame1.Text = "Customer Invoice Settings"
		Me.Frame1.Size = New System.Drawing.Size(321, 137)
		Me.Frame1.Location = New System.Drawing.Point(368, 56)
		Me.Frame1.TabIndex = 14
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtText.AutoSize = False
		Me.txtText.Size = New System.Drawing.Size(249, 41)
		Me.txtText.Location = New System.Drawing.Point(64, 88)
		Me.txtText.MultiLine = True
		Me.txtText.TabIndex = 20
		Me.txtText.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtText.AcceptsReturn = True
		Me.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtText.BackColor = System.Drawing.SystemColors.Window
		Me.txtText.CausesValidation = True
		Me.txtText.Enabled = True
		Me.txtText.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtText.HideSelection = True
		Me.txtText.ReadOnly = False
		Me.txtText.Maxlength = 0
		Me.txtText.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtText.TabStop = True
		Me.txtText.Visible = True
		Me.txtText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtText.Name = "txtText"
		Me.txtContractNo.AutoSize = False
		Me.txtContractNo.Size = New System.Drawing.Size(249, 21)
		Me.txtContractNo.Location = New System.Drawing.Point(64, 56)
		Me.txtContractNo.TabIndex = 19
		Me.txtContractNo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtContractNo.AcceptsReturn = True
		Me.txtContractNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContractNo.BackColor = System.Drawing.SystemColors.Window
		Me.txtContractNo.CausesValidation = True
		Me.txtContractNo.Enabled = True
		Me.txtContractNo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContractNo.HideSelection = True
		Me.txtContractNo.ReadOnly = False
		Me.txtContractNo.Maxlength = 0
		Me.txtContractNo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContractNo.MultiLine = False
		Me.txtContractNo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContractNo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContractNo.TabStop = True
		Me.txtContractNo.Visible = True
		Me.txtContractNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContractNo.Name = "txtContractNo"
		Me.txtAttention.AutoSize = False
		Me.txtAttention.Size = New System.Drawing.Size(249, 21)
		Me.txtAttention.Location = New System.Drawing.Point(64, 24)
		Me.txtAttention.TabIndex = 18
		Me.txtAttention.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAttention.AcceptsReturn = True
		Me.txtAttention.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAttention.BackColor = System.Drawing.SystemColors.Window
		Me.txtAttention.CausesValidation = True
		Me.txtAttention.Enabled = True
		Me.txtAttention.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAttention.HideSelection = True
		Me.txtAttention.ReadOnly = False
		Me.txtAttention.Maxlength = 0
		Me.txtAttention.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAttention.MultiLine = False
		Me.txtAttention.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAttention.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAttention.TabStop = True
		Me.txtAttention.Visible = True
		Me.txtAttention.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAttention.Name = "txtAttention"
		Me.Label6.Text = "Contract #"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 56)
		Me.Label6.TabIndex = 17
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
		Me.Label5.Text = "Body Text"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 88)
		Me.Label5.TabIndex = 16
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
		Me.Label4.Text = "Attention"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 24)
		Me.Label4.TabIndex = 15
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
		Me.cbTypeId.Size = New System.Drawing.Size(249, 21)
		Me.cbTypeId.Location = New System.Drawing.Point(64, 104)
		Me.cbTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbTypeId.TabIndex = 13
		Me.cbTypeId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbTypeId.BackColor = System.Drawing.SystemColors.Window
		Me.cbTypeId.CausesValidation = True
		Me.cbTypeId.Enabled = True
		Me.cbTypeId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbTypeId.IntegralHeight = True
		Me.cbTypeId.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbTypeId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbTypeId.Sorted = False
		Me.cbTypeId.TabStop = True
		Me.cbTypeId.Visible = True
		Me.cbTypeId.Name = "cbTypeId"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAdd.Text = "<"
		Me.cmdAdd.Size = New System.Drawing.Size(25, 25)
		Me.cmdAdd.Location = New System.Drawing.Point(336, 368)
		Me.cmdAdd.TabIndex = 9
		Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		Me.cmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRemove.Text = ">"
		Me.cmdRemove.Size = New System.Drawing.Size(25, 25)
		Me.cmdRemove.Location = New System.Drawing.Point(336, 328)
		Me.cmdRemove.TabIndex = 8
		Me.cmdRemove.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRemove.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRemove.CausesValidation = True
		Me.cmdRemove.Enabled = True
		Me.cmdRemove.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRemove.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRemove.TabStop = True
		Me.cmdRemove.Name = "cmdRemove"
		Me.txtGroupName.AutoSize = False
		Me.txtGroupName.Size = New System.Drawing.Size(249, 19)
		Me.txtGroupName.Location = New System.Drawing.Point(64, 144)
		Me.txtGroupName.TabIndex = 5
		Me.txtGroupName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGroupName.AcceptsReturn = True
		Me.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGroupName.BackColor = System.Drawing.SystemColors.Window
		Me.txtGroupName.CausesValidation = True
		Me.txtGroupName.Enabled = True
		Me.txtGroupName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGroupName.HideSelection = True
		Me.txtGroupName.ReadOnly = False
		Me.txtGroupName.Maxlength = 0
		Me.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGroupName.MultiLine = False
		Me.txtGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGroupName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGroupName.TabStop = True
		Me.txtGroupName.Visible = True
		Me.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGroupName.Name = "txtGroupName"
		Me.txtCustName.AutoSize = False
		Me.txtCustName.Size = New System.Drawing.Size(249, 19)
		Me.txtCustName.Location = New System.Drawing.Point(64, 72)
		Me.txtCustName.TabIndex = 7
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
		Me.cmdFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFilter.Text = "Filter"
		Me.cmdFilter.Size = New System.Drawing.Size(57, 25)
		Me.cmdFilter.Location = New System.Drawing.Point(456, 200)
		Me.cmdFilter.TabIndex = 6
		Me.cmdFilter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFilter.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFilter.CausesValidation = True
		Me.cmdFilter.Enabled = True
		Me.cmdFilter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFilter.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFilter.TabStop = True
		Me.cmdFilter.Name = "cmdFilter"
		Me.cmdShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdShowAll.Text = "Show All"
		Me.cmdShowAll.Size = New System.Drawing.Size(57, 25)
		Me.cmdShowAll.Location = New System.Drawing.Point(384, 200)
		Me.cmdShowAll.TabIndex = 4
		Me.cmdShowAll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdShowAll.BackColor = System.Drawing.SystemColors.Control
		Me.cmdShowAll.CausesValidation = True
		Me.cmdShowAll.Enabled = True
		Me.cmdShowAll.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdShowAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdShowAll.TabStop = True
		Me.cmdShowAll.Name = "cmdShowAll"
		dgGroupStore.OcxState = CType(resources.GetObject("dgGroupStore.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgGroupStore.Size = New System.Drawing.Size(297, 241)
		Me.dgGroupStore.Location = New System.Drawing.Point(16, 240)
		Me.dgGroupStore.TabIndex = 2
		Me.dgGroupStore.Name = "dgGroupStore"
		dgStores.OcxState = CType(resources.GetObject("dgStores.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgStores.Size = New System.Drawing.Size(297, 241)
		Me.dgStores.Location = New System.Drawing.Point(384, 240)
		Me.dgStores.TabIndex = 3
		Me.dgStores.Name = "dgStores"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(702, 44)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 10
		Me.Toolbar1.ImageList = ImageList2
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button2.Size = New System.Drawing.Size(40, 39)
		Me._Toolbar1_Button2.AutoSize = False
		Me._Toolbar1_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button2.ToolTipText = "Exit without changes"
		Me._Toolbar1_Button2.Width = 10
		Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Label3.Text = "Type"
		Me.Label3.Size = New System.Drawing.Size(41, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 104)
		Me.Label3.TabIndex = 12
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
		Me.lbMessage.Text = "All Records"
		Me.lbMessage.Size = New System.Drawing.Size(297, 41)
		Me.lbMessage.Location = New System.Drawing.Point(328, 488)
		Me.lbMessage.TabIndex = 11
		Me.lbMessage.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbMessage.BackColor = System.Drawing.SystemColors.Control
		Me.lbMessage.Enabled = True
		Me.lbMessage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbMessage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbMessage.UseMnemonic = True
		Me.lbMessage.Visible = True
		Me.lbMessage.AutoSize = False
		Me.lbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbMessage.Name = "lbMessage"
		Me.Label2.Text = "Group"
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 144)
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
		Me.Label1.Text = "Customer"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 72)
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
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cbTypeId)
		Me.Controls.Add(cmdAdd)
		Me.Controls.Add(cmdRemove)
		Me.Controls.Add(txtGroupName)
		Me.Controls.Add(txtCustName)
		Me.Controls.Add(cmdFilter)
		Me.Controls.Add(cmdShowAll)
		Me.Controls.Add(dgGroupStore)
		Me.Controls.Add(dgStores)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Label3)
		Me.Controls.Add(lbMessage)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(txtText)
		Me.Frame1.Controls.Add(txtContractNo)
		Me.Frame1.Controls.Add(txtAttention)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Toolbar1.Items.Add(_Toolbar1_Button2)
		CType(Me.dgStores, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgGroupStore, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Toolbar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class