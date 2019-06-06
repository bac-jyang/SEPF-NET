Option Strict Off
Imports System.Text
Imports BAC.Controls


Public Class FormEmployerPayment

    Dim helper As New ClassQbeHelpers

    Dim tabOrderManager As New BacQbeTabOrderManager(Me)

    '*****TO DO ******
    '1. Set the Connection String
    Dim connectionString As String = Mine.ConnString.SEPFConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)

#Region "Form Vars"
    Private mPassedQbeInfo As New PassToEditFormFromQbe
    Private formCaptionValue As String = String.Empty
    Private formIdValue As Integer = 0
    Dim recordSource As String = String.Empty



    ''' <summary>
    ''' The text to display on the form title bar.
    ''' </summary>
    ''' <returns>String</returns>
    Public Property FormCaption As String
        Get
            Return formCaptionValue
        End Get
        Set(value As String)
            formCaptionValue = value
            Me.Text = value
        End Set
    End Property
    ''' <summary>
    '''  The id number of the field in the Audit Table that will pull the information.
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property FormId As Integer
        Get
            Return formIdValue
        End Get
        Set(value As Integer)
            formIdValue = value

        End Set
    End Property

#End Region

#Region "New,Load"
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()

            connection.Open()
            'set buttions to no records state
            ' ChangeMenuButtonsEnabled(False)
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
            '         
            Me.Text = FormCaption
            recordSource = dgResults.RecordSourceSql & " WHERE Emp_ID=" & formIdValue

            Me.dgResults.FillGrid(connectionString, recordSource)

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

            For Each ctl In Me.gbxSelections.Controls
                If TypeOf ctl Is QbeDateBox Then
                    If Not String.IsNullOrEmpty(ctl.Text) And ctl.text <> "  /  /" Then
                        whereTempClause = ctl.GetQbeSQLstring

                        If whereClause.Length = 0 Then
                            whereClause.Append(whereTempClause)
                        Else
                            whereClause.Append(" AND ")
                            whereClause.Append(whereTempClause)
                        End If
                    End If
                End If
            Next

            'Then the combo boxes

            For Each ctl As BacQbeCombo In helper.ReadOnlyComboControlList
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
                recordSource = dgResults.RecordSourceSql & " WHERE Emp_ID=" & formIdValue
                recordSource = recordSource & " And " & whereClause.ToString
                Me.dgResults.FillGrid(connectionString, recordSource)

                FindComplete()

            Else 'no SQL
                'MessageBox.Show("Please check query selection data",
                '         "No Selection Criteria", MessageBoxButtons.OK,
                '         MessageBoxIcon.Information)
                recordSource = dgResults.RecordSourceSql & " WHERE Emp_ID=" & formIdValue
                Me.dgResults.FillGrid(connectionString, recordSource)

                FindComplete()
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
                    ' ChangeMenuButtonsEnabled(True)
                    ' Me.cmdGoTo.PerformClick()

                Case Else
                    '  ChangeMenuButtonsEnabled(True)
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
            For Each cboControl As BacQbeCombo In helper.ReadOnlyComboControlList
                cboControl.SelectedIndex = -1
            Next

            'clear off qbeDatebox
            For Each ctl In Me.gbxSelections.Controls
                If TypeOf ctl Is QbeDateBox Then
                    ctl.text = String.Empty
                End If
            Next

            'TODO: Add
            Call CType(dgResults.DataSource, DataTable).Rows.Clear()

            'ChangeMenuButtonsEnabled(False)
            helper.ClearStatusControl(Me.bacStatusStrip)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Reset",
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


#Region "Close/Exit_Click"
    Private Sub CloseToolStripMenuItem_Click(sender As Object,
                                             e As EventArgs) _
                                         Handles CloseToolStripMenuItem.Click
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

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region



End Class
