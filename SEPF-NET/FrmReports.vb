
Imports System.Data.SqlClient



Public Class FrmReports
    Dim da As SqlDataAdapter
    Dim dt As New DataTable

    Private Sub FrmReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = String.Empty

        sql = "SELECT * from reports"
        da = New SqlDataAdapter(Sql, gCnn)
        da.Fill(dt)
        'Call AddNodes to Fill tree nodes
        trvReports.Nodes.Clear()
        AddNodes(-1, trvReports.Nodes)
        trvReports.ExpandAll()
        trvReports.Focus()
    End Sub
    Private Sub AddNodes(ByVal id As Long, ByVal Trv As TreeNodeCollection)

        'recurcivly load child for one parent and add to the collection

        Try
            For Each dr As DataRow In dt.Select("Rpts_ParentID = " & id)
                Dim subNode As New TreeNode
                subNode.Text = dr("Rpts_desc").ToString
                subNode.Tag = dr("Rpts_ID").ToString
                subNode.Name = dr("Rpts_Name").ToString 'remember it for trv.nodes.Find() method.

                Trv.Add(subNode)
                subNode.ExpandAll()
                AddNodes(CLng(subNode.Tag), subNode.Nodes)
            Next
        Catch ex As Exception
            MsgBox(ex.Source & "- " & ex.Message)
        End Try
    End Sub

    Private Sub trvReports_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles trvReports.AfterSelect

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If trvReports.SelectedNode.Name = "ReportQBE" Then
            frmReportQBE.Show()

        Else
            frmViewer.rptFile = trvReports.SelectedNode.Name
            frmViewer.Show()
        End If

    End Sub
End Class