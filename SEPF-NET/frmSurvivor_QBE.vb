Option Strict Off
Imports System.Data.SqlClient
Public Class frmSurvivor_QBE
    Dim da As SqlDataAdapter
    Dim dt As New DataTable
    Private Function GetWhereClause() As String
        Dim sWhere As String = String.Empty
        Try
            'If Not IsNull(Me!txtLname) Then
            '    If sqlBody > " " Then
            '        sqlBody = sqlBody & "and "
            '    End If
            '    sqlBody = sqlBody & "([Survivor_lastname] like '" & Me!txtLname & "%')"
            'End If

            'If Not IsNull(Me!txtSSN) Then
            '    If sqlBody > " " Then
            '        sqlBody = sqlBody & "and "
            '    End If
            '    temp = MakeInClause(Me!txtSSN)
            '    sqlBody = sqlBody & "([Survivor_ssn] in (" & temp & "))"
            'End If
            'If sqlBody = " " Then
            '    sqlBody = "([SurvivorID] <> 0)"
            'End If
            If txtSSN.Text <> String.Empty Then
                sWhere = "Survivor_ssn like '%" & txtSSN.Text & "%'"
            Else
                sWhere = ""
            End If

            If txtLastName.Text <> String.Empty Then

                sWhere = IIf(sWhere <> "", sWhere & "and ", "") & " Survivor_lastname like '%" & txtLastName.Text & "%'"

            End If


            GetWhereClause = sWhere

        Catch ex As Exception
            MsgBox(ex.Source & "-" & ex.Message)
        End Try
        Return sWhere
    End Function


    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        Dim sql As String
        sql = ""
        Try
            If GetWhereClause() = "" Then
                MsgBox("Please enter search criteria.")
                Exit Sub
            End If
            'clear result first
            dt.Rows.Clear()
            grdResult.DataSource = Nothing
            grdResult.Rows.Clear()
            sql = ""
            sql = "select ParticipantID,SurvivorID,Survivor_SSN as [SSN],Survivor_FirstName as [First Name],"
            sql = sql & "Survivor_Lastname as [Last Name],Survivor_Spouse_Flag as [Spouse] from tbl_Survivor_Info where " & GetWhereClause()
            da = New SqlDataAdapter(sql, gCnn)
            da.Fill(dt)
            grdResult.DataSource = dt
            grdResult.Columns(0).Visible = False
            grdResult.Columns(1).Visible = False
        Catch ex As Exception
            MsgBox(ex.Source & "-" & ex.Message)
        End Try

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        txtSSN.Text = ""
        txtLastName.Text = ""
        grdResult.DataSource = Nothing
        grdResult.Rows.Clear()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        dt.Dispose()
        da.Dispose()
        da = Nothing
        Me.Close()
    End Sub

    Private Sub btnGoto_Click(sender As System.Object, e As System.EventArgs) Handles btnGoto.Click
        frmSurvivor_Info.Show()
    End Sub
End Class