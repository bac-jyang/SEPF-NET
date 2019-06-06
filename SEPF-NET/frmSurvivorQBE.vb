Imports BAC.Controls
Imports BAC.Libraries.bacUtilities.CntlFunctions
Imports System.Text
Imports System.Data.SqlClient


Public Class frmSurvivorQBE
    Private comboControlList As New List(Of bacQbeCombo)


    Dim connectionString As String = Mine.ConnString.SEPFConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)

    Dim originalRecordSource As String = _
             "Select * FROM SEPF.dbo.v_ak_Qbe_Participant "
    Dim spForCombosName As String = "FillAllCombos_PartQBE"
    Dim idIndexColumn As Integer = 13
    Dim idIndexColumnName As String = "Part_ID"

    Dim tabOrderManager As New BacQbeTabOrderManager(Me)

    Private Enum EntryDataEnum
        EntryByOrdinal = 9
        EntryDateOrdinal = 10
        LastChangeByOrdinal = 11
        LastChangeDateOrdinal = 12
    End Enum

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        connection.Open()

        'set buttions to no records state
        ChangeMenuButtonsEnabled(False)

    End Sub

    Private Sub Qbe_Load(ByVal sender As Object, _
                        ByVal e As System.EventArgs) Handles Me.Load

        Try

            ''Fill all combos
            With comboControlList
                '.Add(Me.BacQbeCombo1)
            End With

            clsQbeHelpers.FillMultiUsingDataTable(comboControlList, connection, _
                                              CommandType.StoredProcedure, _
                                              spForCombosName)


            'TODO 8: 'Set tab orders
            'if any group controls that should be set a different tab order
            'set them here FIRST.
            'Set tab order as Down, Across, or None
            With tabOrderManager
                ' .SetSchemeForControl(Me.GroupBox1, BacQbeTabOrderManager.TabScheme.DownFirst)
                .SetTabOrder(BacQbeTabOrderManager.TabScheme.DownFirst)
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ras", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#Region "FindReset_Click"
    Private Sub cmdFind_Click(sender As System.Object, _
                              e As System.EventArgs) Handles cmdFind.Click, _
                                    FindToolStripMenuItem.Click
        Try

            Dim recordSource As String = originalRecordSource

            Dim whereTempClause As String = String.Empty

            Dim testCombo As bacQbeCombo
            Dim testText As bacQbeTextBox

            Dim whereClause As New StringBuilder

            For Each ctl As Control In Me.gbxSelections.Controls
                testText = TryCast(ctl, bacQbeTextBox)

                If Not testText Is Nothing Then
                    If Not String.IsNullOrEmpty(testText.Text) Then

                        whereTempClause = testText.GetQbeSQLstring

                        If whereClause.Length = 0 Then
                            whereClause.Append(whereTempClause)
                        Else
                            whereClause.Append(" AND ")
                            whereClause.Append(whereTempClause)
                        End If
                    End If

                End If



                testCombo = TryCast(ctl, bacQbeCombo)

                If Not testCombo Is Nothing Then
                    If Not String.IsNullOrEmpty(testCombo.QbeFieldName) And testCombo.Key <> "-1" _
                        And (Not testCombo.Key Is Nothing) Then
                        whereTempClause = testCombo.GetQbeSQLstring

                        If whereClause.Length = 0 Then
                            whereClause.Append(whereTempClause)
                        Else
                            whereClause.Append(" AND ")
                            whereClause.Append(whereTempClause)
                        End If
                    End If
                End If


            Next

            If whereClause.Length > 0 Then
                recordSource = recordSource & " WHERE " & whereClause.ToString

                FillGrid(connectionString, recordSource, dgResults, True)

                Me.tslComment.Text = dgResults.Rows.ToString & " records returned"

            Else

                ' FillGrid(connectionString, recordSource, dgResults, True)
            End If


            FindComplete()



        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Find", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub FindComplete()
        Try

            Select Case dgResults.Rows.Count
                Case Is <= 0
                    MessageBox.Show("Please check query selection data", _
                         "No Records", MessageBoxButtons.OK, _
                         MessageBoxIcon.Information)
                Case Is = 1

                    Me.cmdBrowse.PerformClick()
                    ChangeMenuButtonsEnabled(True)
                Case Else
                    ChangeMenuButtonsEnabled(True)
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub cmdReset_Click(sender As System.Object, _
                               e As System.EventArgs) Handles cmdReset.Click, _
                                    ResetToolStripMenuItem.Click
        Try

            Dim testTextBox As BAC.Controls.bacQbeTextBox
            Dim testCombo As BAC.Controls.bacQbeCombo

            For Each ctl As Control In gbxSelections.Controls
                testTextBox = TryCast(ctl, BAC.Controls.bacQbeTextBox)
                If Not testTextBox Is Nothing Then
                    testTextBox.Text = String.Empty
                Else
                    testCombo = TryCast(ctl, BAC.Controls.bacQbeCombo)
                    If Not testCombo Is Nothing Then
                        testCombo.SelectedIndex = -1
                    End If
                End If
            Next


            ChangeMenuButtonsEnabled(False)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Reset", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
