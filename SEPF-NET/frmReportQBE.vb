Public Class frmReportQBE

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmViewer.rptFile = "Pensioners.rpt"  ' "Participants.rpt"
        frmViewer.rptSelectionCritera = "{v_rpt_sq_Pensioners.Status}='P'"
        frmViewer.Show()
    End Sub
End Class