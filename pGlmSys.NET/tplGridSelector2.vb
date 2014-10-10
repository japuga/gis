Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class tplGridSelector2
	Inherits System.Windows.Forms.Form
	'Extendido de tplGridSelector
    Private rsLeft As DataTable
    Private rsRight As DataTable
    Private rsHeader As DataTable
    Private cmLocal As SqlCommand = cn.CreateCommand()
    Private rsLocal As DataTable
    Private ImageList2 As New ImageList()
	
	
	'UPGRADE_WARNING: Event cbHeader.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cbHeader_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbHeader.SelectedIndexChanged
		Dim sQuerySource As String
		Dim sQuerySelected As String
		
		If cbHeader.SelectedIndex = 0 Then '<New>
			new_record()
		End If
		
		If Len(gItplGridSelector2.sQuerySource) > 0 Then
			sQuerySource = gItplGridSelector2.sQuerySource & "'" & cbHeader.Text & "')" & vbCrLf & gItplGridSelector2.sQueryOrderBy
			
			load_dgLeft(sQuerySource)
		End If
		
		
		If Len(gItplGridSelector2.sQuerySelected) > 0 Then
			sQuerySelected = gItplGridSelector2.sQuerySelected & "'" & cbHeader.Text & "'" & vbCrLf & gItplGridSelector2.sQueryOrderBy
			
			load_dgRight(sQuerySelected)
		End If
	End Sub
	
	Private Sub cmdCancel_Click()
		gItplGridSelector2.bFlag = False
		Me.Close()
	End Sub
	
	Private Sub cmdLeft_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLeft.Click
		move_left()
	End Sub
	
	Private Sub cmdOk_Click()
		gItplGridSelector2.bFlag = True
		gItplGridSelector2.rsResult = rsRight
		Me.Close()
	End Sub
	
	Private Sub cmdRight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRight.Click
		move_right()
	End Sub
	
	Private Sub dgLeft_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgLeft.DblClick
		move_right()
	End Sub
	
	Private Sub dgRight_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgRight.DblClick
		move_left()
	End Sub
	
	Private Sub tplGridSelector2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	
	Private Sub init_vars()
		
		
        cmLocal = cn.CreateCommand
		
        init_rsRight()
		
		Me.Text = gItplGridSelector2.sFormCaption
		'Count
        cmLocal.CommandType = CommandType.Text
		
		txtHeader.Text = ""
		
		Select Case gItplGridSelector2.bModo
			Case General.modo.NewRecord
				cbHeader.Visible = False
				txtHeader.Visible = True
			Case General.modo.UpdateRecord
				cbHeader.Visible = True
				txtHeader.Visible = False
		End Select
		
		'Header
		header_settings()
		
		set_visible(gItplGridSelector2.bModo)
		
		If Len(gItplGridSelector2.sQueryHeader) > 0 Then
			load_header(gItplGridSelector2.sQueryHeader)
		End If
		
	End Sub
	Private Sub init_rsRight()
		'UPGRADE_NOTE: Object rsRight may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRight = Nothing
    End Sub
	Private Sub header_settings()
		Dim i As Short
		
		
		For i = 1 To 3
			Select Case gItplGridSelector2.header(i).itemHeader
				Case "lbHeader"
					lbHeader.Text = gItplGridSelector2.header(i).sCaption
					lbHeader.Left = VB6.TwipsToPixelsX(gItplGridSelector2.header(i).PositionLeft)
					lbHeader.Top = VB6.TwipsToPixelsY(gItplGridSelector2.header(i).PositionTop)
					
				Case "txtHeader"
					'txtHeader.Caption = gItplGridSelector2.header(i).itemHeader
					txtHeader.Left = VB6.TwipsToPixelsX(gItplGridSelector2.header(i).PositionLeft)
					txtHeader.Top = VB6.TwipsToPixelsY(gItplGridSelector2.header(i).PositionTop)
					
				Case "cbHeader"
					'cbHeader.Caption = gItplGridSelector2.header(i).itemHeader
					cbHeader.Left = VB6.TwipsToPixelsX(gItplGridSelector2.header(i).PositionLeft)
					cbHeader.Top = VB6.TwipsToPixelsY(gItplGridSelector2.header(i).PositionTop)
					
			End Select
		Next i
		
		
	End Sub
	Private Sub set_visible(ByRef nOption As General.modo)
		Select Case nOption
			Case General.modo.NewRecord
				cbHeader.Visible = False
				txtHeader.Visible = True
			Case General.modo.UpdateRecord
				cbHeader.Visible = True
				txtHeader.Visible = False
			Case Else
				cbHeader.Visible = True
				txtHeader.Visible = False
		End Select
	End Sub
	Private Sub load_header(ByRef sQuery As String)
		
		cbHeader.Items.Clear()
		
		cbHeader.Items.Insert(0, "<New>")
		
		load_cb_query2(cbHeader, sQuery, 1, False)
		
		If cbHeader.Items.Count > 1 Then
			cbHeader.SelectedIndex = 1
		End If
	End Sub
	Private Sub load_dgLeft(ByRef sQuery As String)
		Dim gridRecord As gItplGridSelectorFieldUDT
		Dim i As Short
		
        rsLeft = getDataTable(sQuery) '.Open(sQuery, cn)
        If rsLeft.Rows.Count > 0 Then
            dgLeft.DataSource = rsLeft
        Else
            Exit Sub
        End If
		
		'Formato
		dgLeft.Text = gItplGridSelector2.sLeftCaption
		
		For i = 0 To 10
			'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gridRecord = gItplGridSelector2.aFields(i)
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(gridRecord.sFieldName) And Len(gridRecord.sFieldName) > 0 Then
				dgLeft.Columns(gridRecord.sFieldName).Visible = gridRecord.bVisible
				dgLeft.Columns(gridRecord.sFieldName).Width = VB6.TwipsToPixelsX(gridRecord.nWidth)
			Else
				Exit For
			End If
		Next i
		
	End Sub
	
	Private Sub load_dgRight(ByRef sQuery As String)
		Dim gridRecord As gItplGridSelectorFieldUDT
		Dim i As Short
		
        rsRight = getDataTable(sQuery) '.Open(sQuery, cn)
        If rsRight.Rows.Count > 0 Then
            dgRight.DataSource = rsRight
        Else
            Exit Sub
        End If
		
		
		'Formato
		dgRight.Text = gItplGridSelector2.sRightCaption
		
		For i = 0 To 10
			'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gridRecord = gItplGridSelector2.aFields(i)
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If Not IsDbNull(gridRecord.sFieldName) And Len(gridRecord.sFieldName) > 0 Then
				dgRight.Columns(gridRecord.sFieldName).Visible = gridRecord.bVisible
				dgRight.Columns(gridRecord.sFieldName).Width = VB6.TwipsToPixelsX(gridRecord.nWidth)
			Else
				Exit For
			End If
		Next i
		
	End Sub
	
	Private Sub move_right()
		Dim i As Short
		Dim vRow As Object
		Dim gridRecord As gItplGridSelectorFieldUDT
		
		On Error GoTo ErrorHandler
		
        If rsRight.Rows.Count <= 0 Then
            init_rsRight()
            load_dgRight(gItplGridSelector2.sQueryInit)
            'rsRight.Open gItplGridSelector2.sQueryInit, cn
            'If rsRight.State = adStateOpen Then
            '    Set dgRight.DataSource = rsRight
            'End If
        End If
		
		For	Each vRow In dgLeft.SelBookmarks
			'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'rsLeft.Bookmark = vRow 'Muevo el recordset a la fila seleccionada
			
            'MsgBox "before:" + Str(rsRight.RecordCount)
            Dim drow As DataRow = rsRight.NewRow
            'rsRight.AddNew()
			'Copio todos los campos del registro
			For i = 0 To 10
				'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gridRecord = gItplGridSelector2.aFields(i)
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(gridRecord.sFieldName) And Len(gridRecord.sFieldName) > 0 Then
                    drow.Item(gridRecord.sFieldName).Value = rsLeft.Rows(vRow).Item(gridRecord.sFieldName).Value
				Else
					Exit For
				End If
			Next i
			
			
            'rsRight.Update()
            rsRight.Rows.Add(drow)
            rsRight.Select("", gItplGridSelector2.sOrderBy)
			'rsRight.MoveFirst
			'MsgBox "after:" + Str(rsRight.RecordCount)
            rsLeft.Rows.Remove(vRow)
		Next vRow
		Exit Sub
		
