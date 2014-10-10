Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmCustInvTemplate
	Inherits System.Windows.Forms.Form
    Private rsLocal As DataTable
    Private ImageList2 As New ImageList()
	
	
	Private Sub dgTemplate_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgTemplate.DblClick
		update_template()
	End Sub
	
	Private Sub frmCustInvTemplate_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
		
		load_template()
	End Sub
	
	Private Sub load_template()
		
		'UPGRADE_NOTE: Object dgTemplate.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgTemplate.DataSource = Nothing
		
		sStmt = "SELECT template_id, template_name 'Template', " & " Description , filename 'File Name' " & " FROM CustomerInvoiceTemplate " & " WHERE 1 = 1 "
		

		If Not IsDbNull(txtTemplateName.Text) And Len(Trim(txtTemplateName.Text)) > 0 Then
			sStmt = sStmt & " AND template_name LIKE '%" & txtTemplateName.Text & "%' "
		End If
		

		If Not IsDbNull(txtDescription.Text) And Len(Trim(txtDescription.Text)) > 0 Then
			sStmt = sStmt & " AND description LIKE '%" & txtDescription.Text & "%' "
		End If
		
        rsLocal = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.Rows.Count > 0 Then
            dgTemplate.DataSource = rsLocal
        End If
				
		dgTemplate.Columns("template_id").Visible = False
		
		dgTemplate.Columns("File Name").Width = VB6.TwipsToPixelsX(2000)
		
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

        Select Case Button.Name
            Case "new"
                gCustInvTemplate.bFlag = General.modo.NewRecord

                VB6.ShowForm(frmCustInvTemplateEntry, VB6.FormShowConstants.Modal, Me)

                If gCustInvTemplate.bFlag = General.modo.SavedRecord Then
                    load_template()
                End If

            Case "save"
                update_template()

            Case "search"
                load_template()

            Case "exit"
                Me.Close()
        End Select

    End Sub
	
	
	Private Sub update_template()
		If dgTemplate.SelBookmarks.Count <= 0 Then
			MsgBox("Please select a record before attempting this command.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		End If
		
		gCustInvTemplate.bFlag = General.modo.UpdateRecord
		'UPGRADE_WARNING: Couldn't resolve default property of object dgTemplate.Columns().value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gCustInvTemplate.nTemplateId = dgTemplate.Columns("template_id").value
		'UPGRADE_WARNING: Couldn't resolve default property of object dgTemplate.Columns().value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gCustInvTemplate.sDescription = dgTemplate.Columns("Description").value
		'UPGRADE_WARNING: Couldn't resolve default property of object dgTemplate.Columns().value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gCustInvTemplate.sTemplateName = dgTemplate.Columns("Template").value
		'UPGRADE_WARNING: Couldn't resolve default property of object dgTemplate.Columns().value. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gCustInvTemplate.sFilename = dgTemplate.Columns("File Name").value
		
		VB6.ShowForm(frmCustInvTemplateEntry, VB6.FormShowConstants.Modal, Me)
		
		If gCustInvTemplate.bFlag = General.modo.SavedRecord Then
			load_template()
		End If
		
	End Sub
End Class