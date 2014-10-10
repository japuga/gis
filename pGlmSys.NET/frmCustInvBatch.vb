Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmCustInvBatch
	Inherits System.Windows.Forms.Form
    Private rsLocal As DataTable
	Private period_start_date() As Date
    Public sReport_Id As String
    Private ImageList2 As New ImageList()
	
	
	Private Sub cbFill_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbFill.Click
		
		struct_dgBatch()
		
		If cbPeriod.SelectedIndex < 0 Then
			Exit Sub
		End If
		
		'Set dgBatch.DataSource = Nothing
		
		sStmt = "SELECT " & "    customerInvoiceBatch.batch_date,  " & "    customerInvoiceBatch.batch_desc, " & "    customerInvoiceBatch.invoice_date, " & "    period.period_name, " & "    groups.group_name, " & "    customerInvoiceBatch.cust_inv_batch_seq " & " FROM groups, period, customerInvoiceBatch " & " WHERE groups.cust_id = customerInvoiceBatch.cust_id " & "    AND period.cust_id = groups.cust_id" & "    AND customerInvoiceBatch.period_seq = period.period_seq " & "    AND customerInvoiceBatch.group_seq = groups.group_seq  " & IIf(ckInvoiceDates.CheckState = 0, "", " AND customerInvoiceBatch.invoice_date between '" & VB6.Format(Me.dtFrom.value, DATEFORMAT) & "' AND '" & VB6.Format(Me.dtTo.value, DATEFORMAT) & "'")
		
		If cbCustId.SelectedIndex > 0 Then
			sStmt = sStmt & "    AND customerInvoiceBatch.cust_id = '" & Trim(cbCustId.Text) & "'"
		End If
		
		If cbPeriod.SelectedIndex > 0 Then
			sStmt = sStmt & "    AND period.period_seq = " & VB6.GetItemData(cbPeriod, cbPeriod.SelectedIndex)
		End If
		
		rsLocal = exec_sql(sStmt)
		
        rsLocal = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
        If rsLocal.Rows.Count > 0 Then
            dgBatch.DataSource = rsLocal
        Else
            'UPGRADE_NOTE: Object dgBatch.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            dgBatch.DataSource = Nothing
            Exit Sub
        End If
		
		width_column_dgBatch()
		
		'dgBatch.Columns("Group Name").Width = 1000
		'dgBatch.Columns("Period").Width = 800
		'dgBatch.Columns("Invoice Date").Width = 800
		'dgBatch.Columns("Description").Width = 3000
		'dgBatch.Columns("Batch Date").Width = 800
		
		
	End Sub
	
	'UPGRADE_WARNING: Event cbPeriod.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbPeriod_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbPeriod.SelectedIndexChanged
		'txtInvoiceNo.Text = "NV-" & Trim(cbCustId.Text)
		'txBillingPeriod.Text = ""
		'If cbPeriod.ListCount > 0 Then
		'txtInvoiceNo.Text = txtInvoiceNo.Text & "-" & Format(period_start_date(cbPeriod.ListIndex + 1), "MM") & Format(period_start_date(cbPeriod.ListIndex + 1), "yy")
		'txBillingPeriod.Text = Format(period_start_date(cbPeriod.ListIndex + 1), "MMMM yyyy")
		'End If
	End Sub
	
	'UPGRADE_WARNING: Event ckInvoiceDates.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ckInvoiceDates_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ckInvoiceDates.CheckStateChanged
		frInvoiceDates.Enabled = IIf(ckInvoiceDates.CheckState = 1, True, False)
	End Sub
	
	Private Sub dgBatch_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgBatch.DblClick
		detail_record()
	End Sub
	
	Private Sub frmCustInvBatch_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
		load_comp()
		
		cbCustName.SelectedIndex = 0
		
	End Sub
	
	Private Sub init_vars()
        rsLocal = Nothing
		'Inicializo parametros de retorno
		
		dtTo.value = Today
		dtFrom.value = Today
		'UPGRADE_NOTE: Object dgBatch.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgBatch.DataSource = Nothing
		cbPeriod.Items.Clear()
		cbStoreGroup.Items.Clear()
		
		load_comp()
		struct_dgBatch()
		
	End Sub
	
	Private Sub struct_dgBatch()
		Dim iIndice As Short
		'UPGRADE_NOTE: Object dgBatch.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgBatch.DataSource = Nothing
		For iIndice = dgBatch.Columns.Count - 1 To 2 Step -1
			dgBatch.Columns.Remove(iIndice)
		Next 
		dgBatch.Columns(0).Caption = "Group Name"
		dgBatch.Columns(1).Caption = "Period"
		dgBatch.Columns.Add(2).Caption = "Invoice Date"
		dgBatch.Columns.Add(3).Caption = "Description"
		dgBatch.Columns.Add(4).Caption = "Batch Date"
		dgBatch.Columns.Add(5).Caption = "Batch Seq"
		
		width_column_dgBatch()
		
	End Sub
	
	Private Sub width_column_dgBatch()
		
		dgBatch.Columns(0).Caption = "Batch Date"
		dgBatch.Columns(1).Caption = "Description"
		dgBatch.Columns(2).Caption = "Invoice Date"
		dgBatch.Columns(3).Caption = "Period"
		dgBatch.Columns(4).Caption = "Group Name"
		dgBatch.Columns(5).Caption = "Batch Seq"
		
		dgBatch.Columns("Group Name").Width = VB6.TwipsToPixelsX(1000)
		dgBatch.Columns("Period").Width = VB6.TwipsToPixelsX(800)
		dgBatch.Columns("Invoice Date").Width = VB6.TwipsToPixelsX(1200)
		dgBatch.Columns("Description").Width = VB6.TwipsToPixelsX(3000)
		dgBatch.Columns("Batch Date").Width = VB6.TwipsToPixelsX(1200)
		dgBatch.Columns("Batch Seq").Width = VB6.TwipsToPixelsX(800)
	End Sub
	
	
	Private Sub load_comp()
		
		load_cb_customer(cbCustName, cbCustId, True)
		
		Exit Sub
		
		
	End Sub
	
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		cbCustId.SelectedIndex = cbCustName.SelectedIndex
		
		'cbPeriod.Clear
		'cbStoreGroup.Clear
		'UPGRADE_NOTE: Object dgBatch.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgBatch.DataSource = Nothing
		
		
		'Load period
		loadPeriodAndArray(cbPeriod, period_start_date, (cbCustId.Text), True)
		If cbPeriod.Items.Count > 0 Then
			cbPeriod.SelectedIndex = 0
		End If
		
		
		
		'Load Store Group
		'load_cb_groups cbStoreGroup, cbCustId.Text, True
		load_cb_groups(cbStoreGroup, (cbCustId.Text), True, True)
		If cbStoreGroup.Items.Count > 0 Then
			cbStoreGroup.SelectedIndex = 0
		End If
		
		
		'cbStoreGroup.Clear
		
		
		
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Dim frmBatch As frmCustInvBatchEntry
        Select Case Button.Name
            Case "new"
                frmBatch = New frmCustInvBatchEntry
                VB6.ShowForm(frmBatch, VB6.FormShowConstants.Modal, Me)

                'Me.cbCustId.ListIndex = frmBatch.scbCustId
                Me.cbCustName.SelectedIndex = frmBatch.scbCustName + 1 'All at pos zero
                cbPeriod.SelectedIndex = frmBatch.scbPeriod + 1 'All at pos zero
                cbStoreGroup.SelectedIndex = frmBatch.scbStoreGroup + 1 'All at pos zero
                dtTo.Value = frmBatch.sdtInvoiceDate
                dtFrom.Value = frmBatch.sdtInvoiceDate

                ckInvoiceDates.CheckState = System.Windows.Forms.CheckState.Checked

                cbFill_Click(cbFill, New System.EventArgs())
                'UPGRADE_NOTE: Object frmBatch may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                frmBatch = Nothing

            Case "delete"
                delete_record()
            Case "exit"
                Me.Close()
            Case "detail"
                detail_record()
        End Select
    End Sub
	
	
	Private Sub detail_record()
		
		If dgBatch.Row < 0 Then
			MsgBox("Please select one or more record before attempting this action." & vbCrLf, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Warning")
			Exit Sub
		End If
		
		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        frmCustInvGenSearch.Show()
		frmCustInvGenSearch.Label1.Visible = False
		frmCustInvGenSearch.Label4.Visible = False
		frmCustInvGenSearch.Label5.Visible = False
		frmCustInvGenSearch.frInvoiceDates.Visible = False
		frmCustInvGenSearch.cbGroupName.Visible = False
		frmCustInvGenSearch.cbCustId.Visible = False
		frmCustInvGenSearch.cbCustName.Visible = False
		frmCustInvGenSearch.cbFill.Visible = False
		frmCustInvGenSearch.cbPeriod.Visible = False
		frmCustInvGenSearch.dgData.Top = VB6.TwipsToPixelsY(900)
		frmCustInvGenSearch.dgData.Height = VB6.TwipsToPixelsY(4500)
		frmCustInvGenSearch.Toolbar1.Items.Item("new").Visible = False
		frmCustInvGenSearch.Toolbar1.Items.Item("save").Visible = False
		frmCustInvGenSearch.Toolbar1.Items.Item("print").Visible = True
		frmCustInvGenSearch.idBatch = Trim(dgBatch.Columns("Batch Seq").Text)
		frmCustInvGenSearch.ckInvoiceDates.Visible = False
		frmCustInvGenSearch.showBatch()
		frmCustInvGenSearch.ShowDialog()
	End Sub
	
	Private Sub delete_record()
		
		
		If dgBatch.Row < 0 Then
			MsgBox("Please select one or more record before attempting this action." & vbCrLf, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Warning")
			Exit Sub
		End If
		
		sStmt = "SELECT suser_name " & "FROM suser " & "WHERE suser_name='" & Trim(gsUser) & "' and type_id = 'A'"
		
		
		'ReDim period_start_date(1 To 1) As Date
		
		rsLocal = exec_sql(sStmt)
		
        If rsLocal.Rows.Count <= 0 Then
            MsgBox("Your user account does not have privileges for the requested command." & vbCrLf & "Please contact your Administrator to perform this action.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Warning")
            Exit Sub
        End If

        Dim cmd As SqlCommand = cn.CreateCommand
        sStmt = "DELETE FROM customerInvoiceBatch  " & "WHERE cust_inv_batch_seq = " & Trim(dgBatch.Columns("Batch Seq").Text)
        cmd.CommandText = sStmt
        cmd.ExecuteNonQuery()


        sStmt = "DELETE FROM customerInvoice  " & "WHERE cust_invoice_seq IN (SELECT cust_invoice_seq FROM customerInvoiceBatchDet WHERE  cust_inv_batch_seq = " & Trim(dgBatch.Columns("Batch Seq").Text) & ")"
        cmd.CommandText = sStmt
        cmd.ExecuteNonQuery()


        sStmt = "DELETE FROM customerInvoiceBatchDet  " & "WHERE cust_inv_batch_seq = " & Trim(dgBatch.Columns("Batch Seq").Text)
        cmd.CommandText = sStmt
        cmd.ExecuteNonQuery()

        cbFill_Click(cbFill, New System.EventArgs())

        MsgBox("Batch was removed successfully.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")


    End Sub
End Class