''' <summary>
''' Dialog form to display data from AuditTable to user.
''' It should be called as a dialog form when opened.
''' </summary>
''' <example> Use this method to call from an Efl form
''' <code lang="VB.NET" title="Open the Audit Form">
'''Try
'''
'''Dim cm As CurrencyManager = TryCast(Me.bacEflNavigationControl.CurrencyMgr, CurrencyManager)
'''Dim p As DataRowView = CType(cm.Current, DataRowView)
'''Dim id As Integer = CInt(p.Item(0))
'''
'''With My.Forms.FormAuditTrail
'''.FormId = id
'''.FormCaption = Me.Text
'''.ShowDialog(My.Forms.FormParticipantInfo)
'''End With
'''
'''Catch ex As Exception
'''MessageBox.Show("Problem opening Audit Form: " + ex.Message, "Error",
'''                            MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
'''End Try
'''  </code>
''' </example>
Public Class FormAuditTrail
#Region "Form Vars"

    Private formCaptionValue As String = String.Empty
    Private formIdValue As Integer = 0
    ''' <summary>
    ''' The string column name of the Audit table, such as At_RefID.
    ''' </summary>
    Private ReadOnly auditTableIdName As String = "At_RefID"
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
    ''' <summary>
    ''' Form constructor
    ''' </summary>
    ''' <remarks>Constructor calls the <c>SetFormSize</c> function which alligns a Dialog form 10% smaller than calling form.</remarks>
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()

            ' Mine.AppData.SetFormSize(Me, True)

        Catch argNull As ArgumentNullException
            MessageBox.Show("Error in " & argNull.TargetSite.Name &
                           " " & argNull.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                            " " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    ''' <summary>
    ''' Uses the passed information of ID to fill the form by using <c>FillGrid</c> Sub.
    ''' </summary>
    ''' <param name="sender">The FormAuditTrail object.</param>
    ''' <param name="e">The EventArgs</param>
    Private Sub FormAuditTrail_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try


            If formIdValue = 0 Then
                MessageBox.Show("No id value Supplied", "No ID", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information)

            Else
                FillGrid()
            End If
        Catch ex As Exception
            MessageBox.Show("Error in " & ex.TargetSite.Name &
                           " " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "RemoveClose"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
    ''' <summary>
    ''' Fills the datagrid with the results of query.
    ''' </summary>
    Private Sub FillGrid()

        Try

            Dim recordSource As String = dgResults.RecordSourceSql
            Dim connectionString As String = Mine.ConnString.SEPFConnection

            recordSource = recordSource & " WHERE " & auditTableIdName & " = " & Me.formIdValue

            Me.dgResults.FillGrid(connectionString, recordSource)


        Catch sqEx As SqlClient.SqlException

            MessageBox.Show("Error in SQL " & sqEx.TargetSite.Name &
                           " " & sqEx.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles CloseToolStripMenuItem.Click, cmdClose.Click
        Try

            Me.Close()
            My.Forms.FormAuditTrail.Dispose()

        Catch ioEx As InvalidOperationException
            MessageBox.Show(ioEx.ToString, "Error on Form Closing",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error on Form Closing",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub
End Class