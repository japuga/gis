Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmWebReport
	Inherits System.Windows.Forms.Form
    Dim rsLocal As DataTable
    Private ImageList2 As New ImageList()
	
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		
		If cbCustName.SelectedIndex >= 0 Then
			cbCustId.SelectedIndex = cbCustName.SelectedIndex
		End If
		
		load_dbWebReport((cbCustId.Text))
	End Sub
	
	Private Sub dgWebReport_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgWebReport.DblClick
		update_webReport()
	End Sub
	
	Private Sub frmWebReport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
		
		sStmt = "SELECT cust_id, cust_name FROM customer ORDER BY cust_name"
		load_cb_query2(cbCustId, sStmt, 1, False)
		
		
		sStmt = "SELECT cust_name FROM customer ORDER BY cust_name"
		load_cb_query2(cbCustName, sStmt, 1, False)
		
		If cbCustName.Items.Count > 0 Then
			cbCustName.SelectedIndex = 0
		End If
		
	End Sub
	
	Private Sub load_dbWebReport(ByRef sCustId As String)
		
		sStmt = "SELECT web_report_id, table_name 'Report Type' , report_desc 'Report Name', " & " CASE enabled_flag " & "   WHEN 1 THEN 'TRUE' " & "   WHEN 0 then 'FALSE' " & "   Else 'UNKNOWN' " & " END  'Publish' " & " FROM web_report  " & " WHERE cust_id = '" & sCustId & "'"
		
        rsLocal = getDataTable(sStmt) '.Open(sStmt, cn)
		
        If rsLocal.Rows.Count > 0 Then
            'If rsLocal.RecordCount > 0 Then
            dgWebReport.DataSource = rsLocal
            dgWebReport.Columns("web_report_id").Visible = False
            'End If
        End If
		
		
		
		'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        dgWebReport.Refresh()
		
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case "save"
                update_webReport()
            Case "exit"
                Me.Close()
        End Select
    End Sub
	Private Sub update_webReport()
		If dgWebReport.SelBookmarks.Count > 0 Then
			gWebReport.bFlag = General.modo.UpdateRecord
			setWebReportData()
			VB6.ShowForm(frmWebReportEntry, VB6.FormShowConstants.Modal, Me)
			If gWebReport.bFlag = General.modo.SavedRecord Then
				load_dbWebReport((cbCustId.Text))
			End If
		Else
			MsgBox("Please select a record before attempting this action.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
		End If
		
	End Sub
	Private Sub setWebReportData()
        gWebReport.tableName = rsLocal.Rows(0).Item("Report Type").value
        gWebReport.reportDesc = rsLocal.Rows(0).Item("Report Name").value
        gWebReport.enabledFlag = rsLocal.Rows(0).Item("Publish").value
        gWebReport.webReportId = rsLocal.Rows(0).Item("web_report_id").value
		
	End Sub
End Class