ErrorHandler: 
		If Err.Number = 3021 Then
			MsgBox("Error found.")
		End If
		'save_error Me.name, "add_member"
		MsgBox("Unexpected error found. Check log for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
		
		
	End Sub
	
	
	Private Sub move_left()
		Dim i As Short
		Dim vRow As Object
		Dim gridRecord As gItplGridSelectorFieldUDT
		
		On Error GoTo ErrorHandler
		
		For	Each vRow In dgRight.SelBookmarks
			'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'rsRight.Bookmark = vRow 'Muevo el recordset a la fila seleccionada
			
            'rsLeft.AddNew()
            Dim drow As DataRow = rsLeft.NewRow
			'Copio todos los campos del registro
			For i = 0 To 10
				'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gridRecord = gItplGridSelector2.aFields(i)
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(gridRecord.sFieldName) And Len(gridRecord.sFieldName) > 0 Then
                    drow.Item(gridRecord.sFieldName).Value = rsRight.Rows(vRow).Item(gridRecord.sFieldName).Value
				Else
					Exit For
				End If
			Next i
			
            'rsLeft.Update()
            rsLeft.Rows.Add(drow)
            rsLeft.Select("", gItplGridSelector2.sOrderBy)
			
            rsRight.Rows.Remove(vRow) '.Delete(ADODB.AffectEnum.adAffectCurrent)
			
		Next vRow
		Exit Sub
		
ErrorHandler: 
		If Err.Number = 3021 Then
			MsgBox("Error found.")
		End If
		'save_error Me.name, "add_member"
		MsgBox("Unexpected error found. Check log for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
		
		
	End Sub
	
	
	
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"

                cbHeader.SelectedIndex = 0 '<New>
                new_record()
            Case "save"
                If val_fields(gItplGridSelector2.bModo) Then
                    save_record(gItplGridSelector2.bModo)
                    gItplGridSelector2.bModo = General.modo.UpdateRecord
                    load_header(gItplGridSelector2.sQueryHeader)
                    set_visible(gItplGridSelector2.bModo)
                End If
            Case "delete"
                If gItplGridSelector2.bModo = General.modo.NewRecord Then
                    MsgBox("Can not perform this action until record is saved.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Warning")
                Else
                    If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "GLM Message") = MsgBoxResult.Yes Then
                        delete_record(cbHeader.Text)
                        load_header(gItplGridSelector2.sQueryHeader)
                        set_visible(gItplGridSelector2.bModo)
                    End If
                End If

            Case "exit"
                Me.Close()
        End Select
    End Sub
	
	Private Sub new_record()
		gItplGridSelector2.bModo = General.modo.NewRecord
		set_visible((General.modo.NewRecord))
		
		txtHeader.Text = ""
		txtHeader.Focus()
	End Sub
	Private Function val_fields(ByRef nOption As General.modo) As Boolean
		val_fields = False
		
		Select Case nOption
			Case General.modo.NewRecord
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If IsDbNull(txtHeader.Text) Then
					MsgBox("Please enter a value for:" & lbHeader.Text, MsgBoxStyle.OKOnly, "GLM Warning")
					txtHeader.Focus()
					Exit Function
				ElseIf Len(Trim(txtHeader.Text)) = 0 Then 
					MsgBox("Please enter a value for:" & lbHeader.Text, MsgBoxStyle.OKOnly, "GLM Warning")
					txtHeader.Focus()
					Exit Function
				End If
				
                If rsRight.rows.count = 0 Then
                    MsgBox("Please select one or more records from left pane.", MsgBoxStyle.OkOnly, "GLM Warning")
                    Exit Function
                End If
				
				If has_details(Trim(txtHeader.Text)) Then
					MsgBox("There is already a " & lbHeader.Text & " with this name." & vbCrLf & "Please enter another value.")
					txtHeader.Focus()
					Exit Function
				End If
			Case General.modo.UpdateRecord
                If rsRight.Rows.Count = 0 Then
                    MsgBox("Please select one or more records from left pane.", MsgBoxStyle.OkOnly, "GLM Warning")
                    Exit Function
                End If
				
		End Select
		
		val_fields = True
	End Function
	Private Sub delete_record(ByRef sPrimaryKey As String)
		Dim cmDelete As ADODB.Command
		Dim nRecords As Short
		
		cmDelete = New ADODB.Command
		
		cmDelete.let_ActiveConnection(cn)
		cmDelete.CommandText = gItplGridSelector2.sDeleteStmt
		cmDelete.CommandType = ADODB.CommandTypeEnum.adCmdText
		cmDelete.Parameters.Refresh()
		cmDelete.Parameters(0).Value = sPrimaryKey
		cmDelete.Execute(nRecords)
		If nRecords > 0 Then
			MsgBox("Record was successfully removed", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "GLM Message")
		Else
			MsgBox("Failed to remove record.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "GLM Error")
		End If
		
	End Sub
	Private Function has_details(ByRef sGroupId As String) As Boolean
        Dim cmCount As sqlcommand = cn.CreateCommand()
        Dim rsCount As DataTable
		
		
		On Error GoTo ErrorHandler
		
		has_details = False
        cmCount = cn.CreateCommand

		

        cmCount.CommandType = CommandType.Text
		cmCount.CommandText = gItplGridSelector2.sQueryCount
        'cmCount.Parameters.Refresh()
		'cmCount.Parameters.Append cmCount.CreateParameter("group_id", adChar, adParamInput, 20)
		
		cmCount.Parameters(0).Value = sGroupId
        rsCount = getDataTable(gItplGridSelector2.sQueryCount) 'cmCount.ExecuteNonQuery()
		
		
        If rsCount.Rows.Count > 0 Then
            If rsCount.Rows(0).Item(0).Value > 0 Then
                has_details = True
            End If
        End If
		Exit Function
		
ErrorHandler: 
		has_details = False
		save_error(Me.Name, "has_details")
		write_error("Failed to count number of details for:" & sGroupId, sLogfile, False)
		
	End Function
	Private Sub save_record(ByRef nOption As General.modo)
		Dim nRecords As Short
		
		On Error GoTo ErrorHandler
		
		
		cmLocal.CommandType = ADODB.CommandTypeEnum.adCmdText
		'cm.Parameters.Append cm.CreateParameter("group_id", adChar, adParamInput, 20)
		
		Select Case nOption
			Case General.modo.NewRecord
				
			Case General.modo.UpdateRecord
				cmLocal.CommandText = gItplGridSelector2.sDeleteStmt

				cmLocal.Parameters(0).Value = cbHeader.Text
                nRecords = cmLocal.ExecuteNonQuery()
		End Select
		
		cmLocal.CommandText = gItplGridSelector2.sInsertStmt
        'cmLocal.Parameters.Refresh()
		
		'cm.Parameters.Append cm.CreateParameter("serv_id", adChar, adParamInput, 20)
		
		Select Case nOption
			Case General.modo.NewRecord
				cmLocal.Parameters(0).Value = quotation_mask(txtHeader.Text)
			Case General.modo.UpdateRecord
				cmLocal.Parameters(0).Value = quotation_mask(cbHeader.Text)
		End Select

        For row As Integer = 0 To rsRight.Rows.Count - 1
            cmLocal.Parameters(1).Value = rsRight.Rows(row).Item("serv_id").Value
            nRecords = cmLocal.ExecuteNonQuery()
            If nRecords <= 0 Then
                Exit For
            End If
        Next row
        

        MsgBox("Data was successfully saved.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "GLM Message")
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "save_record")
        MsgBox("Unexpected error occurred while saving data.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
    End Sub
	
	Private Sub txtHeader_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHeader.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = 60 Or KeyAscii = 62 Then
			KeyAscii = 0
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class