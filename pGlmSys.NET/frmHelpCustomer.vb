Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class frmHelpCustomer

    Inherits System.Windows.Forms.Form
    '06.07.06   Added sorting funcitonality. The rsHelp recordset
    '           is sorted when user clicks a header column in dgStore_HeadClick
    '           Had to make rsHelp as client-side recordset.
    Public Enum options
        adStoreHelp = 1
        adInvoiceHelp = 2
    End Enum
    Public nMode As options
    Private bFirstTime As Boolean
    Private rsLocal As datatable



    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click

        Me.Close()
    End Sub

    Private Sub cmdFilter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFilter.Click
        Dim sFilter As String
        sFilter = build_store_filter()
        If Len(sFilter) = 0 Then
            MsgBox("Enter any criteria before to apply filters.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "GLM Warning")
        Else
            load_dg(sFilter)
        End If

    End Sub

    Private Function build_store_filter() As String
        Dim sFilter As String

        sFilter = ""

        If Len(txtStoreNumber.Text) > 0 Then
            sFilter = sFilter & " AND store_number LIKE '%" & quotation_mask(Trim(txtStoreNumber.Text)) & "%'"
        End If

        If Len(txtStoreName.Text) > 0 Then
            sFilter = sFilter & " AND store_name LIKE '%" & quotation_mask(Trim(txtStoreName.Text)) & "%'"
        End If

        If Len(txtStoreAddress.Text) > 0 Then
            sFilter = sFilter & " AND store_address LIKE '%" & quotation_mask(Trim(txtStoreAddress.Text)) & "%'"
        End If

        If Len(txtAccountMask.Text) > 0 Then
            sFilter = sFilter & " AND account_mask LIKE '%" & quotation_mask(Trim(txtAccountMask.Text)) & "%'"
        End If

        If Len(txtVendName.Text) > 0 Then
            sFilter = sFilter & " AND vend_name LIKE '%" & quotation_mask(Trim(txtVendName.Text)) & "%'"
        End If

        build_store_filter = sFilter
    End Function


    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        dgStore_DblClick(dgStore, New System.EventArgs())
        bUserCancel = False
    End Sub


    Private Sub cmdShowAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdShowAll.Click
        load_dg("")
    End Sub


    Private Sub dgStore_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dgStore.DblClick
        Dim vRow As Object
        Dim nRow As Short
        Dim i As Short

        On Error GoTo ErrorHandler

        nRow = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vRow = 0
        For Each vRow In dgStore.SelBookmarks
            'Selecciona el primer registro marcado
            'UPGRADE_WARNING: Couldn't resolve default property of object vRow. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            nRow = vRow
            Exit For
        Next vRow

        'Si no ha marcado ningun registro no hace nada
        If nRow = 0 Then
            Exit Sub
        End If

        'Por verificar es probable que esto quede igual.
        'Asigna los valores de seleccion a los componentes de la forma padre
        Select Case nMode
            Case options.adStoreHelp
                frmInvoiceBooking.txtStore.Text = dgStore.Columns(2).Text
                frmInvoiceBooking.txtStore.Tag = dgStore.Columns("StoreId").Text
                frmInvoiceBooking.txtStoreId.Text = dgStore.Columns("StoreId").Text
                frmInvoiceBooking.lVendorAddress.Text = Trim(dgStore.Columns(3).Text) & " " & vbCrLf & Trim(dgStore.Columns(4).Text) & " " & vbCrLf & Trim(dgStore.Columns(5).Text)


                'Rel 1.4 -Evita que cbVendor y cbAccount permanezcan
                'apuntando a informacion que ya no corresponde a esta tienda.
                frmInvoiceBooking.cbVendor.Items.Clear()
                frmInvoiceBooking.cbVendor.SelectedIndex = -1
                frmInvoiceBooking.cbAccount.Items.Clear()
                frmInvoiceBooking.cbAccount.SelectedIndex = -1

            Case options.adInvoiceHelp


                'Add here validation before cleaning form
                frmInvoiceBooking.clear_form("ALL")

                'Save customer
                For i = 0 To frmInvoiceBooking.cbCustomer.Items.Count - 1
                    If dgStore.Columns("cust_id").Text = VB6.GetItemString(frmInvoiceBooking.cbCustomer, i) Then
                        frmInvoiceBooking.cbCustomer.SelectedIndex = i
                        Exit For
                    End If
                Next i

                'Save State
                For i = 0 To frmInvoiceBooking.cbState.Items.Count - 1
                    If dgStore.Columns("State").Text = VB6.GetItemString(frmInvoiceBooking.cbState, i) Then
                        frmInvoiceBooking.cbState.SelectedIndex = i
                        Exit For
                    End If
                Next i

                frmInvoiceBooking.txtStore.Text = dgStore.Columns("Store").Text
                frmInvoiceBooking.txtStore.Tag = dgStore.Columns("store_id").Text
                frmInvoiceBooking.txtStoreId.Text = dgStore.Columns("store_id").Text

                'Save Vendor
                frmInvoiceBooking.load_combo((frmInvoiceBooking.cbVendor))

                For i = 0 To frmInvoiceBooking.cbVendor.Items.Count - 1
                    'If Trim(dgStore.Columns("Vendor")) = frmInvoiceBooking.cbVendor.List(i) Then
                    If CDbl(dgStore.Columns("vend_seq").Text) = VB6.GetItemData(frmInvoiceBooking.cbVendor, i) Then
                        frmInvoiceBooking.cbVendor.SelectedIndex = i
                        Exit For
                    End If
                Next i

                'Save address label
                frmInvoiceBooking.load_address(dgStore.Columns("cust_id").Text, dgStore.Columns("Store").Text, dgStore.Columns("State").Text)

                'Save account
                frmInvoiceBooking.load_combo((frmInvoiceBooking.cbAccount))

                For i = 0 To frmInvoiceBooking.cbAccount.Items.Count - 1
                    If Trim(dgStore.Columns("Account").Text) = VB6.GetItemString(frmInvoiceBooking.cbAccount, i) Then
                        frmInvoiceBooking.cbAccount.SelectedIndex = i
                        Exit For
                    End If
                Next i

                'Save Invoice
                frmInvoiceBooking.txtInvoice.Text = dgStore.Columns("Invoice").Text
                frmInvoiceBooking.dtDate._Value = dgStore.Columns("Date").Text
                'frmInvoiceBooking.dtStartPeriod = dgStore.Columns("start_period")
                'frmInvoiceBooking.dtEndPeriod = dgStore.Columns("end_period")
                For i = 0 To frmInvoiceBooking.cbMonthPeriod.Items.Count - 1
                    If Trim(dgStore.Columns("month_period").Text) = VB6.GetItemString(frmInvoiceBooking.cbMonthPeriod, i) Then
                        frmInvoiceBooking.cbMonthPeriod.SelectedIndex = i
                        Exit For
                    End If
                Next i

                For i = 0 To frmInvoiceBooking.cbPeriod.Items.Count - 1
                    If CDbl(dgStore.Columns("period_seq").Text) = VB6.GetItemData(frmInvoiceBooking.cbPeriod, i) Then
                        frmInvoiceBooking.cbPeriod.SelectedIndex = i
                        Exit For
                    End If
                Next i

                frmInvoiceBooking.txtYearPeriod.Text = dgStore.Columns("year_period").Text
                frmInvoiceBooking.txtWorkOrderNo.Text = dgStore.Columns("work_order").Text

                frmInvoiceBooking.txtSc.Text = dgStore.Columns("sc").Text
                frmInvoiceBooking.txtExtc.Text = dgStore.Columns("extc").Text

                'cbGroupName
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If IsDBNull(dgStore.Columns("group_seq").Text) Or dgStore.Columns("group_seq").Text = "" Then
                    'Do not set index
                Else
                    set_cb_ItemData2((frmInvoiceBooking.cbGroupName), CShort(dgStore.Columns("group_seq").Text))
                End If

                frmInvoiceBooking.enable_pk(False)
                frmInvoiceBooking.load_combo((frmInvoiceBooking.cbEquipment))
                frmInvoiceBooking.load_rs()
                frmInvoiceBooking.load_detail("OLD")
                'Modo de actualizacion de la factura.
                frmInvoiceBooking.nMode = frmInvoiceBooking.mode.adUpdate
        End Select
        Me.Close()
        Exit Sub

ErrorHandler:
        save_error(Me.Name, "dgStore_click")
        MsgBox("An unexpected error has occurred. Check log file for details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "GLM Error")
    End Sub

    Private Sub dgStore_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxMSDataGridLib.DDataGridEvents_HeadClickEvent) Handles dgStore.HeadClick

        Dim sMsg As String
        Dim sColname As String

        On Error GoTo ErrorHandler

        sColname = dgStore.Columns(eventArgs.colIndex).Caption
        rsHelp.Select("", sColname)
        Exit Sub

ErrorHandler:
        sMsg = ""
        If Err.Number = 3265 Then
            sMsg = "-WARNING-Failed to sort using Header column-" & sColname
        End If
        save_error(Me.Name, "dgStore_HeadClick" & sMsg)

        Resume Next

    End Sub

    'UPGRADE_WARNING: Form event frmHelpCustomer.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmHelpCustomer_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        set_defaults()
    End Sub

    Private Sub frmHelpCustomer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        rsLocal = Nothing

        txtStore.Visible = False

        bUserCancel = True
        bFirstTime = True
        'Asocia el recordset al datagrid
        redraw_form()
        load_dg("")


        bFirstTime = False
    End Sub
    'Agrega elementos a al forma dependiendo el tipo de ayuda
    Private Sub redraw_form()


        Select Case nMode
            Case options.adStoreHelp
                'lbStore = ""

                txtStore.Top = dgStore.Top
                txtStore.Left = dgStore.Left
                txtStore.Enabled = False
                txtStore.ReadOnly = True


                lbMessage.Text = "Please Choose Store from List:"
                frStoreFilter.Visible = True


                'txtStoreNumber.SetFocus
            Case options.adInvoiceHelp
                frStoreFilter.Visible = False

                lbMessage.Text = "Please Choose Invoice from List:"
                lbMessage.Top = frStoreFilter.Top
                dgStore.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frStoreFilter.Top) + VB6.PixelsToTwipsY(lbMessage.Height))
                cmdOk.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frStoreFilter.Top) + VB6.PixelsToTwipsY(lbMessage.Height) + VB6.PixelsToTwipsY(dgStore.Height) + 200)
                cmdCancel.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frStoreFilter.Top) + VB6.PixelsToTwipsY(lbMessage.Height) + VB6.PixelsToTwipsY(dgStore.Height) + 200)
                Me.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(cmdOk.Top) + VB6.PixelsToTwipsY(cmdOk.Height) + 650)
        End Select

    End Sub
    'Carga datos del recordset rsHelp previamente abierto y cargado en
    'forma que invoco esta ayuda: frmInvoice, frmInvoiceSearch
    Private Sub load_dg(ByRef sFilter As String)


        'Ejecuto query
        sStmt = gInvoiceHelp.sSql & sFilter & gInvoiceHelp.sOrderBy

        rsHelp = getDataTable(sStmt) '.Open(sStmt, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        dgStore.DataSource = rsHelp

        Select Case nMode
            Case options.adStoreHelp
                'Formateo de columnas
                dgStore.Text = " Store Information"
                dgStore.Columns("Store Number").Caption = "Store#"
                dgStore.Columns("Store Name").Caption = "Name"
                dgStore.Columns("Customer").Width = VB6.TwipsToPixelsX(500)
                dgStore.Columns("Code").Width = VB6.TwipsToPixelsX(900)
                dgStore.Columns("Store Address").Width = VB6.TwipsToPixelsX(4000)
                'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                dgStore.Refresh()
                dgStore.Columns("StoreId").Visible = False


                If rsHelp.Rows.Count = 0 And bFirstTime Then
                    MsgBox("Store information is not available for " & vbCrLf & "selected Customer and State", MsgBoxStyle.Exclamation, "Warning")
                End If


            Case options.adInvoiceHelp
                'Formateo de columnas
                dgStore.Text = "Invoice Information"
                dgStore.Columns("Customer").Width = VB6.TwipsToPixelsX(1000)
                'dgStore.Columns("start_period").Visible = False
                dgStore.Columns("month_period").Visible = False
                dgStore.Columns("cust_id").Visible = False
                dgStore.Columns("store_id").Visible = False
                dgStore.Columns("vend_seq").Visible = False
                'dgStore.Columns("end_period").Visible = False
                dgStore.Columns("year_period").Visible = False
                dgStore.Columns("period_seq").Visible = False
                dgStore.Columns("group_seq").Visible = False
                dgStore.Columns("work_order").Visible = False
                dgStore.Columns("sc").Visible = False
                dgStore.Columns("extc").Visible = False
        End Select


        If rsHelp.Rows.Count > 0 Then
            lRecords.Text = "Total Records:" & Str(rsHelp.Rows.Count)
        Else
            lRecords.Text = ""
        End If


        Exit Sub

ErrorHandler:
        save_error(Me.Name, "load_dg")
        MsgBox("An unexpected error has ocurred, check log file for details", MsgBoxStyle.Critical, "GLM Error")
    End Sub

    Private Sub set_defaults()
        Select Case nMode
            Case options.adStoreHelp
                txtStoreNumber.Focus()
        End Select
    End Sub
End Class