<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVendorSearch
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
	Public WithEvents cbVendor As System.Windows.Forms.ComboBox
	Public WithEvents cbState As System.Windows.Forms.ComboBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmOk As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVendorSearch))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cbVendor = New System.Windows.Forms.ComboBox
		Me.cbState = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.cmOk = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Query Criteria"
		Me.ClientSize = New System.Drawing.Size(366, 213)
		Me.Location = New System.Drawing.Point(310, 270)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmVendorSearch"
		Me.Frame1.Size = New System.Drawing.Size(345, 121)
		Me.Frame1.Location = New System.Drawing.Point(8, 24)
		Me.Frame1.TabIndex = 2
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cbVendor.Size = New System.Drawing.Size(265, 21)
		Me.cbVendor.Location = New System.Drawing.Point(64, 24)
		Me.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbVendor.TabIndex = 4
		Me.cbVendor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbVendor.BackColor = System.Drawing.SystemColors.Window
		Me.cbVendor.CausesValidation = True
		Me.cbVendor.Enabled = True
		Me.cbVendor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cbVendor.IntegralHeight = True
		Me.cbVendor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cbVendor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cbVendor.Sorted = False
		Me.cbVendor.TabStop = True
		Me.cbVendor.Visible = True
		Me.cbVendor.Name = "cbVendor"
		Me.cbState.Size = New System.Drawing.Size(105, 21)
		Me.cbState.Location = New System.Drawing.Point(64, 64)
		Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbState.TabIndex = 3
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
		Me.Label3.Text = "Vendor"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 24)
		Me.Label3.TabIndex = 6
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
		Me.Label4.Text = "State"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 64)
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
		Me.cmOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmOk.Text = "Ok"
		Me.cmOk.Size = New System.Drawing.Size(57, 33)
		Me.cmOk.Location = New System.Drawing.Point(104, 152)
		Me.cmOk.TabIndex = 1
		Me.cmOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmOk.CausesValidation = True
		Me.cmOk.Enabled = True
		Me.cmOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmOk.TabStop = True
		Me.cmOk.Name = "cmOk"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(57, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(192, 152)
		Me.cmdCancel.TabIndex = 0
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmOk)
		Me.Controls.Add(cmdCancel)
		Me.Frame1.Controls.Add(cbVendor)
		Me.Frame1.Controls.Add(cbState)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class