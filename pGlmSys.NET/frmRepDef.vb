Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmRepDef
	Inherits System.Windows.Forms.Form
    Private rsLocal As sqldatareader
    Private ImageList2 As New ImageList()
	
	Private Sub dgRepDef_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgRepDef.DblClick
		save_repDef((General.modo.UpdateRecord))
	End Sub
	
	Private Sub frmRepDef_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	Private Sub init_vars()
        rsLocal = Nothing

		load_dgRepDef()
	End Sub
	Private Sub load_dgRepDef()
        Dim cmd As SqlCommand = cn.CreateCommand()
		'UPGRADE_NOTE: Object dgRepDef.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		dgRepDef.DataSource = Nothing
		'Cargar Lista de Reports
		sStmt = "SELECT rep_no, rep_caption 'Name', " & "rep_sp_name 'Stored Procedure', " & "rep_template_file 'Default Template'," & "table_name " & " FROM repDef " & " ORDER BY rep_caption "
        cmd.CommandText = sStmt
		
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rsLocal.HasRows() Then
            dgRepDef.DataSource = rsLocal
            'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            dgRepDef.Refresh()
        Else
            Exit Sub
        End If
		
		'Formato
		dgRepDef.Columns("rep_no").Visible = False
		dgRepDef.Columns("Name").Width = VB6.TwipsToPixelsX(2000)
		dgRepDef.Columns("Stored Procedure").Width = VB6.TwipsToPixelsX(2000)
		dgRepDef.Columns("Default Template").Width = VB6.TwipsToPixelsX(3000)
		dgRepDef.Columns("table_name").Visible = False
	End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                save_repDef((General.modo.NewRecord))
            Case "save"
                save_repDef((General.modo.UpdateRecord))

            Case "delete"
                delete_repDef()
            Case "exit"
                Me.Close()
        End Select

    End Sub
	Private Sub save_repDef(ByRef nOption As General.modo)
		If set_RepDef(nOption) Then
			VB6.ShowForm(frmRepDefEntry, VB6.FormShowConstants.Modal, Me)
			load_dgRepDef()
		End If
		
	End Sub
	'Alimenta gRepDef con los datos del datagrid
	Private Function set_RepDef(ByRef bFlag As General.modo) As Boolean
		
		
		On Error GoTo ErrorHandler
		
		set_RepDef = False
		
		Select Case bFlag
			Case General.modo.NewRecord
				gRepDef.bFlag = General.modo.NewRecord
				gRepDef.nRepNo = 0
				gRepDef.sRepCaption = ""
				gRepDef.sRepSpName = ""
				gRepDef.sRepTemplateFile = ""
				gRepDef.sTableName = ""
				
			Case General.modo.UpdateRecord
				If dgRepDef.Row < 0 Then
					MsgBox("You must select a row before attempting this action.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
					Exit Function
				End If
				
				gRepDef.bFlag = General.modo.UpdateRecord
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(rsLocal.item("rep_no").Value) Then
                    gRepDef.nRepNo = rsLocal.item("rep_no").Value
                Else
                    MsgBox("Could not find report number.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
                    Exit Function
                End If
				
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(rsLocal.item("Name").Value) Then
                    gRepDef.sRepCaption = rsLocal.item("Name").Value
                Else
                    MsgBox("Could not find report name.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
                    Exit Function
                End If
				
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(rsLocal.item("Stored Procedure").Value) Then
                    gRepDef.sRepSpName = dgRepDef.Columns("Stored Procedure").Text
                Else
                    MsgBox("Could not find report stored procedure.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
                    Exit Function
                End If
				
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(rsLocal.item("Default Template").Value) Then
                    gRepDef.sRepTemplateFile = dgRepDef.Columns("Default Template").Text
                Else
                    MsgBox("Could not find template file.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
                    Exit Function
                End If
				
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(rsLocal.item("table_name").Value) Then
                    gRepDef.sTableName = dgRepDef.Columns("table_name").Text
                Else
                    MsgBox("Could not find data table name.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Warning")
                    Exit Function
                End If
				
		End Select
		set_RepDef = True
		Exit Function
		
ErrorHandler: 
		save_error(Me.Name, "set_RepDef")
		MsgBox("Unexpected error was found. Check log file for details.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Error")
		
	End Function
	'Deletes record from RepDef table
	Private Sub delete_repDef()
        Dim nRecords As Short
        Dim cmd As SqlCommand = cn.CreateCommand()
		If dgRepDef.SelBookmarks.Count <= 0 Then
			MsgBox("You must select a row before attempting this action.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
		End If
		
		If count_report_template(CShort(dgRepDef.Columns("rep_no").Text)) > 0 Then
			MsgBox("Found templates for this report, you must delete them " & vbCrLf & "before attempting to delete this record.", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "GLM Warning")
			Exit Sub
			
		End If
		
		sStmt = "DELETE FROM RepDef WHERE rep_no=" & dgRepDef.Columns("rep_no").Text
        cmd.CommandText = sStmt
        nRecords = cmd.ExecuteNonQuery()
		If nRecords > 0 Then
			MsgBox("Record was successfully removed.", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
			load_dgRepDef()
		Else
			MsgBox("Failed to remove record or record was removed by another user.", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "GLM Message")
		End If
		
	End Sub
	
	Private Function count_report_template(ByRef nRepNo As Short) As Short
		Dim nRecords As Short
        Dim cmd As sqlcommand = cn.CreateCommand()
		sStmt = "SELECT COUNT(*) FROM RepDefTemplate " & " WHERE rep_no =" & Str(nRepNo)
        cmd.CommandText = sStmt
        rs = getDataTable(sStmt) ' cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        If rs.Rows.Count > 0 Then
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rs.Rows(0).Item(0).Value) Then
                nRecords = 0
            Else
                nRecords = rs.Rows(0).Item(0).Value
            End If
        End If

        count_report_template = nRecords
	End Function
End Class