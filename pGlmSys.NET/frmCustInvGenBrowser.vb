Public Class frmCustInvGenBrowser
    Private Sub frmCustInvGenPreview_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'iCust_invoice_seq = 0
        'sFileSaved = False
    End Sub

    Private Sub WebBrowser1_NavigateComplete2(ByVal sender As Object, _
    ByVal e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event) _
    Handles WebBrowser1.NavigateComplete2

        On Error Resume Next

        oDocument = e.pDisp.Document

        'Note: You can use the reference to the document object to
        '      automate the document server.
        MsgBox("File opened by: " & oDocument.Application.Name)

    End Sub


    private Sub WebBrowser1_NavigateComplete2(byVal sender As Object, byVal e as 
End Class