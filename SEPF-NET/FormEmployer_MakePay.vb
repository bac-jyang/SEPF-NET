Imports System.Data.SqlClient

Public Class FormEmployer_MakePay

    'purpose: 1. make a new payment,
    '         2. make an adjustment/negate an existing payment
    'Jun Yang 3/29/17, 4/22/2019
    ' need data validation
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
    Public Property EmpId As Integer
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

#End Region


#Region "from validation"


    Private Sub FormValidate()
        Dim iRts As Integer

        If Me.dtbContribMonth.Text = "" Then
            MsgBox("Error!  Contribution Month is a required field.")
            Exit Sub
        End If
        If Me.dtbRecvDate.Text = "" Then ' Or Not Is Date.ParseExact(dtbRecvDate.Text.ToString, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture) Then
            MsgBox("Error!  a Validate Date of Transfer is a required field.")
            Exit Sub
        End If

        If Me.txtAmt.Text = "" Or Not IsNumeric(CType(txtAmt.Text, Integer)) Then
            MsgBox("Error!  Amount is a required field.")
            Exit Sub
        End If

        If Me.cboType.Text = "" Then
            MsgBox("Error!  Type is a required field.")
            Exit Sub
        End If

        Try
            Dim cmdPay As SqlCommand = New SqlCommand("dt_ValidateEmployerPayment", connection)
            cmdPay.CommandType = CommandType.StoredProcedure
            cmdPay.Parameters.Add("@EmpId", SqlDbType.Int).Value = EmpId
            cmdPay.Parameters.Add("@sPayType", SqlDbType.Char).Value = "'" & cboType.Text.ToString.Substring(0, 1) & "'"
            cmdPay.Parameters.Add("@PayAmt", SqlDbType.Float).Value = txtAmt.Text
            cmdPay.Parameters.Add("@TransDate", SqlDbType.DateTime).Value = CType(dtbRecvDate.Text, Date)

            cmdPay.Parameters.Add("@Rts", SqlDbType.Int)
            cmdPay.Parameters("@Rts").Direction = ParameterDirection.Output
            cmdPay.ExecuteNonQuery()
            If IsDBNull(cmdPay.Parameters("@Rts").Value) Then Exit Sub

            iRts = CType(cmdPay.Parameters("@Rts").Value, Integer)
            Select Case iRts
                Case -1
                    If MsgBox("A payment for this date has already been entered." & Chr(13) & "Do you want to enter another entry for this Employer?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                Case -2
                    MsgBox("There are no payments to negate or adjustment more than previous payment")
                    Exit Sub
                Case -3
                    MsgBox("Adjusted amounts must have a corresponding Date of Transfer.")
                    Exit Sub
                Case -4
                    MsgBox("Negative amounts must have a corresponding Date of Transfer, Amount and Type.")
                    Exit Sub
                Case Else
                    MsgBox("stored procedure to validate payment entry failed")
                    Exit Sub

            End Select
            cmdPay.Dispose()
        Catch ex As Exception
            MsgBox(ex.Source & ex.Message)

            Exit Sub


        End Try
    End Sub
#End Region


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        'add new record to EmployerPayment
        'update tbl_Employer pay/balance info
        'dt_UpdateEmployerPayment
        Call FormValidate()
        Try
            Dim cmdPay As SqlCommand = New SqlCommand("dt_UpdateEmployerPayment", connection)
            cmdPay.CommandType = CommandType.StoredProcedure
            cmdPay.Parameters.Add("@EmpId", SqlDbType.Int).Value = EmpID
            cmdPay.Parameters.Add("@PaymentDate", SqlDbType.DateTime).Value = DateTime.ParseExact("01/" & dtbContribMonth.Text, "dd/MM/yyyy", Nothing) 'CType("01/" & dtbContribMonth.Text, Date)

            cmdPay.Parameters.Add("@PaymentAmount", SqlDbType.Float).Value = txtAmt.Text
            cmdPay.Parameters.Add("@PayType", SqlDbType.Char).Value = cboType.Text.ToString.Substring(0, 1)
            cmdPay.Parameters.Add("@ReceiveDate", SqlDbType.DateTime).Value = CType(dtbRecvDate.Text, Date)
            cmdPay.Parameters.Add("@UserID", SqlDbType.Int).Value = 0

            cmdPay.Parameters.Add("@Rts", SqlDbType.Int)
            cmdPay.Parameters("@Rts").Direction = ParameterDirection.Output

            cmdPay.ExecuteNonQuery()

            If CType(cmdPay.Parameters("@rts").Value, Integer) = 0 Then

                MsgBox("Payment was not saved.")
                Exit Sub
            Else
                MsgBox("Payment was saved.")
                Call Reset()

            End If
            cmdPay.Dispose()
        Catch ex As Exception
            MsgBox(ex.Source & ex.Message)
            Exit Sub

        End Try

    End Sub

    Public Sub Reset()
        txtAmt.Text = ""
        dtbContribMonth.Text = ""
        dtbRecvDate.Text = ""
        cboType.Text = ""
    End Sub
End Class