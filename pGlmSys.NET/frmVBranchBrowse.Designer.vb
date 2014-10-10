<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmVBranchBrowse
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
	Public WithEvents txtVendPayAddress As System.Windows.Forms.TextBox
	Public WithEvents txtVendName As System.Windows.Forms.TextBox
	Public WithEvents dgVBranch As AxMSDataGridLib.AxDataGrid
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVBranchBrowse))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtVendPayAddress = New System.Windows.Forms.TextBox
		Me.txtVendName = New System.Windows.Forms.TextBox
		Me.dgVBranch = New AxMSDataGridLib.AxDataGrid
		Me.Label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dgVBranch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "List of Vendor Branches"
		Me.ClientSize = New System.Drawing.Size(453, 302)
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
		Me.Name = "frmVBranchBrowse"
		Me.txtVendPayAddress.AutoSize = False
		Me.txtVendPayAddress.Enabled = False
		Me.txtVendPayAddress.Size = New System.Drawing.Size(297, 19)
		Me.txtVendPayAddress.Location = New System.Drawing.Point(120, 48)
		Me.txtVendPayAddress.TabIndex = 4
		Me.txtVendPayAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendPayAddress.AcceptsReturn = True
		Me.txtVendPayAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendPayAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendPayAddress.CausesValidation = True
		Me.txtVendPayAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendPayAddress.HideSelection = True
		Me.txtVendPayAddress.ReadOnly = False
		Me.txtVendPayAddress.Maxlength = 0
		Me.txtVendPayAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendPayAddress.MultiLine = False
		Me.txtVendPayAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendPayAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendPayAddress.TabStop = True
		Me.txtVendPayAddress.Visible = True
		Me.txtVendPayAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendPayAddress.Name = "txtVendPayAddress"
		Me.txtVendName.AutoSize = False
		Me.txtVendName.Enabled = False
		Me.txtVendName.Size = New System.Drawing.Size(337, 19)
		Me.txtVendName.Location = New System.Drawing.Point(80, 16)
		Me.txtVendName.TabIndex = 2
		Me.txtVendName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVendName.AcceptsReturn = True
		Me.txtVendName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVendName.BackColor = System.Drawing.SystemColors.Window
		Me.txtVendName.CausesValidation = True
		Me.txtVendName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVendName.HideSelection = True
		Me.txtVendName.ReadOnly = False
		Me.txtVendName.Maxlength = 0
		Me.txtVendName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVendName.MultiLine = False
		Me.txtVendName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVendName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVendName.TabStop = True
		Me.txtVendName.Visible = True
		Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVendName.Name = "txtVendName"
		dgVBranch.OcxState = CType(resources.GetObject("dgVBranch.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dgVBranch.Size = New System.Drawing.Size(417, 185)
		Me.dgVBranch.Location = New System.Drawing.Point(16, 96)
		Me.dgVBranch.TabIndex = 0
		Me.dgVBranch.Name = "dgVBranch"
		Me.Label2.Text = "Payment Address"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 48)
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
		Me.label1.Text = "Vendor"
		Me.label1.Size = New System.Drawing.Size(49, 17)
		Me.label1.Location = New System.Drawing.Point(16, 16)
		Me.label1.TabIndex = 1
		Me.label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.label1.BackColor = System.Drawing.SystemColors.Control
		Me.label1.Enabled = True
		Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.label1.UseMnemonic = True
		Me.label1.Visible = True
		Me.label1.AutoSize = False
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.label1.Name = "label1"
		Me.Controls.Add(txtVendPayAddress)
		Me.Controls.Add(txtVendName)
		Me.Controls.Add(dgVBranch)
		Me.Controls.Add(Label2)
		Me.Controls.Add(label1)
		CType(Me.dgVBranch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class