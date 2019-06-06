Public Class frmBaseMDI

    Private Sub frmBaseMDI_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        frmMain.MdiParent = Me
        frmMain.Show()
    End Sub
End Class