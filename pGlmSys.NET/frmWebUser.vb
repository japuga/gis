Option Strict Off
Option Explicit On
Friend Class frmWebUser
	Inherits System.Windows.Forms.Form
    Private ImageList2 As New ImageList()
	'UPGRADE_WARNING: Event cbCustName.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbCustName_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCustName.SelectedIndexChanged
		If cbCustName.SelectedIndex >= 0 Then
			cbCustId.SelectedIndex = cbCustName.SelectedIndex
		End If
		
	End Sub
	
	Private Sub frmWebUser_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
		
		sStmt = "SELECT cust_name, cust_id FROM customer " & " ORDER BY cust_name "
		load_cb_query2(cbCustName, sStmt, 1, True)
		
		sStmt = "SELECT cust_id, cust_name FROM customer " & " ORDER BY cust_name "
		load_cb_query2(cbCustId, sStmt, 1, True)
		
		If cbCustName.Items.Count > 0 Then
			cbCustName.SelectedIndex = 0
		End If
		
	End Sub
End Class