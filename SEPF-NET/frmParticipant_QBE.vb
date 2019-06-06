Imports System.Data.SqlClient
Public Class frmParticipant_QBE
    Dim ssql As String

    Public Sub FillCombo(ctr As Windows.Forms.ComboBox, cn As SqlConnection, sSql As String)
        Dim Adp As New SqlDataAdapter(sSql, cn)
        Dim Dt As New DataTable
        Adp.Fill(Dt)
        ctr.DataSource = Dt
        ctr.DisplayMember = Dt.Columns(0).ToString
        ctr.ValueMember = Dt.Columns(0).ToString
        Adp.Dispose()
    End Sub

    Private Sub frmParticipant_QBE_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'fill all combobox
        FillCombo(cboPensOpt, gCnn, "SELECT Pension_Option FROM tbl_Pension_Option")
        cboPensOpt.SelectedIndex = -1
        FillCombo(cboRetireType, gCnn, "SELECT Retirement_Type FROM tbl_Pension_Type")
        cboRetireType.SelectedIndex = -1
    End Sub
    Private Sub GetCriteria()
        Dim sqlCol As String
        Dim sqlBody As String
        sqlCol = "ParticipantID,SSN,Participant_FirstName as [First Name],Participant_LastName as [Last Name],Participant_Status as [Status],"
        sqlCol = sqlCol & "Participant_Option as [Option],Participant_Pension_Type as [Type],DOB_Years as [AGE]"
        sqlBody = " "
        'build selection string

        ' select by pension options
        If Me.cboPensOpt.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "AND "
            End If
            sqlBody = sqlBody & "([PARTICIPANT_OPTION] = '" & Me.cboPensOpt.Text & "')"
        End If

        ' select by pension type
        If Me.cboRetireType.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            sqlBody = sqlBody & "([participant_pension_type] = '" & Me.cboRetireType.Text & "')"
        End If

        ' select by lastname
        If Me.txtName.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            sqlBody = sqlBody & "([Participant_lastname] like '" & Me.txtName.Text & "%')"
        End If

        ' select SSN
        If Me.txtSSN.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            'temp = MakeInClause(Me!txtSSN)
            sqlBody = sqlBody & "([participant_ssn] in (" & Me.txtSSN.Text & "))"
        End If

        ' select by status
        If Me.cboStatus.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            sqlBody = sqlBody & "([participant_status] = '" & Me.cboStatus.Text & "')"
        End If

        ' select by organization
        If Me.cboOrg.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            sqlBody = sqlBody & "([participant_Organization] = '" & Me.cboOrg.Text & "')"
        End If

        ' select by LOEPF credits
        If Me.chkLOEPF.Checked Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "AND "
            End If
            sqlBody = sqlBody & "([Participant_IL_Service_Credits] > 0)"
        End If

        ' select participant age
        If Me.txtAge.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            'If Me.cboOperator) Or Me!cboOperator.Column(0) = "" Then
            '    sqlBody = sqlBody & "([DOB_Years] = " & Me!txtAge & ")"
            'Else
            '    sqlBody = sqlBody & "([DOB_Years]" & Me!cboOperator & " '" & Me!txtAge & "') "
            'End If
        End If
        ' select country
        If Me.cboCountry.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            sqlBody = sqlBody & "([participant_fund] = '" & Me.cboCountry.Text & "')"
        End If
        If sqlBody = " " Then
            sqlBody = "([ParticipantID] <> 0)"
        End If

        'select participant vested
        If Me.cboVested.Text <> "" Then
            If sqlBody > " " Then
                sqlBody = sqlBody & "and "
            End If
            sqlBody = sqlBody & "([vested] = '" & Me.cboVested.Text & "')"
        End If

        'assign rowsource based on criterias selected

        ssql = "Select " & sqlCol & " From " & "view_Participant_Info " & " Where " & sqlBody & "order by Participant_LastName, Participant_FirstName"



        
    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        Try
            GetCriteria()
            Dim Adp As New SqlDataAdapter(ssql, gCnn)
            Dim Dt As New DataTable

            Adp.Fill(Dt)

            grdResult.DataSource = Dt
            grdResult.Columns(0).Visible = False
            sbarEmployee.Items(0).Text = "Total " & grdResult.Rows.Count & " Records found."
            Adp.Dispose()
        Catch ex As Exception
            MsgBox("load participants data failed")
        Finally

        End Try


    End Sub

   

    Private Sub grdResult_Click(sender As Object, e As System.EventArgs) Handles grdResult.Click
        '  frmParticipantInfo.Show()
        'frmParticipantInfo.PartID.Text = grdResult.Item(0, grdResult.CurrentRow.Index).Value.ToString
        'frmParticipantInfo.FillByToolStripButton.PerformClick()
    End Sub

    Private Sub GotoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GotoToolStripMenuItem.Click
        btnGoto.PerformClick()
    End Sub

    Private Sub btnGoto_Click(sender As System.Object, e As System.EventArgs) Handles btnGoto.Click
        ' frmParticipantInfo.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        btnPrint.PerformClick()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ' frmParticipantInfo.Show()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        MsgBox("print form")
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        btnNew.PerformClick()
    End Sub

    Private Sub grdResult_DoubleClick(sender As Object, e As System.EventArgs) Handles grdResult.DoubleClick
        frmParticipantInfo.Show()


    End Sub

    Private Sub grdResult_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdResult.CellContentClick

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        cboCountry.SelectedIndex = -1
        cboOrg.SelectedIndex = -1
        cboPensOpt.SelectedIndex = -1
        cboRetireType.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        cboVested.SelectedIndex = -1
        txtAge.Text = ""
        txtName.Text = ""
        txtSSN.Text = ""
    End Sub
End Class