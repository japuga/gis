<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLoadExcel
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
	Public WithEvents _sbLoad_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbLoad As System.Windows.Forms.StatusStrip
	Public WithEvents dg1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents prbLoad As System.Windows.Forms.ProgressBar
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdLoadData As System.Windows.Forms.Button
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cmdOpen As System.Windows.Forms.Button
	Public WithEvents txtExcelFile As System.Windows.Forms.TextBox
	Public cdFileOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents obEquipment As System.Windows.Forms.RadioButton
	Public WithEvents obStore As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLoadExcel))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.sbLoad = New System.Windows.Forms.StatusStrip
		Me._sbLoad_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me.dg1 = New AxMSDataGridLib.AxDataGrid
		Me.prbLoad = New System.Windows.Forms.ProgressBar
		Me.cmdClose = New System.Windows.Forms.Button
		Me.cmdLoadData = New System.Windows.Forms.Button
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cmdOpen = New System.Windows.Forms.Button
		Me.txtExcelFile = New System.Windows.Forms.TextBox
		Me.cdFileOpen = New System.Windows.Forms.OpenFileDialog
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.obEquipment = New System.Windows.Forms.RadioButton
		Me.obStore = New System.Windows.Forms.RadioButton
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.sbLoad.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Migration Tool"
		Me.ClientSize = New System.Drawing.Size(412, 349)
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
		Me.Name = "frmLoadExcel"
		Me.sbLoad.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.sbLoad.Size = New System.Drawing.Size(412, 17)
		Me.sbLoad.Location = New System.Drawing.Point(0, 332)
		Me.sbLoad.TabIndex = 13
		Me.sbLoad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sbLoad.Name = "sbLoad"
		Me._sbLoad_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._sbLoad_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._sbLoad_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._sbLoad_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._sbLoad_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._sbLoad_Panel1.Size = New System.Drawing.Size(96, 17)
		Me._sbLoad_Panel1.AutoSize = False
		dg1.OcxState = CType(resources.GetObject("dg1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dg1.Size = New System.Drawing.Size(361, 113)
		Me.dg1.Location = New System.Drawing.Point(56, 336)
		Me.dg1.TabIndex = 12
		Me.dg1.Name = "dg1"
		Me.prbLoad.Size = New System.Drawing.Size(305, 33)
		Me.prbLoad.Location = New System.Drawing.Point(32, 280)
		Me.prbLoad.TabIndex = 11
		Me.prbLoad.Name = "prbLoad"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(65, 25)
		Me.cmdClose.Location = New System.Drawing.Point(224, 224)
		Me.cmdClose.TabIndex = 10
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.cmdLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLoadData.Text = "Load Data"
		Me.cmdLoadData.Size = New System.Drawing.Size(65, 25)
		Me.cmdLoadData.Location = New System.Drawing.Point(128, 224)
		Me.cmdLoadData.TabIndex = 9
		Me.cmdLoadData.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLoadData.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLoadData.CausesValidation = True
		Me.cmdLoadData.Enabled = True
		Me.cmdLoadData.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLoadData.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLoadData.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLoadData.TabStop = True
		Me.cmdLoadData.Name = "cmdLoadData"
		Me.cbCustId.Size = New System.Drawing.Size(113, 21)
		Me.cbCustId.Location = New System.Drawing.Point(248, 24)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 8
		Me.cbCustId.Visible = False
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
		Me.cbCustId.Name = "cbCustId"
		Me.cmdOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOpen.Text = "Open"
		Me.cmdOpen.Size = New System.Drawing.Size(73, 25)
		Me.cmdOpen.Location = New System.Drawing.Point(320, 88)
		Me.cmdOpen.TabIndex = 7
		Me.cmdOpen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOpen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOpen.CausesValidation = True
		Me.cmdOpen.Enabled = True
		Me.cmdOpen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOpen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOpen.TabStop = True
		Me.cmdOpen.Name = "cmdOpen"
		Me.txtExcelFile.AutoSize = False
		Me.txtExcelFile.Enabled = False
		Me.txtExcelFile.Size = New System.Drawing.Size(289, 21)
		Me.txtExcelFile.Location = New System.Drawing.Point(16, 88)
		Me.txtExcelFile.TabIndex = 6
		Me.txtExcelFile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExcelFile.AcceptsReturn = True
		Me.txtExcelFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExcelFile.BackColor = System.Drawing.SystemColors.Window
		Me.txtExcelFile.CausesValidation = True
		Me.txtExcelFile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExcelFile.HideSelection = True
		Me.txtExcelFile.ReadOnly = False
		Me.txtExcelFile.Maxlength = 0
		Me.txtExcelFile.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExcelFile.MultiLine = False
		Me.txtExcelFile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExcelFile.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExcelFile.TabStop = True
		Me.txtExcelFile.Visible = True
		Me.txtExcelFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExcelFile.Name = "txtExcelFile"
		Me.Frame1.Text = "Destination Table"
		Me.Frame1.Size = New System.Drawing.Size(377, 73)
		Me.Frame1.Location = New System.Drawing.Point(16, 128)
		Me.Frame1.TabIndex = 2
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.obEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obEquipment.Text = "Equipment    (StoreEqpt)"
		Me.obEquipment.Size = New System.Drawing.Size(225, 17)
		Me.obEquipment.Location = New System.Drawing.Point(56, 40)
		Me.obEquipment.TabIndex = 4
		Me.obEquipment.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obEquipment.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obEquipment.BackColor = System.Drawing.SystemColors.Control
		Me.obEquipment.CausesValidation = True
		Me.obEquipment.Enabled = True
		Me.obEquipment.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obEquipment.Cursor = System.Windows.Forms.Cursors.Default
		Me.obEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obEquipment.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obEquipment.TabStop = True
		Me.obEquipment.Checked = False
		Me.obEquipment.Visible = True
		Me.obEquipment.Name = "obEquipment"
		Me.obStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obStore.Text = "Store"
		Me.obStore.Size = New System.Drawing.Size(121, 13)
		Me.obStore.Location = New System.Drawing.Point(56, 16)
		Me.obStore.TabIndex = 3
		Me.obStore.Checked = True
		Me.obStore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obStore.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obStore.BackColor = System.Drawing.SystemColors.Control
		Me.obStore.CausesValidation = True
		Me.obStore.Enabled = True
		Me.obStore.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obStore.Cursor = System.Windows.Forms.Cursors.Default
		Me.obStore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obStore.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obStore.TabStop = True
		Me.obStore.Visible = True
		Me.obStore.Name = "obStore"
		Me.cbCustName.Size = New System.Drawing.Size(145, 21)
		Me.cbCustName.Location = New System.Drawing.Point(80, 24)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 1
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
		Me.Label2.Text = "Source Excel File"
		Me.Label2.Size = New System.Drawing.Size(105, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 72)
		Me.Label2.TabIndex = 5
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
		Me.Label1.Location = New System.Drawing.Point(16, 32)
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
		Me.Controls.Add(sbLoad)
		Me.Controls.Add(dg1)
		Me.Controls.Add(prbLoad)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(cmdLoadData)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cmdOpen)
		Me.Controls.Add(txtExcelFile)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.sbLoad.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._sbLoad_Panel1})
		Me.Frame1.Controls.Add(obEquipment)
		Me.Frame1.Controls.Add(obStore)
		CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.sbLoad.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class