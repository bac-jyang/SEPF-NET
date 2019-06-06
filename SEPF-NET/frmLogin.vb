Imports System.Data.SqlClient

Public Class frmLogin


    Private Sub cmdOk_Click(sender As Object, e As System.EventArgs) Handles cmdOk.Click

        gCnn = New SqlConnection
        Try

            If optNT.Checked Then
                '' NT authentication
                txtUserID.Enabled = False
                txtPwsd.Enabled = False

                gCnn.ConnectionString =
                  "Data Source=" & Me.txtServer.Text & ";" & _
                  "Initial Catalog=" & Me.txtDBName.Text & ";" & _
                  "Integrated Security=SSPI"
            End If
            If optSQL.Checked Then
                ' SQL server authentication
                txtUserID.Enabled = True
                txtPwsd.Enabled = True

                gCnn.ConnectionString =
                  "Data Source=" & Me.txtServer.Text & ";" & _
                  "Initial Catalog=" & Me.txtDBName.Text & ";" & _
                  "User ID=" & Me.txtUserID.Text & _
                  ";Password=" & Me.txtPwsd.Text
            End If
            gCnn.Open()
            If gCnn.State = ConnectionState.Open Then
                'connected
                frmBaseMDI.ShowDialog()
                Me.Close()
            Else
                MsgBox("unable to connect to database")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtClose_Click(sender As System.Object, e As System.EventArgs) Handles txtClose.Click
        Me.Close()
    End Sub

    Private Sub txtCancel_Click(sender As System.Object, e As System.EventArgs) Handles txtCancel.Click
        If gCnn.State = ConnectionState.Open Then
            gCnn.Close()
            gCnn = Nothing

        End If
    End Sub
End Class