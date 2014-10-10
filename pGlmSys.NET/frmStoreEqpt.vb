Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmStoreEqpt
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Private rsStore As DataTable
    Private rsStoreEqpt As DataTable
    Private ImageList2 As New ImageList()
	
	Private Sub dgStore_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgStore.ClickEvent
		'Solo si hay datos en el datagrid dgStore buscamos para dgStoreEqpt
		
		'If dgStore.Row >= 0 Then
		If dgStore.SelBookmarks.Count > 0 Then
            set_dgStoreEqptData(True, CShort(dgStore.Columns("store_id").Text), dgStore.Columns("Store").Text)
		End If
	End Sub
	
	Private Sub dgStoreEqpt_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgStoreEqpt.DblClick
		update_storeEqpt()
		If General.gbStoreEqptMode = General.modo.SavedRecord Then
            set_dgStoreData(True)
		End If
	End Sub
	'Actualiza Equipo
	Private Sub update_storeEqpt()
        If dgStoreEqpt.Row >= 0 Then
            Dim ds As DataSet = New DataSet()

            'no se como funciona bookmark
            'dgStoreEqpt.SelBookmarks.Add(rsStoreEqpt.Bookmark)
            General.gbStoreEqptMode = General.modo.UpdateRecord
            If get_storeEqpt(General.gbStoreEqptMode) = True Then
                VB6.ShowForm(frmStoreEqptEntry, VB6.FormShowConstants.Modal, Me)
            End If
        End If
	End Sub
	'Guarda los datos del equipo para Actualizarlos en frmStoreEqptEntry
	Private Function get_storeEqpt(ByRef bFlag As General.modo) As Boolean
        'gStoreEqptRecord.sCustId = Trim(rsStoreEqpt.item("cust_id"))
        'gStoreEqptRecord.nStoreId = rsStoreEqpt.item("store_id")
		'gStoreEqptRecord.sCustName = gbStoreSearch.sCustName
        'gStoreEqptRecord.sStoreNumber = rsLocal.item("Store")
		
		On Error GoTo ErrorHandler
		
		get_storeEqpt = True 'Ok por defecto
        gStoreEqptRecord.sCustId = Trim(rsStore.Rows(0).Item("cust_id").Value)
        gStoreEqptRecord.nStoreId = rsStore.Rows(0).Item("store_id").Value
		gStoreEqptRecord.sCustName = gbStoreSearch.sCustName
        gStoreEqptRecord.sStoreNumber = rsStore.Rows(0).Item("Store").Value
		
		If bFlag = General.modo.UpdateRecord Then
            gStoreEqptRecord.nEqptSeq = rsStoreEqpt.Rows(0).Item("eqpt_seq").Value
            gStoreEqptRecord.nEqptId = rsStoreEqpt.Rows(0).Item("eqpt_id").Value
            gStoreEqptRecord.sLoadId = rsStoreEqpt.Rows(0).Item("load_id").Value
			
            gStoreEqptRecord.sEqptStatus = rsStoreEqpt.Rows(0).Item("Status").Value
            gStoreEqptRecord.sEqptDesc = rsStoreEqpt.Rows(0).Item("Equip").Value
            gStoreEqptRecord.nContentId = rsStoreEqpt.Rows(0).Item("content_id").Value
            gStoreEqptRecord.nEqptQty = rsStoreEqpt.Rows(0).Item("Qty").Value
            gStoreEqptRecord.nEqptSizeCapacity = rsStoreEqpt.Rows(0).Item("eqpt_size_capacity").Value
            gStoreEqptRecord.nEqptActualQty = rsStoreEqpt.Rows(0).Item("eqpt_actual_qty").Value
			
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If IsDBNull(rsStoreEqpt.Rows(0).Item("eqpt_temp").Value) Then
                gStoreEqptRecord.sEqptTemp = ""
            Else
                gStoreEqptRecord.sEqptTemp = rsStoreEqpt.Rows(0).Item("eqpt_temp").Value
            End If
		End If
		Exit Function
		
