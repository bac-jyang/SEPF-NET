Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text

Public Class FormEmployer_MonthlyReport

    'Jun Yang 8/08/2018
    'load employee of one employer, create monthly charge

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

#End Region
#Region "Form Vars"
    Private Enum grdCloumn
        clmID = 0
        clmSSN = 1
        clmLastName = 2
        clmFirstName = 3
        clmSalary = 4
        clmPartContrib = 5
        clmEmpContrib = 6
        clmTotContrib = 7
        clmPartRate = 8
        clmEmpName = 9
    End Enum
    '1. Set the Connection String
    Dim connectionString As String = Mine.ConnString.SEPFConnection
    Dim connection As New SqlClient.SqlConnection(connectionString)


    Private formCaptionValue As String = String.Empty
    Private EmpID As Long



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
    Public Property EmployerID() As Long
        Get
            Return Me.EmpID
        End Get
        Set(ID As Long)
            EmpID = ID
        End Set
    End Property

#End Region





    Private Sub frmEmployer_MonthlyReport_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = String.Empty
        Dim dt As New DataTable


        Try

            sql = " exec dt_EmployerMbrInfo " & EmpID
            Dim da = New SqlDataAdapter(sql, connection)
            da.Fill(dt)
            grdPart.DataSource = dt
            grdPart.Columns(grdCloumn.clmID).Visible = False
            grdPart.Columns(grdCloumn.clmPartRate).Visible = False
            grdPart.Columns(grdCloumn.clmEmpName).Visible = False

            grdPart.ReadOnly = False
            For Each dgvc As DataGridViewColumn In grdPart.Columns
                If dgvc.Index = grdCloumn.clmSalary Then
                    dgvc.ReadOnly = False
                Else
                    dgvc.ReadOnly = True
                    ' grdPart.Columns(grdCloumn.clmSalary).ReadOnly = False
                    dgvc.DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next

            grdPart.Columns(grdCloumn.clmPartContrib).ReadOnly = True

            grdPart.Columns(grdCloumn.clmEmpContrib).ReadOnly = True
            grdPart.Columns(grdCloumn.clmTotContrib).ReadOnly = True


            'fill employee rate and employer rate
            txtPartRate.Text = grdPart.Rows(0).Cells(grdCloumn.clmPartRate).Value.ToString
            txtEmpContrib.Text = grdPart.Rows(0).Cells(grdCloumn.clmEmpContrib).Value.ToString

        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        Finally
            dt.Dispose()

        End Try
    End Sub




    Private Sub grdPart_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPart.CellValueChanged
        'when salary entered, update total contributon cell value
        If grdPart.Rows.Count > 0 Then

            If e.ColumnIndex = grdCloumn.clmSalary Then
                Dim dblSalary As Double = CDbl(grdPart.Rows(e.RowIndex).Cells(grdCloumn.clmSalary).Value)
                Dim dblPartRate As Double = CDbl(grdPart.Rows(e.RowIndex).Cells(grdCloumn.clmPartRate).Value)
                Dim dblEmpContrib As Double = CDbl(grdPart.Rows(e.RowIndex).Cells(grdCloumn.clmEmpContrib).Value)

                grdPart.Rows(e.RowIndex).Cells(grdCloumn.clmPartContrib).Value = dblSalary * dblPartRate
                grdPart.Rows(e.RowIndex).Cells(grdCloumn.clmTotContrib).Value = dblSalary * dblPartRate + dblEmpContrib

                Dim dbleTotContrib As Double = CDbl(grdPart.Rows(e.RowIndex).Cells(grdCloumn.clmTotContrib).Value)
                'refresh the total calculate amt

                Dim sum As Double = 0
                For i As Integer = 0 To grdPart.Rows.Count() - 1 Step +1
                    sum = sum + CDbl(grdPart.Rows(i).Cells(grdCloumn.clmTotContrib).Value)
                Next

                txtCalAmt.Text = sum.ToString()
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If formValidate() = True Then
            'circle through grid, if row changed, then save
            If grdPart.Rows.Count > 0 Then
                For Each rs As DataGridViewRow In grdPart.Rows
                    'if row changed
                    Dim PartID As Integer = CInt(rs.Cells(grdCloumn.clmID).Value)
                    Dim Salary As Double = CDbl(rs.Cells(grdCloumn.clmSalary).Value)

                    Call SaveReport(PartID, CDate(dtbContribDate.Text), Salary, CDate(dtbRevcDate.Text), "ZA")

                Next

            End If
        End If
    End Sub
    Private Sub SaveReport(PartID As Integer, ContribDate As Date, Salary As Double, ReceivedDate As Date, ChargeType As String)
        Try
            Dim cmdReport As SqlCommand = New SqlCommand("dt_MonthlyChargeAndReport", connection)
            cmdReport.CommandType = CommandType.StoredProcedure
            cmdReport.Parameters.Add("@EmpID ", SqlDbType.Int).Value = EmpID
            cmdReport.Parameters.Add("@PartID ", SqlDbType.Int).Value = PartID
            cmdReport.Parameters.Add("@ContribDate", SqlDbType.DateTime).Value = ContribDate

            cmdReport.Parameters.Add("@Salary", SqlDbType.Float).Value = Salary

            cmdReport.Parameters.Add("@ReceivedDate", SqlDbType.DateTime).Value = ReceivedDate
            cmdReport.Parameters.Add("@ChargeType", SqlDbType.Char).Value = ChargeType
            cmdReport.Parameters.Add("@UserID ", SqlDbType.Int).Value = 0

            'cmdReport.Parameters.Add("@Rt", SqlDbType.Int)
            'cmdReport.Parameters("@Rt").Direction = ParameterDirection.Output

            cmdReport.ExecuteNonQuery()
            '           @EmpID int,
            '@PartID int,
            '@ContribDate datetime,
            '@Salary money,
            '@ReceivedDate datetime,
            '--@EntryDate datetime, 
            '@ChargeType varchar(2),
            '@Rt int out

            ' If CType(cmdReport.Parameters("@Rt").Value, Integer) = 0 Then

            'MsgBox("Payment was not saved.")
            ' Exit Sub
            'Else
            MsgBox("Monthly reaport was saved.")


            'End If
            cmdReport.Dispose()
        Catch ex As Exception
            MsgBox(ex.Source & ex.Message)
            Exit Sub

        End Try
    End Sub
