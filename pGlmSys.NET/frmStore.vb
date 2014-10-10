Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmStore
	Inherits System.Windows.Forms.Form
    Private rsLocal As SqlDataReader
    Private rsTmp As SqlDataReader
    Private ImageList2 As New ImageList()
	Private Sub search_store(ByRef nStoreId As Short)
		
	End Sub
	Private Sub update_store()
		If dgStore.Row >= 0 Then
			General.gbMode = General.modo.UpdateRecord
			If get_store Then
				VB6.ShowForm(frmStoreEntry, VB6.FormShowConstants.Modal, Me)
			End If
		End If
		
	End Sub
	
	Private Sub dgStore_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgStore.DblClick
		update_store()
		If General.gbMode = General.modo.SavedRecord Then
			'Refresca query
            set_dgStoreData(True)
		End If
	End Sub
	
	Private Sub frmStore_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		init_vars()
		load_comp()
	End Sub
	Private Sub init_vars()

    End Sub
	
	Private Sub load_comp()
		
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
    Private Sub set_dgStoreData(ByRef bFlag As Boolean)
        Dim bFound As Boolean
        Dim cmd As SqlCommand = cn.CreateCommand
        On Error GoTo ErrorHandler

        If bFlag Then
            Label1.Text = Trim(gbStoreSearch.sCustName) & " - Stores"
            lbState.Text = "State - " & gbStoreSearch.sStateId
            sStmt = "SELECT store.store_id, " & "store.store_number AS Store, store_name AS Name," & "store_address AS Address, store_city AS City, " & "store_zip AS Zip, store_contact AS Contact, store_address_seq " & "FROM store " & "WHERE cust_id ='" & gbStoreSearch.sCustId & "' "

            If gbStoreSearch.sStateId = "<All>" Then
                '1.8.8 Solo estados con permiso
                sStmt = Trim(sStmt) & " AND state_id IN (SELECT state_id " & " FROM suser_data " & " WHERE suser_name ='" & Trim(gsUser) & "' " & " AND cust_id ='" & gbStoreSearch.sCustId & "') "
            Else
                sStmt = Trim(sStmt) & "AND state_id = '" & gbStoreSearch.sStateId & "' "
            End If

            sStmt = Trim(sStmt) & " ORDER BY store_number"

        Else
            'Este query es solo para mostrar los titulos de los campos en Datagrid
            Label1.Text = "Stores"
            lbState.Text = ""
            sStmt = "SELECT store.store_id, " & "store.store_number AS Store, store_name AS Name," & "store_address AS Address, store_city AS City, " & "store_zip AS Zip, store_contact AS Contact, store_address_seq " & "FROM store " & "WHERE cust_id ='00' "


        End If

        'UPGRADE_NOTE: Object dgStore.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        dgStore.DataSource = Nothing
        cmd.CommandText = sStmt
        rsLocal = cmd.ExecuteReader() '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)


        'search
        bFound = False

        If rsLocal.HasRows() Then

            While rsLocal.Read()
                If rsLocal.Item("store_id").Value = gStoreRecord.nStoreId Then
                    'dgStore.SelBookmarks.Add (rsLocal.Bookmark)
                    bFound = True
                    Exit While
                End If
            End While
        End If



        dgStore.DataSource = rsLocal

        If rsLocal.HasRows() Then
            If bFound = False Then

            End If
            'no se como funcionan los bookmarks
            'dgStore.SelBookmarks.Add((rsLocal.Bookmark))
        End If


        dgStore.Columns("store_id").Visible = False
        dgStore.Columns("store_address_seq").Visible = False

        'Formato de columnas en datagrid.
        dgStore.Columns("Store").Width = VB6.TwipsToPixelsX(800)
        dgStore.Columns("Address").Width = VB6.TwipsToPixelsX(2500)
        dgStore.Columns("City").Width = VB6.TwipsToPixelsX(900)
        dgStore.Columns("Zip").Width = VB6.TwipsToPixelsX(1000)
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "set_dgStoreData")
        MsgBox("An unexpected error has occurred.Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Error")

    End Sub
	
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button4.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "new"
                General.gbMode = General.modo.NewRecord
                VB6.ShowForm(frmStoreEntry, VB6.FormShowConstants.Modal, Me)
                If General.gbMode = General.modo.SavedRecord Then
                    'Refresca query
                    set_dgStoreData(True)
                End If
            Case "save"
                update_store()
                If General.gbMode = General.modo.SavedRecord Then
                    'Refresca query
                    set_dgStoreData(True)
                End If

            Case "search"
                load_comp()
            Case "exit"
                Me.Close()
        End Select


    End Sub
	
	'Saves Store info in gStoreRecord
	Private Function get_store() As Boolean
		
        Dim dt As DataTable
		get_store = False
		gStoreRecord.sStoreNumber = dgStore.Columns("Store").Text
		gStoreRecord.nStoreId = CShort(dgStore.Columns("store_id").Text)
		
		sStmt = "SELECT  store_name, " & "store_address, store_city, store_zip, " & "state_id, store_phone1, store_phone2, " & "store_fax1, store_fax2, store_contact," & "store_status, store_folder, store_co_code, store_occupants, " & "store_address_seq, store_billing_contact, store_billing_account, " & "lf_group, store_market, store_sold, store_sold_date " & " FROM store " & " WHERE cust_id ='" & Trim(gbStoreSearch.sCustId) & "' " & " AND store_id=" & Str(gStoreRecord.nStoreId)
        Try
            dt = getDataTable(sStmt)
            'rsTmp.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If dt.Rows.Count > 0 Then
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreName = IIf(IsDBNull(dt.Rows(0).Item("store_name").Value), "", Trim(dt.Rows(0).Item("store_name").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreAddress = IIf(IsDBNull(dt.Rows(0).Item("store_address").Value), "", Trim(dt.Rows(0).Item("store_address").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreCity = IIf(IsDBNull(dt.Rows(0).Item("store_city").Value), "", Trim(dt.Rows(0).Item("store_city").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreZip = IIf(IsDBNull(dt.Rows(0).Item("store_zip").Value), "", Trim(dt.Rows(0).Item("store_zip").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStateId = IIf(IsDBNull(dt.Rows(0).Item("state_id").Value), "", Trim(dt.Rows(0).Item("state_id").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStorePhone1 = IIf(IsDBNull(dt.Rows(0).Item("store_phone1").Value), "", Trim(dt.Rows(0).Item("store_phone1").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStorePhone2 = IIf(IsDBNull(dt.Rows(0).Item("store_phone2").Value), "", Trim(dt.Rows(0).Item("store_phone2").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreFax1 = IIf(IsDBNull(dt.Rows(0).Item("store_fax1").Value), "", Trim(dt.Rows(0).Item("store_fax1").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreFax2 = IIf(IsDBNull(dt.Rows(0).Item("store_fax2").Value), "", Trim(dt.Rows(0).Item("store_fax2").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreContact = IIf(IsDBNull(dt.Rows(0).Item("store_contact").Value), "", Trim(dt.Rows(0).Item("store_contact").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreStatus = IIf(IsDBNull(dt.Rows(0).Item("store_status").Value), "", Trim(dt.Rows(0).Item("store_status").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreFolder = IIf(IsDBNull(dt.Rows(0).Item("store_folder").Value), "", Trim(dt.Rows(0).Item("store_folder").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreCoCode = IIf(IsDBNull(dt.Rows(0).Item("store_co_code").Value), "", Trim(dt.Rows(0).Item("store_co_code").Value))

                'Bug 35.begin
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.nStoreOccupants = IIf(IsDBNull(dt.Rows(0).Item("store_occupants")), 0, Trim(dt.Rows(0).Item("store_occupants").Value))
                'Bug 35.end

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.nStoreAddressSeq = IIf(IsDBNull(dt.Rows(0).Item("store_address_seq").Value), 0, Trim(dt.Rows(0).Item("store_address_seq").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreBillingContact = IIf(IsDBNull(dt.Rows(0).Item("store_billing_contact").Value), "", Trim(dt.Rows(0).Item("store_billing_contact").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreBillingAccount = IIf(IsDBNull(dt.Rows(0).Item("store_billing_account").Value), "", Trim(dt.Rows(0).Item("store_billing_account").Value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sLfGroup = IIf(IsDBNull(dt.Rows(0).Item("lf_group").Value), "", Trim(dt.Rows(0).Item("lf_group").value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreMarket = IIf(IsDBNull(dt.Rows(0).Item("store_market").Value), "", Trim(dt.Rows(0).Item("store_market").value))

                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                gStoreRecord.sStoreSold = IIf(IsDBNull(dt.Rows(0).Item("store_sold").Value), "", Trim(dt.Rows(0).Item("store_sold").value))


                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If dt.Rows(0).Item("store_sold_date").value Is System.DBNull.Value Then
                    gStoreRecord.dtStoreSoldDate = dt.Rows(0).Item("store_sold_date").value
                End If


                'lf_group, store_market, store_sold, store_sold_date

                get_store = True
            Else
                MsgBox("Unable to get data for customer:" & Trim(gbStoreSearch.sCustId) & " store:" & gStoreRecord.sStoreNumber, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")


            End If

        Catch e As Exception
            MsgBox("Error accesing database.", MsgBoxStyle.OkOnly, "GLM Error")
        End Try

        Exit Function

ErrorHandler:
        get_store = False
        save_error("frmStore", "get_store")
        MsgBox("Failed to retrieve Store info." & vbCrLf & "Check log file for details.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "GLM Error")
    End Function
End Class