<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckBatchBrowse
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtBatchId As System.Windows.Forms.TextBox
	Public WithEvents cbCustId As System.Windows.Forms.ComboBox
	Public WithEvents cbCustName As System.Windows.Forms.ComboBox
	Public WithEvents dtBatchTo As AxMSComCtl2.AxDTPicker
	Public WithEvents dtBatchFrom As AxMSComCtl2.AxDTPicker
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckBatchBrowse))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtBatchId = New System.Windows.Forms.TextBox
		Me.cbCustId = New System.Windows.Forms.ComboBox
		Me.cbCustName = New System.Windows.Forms.ComboBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.dtBatchTo = New AxMSComCtl2.AxDTPicker
		Me.dtBatchFrom = New AxMSComCtl2.AxDTPicker
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtBatchTo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtBatchFrom, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Batch Criteria"
		Me.ClientSize = New System.Drawing.Size(297, 302)
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
		Me.Name = "frmCheckBatchBrowse"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(160, 240)
		Me.cmdCancel.TabIndex = 11
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(65, 33)
		Me.cmdOk.Location = New System.Drawing.Point(64, 240)
		Me.cmdOk.TabIndex = 10
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtBatchId.AutoSize = False
		Me.txtBatchId.Size = New System.Drawing.Size(121, 21)
		Me.txtBatchId.Location = New System.Drawing.Point(104, 72)
		Me.txtBatchId.TabIndex = 2
		Me.txtBatchId.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBatchId.AcceptsReturn = True
		Me.txtBatchId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBatchId.BackColor = System.Drawing.SystemColors.Window
		Me.txtBatchId.CausesValidation = True
		Me.txtBatchId.Enabled = True
		Me.txtBatchId.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBatchId.HideSelection = True
		Me.txtBatchId.ReadOnly = False
		Me.txtBatchId.Maxlength = 0
		Me.txtBatchId.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBatchId.MultiLine = False
		Me.txtBatchId.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBatchId.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBatchId.TabStop = True
		Me.txtBatchId.Visible = True
		Me.txtBatchId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBatchId.Name = "txtBatchId"
		Me.cbCustId.Size = New System.Drawing.Size(89, 21)
		Me.cbCustId.Location = New System.Drawing.Point(104, 8)
		Me.cbCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCustId.TabIndex = 9
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
		Me.cbCustName.Size = New System.Drawing.Size(121, 21)
		Me.cbCustName.Location = New System.Drawing.Point(104, 32)
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
		Me.Frame1.Text = "Generation Dates"
		Me.Frame1.Size = New System.Drawing.Size(233, 105)
		Me.Frame1.Location = New System.Drawing.Point(24, 112)
		Me.Frame1.TabIndex = 4
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		dtBatchTo.OcxState = CType(resources.GetObject("dtBatchTo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtBatchTo.Size = New System.Drawing.Size(121, 21)
		Me.dtBatchTo.Location = New System.Drawing.Point(80, 64)
		Me.dtBatchTo.TabIndex = 8
		Me.dtBatchTo.Name = "dtBatchTo"
		dtBatchFrom.OcxState = CType(resources.GetObject("dtBatchFrom.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtBatchFrom.Size = New System.Drawing.Size(121, 21)
		Me.dtBatchFrom.Location = New System.Drawing.Point(80, 32)
		Me.dtBatchFrom.TabIndex = 7
		Me.dtBatchFrom.Name = "dtBatchFrom"
		Me.Label5.Text = "To Date"
		Me.Label5.Size = New System.Drawing.Size(49, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 64)
		Me.Label5.TabIndex = 6
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
		Me.Label4.Text = "From Date"
		Me.Label4.Size = New System.Drawing.Size(57, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 32)
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
		Me.Label2.Text = "Batch ID"
		Me.Label2.Size = New System.Drawing.Size(49, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 72)
		Me.Label2.TabIndex = 3
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
		Me.Label1.Location = New System.Drawing.Point(24, 32)
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
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtBatchId)
		Me.Controls.Add(cbCustId)
		Me.Controls.Add(cbCustName)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(dtBatchTo)
		Me.Frame1.Controls.Add(dtBatchFrom)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		CType(Me.dtBatchFrom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtBatchTo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class