#Region "Form Validation"
    Private Function formValidate() As Boolean
        'required fields
        'contribution month cannot dup
        Dim sError As New StringBuilder


        If String.IsNullOrEmpty(dtbContribDate.Text) Or dtbContribDate.Text = "  /  /" Then
            ' MessageBox.Show("Contribution date is required, cannot be empty", _
            '  "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sError.Append("Contribution date is required, cannot be empty")
            ' Return False
            '  ErrorProvider1.SetError(dtbContribDate, "this field is required")
        Else
            ' ErrorProvider1.Clear()
            '  ErrorProvider1.SetError(dtbContribDate, String.Empty)

        End If
        If String.IsNullOrEmpty(dtbRevcDate.Text) Or dtbRevcDate.Text = "  /  /" Then
            ' MessageBox.Show("Received date is required, cannot be empty", _
            ' "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sError.AppendLine()
            sError.Append("Received date is required, cannot be empty")
            ' Return False

        End If

        'salary column required


        For Each rs As DataGridViewRow In grdPart.Rows
            If CDbl(rs.Cells(grdCloumn.clmSalary).Value) <= 0 Then
                sError.AppendLine()
                sError.Append("Salary must be grater than 0.")
            End If
        Next

        If sError.Length > 0 Then
            MessageBox.Show(sError.ToString, _
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function
#End Region

End Class