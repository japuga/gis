<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustFeeBillRange
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
    Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustFeeBillRange))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip
        Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripSeparator
        Me.dgBillingRange = New System.Windows.Forms.DataGridView
        Me.btNew = New System.Windows.Forms.ToolStripButton
        Me.btSave = New System.Windows.Forms.ToolStripButton
        Me.btDelete = New System.Windows.Forms.ToolStripButton
        Me.btExit = New System.Windows.Forms.ToolStripButton
        Me.Toolbar1.SuspendLayout()
        CType(Me.dgBillingRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar1
        '
        Me.Toolbar1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNew, Me.btSave, Me.btDelete, Me._Toolbar1_Button5, Me.btExit})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(513, 39)
        Me.Toolbar1.TabIndex = 1
        '
        '_Toolbar1_Button5
        '
        Me._Toolbar1_Button5.AutoSize = False
        Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
        Me._Toolbar1_Button5.Size = New System.Drawing.Size(10, 39)
        '
        'dgBillingRange
        '
        Me.dgBillingRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBillingRange.Location = New System.Drawing.Point(12, 42)
        Me.dgBillingRange.Name = "dgBillingRange"
        Me.dgBillingRange.Size = New System.Drawing.Size(489, 202)
        Me.dgBillingRange.TabIndex = 2
        '
        'btNew
        '
        Me.btNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btNew.Image = CType(resources.GetObject("btNew.Image"), System.Drawing.Image)
        Me.btNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(36, 36)
        Me.btNew.Text = "New"
        '
        'btSave
        '
        Me.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btSave.Image = CType(resources.GetObject("btSave.Image"), System.Drawing.Image)
        Me.btSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(36, 36)
        Me.btSave.Text = "Save"
        '
        'btDelete
        '
        Me.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btDelete.Image = CType(resources.GetObject("btDelete.Image"), System.Drawing.Image)
        Me.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(36, 36)
        Me.btDelete.Text = "Delete"
        '
        'btExit
        '
        Me.btExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btExit.Image = CType(resources.GetObject("btExit.Image"), System.Drawing.Image)
        Me.btExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(36, 36)
        Me.btExit.Text = "Exit"
        '
        'frmCustFeeBillRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(513, 256)
        Me.Controls.Add(Me.dgBillingRange)
        Me.Controls.Add(Me.Toolbar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmCustFeeBillRange"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Billing Range"
        Me.Toolbar1.ResumeLayout(False)
        Me.Toolbar1.PerformLayout()
        CType(Me.dgBillingRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgBillingRange As System.Windows.Forms.DataGridView
    Friend WithEvents btNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btExit As System.Windows.Forms.ToolStripButton
#End Region 
End Class