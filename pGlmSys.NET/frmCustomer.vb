Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmCustomer
	Inherits System.Windows.Forms.Form
    Private rsLocal As DataTable
    Private ImageList2 As New ImageList()
	
	Private Sub dgCustomer_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgCustomer.DblClick
		If dgCustomer.SelBookmarks.Count > 0 Then
			update_customer(dgCustomer.Columns("id"))
		Else
			MsgBox("You must select a customer before attempting this command.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
			Exit Sub
		End If
		
	End Sub
	Private Sub update_customer(ByRef sCustId As Object)
		
		gCustomerRecord.bFlag = General.modo.UpdateRecord
		'UPGRADE_WARNING: Couldn't resolve default property of object sCustId. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gCustomerRecord.sCustId = sCustId
		VB6.ShowForm(frmCustomerEntry, VB6.FormShowConstants.Modal, Me)
		
		If gCustomerRecord.bFlag = General.modo.SavedRecord Then
			load_dgCustomer()
		End If
		
	End Sub
	Private Sub frmCustomer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        rsLocal = Nothing

		load_dgCustomer()
	End Sub
	
	Private Sub load_dgCustomer()
		
		'On Error GoTo ErrorHandler
		
		sStmt = "SELECT cust_id AS 'ID', state_id AS 'State'," & " cust_name AS Name," & "cust_contact AS Contact, cust_address AS Address, " & "cust_city AS City" & " FROM customer "
		
		'UPGRADE_NOTE: Object dgCustomer.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgCustomer.DataSource = Nothing
		
        rsLocal = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.Rows.Count > 0 Then
            dgCustomer.DataSource = rsLocal
        Else
            Exit Sub
        End If
		
		'Formato
		dgCustomer.Columns("ID").Width = VB6.TwipsToPixelsX(400)
		dgCustomer.Columns("State").Width = VB6.TwipsToPixelsX(400)
		dgCustomer.Columns("Name").Width = VB6.TwipsToPixelsX(1200)
		dgCustomer.Columns("Contact").Width = VB6.TwipsToPixelsX(1200)
		dgCustomer.Columns("Address").Width = VB6.TwipsToPixelsX(1200)
		dgCustomer.Columns("City").Width = VB6.TwipsToPixelsX(1000)
		
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgCustomer")
		MsgBox("Failed to access Customer table. " & "Check log file for details.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Error")
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                add_customer()
            Case "save"
                If dgCustomer.SelBookmarks.Count > 0 Then
                    update_customer(dgCustomer.Columns("id"))
                Else
                    MsgBox("You must select a customer before attempting this command.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "GLM Message")
                End If
            Case "exit"
                Me.Close()
        End Select

    End Sub
	
	Private Sub add_customer()
		
		gCustomerRecord.bFlag = General.modo.NewRecord
		VB6.ShowForm(frmCustomerEntry, VB6.FormShowConstants.Modal, Me)
		
		If gCustomerRecord.bFlag = General.modo.SavedRecord Then
			load_dgCustomer()
		End If
		
	End Sub
End Class