ErrorHandler: 
		
		save_error(Me.Name, "get_storeEqpt")
		get_storeEqpt = False
		MsgBox("Unexpected error when loading Store Eqpt Form." & vbCrLf & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "GLM Error")
	End Function
	Private Sub frmStoreEqpt_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
		get_data()
	End Sub
	
	Private Sub init_vars()
        General.gbStoreEqptMode = General.modo.NewRecord
	End Sub
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                General.gbStoreEqptMode = General.modo.NewRecord
                'If dgStoreEqpt.Row >= 0 Then
                If get_storeEqpt(General.gbStoreEqptMode) = True Then

                    VB6.ShowForm(frmStoreEqptEntry, VB6.FormShowConstants.Modal, Me)
                    If General.gbStoreEqptMode = General.modo.SavedRecord Then
                        set_dgStoreData(True)
                    End If
                End If

                'End If

            Case "save"
                update_storeEqpt()
                If General.gbStoreEqptMode = General.modo.SavedRecord Then
                    set_dgStoreData(True)
                End If
            Case "search"
                get_data()
            Case "exit"
                Me.Close()
        End Select
    End Sub
	
	'Invoca a frmVendorSearch para obtener parametros
	'para mostrar datos en Datagrid
	Private Sub get_data()
		
		VB6.ShowForm(frmStoreSearch, VB6.FormShowConstants.Modal, Me)
		If gbStoreSearch.bFlag Then 'Usuario ingreso parametros para query
			'Habilito botones
			Toolbar1.Items.Item("new").Enabled = True
			Toolbar1.Items.Item("save").Enabled = True
			
		Else
			'Deshabilito botones
			Toolbar1.Items.Item("new").Enabled = False
			Toolbar1.Items.Item("save").Enabled = False
			
		End If
		'Corro query y cargo datos al Datagrid
        set_dgStoreData(gbStoreSearch.bFlag)
		
	End Sub
	
	'Ejecuta query usando parametros de StoreSearch
	'para cargar a Datagrid
    Private Sub set_dgStoreData(ByRef bFlag As Boolean)

        On Error GoTo ErrorHandler

        If bFlag Then
            lbCustomer.Text = Trim(gbStoreSearch.sCustName) & " - Stores"
            lbState.Text = "State - " & gbStoreSearch.sStateId
            sStmt = "SELECT store.cust_id, store.store_id, " & "store.store_number AS Store, store_name AS Name," & "store_address AS Address, store_city AS City, " & "store_zip AS Zip " & "FROM store " & "WHERE cust_id ='" & gbStoreSearch.sCustId & "' "

            If gbStoreSearch.sStateId = "<All>" Then
                'No se agrega condicion para State
                '1.8.8 Solo estados con permiso
                sStmt = Trim(sStmt) & " AND state_id IN (SELECT state_id " & " FROM suser_data " & " WHERE suser_name ='" & Trim(gsUser) & "' " & " AND cust_id ='" & gbStoreSearch.sCustId & "') "
            Else
                sStmt = Trim(sStmt) & "AND state_id = '" & gbStoreSearch.sStateId & "' "
            End If

            sStmt = Trim(sStmt) & " ORDER BY store_number"

        Else
            'Este query es solo para mostrar los titulos de los campos en Datagrid
            lbCustomer.Text = "Stores"
            lbState.Text = ""
            sStmt = "SELECT store.cust_id, store.store_id, " & "store.store_number AS Store, store_name AS Name," & "store_address AS Address, store_city AS City, " & "store_zip AS Zip " & "FROM store " & "WHERE cust_id ='00' "


        End If

        'UPGRADE_NOTE: Object dgStore.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        dgStore.DataSource = Nothing

        rsStore = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)


        dgStore.DataSource = rsStore
        dgStore.Columns("store_id").Visible = False
        dgStore.Columns("cust_id").Visible = False

        'Formato de columnas en datagrid.
        dgStore.Columns("Store").Width = VB6.TwipsToPixelsX(800)
        dgStore.Columns("Address").Width = VB6.TwipsToPixelsX(2500)
        dgStore.Columns("City").Width = VB6.TwipsToPixelsX(900)
        dgStore.Columns("Zip").Width = VB6.TwipsToPixelsX(1000)

        'search
        If rsStore.Rows.Count > 0 Then
            'StoreEqpt se actualizo sin problema
            If General.gbStoreEqptMode = General.modo.SavedRecord Then
                For row As Integer = 0 To rsStore.Rows.Count - 1
                    If rsStore.Rows(row).Item("store_id").Value = gStoreEqptRecord.nStoreId Then
                        'bookmark como funciona
                        'dgStore.SelBookmarks.Add(rsStore.Rows.Bookmark)
                        set_dgStoreEqptData(True, CShort(dgStore.Columns("store_id").Text), dgStore.Columns("Store").Text)
                        Exit For
                    End If
                Next row
                
            Else
                'If Not IsNull(dgStore.Columns("store_id")) Then
                'dgStore.SelBookmarks.Add(rsStore.Bookmark)
                set_dgStoreEqptData(True, CShort(dgStore.Columns("store_id").Text), dgStore.Columns("Store").Text)
                'End If
            End If
        Else
            set_dgStoreEqptData(False)
        End If
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "set_dgStoreEqpt")
        MsgBox("An unexpected error has occurred, check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")

    End Sub
	
	'Carga datos en el Datagrid de Equipos
    Private Sub set_dgStoreEqptData(ByRef bFlag As Boolean, Optional ByRef nStoreId As Short = 0, Optional ByRef sStoreNumber As String = "")
        Dim bFound As Boolean

        On Error GoTo ErrorHandler

        If bFlag Then
            lbEquipment.Text = "Equipment Assigned - Store " & Trim(sStoreNumber)

            sStmt = "SELECT se.cust_id AS cust_id, se.store_id, " & "se.eqpt_seq, se.eqpt_id, se.load_id, " & "eqpt_desc AS Equip, se.eqpt_status AS Status, " & "se.content_id, content.content_desc AS Content,  " & "se.load_id AS 'Load Type', se.eqpt_qty AS Qty, se.eqpt_temp, " & "se.eqpt_size_capacity, se.eqpt_actual_qty " & "FROM storeEqpt se, content " & " WHERE se.content_id  = content.content_id " & " AND se.cust_id = '" & gbStoreSearch.sCustId & "'" & " AND se.store_id = " & Str(nStoreId) & " " & " ORDER BY Equip "


        Else
            'Inicializar el Datagrid
            lbEquipment.Text = "Equipment Assigned "
            sStmt = "SELECT se.cust_id, se.store_id, " & "se.eqpt_seq, se.eqpt_id, se.load_id, " & "eqpt_desc AS Equip, se.eqpt_status AS Status, " & "se.content_id, content.content_desc AS Content, " & "se.load_id AS 'Load Type', se.eqpt_qty AS Qty, se.eqpt_temp, " & "se.eqpt_size_capacity, se.eqpt_actual_qty " & "FROM storeEqpt se, content " & "WHERE se.content_id  = content.content_id " & "AND se.cust_id = '00' " & "ORDER BY Equip "


        End If

        'UPGRADE_NOTE: Object dgStoreEqpt.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        dgStoreEqpt.DataSource = Nothing
        dgStoreEqpt.Text = "Equipment"

        
        rsStoreEqpt = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        dgStoreEqpt.DataSource = rsStoreEqpt

        'search
        bFound = False

        If rsStoreEqpt.Rows.Count > 0 Then
            If General.gbStoreEqptMode = General.modo.SavedRecord Then
                For row As Integer = 0 To rsStoreEqpt.Rows.Count - 1
                    If rsStoreEqpt.Rows(row).Item("store_id").Value = gStoreEqptRecord.nStoreId And rsStoreEqpt.Rows(row).Item("cust_id").Value = gStoreEqptRecord.sCustId And rsStoreEqpt.Rows(row).Item("eqpt_seq").Value = gStoreEqptRecord.nEqptSeq Then
                        'no se como hacer bookmark
                        'dgStoreEqpt.SelBookmarks.Add((rsStoreEqpt.Rows(row).Bookmark))
                        bFound = True
                        Exit For
                    End If
                Next row
                
                'Store-Eqpt no se encontro
                If bFound = False Then
                    'dgStoreEqpt.SelBookmarks.Add((rsStoreEqpt.Bookmark))
                End If
            Else
                'dgStoreEqpt.SelBookmarks.Add((rsStoreEqpt.Bookmark))
            End If
        End If


        'Escondo Columnas
        dgStoreEqpt.Columns("cust_id").Visible = False
        dgStoreEqpt.Columns("store_id").Visible = False
        dgStoreEqpt.Columns("eqpt_seq").Visible = False
        dgStoreEqpt.Columns("eqpt_id").Visible = False
        dgStoreEqpt.Columns("load_id").Visible = False
        dgStoreEqpt.Columns("content_id").Visible = False
        dgStoreEqpt.Columns("eqpt_temp").Visible = False
        dgStoreEqpt.Columns("eqpt_size_capacity").Visible = False
        dgStoreEqpt.Columns("eqpt_actual_qty").Visible = False

        'Fomato de Columnas
        dgStoreEqpt.Columns("Equip").Width = VB6.TwipsToPixelsX(2500)
        dgStoreEqpt.Columns("Status").Width = VB6.TwipsToPixelsX(650)
        dgStoreEqpt.Columns("Content").Width = VB6.TwipsToPixelsX(1500)
        dgStoreEqpt.Columns("Qty").Width = VB6.TwipsToPixelsX(1000)


        Exit Sub

ErrorHandler:
        save_error(Me.Name, "set_dgStoreEqpt")
        MsgBox("An unexpected error has occurred, check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
    End Sub
End Class