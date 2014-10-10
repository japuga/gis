<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmExportVendor
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
	Public WithEvents prbLoad As System.Windows.Forms.ProgressBar
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdExport As System.Windows.Forms.Button
	Public WithEvents txtSql As System.Windows.Forms.TextBox
	Public WithEvents obSql As System.Windows.Forms.RadioButton
	Public WithEvents obCriteria As System.Windows.Forms.RadioButton
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents txtQBGroupDesc As System.Windows.Forms.TextBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public cdFileSave As System.Windows.Forms.SaveFileDialog
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmExportVendor))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.prbLoad = New System.Windows.Forms.ProgressBar
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdExport = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtSql = New System.Windows.Forms.TextBox
		Me.obSql = New System.Windows.Forms.RadioButton
		Me.obCriteria = New System.Windows.Forms.RadioButton
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.txtQBGroupDesc = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.cdFileSave = New System.Windows.Forms.SaveFileDialog
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Export Vendors"
		Me.ClientSize = New System.Drawing.Size(482, 462)
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
		Me.Name = "frmExportVendor"
		Me.prbLoad.Size = New System.Drawing.Size(305, 33)
		Me.prbLoad.Location = New System.Drawing.Point(80, 360)
		Me.prbLoad.TabIndex = 11
		Me.prbLoad.Name = "prbLoad"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(256, 416)
		Me.cmdCancel.TabIndex = 7
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdExport.Text = "Export"
		Me.cmdExport.Size = New System.Drawing.Size(57, 33)
		Me.cmdExport.Location = New System.Drawing.Point(160, 416)
		Me.cmdExport.TabIndex = 6
		Me.cmdExport.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExport.BackColor = System.Drawing.SystemColors.Control
		Me.cmdExport.CausesValidation = True
		Me.cmdExport.Enabled = True
		Me.cmdExport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdExport.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExport.TabStop = True
		Me.cmdExport.Name = "cmdExport"
		Me.Frame1.Size = New System.Drawing.Size(393, 329)
		Me.Frame1.Location = New System.Drawing.Point(32, 16)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtSql.AutoSize = False
		Me.txtSql.Size = New System.Drawing.Size(329, 137)
		Me.txtSql.Location = New System.Drawing.Point(40, 168)
		Me.txtSql.MultiLine = True
		Me.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtSql.TabIndex = 10
		Me.txtSql.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSql.AcceptsReturn = True
		Me.txtSql.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSql.BackColor = System.Drawing.SystemColors.Window
		Me.txtSql.CausesValidation = True
		Me.txtSql.Enabled = True
		Me.txtSql.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSql.HideSelection = True
		Me.txtSql.ReadOnly = False
		Me.txtSql.Maxlength = 0
		Me.txtSql.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSql.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSql.TabStop = True
		Me.txtSql.Visible = True
		Me.txtSql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSql.Name = "txtSql"
		Me.obSql.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obSql.Text = "SQL"
		Me.obSql.Size = New System.Drawing.Size(121, 17)
		Me.obSql.Location = New System.Drawing.Point(8, 136)
		Me.obSql.TabIndex = 9
		Me.obSql.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obSql.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obSql.BackColor = System.Drawing.SystemColors.Control
		Me.obSql.CausesValidation = True
		Me.obSql.Enabled = True
		Me.obSql.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obSql.Cursor = System.Windows.Forms.Cursors.Default
		Me.obSql.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obSql.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obSql.TabStop = True
		Me.obSql.Checked = False
		Me.obSql.Visible = True
		Me.obSql.Name = "obSql"
		Me.obCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCriteria.Text = "Criteria"
		Me.obCriteria.Size = New System.Drawing.Size(113, 13)
		Me.obCriteria.Location = New System.Drawing.Point(8, 16)
		Me.obCriteria.TabIndex = 8
		Me.obCriteria.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.obCriteria.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.obCriteria.BackColor = System.Drawing.SystemColors.Control
		Me.obCriteria.CausesValidation = True
		Me.obCriteria.Enabled = True
		Me.obCriteria.ForeColor = System.Drawing.SystemColors.ControlText
		Me.obCriteria.Cursor = System.Windows.Forms.Cursors.Default
		Me.obCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.obCriteria.Appearance = System.Windows.Forms.Appearance.Normal
		Me.obCriteria.TabStop = True
		Me.obCriteria.Checked = False
		Me.obCriteria.Visible = True
		Me.obCriteria.Name = "obCriteria"
		Me.cbCustName.Size = New System.Drawing.Size(145, 21)
		Me.cbCustName.Location = New System.Drawing.Point(48, 56)
		Me.cbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustName.TabIndex = 3
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
		Me.cbCustId.Size = New System.Drawing.Size(137, 21)
		Me.cbCustId.Location = New System.Drawing.Point(48, 88)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 2
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
		Me.txtQBGroupDesc.AutoSize = False
		Me.txtQBGroupDesc.Size = New System.Drawing.Size(161, 21)
		Me.txtQBGroupDesc.Location = New System.Drawing.Point(224, 56)
		Me.txtQBGroupDesc.TabIndex = 1
		Me.txtQBGroupDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQBGroupDesc.AcceptsReturn = True
		Me.txtQBGroupDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtQBGroupDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtQBGroupDesc.CausesValidation = True
		Me.txtQBGroupDesc.Enabled = True
		Me.txtQBGroupDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQBGroupDesc.HideSelection = True
		Me.txtQBGroupDesc.ReadOnly = False
		Me.txtQBGroupDesc.Maxlength = 0
		Me.txtQBGroupDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQBGroupDesc.MultiLine = False
		Me.txtQBGroupDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQBGroupDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQBGroupDesc.TabStop = True
		Me.txtQBGroupDesc.Visible = True
		Me.txtQBGroupDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQBGroupDesc.Name = "txtQBGroupDesc"
		Me.Label4.Text = "Customer"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.Location = New System.Drawing.Point(48, 40)
		Me.Label4.TabIndex = 5
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
		Me.Label3.Text = "QBooks Group"
		Me.Label3.Size = New System.Drawing.Size(81, 17)
		Me.Label3.Location = New System.Drawing.Point(224, 40)
		Me.Label3.TabIndex = 4
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
		Me.Controls.Add(prbLoad)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdExport)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(txtSql)
		Me.Frame1.Controls.Add(obSql)
		Me.Frame1.Controls.Add(obCriteria)
		Me.Frame1.Controls.Add(cbCustName)
		Me.Frame1.Controls.Add(cbCustId)
		Me.Frame1.Controls.Add(txtQBGroupDesc)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class