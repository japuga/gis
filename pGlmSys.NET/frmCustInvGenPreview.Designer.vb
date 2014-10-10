<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustInvGenPreview
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
	Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
	Public WithEvents VScroll1 As System.Windows.Forms.VScrollBar
	Public WithEvents cmdLoad As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdEdit As System.Windows.Forms.Button
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public CommonDialog1Font As System.Windows.Forms.FontDialog
	Public CommonDialog1Color As System.Windows.Forms.ColorDialog
	Public CommonDialog1Print As System.Windows.Forms.PrintDialog
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents OLEInvoice As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustInvGenPreview))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.HScroll1 = New System.Windows.Forms.HScrollBar
		Me.VScroll1 = New System.Windows.Forms.VScrollBar
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdLoad = New System.Windows.Forms.Button
		Me.cmdPrint = New System.Windows.Forms.Button
		Me.cmdEdit = New System.Windows.Forms.Button
		Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
		Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog
		Me.CommonDialog1Font = New System.Windows.Forms.FontDialog
		Me.CommonDialog1Color = New System.Windows.Forms.ColorDialog
		Me.CommonDialog1Print = New System.Windows.Forms.PrintDialog
		Me.cmdSave = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.OLEInvoice = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.White
		Me.Text = "Invoice Preview"
		Me.ClientSize = New System.Drawing.Size(735, 532)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
		Me.Name = "frmCustInvGenPreview"
		Me.HScroll1.Size = New System.Drawing.Size(705, 17)
		Me.HScroll1.Location = New System.Drawing.Point(8, 456)
		Me.HScroll1.TabIndex = 5
		Me.HScroll1.CausesValidation = True
		Me.HScroll1.Enabled = True
		Me.HScroll1.LargeChange = 1
		Me.HScroll1.Maximum = 32767
		Me.HScroll1.Minimum = 0
		Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
		Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HScroll1.SmallChange = 1
		Me.HScroll1.TabStop = True
		Me.HScroll1.Value = 0
		Me.HScroll1.Visible = True
		Me.HScroll1.Name = "HScroll1"
		Me.VScroll1.Size = New System.Drawing.Size(17, 465)
		Me.VScroll1.Location = New System.Drawing.Point(712, 8)
		Me.VScroll1.TabIndex = 4
		Me.VScroll1.CausesValidation = True
		Me.VScroll1.Enabled = True
		Me.VScroll1.LargeChange = 1
		Me.VScroll1.Maximum = 32767
		Me.VScroll1.Minimum = 0
		Me.VScroll1.Cursor = System.Windows.Forms.Cursors.Default
		Me.VScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.VScroll1.SmallChange = 1
		Me.VScroll1.TabStop = True
		Me.VScroll1.Value = 0
		Me.VScroll1.Visible = True
		Me.VScroll1.Name = "VScroll1"
		Me.Frame1.Size = New System.Drawing.Size(745, 65)
		Me.Frame1.Location = New System.Drawing.Point(-8, 472)
		Me.Frame1.TabIndex = 1
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cmdLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLoad.Text = "Load"
		Me.cmdLoad.Size = New System.Drawing.Size(113, 30)
		Me.cmdLoad.Location = New System.Drawing.Point(472, 8)
		Me.cmdLoad.TabIndex = 8
		Me.cmdLoad.Visible = False
		Me.cmdLoad.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLoad.BackColor = System.Drawing.SystemColors.Control
		Me.cmdLoad.CausesValidation = True
		Me.cmdLoad.Enabled = True
		Me.cmdLoad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdLoad.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdLoad.TabStop = True
		Me.cmdLoad.Name = "cmdLoad"
		Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrint.Text = "Print"
		Me.cmdPrint.Size = New System.Drawing.Size(129, 30)
		Me.cmdPrint.Location = New System.Drawing.Point(608, 8)
		Me.cmdPrint.TabIndex = 7
		Me.cmdPrint.Visible = False
		Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrint.CausesValidation = True
		Me.cmdPrint.Enabled = True
		Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrint.TabStop = True
		Me.cmdPrint.Name = "cmdPrint"
		Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEdit.Text = "Edit"
		Me.cmdEdit.Size = New System.Drawing.Size(137, 30)
		Me.cmdEdit.Location = New System.Drawing.Point(16, 8)
		Me.cmdEdit.TabIndex = 6
		Me.cmdEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEdit.CausesValidation = True
		Me.cmdEdit.Enabled = True
		Me.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEdit.TabStop = True
		Me.cmdEdit.Name = "cmdEdit"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save"
		Me.cmdSave.Size = New System.Drawing.Size(121, 30)
		Me.cmdSave.Location = New System.Drawing.Point(168, 8)
		Me.cmdSave.TabIndex = 3
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdClose
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(121, 30)
		Me.cmdClose.Location = New System.Drawing.Point(304, 8)
		Me.cmdClose.TabIndex = 2
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.OLEInvoice.Size = New System.Drawing.Size(690, 840)
		Me.OLEInvoice.Location = New System.Drawing.Point(16, 0)
		Me.OLEInvoice.TabIndex = 0
		Me.OLEInvoice.BackColor = System.Drawing.Color.Red
		Me.OLEInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.OLEInvoice.ForeColor = System.Drawing.Color.Black
		Me.OLEInvoice.Text = "OLEInvoice"
		Me.OLEInvoice.Name = "OLEInvoice"
		Me.Controls.Add(HScroll1)
		Me.Controls.Add(VScroll1)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(OLEInvoice)
		Me.Frame1.Controls.Add(cmdLoad)
		Me.Frame1.Controls.Add(cmdPrint)
		Me.Frame1.Controls.Add(cmdEdit)
		Me.Frame1.Controls.Add(cmdSave)
		Me.Frame1.Controls.Add(cmdClose)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class