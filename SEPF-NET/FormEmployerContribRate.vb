Imports BAC.Controls
Imports System.Text


Public Class FormEmployerContribRate





#Region "Form Vars"

    '*****TO DO ******
    '1. Set the Connection String
    Dim connectionString As String = Mine.ConnString.SEPFConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)


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



        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                            " " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Qbe_Load(ByVal sender As Object,
                        ByVal e As EventArgs) Handles Me.Load
        Try
            Me.Text = FormCaption
            recordSource = dgResults.RecordSourceSql & " WHERE Emp_ID=" & formIdValue

            Me.dgResults.FillGrid(connectionString, recordSource)

            'With tabOrderManager
            '    ' .SetSchemeForControl(Me.GroupBox1, BacQbeTabOrderManager.TabScheme.DownFirst)
            '    .SetTabOrder(BacQbeTabOrderManager.TabScheme.DownFirst)
            'End With

        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                           " " & ex.Message, "Error",
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



End Class
