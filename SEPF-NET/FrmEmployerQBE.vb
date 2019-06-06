Imports BAC.Controls
Imports System.Text
Imports BAC.Controls.BacEditForm

Public Class FrmEmployerQBE

    Dim helper As New ClassQbeHelpers

    Dim tabOrderManager As New BacQbeTabOrderManager(Me)

    '*****TO DO ******
    '1. Set the Connection String
    Dim connectionString As String = Mine.ConnString.SepfConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)

    '2. To fill all the QBEcombo controls, set the name of the
    'stored procedure here - remember it must be made to 
    'match the QbeCombo names
    Dim spForCombosName As String = "FillAllCombos_frmEmployerInfo"
#Region "New,Load"
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()

            connection.Open()
            'set buttions to no records state
            ChangeMenuButtonsEnabled(False)
            helper.ClearStatusControl(Me.bacStatusStrip)



        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                            " " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Qbe_Load(ByVal sender As Object,
                        ByVal e As EventArgs) Handles Me.Load
        Try
            'Fill the control lists, combo and text.  
            helper.FillComboListParents(Me.gbxSelections)
            helper.FillTextListParents(Me.gbxSelections)

            'Fill the combo boxes with information
            helper.FillMultipleUsingDataTableOneTable(helper.ReadOnlyComboControlList, connection,
                                              CommandType.StoredProcedure,
                                              spForCombosName)
            With tabOrderManager
                ' .SetSchemeForControl(Me.GroupBox1, BacQbeTabOrderManager.TabScheme.DownFirst)
                .SetTabOrder(BacQbeTabOrderManager.TabScheme.DownFirst)
            End With

        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                           " " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region
