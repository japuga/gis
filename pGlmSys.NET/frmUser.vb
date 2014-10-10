Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmUser
    Inherits System.Windows.Forms.Form
    Private rsUser As DataTable
    Private ImageList2 As New ImageList()
	
	Private Sub dgUser_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgUser.DblClick
		update_user()
	End Sub
	
	Private Sub frmUser_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
		
	End Sub
	
	
	Private Sub init_vars()

        init_user_record()
        load_dgUser()
    End Sub
	Private Sub init_user_record()
		gUserRecord.sUserDesc = ""
		gUserRecord.sUserName = ""
	End Sub
	Private Sub load_dgUser()
		Dim bFound As Boolean
        Dim dt As DataTable
		On Error GoTo ErrorHandler
		'Si un usuario tiene type_id nulo, se le asigna AccountManager por defecto
		sStmt = "SELECT suser_name 'ID', suser_desc 'Description', " & " ISNULL(suser_type.type_name,'')  'Type', " & " ISNULL(suser.type_id,'C')  type_id " & " FROM suser LEFT OUTER JOIN suser_type " & " ON suser.type_id = suser_type.type_id " & " ORDER BY suser_name "
		
		'UPGRADE_NOTE: Object dgUser.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgUser.DataSource = Nothing
		
		
        rsUser = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		bFound = False

        If rsUser.Rows.Count > 0 Then


            For row As Integer = 0 To rsUser.Rows.Count - 1
                If Trim(rsUser.Rows(row).Item("ID").Value) = Trim(gUserRecord.sUserName) Then
                    bFound = True
                    Exit For
                End If
            Next row
        End If



        dgUser.DataSource = rsUser
        If rsUser.Rows.Count > 0 Then
            If bFound = False Then
                'rsUser.MoveFirst()
            End If
            'dgUser.SelBookmarks.Add((rsUser.Bookmark))
        End If



        'Formato
        dgUser.Columns("ID").Width = VB6.TwipsToPixelsX(1200)
        dgUser.Columns("Description").Width = VB6.TwipsToPixelsX(2800)
        dgUser.Columns("Type").Width = VB6.TwipsToPixelsX(1200)

        dgUser.Columns("type_id").Visible = False
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "load_dgUser")
        MsgBox("Failed to load User data grid." & "Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Error")
		
	End Sub
	
	Private Sub frmUser_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object rsUser may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsUser = Nothing
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                add_user()
            Case "save"
                update_user()
            Case "delete"
                delete_user()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	
	Private Sub add_user()
		gUserRecord.bFlag = General.modo.NewRecord
		VB6.ShowForm(frmUserEntry, VB6.FormShowConstants.Modal, Me)
		If gUserRecord.bFlag = General.modo.SavedRecord Then
			load_dgUser()
		End If
	End Sub
	Private Sub update_user()
		If dgUser.SelBookmarks.Count > 0 Then
			gUserRecord.bFlag = General.modo.UpdateRecord
			set_user()
			
			VB6.ShowForm(frmUserEntry, VB6.FormShowConstants.Modal, Me)
			If gUserRecord.bFlag = General.modo.SavedRecord Then
				load_dgUser()
			End If
		Else
			MsgBox("You must select a user before attempting this command.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "GLM Message")
		End If
	End Sub
	Private Sub set_user()
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(rsUser.Rows(0).Item("ID").Value) Then
            gUserRecord.sUserName = ""
        Else
            gUserRecord.sUserName = Trim(rsUser.Rows(0).Item("ID").Value)
        End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(rsUser.Rows(0).Item("Description").Value) Then
            gUserRecord.sUserDesc = ""
        Else
            gUserRecord.sUserDesc = Trim(rsUser.Rows(0).Item("Description").Value)
        End If
		
		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(rsUser.Rows(0).Item("type_id").Value) Then
            gUserRecord.sTypeId = ""
        Else
            gUserRecord.sTypeId = Trim(rsUser.Rows(0).Item("type_id").Value)
        End If
		
		
	End Sub
	Private Sub delete_user()
		Dim nRecords As Short
        Dim nTran As Sqltransaction
		
		On Error GoTo ErrorHandler
		

        cm = cn.CreateCommand() '.let_ActiveConnection(cn)
        cm.CommandType = CommandType.Text
		
		If dgUser.SelBookmarks.Count > 0 Then
			If MsgBox("Do you want to delete this record.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "GLM Warning") = MsgBoxResult.Yes Then
                nTran = cn.BeginTransaction()
				'Primero se eliminan privilegios en suser_data
                sStmt = "SELECT suser_name FROM suser_data " & " WHERE suser_name ='" & Trim(rsUser.Rows(0).Item("ID").Value) & "'"
				
                rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

                If rs.Rows.Count > 0 Then
                    sStmt = "DELETE FROM suser_data " & " WHERE suser_name ='" & Trim(rsUser.Rows(0).Item("ID").Value) & "'"

                    cm.CommandText = sStmt
                    nRecords = cm.ExecuteNonQuery()
                    If nRecords > 0 Then
                        'ok elminado suser_data
                    Else
                        nTran.Rollback()
                        MsgBox("Failed to delete User Data.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                        Exit Sub
                    End If
                End If 'RecordCOunt


                'suser_options
                sStmt = "SELECT suser_name FROM suser_options " & " WHERE suser_name ='" & Trim(rsUser.Rows(0).Item("ID").Value) & "'"

                
                rs = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

                If rs.Rows.Count > 0 Then
                    sStmt = "DELETE FROM suser_options " & " WHERE suser_name ='" & Trim(rsUser.Rows(0).Item("ID").Value) & "'"
                    cm.CommandText = sStmt
                    nRecords = cm.ExecuteNonQuery()

                    If nRecords > 0 Then
                        'ok elminado suser_options
                    Else
                        nTran.Rollback()
                        MsgBox("Failed to delete User Options.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                        Exit Sub
                    End If
                End If


                'suser
                sStmt = "DELETE FROM suser " & " WHERE suser_name ='" & Trim(rsUser.Rows(0).Item("ID").Value) & "'"

                cm.CommandText = sStmt
                nRecords = cm.ExecuteNonQuery()
                If nRecords > 0 Then
                    'ok
                    nTran.Commit()

                    'MsgBox "User was deleted.", vbOKOnly + vbInformation, "GLM Message"
                Else
                    'rollback
                    nTran.Rollback()
                    MsgBox("Failed to delete User record.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "GLM Error")
                    Exit Sub
                End If

                del_sql_user()

                load_dgUser()
            End If 'Do you want to delete?
        End If
        Exit Sub

ErrorHandler:

        nTran.Rollback()

        save_error(Me.Name, "delete_user")
        If Not show_db_error() Then
            MsgBox("Unexpected error occurred while deleting User info." & vbCrLf & "Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Error")
        End If
	End Sub
	'Borrar usuario de SqlServer
	Private Sub del_sql_user()
        Dim rsTmp As DataTable
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim ds As DataSet = New DataSet("tmpds")

        Try

            'Verifico que el usuario exista en SqlServer
            cm.CommandType = CommandType.StoredProcedure
            cm.CommandText = "usp_sys_user_info"
            cm.Parameters("@sUserName").Value = Trim(rsUser.Rows(0).Item("ID").Value)
            da.SelectCommand = cm
            da.Fill(ds)
            rsTmp = ds.Tables(0)

            cm.CommandText = "usp_sys_delete_user"
            cm.Parameters("@sUserName").Value = Trim(rsUser.Rows(0).Item("ID").Value)
            cm.Parameters("@nResult").Direction = ParameterDirection.Output
            cm.ExecuteNonQuery()
            If cm.Parameters("@nResult").Value = 0 Then
                'ok
                'gUserRecord.bFlag = modo.SavedRecord

            Else
                MsgBox("Failed to remove SqlServer login." & vbCrLf & "You have to remove it manually.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
            End If
            Exit Sub

        Catch e As Exception
            'If cn.Errors(0).NativeError = 15198 Then
            'User does not exist on SqlServer
            'End If
        End Try
    End Sub
End Class