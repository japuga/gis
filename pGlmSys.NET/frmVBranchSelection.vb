Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmVBranchSelection
	Inherits System.Windows.Forms.Form
    Private rsVBranch As DataTable
    Private rsSelVBranch As DataTable
	Private sVendSeq As String
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		
		Me.Close()
	End Sub
	
	Private Sub cmdLeft_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLeft.Click
		del_member()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        'Dim vRow As Object
        Dim sVendSeq As String = ""
        'Dim i As Short
		
        'rsSelVBranch.Resync(ADODB.AffectEnum.adAffectAllChapters)
        If rsSelVBranch.Rows.Count > 0 Then
            For row As Integer = 0 To rsSelVBranch.Rows.Count - 1
                If Len(sVendSeq) = 0 Then
                    sVendSeq = Str(rsSelVBranch.Rows(row).Item("vend_seq").Value)
                Else
                    sVendSeq = sVendSeq & "," & Str(rsSelVBranch.Rows(row).Item("vend_seq").Value)
                End If
            Next row
            
        End If
		
		gVendor.sVendSeq = sVendSeq
		
		Me.Close()
	End Sub
	
	Private Sub cmdRight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRight.Click
		add_member()
	End Sub
	
	Private Sub dgSelVBranch_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgSelVBranch.DblClick
		del_member()
	End Sub
	
	Private Sub dgVBranch_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgVBranch.DblClick
		add_member()
	End Sub
	
	Private Sub frmVBranchSelection_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        rsVBranch = Nothing
        rsSelVBranch = Nothing
		
        'investigar locktype
        'rsVBranch.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
		

        'rsSelVBranch.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
		
		gVendor.sVendSeq = ""
		
		txtVendName.Enabled = False
		txtVendName.ReadOnly = True
		txtVendName.Text = gVendor.sVendName
		
		load_dgVBranch(gVendor.nVendId)
		load_dgSelVBranch(0)
		
	End Sub
	
	Private Sub load_dgVBranch(ByRef nVendId As Short)
		
		On Error GoTo ErrorHandler
		'UPGRADE_NOTE: Object dgVBranch.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgVBranch.DataSource = Nothing
		
		sStmt = "SELECT vend_seq, vend_name, " & " state_id 'State', vend_area 'Area' " & " FROM  VBranch " & " WHERE vend_id= " & Str(nVendId) & " ORDER BY  state_id, vend_name"
		
        rsVBranch = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic)
        If rsVBranch.Rows.Count > 0 Then
            dgVBranch.DataSource = rsVBranch
        End If
		
		dgVBranch.Columns("vend_seq").Visible = False
		dgVBranch.Columns("vend_name").Visible = False
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgVBranch")
		MsgBox("Unexpected error when loading Vendor Branch info." & vbCrLf & "Check log file for details.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Error")
		
	End Sub
	Private Sub load_dgSelVBranch(ByRef nVendId As Short)
		
		'On Error GoTo ErrorHandler:
		'UPGRADE_NOTE: Object dgSelVBranch.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgSelVBranch.DataSource = Nothing
		
		sStmt = "SELECT vend_seq, vend_name, " & " state_id 'State', vend_area 'Area' " & " FROM  VBranch " & " WHERE vend_id= " & Str(nVendId) & " ORDER BY  state_id, vend_name"
		
        rsSelVBranch = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic)
        If rsSelVBranch.Rows.Count > 0 Then
            dgSelVBranch.DataSource = rsSelVBranch
        End If
		
		dgSelVBranch.Columns("vend_seq").Visible = False
		dgSelVBranch.Columns("vend_name").Visible = False
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "load_dgselVBranch")
		MsgBox("Unexpected error when loading Vendor Branch info." & vbCrLf & "Check log file for details.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Error")
		
	End Sub
	'Agrega estados a dgAssgState desde dgState
	Private Sub add_member()
		Dim vRow As Object
		
		On Error GoTo ErrorHandler
		
		For	Each vRow In dgVBranch.SelBookmarks
			'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'investigar bookmarks
            'rsVBranch.Bookmark = vRow 'Muevo el recordset a la fila seleccionada
			'Verifico si branch ya existe en recordset
			
            If record_exist(rsSelVBranch, rsVBranch.Rows(vRow).Item("vend_seq").Value) = False Then

                Dim drow As DataRow = rsVBranch.NewRow()
                'rsSelVBranch.Item("vend_seq").Value = rsVBranch.Item("vend_seq").Value
                drow.Item("vend_seq") = rsVBranch.Rows(vRow).Item("vend_seq").Value
                drow.Item("vend_name") = rsVBranch.Rows(vRow).Item("vend_name").Value
                drow.Item("area") = rsVBranch.Rows(vRow).Item("area").Value
                rsSelVBranch.Rows.Add(drow)

                rsSelVBranch.Select("state")


            End If
            rsVBranch.Rows(vRow).Delete()
		Next vRow
		Exit Sub
		
ErrorHandler: 
		If Err.Number = 3021 Then
			MsgBox("Error found.")
		End If
		'save_error Me.name, "add_member"
		MsgBox("Unexpected error found. Check log for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
		
	End Sub
	
	'Busca una branch en Datagrid
    Private Function record_exist(ByRef rsTmp As DataTable, ByRef nVendSeq As Short) As Boolean
        Dim sCriteria As String
        sCriteria = "vend_seq=" & Str(nVendSeq)
        If rsTmp.Rows.Count > 0 Then
            record_exist = False
            Exit Function
        End If

        'rsTmp.Find(sCriteria, , ADODB.SearchDirectionEnum.adSearchForward)
        rsTmp.Select(sCriteria)

        If rsTmp.Rows.Count > 0 Then
            record_exist = False
            Exit Function
        End If
        record_exist = True

    End Function
	
	'Agrega branches a dgSelVbranch desde dgVBranch
	Private Sub del_member()
		Dim vRow As Object
		
		On Error GoTo ErrorHandler
		
		For	Each vRow In dgSelVBranch.SelBookmarks
			'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'rsSelVBranch.Bookmark = vRow 'Muevo el recordset a la fila seleccionada
			'Verifico si tienda ya existe en recordset
			
            If record_exist(rsVBranch, rsSelVBranch.Rows(vRow).Item("vend_seq").Value) = False Then
                Dim drow As DataRow = rsSelVBranch.NewRow()
                drow.Item("vend_seq") = rsSelVBranch.Rows(vRow).Item("vend_seq").Value
                drow.Item("state") = rsSelVBranch.Rows(vRow).Item("state").Value
                drow.Item("vend_name") = rsSelVBranch.Rows(vRow).Item("vend_name").Value
                drow.Item("area") = rsSelVBranch.Rows(vRow).Item("area").Value
                rsVBranch.Rows.Add(drow)

                rsVBranch.Select("state")
            End If
            rsSelVBranch.Rows(vRow).Delete()
		Next vRow
		Exit Sub
		
ErrorHandler: 
		save_error(Me.Name, "del_member")
		MsgBox("Unexpected error found on Vendor Branch selection." & vbCrLf & "Please check log file for details.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Error")
		
	End Sub
End Class