#Region "FindReset_Click"
    Private Sub CmdFind_Click(sender As Object,
                                e As EventArgs) Handles cmdFind.Click,
                                      FindToolStripMenuItem.Click
        Try

            Dim recordSource As String = dgResults.RecordSourceSql

            Dim whereTempClause As String = String.Empty
            Dim whereClause As New StringBuilder

            'Go through all textbox controls
            'fill whereTempClause with the sql statement from
            'the control
            'if it has one, either append to the existing
            'clause or it becomes the existing clause

            For Each ctl As bacQbeTextBox In helper.ReadOnlyTextBoxControlList
                If Not String.IsNullOrEmpty(ctl.Text) Then
                    whereTempClause = ctl.GetQbeSQLstring

                    If whereClause.Length = 0 Then
                        whereClause.Append(whereTempClause)
                    Else
                        whereClause.Append(" AND ")
                        whereClause.Append(whereTempClause)
                    End If
                End If
            Next

            'Then the combo boxes

            For Each ctl As bacQbeCombo In helper.ReadOnlyComboControlList
                If Not String.IsNullOrEmpty(ctl.QbeFieldName) And ctl.Key <> "-1" _
                        And (Not ctl.Key Is Nothing) Then
                    whereTempClause = ctl.GetQbeSQLstring

                    If whereClause.Length = 0 Then
                        whereClause.Append(whereTempClause)
                    Else
                        whereClause.Append(" AND ")
                        whereClause.Append(whereTempClause)
                    End If
                End If
            Next

            'handle any other types here:


            'Test the where clause
            'MessageBox.Show(whereClause.ToString)


            'set the recordsource to the where clause
            If whereClause.Length > 0 Then
                recordSource = recordSource & " WHERE " & whereClause.ToString
                Me.dgResults.FillGrid(connectionString, recordSource)

                FindComplete()

            Else 'no SQL
                MessageBox.Show("Please check query selection data",
                         "No Selection Criteria", MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                            " " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub FindComplete()
        Try

            Select Case dgResults.Rows.Count
                Case Is <= 0
                    MessageBox.Show("Please check query selection data",
                         "No Records", MessageBoxButtons.OK,
                         MessageBoxIcon.Information)
                Case Is = 1

                    Me.dgResults.Rows(0).Selected = True
                    ChangeMenuButtonsEnabled(True)
                    Me.cmdGoTo.PerformClick()

                Case Else
                    ChangeMenuButtonsEnabled(True)
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub CmdReset_Click(sender As Object,
                               e As EventArgs) Handles cmdReset.Click,
                                    ResetToolStripMenuItem.Click
        Try

            For Each txtControl As bacQbeTextBox In helper.ReadOnlyTextBoxControlList
                txtControl.Text = String.Empty
            Next
            For Each cboControl As bacQbeCombo In helper.ReadOnlyComboControlList
                cboControl.SelectedIndex = -1
            Next

            'TODO: Add
            Call CType(dgResults.DataSource, DataTable).Rows.Clear()

            ChangeMenuButtonsEnabled(False)
            helper.ClearStatusControl(Me.bacStatusStrip)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Reset",
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
            MessageBox.Show(ex.ToString, "ChangeMenuButtonsEnabled",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Public Sub GridRefreshData()
        Try
            Me.dgResults.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "ChangeMenuButtonsEnabled",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region
#Region "Buttons Browse/GoToNew/Print_Click"
    Private Sub BrowseToolStripMenuItem_Click(sender As Object,
                                              e As EventArgs) _
                                          Handles BrowseToolStripMenuItem.Click,
                                          cmdBrowse.Click
        Try

            Dim idList As List(Of TableColumnIntegerId) = helper.GetColDataGridViewListOfData(dgResults)
            ' Dim idList As Collection(Of TableColumnIntegerId) = helper.GetColDataGridViewListOfData(dgResults)
            ShowEditForm(idList, False)

        Catch argNull As ArgumentNullException
            MessageBox.Show(argNull.ToString, "Error on Browse",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Browse",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub GoToToolStripMenuItem_Click(sender As Object,
                                            e As EventArgs) _
                                        Handles GoToToolStripMenuItem.Click, cmdGoTo.Click
        Try

            If dgResults.SelectedRows.Count > 1 Then
                MessageBox.Show("Please select a single row for GOTO" & vbCrLf & " or use Browse Button",
                                 "Multiple Selections made", MessageBoxButtons.OK)
            Else

                Dim idList As List(Of TableColumnIntegerId) = helper.GetColDataGridViewListOfData(dgResults)

                ShowEditForm(idList, False)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on GoTo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub DgResults_DoubleClick(sender As Object, e As EventArgs) _
       Handles dgResults.DoubleClick
        Try


            If dgResults.SelectedRows.Count = 1 Then
                Dim idList As List(Of TableColumnIntegerId) = helper.GetColDataGridViewListOfData(dgResults)
                ShowEditForm(idList, False)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on DoubleClick",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object,
                                           e As EventArgs) _
                                       Handles NewToolStripMenuItem.Click,
                                       cmdNew.Click
        Try

            MessageBox.Show("Not in Service at present")


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on New",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object,
                                             e As EventArgs) _
                                         Handles PrintToolStripMenuItem.Click, cmdPrint.Click
        Try

            MessageBox.Show("Not in Service at present")


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Print",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object,
                                                    e As EventArgs) _
                                                    Handles PrintPreviewToolStripMenuItem.Click, cmdPrint.Click
        Try

            MessageBox.Show("Not in Service at present")


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on New",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region
#Region "Close/Exit_Click"
    Private Sub CloseToolStripMenuItem_Click(sender As Object,
                                             e As EventArgs) _
                                         Handles CloseToolStripMenuItem.Click, cmdClose.Click
        Try

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Form Closing",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub FrmQBE_FormClosing(ByVal sender As Object,
                                            ByVal e As FormClosingEventArgs) _
                                            Handles Me.FormClosing
        Try
            If e.CloseReason = CloseReason.UserClosing Then
                Me.Dispose()
                ' End
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ras",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not connection Is Nothing Then connection = Nothing
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object,
                                            e As EventArgs) _
                                        Handles ExitToolStripMenuItem.Click
        Try

            Dim mainMenuForm As Form = Nothing
            ' mainMenuForm = My.Forms.frmMainMenu

            'close application from the parent form
            If Not (Me.ParentForm Is Nothing) And (Me.ParentForm Is mainMenuForm) Then
                Me.Close()
                ' My.Forms.frmMainMenu2.Close()
                ParentForm.Close()
            Else
                If MessageBox.Show("Close Application?",
                                           "Application Closing",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Application.Exit()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Exit Application",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
#End Region
#Region "ShowForm"


    Private Sub ShowEditForm(idList As List(Of TableColumnIntegerId),
                           openAsNewRecord As Boolean)
        '_ List(Of TableColumnIntegerId),
        ' MessageBox.Show(whereClause)
        Try
            'fill with one table, only need connection and where clause
            'MessageBox.Show("Not In Service Yet....")
            ' Dim idList As List(Of TableColumnIntegerId) =
            helper.GetColDataGridViewListOfData(dgResults)
            With My.Forms.FormEmployerInfo.PassedQbeInfo()

                .PassedConnection = Me.connection
                .IdList = idList
                .OpenAsNewRecord = False
                .RecordSourceName = "v_Efl_Employer"
                .UserId = CInt(User.GlobalUserId)
            End With

            My.Forms.FormEmployerInfo.ShowDialog(Me)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error opening Form",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub ShowEditForm(whereClause As String,
                             openAsNewRecord As Boolean)
        MessageBox.Show(whereClause)
        Try
            ' fill with one table, only need connection and where clause
            'With My.Forms.frmEmployerInfo.PassedQbeInfo()
            '    .PassedConnection = Me.connection
            '    .WhereClause = whereClause.Trim
            '    .OpenAsNewRecord = openAsNewRecord
            'End With

            'My.Forms.frmEmployerInfo.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error opening Form",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub dgResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResults.CellContentClick

    End Sub

#End Region


End Class
