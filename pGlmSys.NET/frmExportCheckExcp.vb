Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmExportCheckExcp
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Private rsCheckDetail As SqlDataReader
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub
	
	Private Sub dgException_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgException.ClickEvent
		If dgException.SelBookmarks.Count > 0 Then
			load_dgCheckDetails(dgException.Columns("cust_id").Text, CShort(dgException.Columns("Check No").Text))
		End If
		
	End Sub
	
	Private Sub frmExportCheckExcp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        load_dgException()
    End Sub
	
    Private Sub load_dgException()
        Dim cmd As SqlCommand = cn.CreateCommand
        sStmt = "SELECT cust_id, check_no as 'Check No', field_name as 'Field'," & " conflict_value1 as 'Value1', conflict_value2 as 'Value2' " & " FROM CheckException"
        cmd.CommandText = sStmt
        rsLocal = cmd.ExecuteReader() ';(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        dgException.DataSource = rsLocal

        'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgException.Refresh()

        dgException.Columns("Check No").Width = VB6.TwipsToPixelsX(600)
        dgException.Columns("Field").Width = VB6.TwipsToPixelsX(1400)
        dgException.Columns("Value1").Width = VB6.TwipsToPixelsX(3000)
        dgException.Columns("Value2").Width = VB6.TwipsToPixelsX(3000)

        dgException.Columns("cust_id").Visible = False
    End Sub
	
	Private Sub load_dgCheckDetails(ByRef sCustId As String, ByRef nCheckNo As Short)
		On Error GoTo ErrorHandler
        Dim cmd As SqlCommand = cn.CreateCommand
		sStmt = "SELECT vbranch.vend_name as 'Vendor', vbranch.vend_area AS 'Area'," & " qb_vendor_vbranch.name AS 'QB Vendor', " & "(SELECT store_number FROM store " & "   WHERE store.store_id = bcheck.store_id " & "   AND store.cust_id= bcheck.cust_id) AS 'Store'," & "bcheck.invoice_no AS 'Invoice', bcheck.account_no AS 'Account'," & "bcheck.invoice_total AS 'Total' " & "FROM bcheck, vbranch, qb_vendor_vbranch " & " WHERE bcheck.check_no = " & Str(nCheckNo) & " AND  bcheck.vend_seq = vbranch.vend_seq " & " AND bcheck.vend_seq=qb_vendor_vbranch.vend_seq " & " AND qb_vendor_vbranch.qb_group_id=" & "   (SELECT qb_group_id FROM customer WHERE cust_id='" & sCustId & "')"
        cmd.CommandText = sStmt
		'UPGRADE_NOTE: Object dgCheckDetail.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgCheckDetail.DataSource = Nothing
		
        rsCheckDetail = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsCheckDetail.HasRows() Then
            dgCheckDetail.DataSource = rsCheckDetail
        End If
		
		dgCheckDetail.Columns("Vendor").Width = VB6.TwipsToPixelsX(1500)
		dgCheckDetail.Columns("Area").Width = VB6.TwipsToPixelsX(2000)
		dgCheckDetail.Columns("QB Vendor").Width = VB6.TwipsToPixelsX(3000)
		dgCheckDetail.Columns("Store").Width = VB6.TwipsToPixelsX(500)
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgCheckDetails")
		MsgBox("Unexpected error while selecting Check Invoices." & vbCrLf & "Review log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Sub
End Class