#End Region
#Region "Records_Click"
    Private Sub BrowseToolStripMenuItem_Click(sender As System.Object, _
                                              e As System.EventArgs) _
                                          Handles BrowseToolStripMenuItem.Click, _
                                          cmdBrowse.Click
        Try

            Dim whereClause As String = _
                clsQbeHelpers.GetQBEGridBrowseWhereLong(dgResults, idIndexColumn, idIndexColumnName)

            ShowEditForm(whereClause, False)


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Browse", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub GoToToolStripMenuItem_Click(sender As System.Object, _
                                            e As System.EventArgs) _
                                        Handles GoToToolStripMenuItem.Click, cmdGoTo.Click
        Try

            If dgResults.SelectedRows.Count > 1 Then
                MessageBox.Show("Please select a single row for GOTO" & vbCrLf & " or use Browse Button", _
                                 "Multiple Selections made", MessageBoxButtons.OK)
            Else


                Dim whereClause As String = _
                  clsQbeHelpers.GetQBEGridBrowseWhereLong(dgResults, idIndexColumn, idIndexColumnName)


                ShowEditForm(whereClause, False)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on GoTo", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As System.Object, _
                                           e As System.EventArgs) _
                                       Handles NewToolStripMenuItem.Click, _
                                       cmdNew.Click
        Try

            MessageBox.Show("Not in Service at present")


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on New", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, _
                                             e As System.EventArgs) _
                                         Handles PrintToolStripMenuItem.Click, cmdPrint.Click
        Try

            MessageBox.Show("Not in Service at present")


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Print", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, _
                                                    e As System.EventArgs) _
                                                    Handles PrintPreviewToolStripMenuItem.Click, cmdPrint.Click
        Try

            MessageBox.Show("Not in Service at present")


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on New", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region
#Region "Close/Exit_Click"
    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, _
                                             e As System.EventArgs) _
                                         Handles CloseToolStripMenuItem.Click, cmdClose.Click
        Try




        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Form Closing", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, _
                                            e As System.EventArgs) _
                                        Handles ExitToolStripMenuItem.Click
        Try

            Dim mainMenuForm As Form = Nothing
            ' mainMenuForm = My.Forms.frmMainMenu

            'close application from the parent form
            If Me.ParentForm Is mainMenuForm Then
                Me.Close()
                ' My.Forms.frmMainMenu2.Close()
                ParentForm.Close()
            Else
                If MessageBox.Show("Close Application?", _
                                           "RAS", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Application.Exit()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Exit Application", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
#End Region

    Public Sub GridRefreshData()
        Try
            Me.dgResults.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ChangeMenuButtonsEnabled", _
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub
    Private Sub ChangeMenuButtonsEnabled(how As Boolean)
        Try


            Me.cmdBrowse.Enabled = how
            Me.BrowseToolStripMenuItem.Enabled = how

            Me.cmdGoTo.Enabled = how
            Me.GoToToolStripMenuItem.Enabled = how

            Me.cmdPrint.Enabled = how
            Me.PrintToolStripMenuItem.Enabled = how

            Me.PrintPreviewToolStripMenuItem.Enabled = how

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ChangeMenuButtonsEnabled", _
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub ShowEditForm(whereClause As String, _
                             openAsNewRecord As Boolean)
        MessageBox.Show(whereClause)
        Try
            'fill with one table, only need connection and where clause
            'With My.Forms.frmAgent_Info.PassedQbeInfo()
            '    .PassedConnection = Me.connection
            '    .WhereClause = whereClause.Trim
            '    .OpenAsNewRecord = openAsNewRecord
            'End With

            'My.Forms.frmAgent_Info.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error opening Form", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub FillGrid(connectionString As String, _
                         sqlString As String, _
                         dataGrid As DataGridView, _
                         autoGenerateColums As Boolean)
        Try
            'Dim sqlString As String = "Select top 50 * FROM SEPF.dbo.v_ak_Qbe_Participant "

            Using sqlCon As New SqlConnection(connectionString)

                Dim ds As New DataSet()
                Dim Adpt As New SqlDataAdapter(sqlString, sqlCon)
                Adpt.Fill(ds, "viewTable")
                dataGrid.AutoGenerateColumns = autoGenerateColums
                dataGrid.DataSource = ds.Tables(0)

                dataGrid.Refresh()
                'End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub dataGridView1_RowEnter(ByVal sender As Object, _
     ByVal e As DataGridViewCellEventArgs) _
     Handles dgResults.RowEnter


        Me.tslComment.Text = "Current Record"
        Me.tslEntryBy.Text = dgResults.Rows(e.RowIndex).Cells(EntryDataEnum.EntryByOrdinal).Value.ToString
        Me.tslEntryDate.Text = dgResults.Rows(e.RowIndex).Cells(EntryDataEnum.EntryDateOrdinal).Value.ToString
        Me.tslLastChangeBy.Text = dgResults.Rows(e.RowIndex).Cells(EntryDataEnum.LastChangeByOrdinal).Value.ToString
        Me.tslLastChangeDate.Text = dgResults.Rows(e.RowIndex).Cells(EntryDataEnum.LastChangeDateOrdinal).Value.ToString

    End Sub
End Class
