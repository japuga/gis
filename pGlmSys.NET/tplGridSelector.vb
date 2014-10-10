Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class tplGridSelector
	Inherits System.Windows.Forms.Form
	'Usage
	
    Private rsLeft As DataTable
    Private rsRight As DataTable
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		gItplGridSelector.bFlag = False
		Me.Close()
	End Sub
	
	Private Sub cmdLeft_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLeft.Click
		move_left()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		If validate_Renamed() Then
			gItplGridSelector.bFlag = True
			gItplGridSelector.rsResult = rsRight
			Me.Close()
		End If
		
		
	End Sub
	'This functions looks for the originator validation function to
	'validate result recordset data
	'UPGRADE_NOTE: validate was upgraded to validate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Function validate_Renamed() As Boolean
		
		validate_Renamed = True
		
		If gItplGridSelector.sInvokeFromForm = "frmRepGlmInvoice" Then
			validate_Renamed = frmRepGlmInvoice.validateStoreGroupList(rsRight)
		End If
		
	End Function
	Private Sub cmdRight_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRight.Click
		move_right()
	End Sub
	
	Private Sub dgLeft_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgLeft.DblClick
		move_right()
	End Sub
	
	Private Sub dgRight_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgRight.DblClick
		move_left()
	End Sub
	
	Private Sub tplGridSelector_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
	End Sub
	
	
	Private Sub init_vars()

        If Len(gItplGridSelector.sQuerySource) > 0 Then
            load_dgLeft(gItplGridSelector.sQuerySource)
        End If

        If Len(gItplGridSelector.sQuerySelected) > 0 Then
            load_dgRight(gItplGridSelector.sQuerySelected)
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
		dgLeft.Text = gItplGridSelector.sLeftCaption
		
		For i = 0 To 10
			'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gridRecord = gItplGridSelector.aFields(i)
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
		dgRight.Text = gItplGridSelector.sRightCaption
		
		For i = 0 To 10
			'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gridRecord = gItplGridSelector.aFields(i)
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
		
		
		For	Each vRow In dgLeft.SelBookmarks
			'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'rsLeft.Bookmark = vRow 'Muevo el recordset a la fila seleccionada
			
            'MsgBox "before:" + Str(rsRight.RecordCount)
            Dim drow As DataRow = rsRight.NewRow
            'rsRight.AddNew()
			'Copio todos los campos del registro
			For i = 0 To 10
				'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gridRecord = gItplGridSelector.aFields(i)
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(gridRecord.sFieldName) And Len(gridRecord.sFieldName) > 0 Then
                    drow.Item(gridRecord.sFieldName).Value = rsLeft.Rows(vRow).Item(gridRecord.sFieldName).Value
				Else
					Exit For
				End If
			Next i
			
            rsRight.Rows.Add(drow) '.Update()
            rsRight.Select("", gItplGridSelector.sOrderBy)
			
			'MsgBox "after:" + Str(rsRight.RecordCount)
            rsLeft.Rows.Remove(vRow) '(ADODB.AffectEnum.adAffectCurrent)
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
            Dim drow As DataRow = rsLeft.NewRow
            'rsLeft.AddNew()
			'Copio todos los campos del registro
			For i = 0 To 10
				'UPGRADE_WARNING: Couldn't resolve default property of object gridRecord. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gridRecord = gItplGridSelector.aFields(i)
				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
				If Not IsDbNull(gridRecord.sFieldName) And Len(gridRecord.sFieldName) > 0 Then
                    drow.Item(gridRecord.sFieldName).Value = rsRight.Rows(vRow).Item(gridRecord.sFieldName).Value
				Else
					Exit For
				End If
			Next i
            rsLeft.Rows.Add(drow)
			'rsLeft.Update()
            rsLeft.Select("", gItplGridSelector.sOrderBy)
			
            rsRight.Rows.Remove(vRow) '(ADODB.AffectEnum.adAffectCurrent)
			
		Next vRow
		Exit Sub
		
ErrorHandler: 
		If Err.Number = 3021 Then
			MsgBox("Error found.")
		End If
		'save_error Me.name, "add_member"
		MsgBox("Unexpected error found. Check log for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
		
		
	End Sub
End Class