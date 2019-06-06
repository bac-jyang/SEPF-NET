Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmMain

    Private Sub btnPartInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnPartInfo.Click
        ' frmParticipantInfo.Show()
        frmParticipant_QBE.Show()
    End Sub

    Private Sub btnRate_Click(sender As System.Object, e As System.EventArgs) Handles btnRate.Click
        ' frmRates.Show()
        FormInterestRate.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        '  frmEmployerContrib.Show()
    End Sub

    Private Sub btnEmployer_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployer.Click
        '  My.Forms.FrmEmployerQBE.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmLabels.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        frmYearEnd.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        frmPart_SalHistory.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        frmPart_BenfHistory.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        frmPart_36MonthSalary.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        CreateActuarialFile("exec dt_ActualActiveMembers", "C:\temp\ActiveEmployee.xlsx")

    End Sub
    Public Sub CreateActuarialFile(sql As String, fileName As String)
        'Dim da As SqlDataAdapter
        'Dim dt As DataTable

        'Try
        '    'need create file path first
        '    da = New SqlDataAdapter(sql, gCnn)
        '    da.Fill(dt)
        '    ExportToExcel(dt, fileName)
        'Catch ex As Exception
        '    MsgBox(ex.Source & " -" & ex.Message)
        'Finally
        '    da.Dispose()
        '    dt.Dispose()
        'End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        CreateActuarialFile("exec dt_ActualPensioners", "C:\temp\Pensioner.xlsx")

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        'frmSurvivor_QBE.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        FormEmployer_MonthlyReport.EmployerID = 1210
        FormEmployer_MonthlyReport.Show()

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        ' CreateReport("testInvoice")
        'user wants to create excel report
        'open datatables and write to file
        'create dataset with balance and member table

        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Dim rptPath As String = "\\Tile\IMU\IMU-GCOS\JYang\SEPF-Net\"
        Dim rptfile As String = "InvoiceTemp.xlsx"

        Dim EmpID As Integer

        Dim workbook As Excel.Workbook


        Dim sql As String = String.Empty

        EmpID = 1210


        Try
            'check to see invoice exists, if yes, verify user whether want to overwrite,
            'if not, copy template and save as new invoice
            Dim NewRpt As String
            Dim currentDate As DateTime = DateTime.Now
            Select Case currentDate.Day

                Case Is < 20
                    If currentDate.Month = 1 Then
                        'back to previous January
                        NewRpt = currentDate.AddMonths(-1).Month.ToString & currentDate.AddYears(-1).Year.ToString

                    Else
                        NewRpt = currentDate.AddMonths(-1).Month.ToString & currentDate.Year.ToString
                    End If
                Case Else
                    NewRpt = currentDate.Month.ToString & currentDate.Year.ToString

            End Select



            NewRpt = "Inv_" & EmpID.ToString & "_" & NewRpt & ".xlsx"

            If File.Exists(rptPath + NewRpt) Then
                If (MessageBox.Show("Do you want to replace from the existing invoice file?", "Create Inovice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                    File.Delete(rptPath + NewRpt)
                Else
                    Return
                End If


            End If
            'create new invoice file
            Dim NewInvoice As String = Path.Combine(rptPath, NewRpt)
            File.Copy(Path.Combine(rptPath, rptfile), NewInvoice, True)




            sql = "dt_rpt_EmpInvoice " & EmpID
            da = New SqlDataAdapter(sql, gCnn)
            da.Fill(ds)


            Dim xlApp = New Excel.Application()
            ' xlApp.Visible = False

            workbook = xlApp.Workbooks.Open(NewInvoice)
            xlApp.Visible = False
            Dim wSheet As Excel.Worksheet
            Dim wSheetBal As Excel.Worksheet


            wSheet = CType(workbook.Worksheets("Members"), Excel.Worksheet)

            'work on Member sheet
            Dim dc As DataColumn
            Dim dr As DataRow
            ' Dim colIndex As Integer = 0
            Dim MrowIndex As Integer = 9
            Dim BrowIndex As Integer = 11

            'For Each dc In dt.Columns
            '    colIndex = colIndex + 1
            '    wSheet.Cells(1, colIndex) = dc.ColumnName
            'Next

            For Each dr In ds.Tables(0).Rows
                'For Each dc In ds.Tables(0).Columns
                If MrowIndex = 9 Then
                    'write common fields one
                    wSheet.Cells(5, "B") = dr(0).ToString
                    wSheet.Cells(6, "B") = dr(1).ToString
                    wSheet.Cells(14, "I") = dr(2).ToString
                End If
                wSheet.Cells(MrowIndex, "A") = dr(3).ToString
                wSheet.Cells(MrowIndex, "B") = dr(4).ToString
                ' Next
                MrowIndex = MrowIndex + 1
            Next
            ' wSheet.Columns.AutoFit()
            workbook.Save() 'As(rptPath)

            Dim Cramt As Double
            Dim Dbamt As Double
            Dim DblCurrBal As Double
            'opent balance sheet to save
            wSheetBal = CType(workbook.Worksheets("Balance"), Excel.Worksheet)
            For Each dr In ds.Tables(1).Rows

                ' For Each dc In ds.Tables(0).Columns
                If BrowIndex = 11 Then
                    'write common fields one
                    wSheetBal.Cells(5, "B") = dr(0).ToString  'name
                    wSheetBal.Cells(6, "B") = dr(1).ToString   'month
                    wSheetBal.Cells(9, "E") = dr(2).ToString    'openbal
                    DblCurrBal = CDbl(dr(3))                    'clsbal
                End If
                wSheetBal.Cells(BrowIndex, "A") = dr(4).ToString + dr(5).ToString
                wSheetBal.Cells(BrowIndex, "B") = dr(6).ToString  'charge
                wSheetBal.Cells(BrowIndex, "C") = dr(7).ToString   'payment
                Dbamt = Dbamt + CDbl(dr(6))
                Cramt = Cramt + CDbl(dr(7))
                'Next
                BrowIndex = BrowIndex + 1
            Next
            'write total
            wSheetBal.Cells(BrowIndex + 2, "A") = "Total:"
            wSheetBal.Cells(BrowIndex + 2, "B") = Dbamt.ToString
            wSheetBal.Cells(BrowIndex + 2, "C") = Cramt.ToString

            'write close balance
            wSheetBal.Cells(BrowIndex + 5, "D") = "Close Balance"
            wSheetBal.Cells(BrowIndex + 5, "E") = DblCurrBal.ToString

            ' wSheet.Columns.AutoFit()
            workbook.Save() '(NewInvoice)


            '  workBook.Save()
            workbook.Close() 'closes the  workbook  Excel still is open
            xlApp.Quit() 'Closes Excel opened with .Visible

            ds.Dispose()
            da.Dispose()

            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(wSheetBal)
            Marshal.ReleaseComObject(wSheet)

            Marshal.ReleaseComObject(xlApp)

            MsgBox("Invoice created")

        Catch ex As Exception
            MsgBox(ex.Source & " -" & ex.Message)
        End Try

       


    End Sub


    Public Sub ImportDataFromExcel(excelFilePath As String, ssqltable As String)

        Try
            Dim slxquery As String = String.Empty

            If ssqltable = "UltiproBenefitTransfer" Then
                slxquery = "select EepSSN,PrgTotEarnAmt,[Period Start Date],[Period End Date], transferdate, [Period Control]from [Page1$]"
            Else
                slxquery = "select EepSSN, SEPFWages,SEPFDedAmt,Startdate, EndDate,transferdate,[Period Control]  from [Page1$]"
            End If
            'create our connection strings 
            ' Dim sexcelconnectionstring As String = (Convert.ToString("provider=microsoft.jet.oledb.4.0;data source=") & excelFilePath) + ";extended properties=" + """excel 8.0;hdr=yes;"""
            ' Dim slxconnectionstring As String = (Convert.ToString("provider=Microsoft.ACE.OLEDB.12.0;data source=") & excelFilePath) & ";extended properties=" + """" & "Excel 12.0 Xml;HDR=Yes;&" & """"
            '  Dim s As String = "Extended Properties =" & " "Excel 12.0 Xml;HDR=YES""
            '  Dim slxconnectionstring As String = "provider=Microsoft.ACE.OLEDB.12.0;data source=" & excelFilePath & ";Extended Properties = " & ""Excel 12.0 Xml;HDR=YES"" &";"
            ' Dim slxconnectionstring As String = "provider=Microsoft.ACE.OLEDB.12.0;data source=" & excelFilePath & ";" & s

            Dim slxconnectionstring As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & excelFilePath & ";" &
              "Extended Properties = " & """" & "Excel 12.0 Xml;HDR=YES" & """" & ";"

            ' Dim slxconnectionstring As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=\\tile\SEPF\UltiDownloads\Salary.xlsx;Extended Properties = " + "Excel 12.0 Xml;HDR=YES" + ""


            'execute a query to erase any previous data from our destination table 
            Dim sclearsql As String = Convert.ToString("delete from ") & ssqltable
            Dim sqlcmd As New SqlCommand(sclearsql, gCnn)

            sqlcmd.ExecuteNonQuery()
            'sqlconn.Close()
            ' bulk copy data from the excel file into  sql table 
            Dim oledbconn As New System.Data.OleDb.OleDbConnection(slxconnectionstring)
            Dim oledbcmd As New OleDbCommand(slxquery, oledbconn)

            oledbconn.Open()

            Dim dr As OleDbDataReader = oledbcmd.ExecuteReader()

            Dim bulkcopy As New SqlBulkCopy(gCnn)
            bulkcopy.DestinationTableName = ssqltable

            While dr.Read()
                bulkcopy.WriteToServer(dr)
            End While
            dr.Close()
            oledbconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Call ImportDataFromExcel("\\tile\SEPF\UltiDownloads\Benefit.xlsx", "UltiproBenefitTransfer")
        'upload to benefit tables
        Dim ssql As String = Convert.ToString("exec dbo.dt_Month_UploadBenefit")
        ' Dim sqlconn As New SqlConnection(ssqlconnectionstring)
        Try
            Dim sqlcmd As New SqlCommand(ssql, gCnn)
            ' sqlconn.Open()
            sqlcmd.ExecuteNonQuery()
            MsgBox("benefit uploaded done")
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Call ImportDataFromExcel("\\tile\SEPF\UltiDownloads\Salary.xlsx", "UltiproSalaryTransfer")
        'upload to benefit tables
        Dim ssql As String = Convert.ToString("exec dt_Month_UploadSalary")
        ' Dim sqlconn As New SqlConnection(ssqlconnectionstring)
        Try
            Dim sqlcmd As New SqlCommand(ssql, gCnn)
            ' sqlconn.Open()
            sqlcmd.ExecuteNonQuery()
            MsgBox("Salary uploaded done")
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        ' FormEmployer_MakePay.EmployerID = 1210
        'FormEmployer_MakePay.Show()
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        FrmReports.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        ' FormEmployer_MakePay.EmpId = 1210
        '  FormEmployer_MakePay.Show()

        FormEmployer_MonthlyReport.EmployerID = 1210
        FormEmployer_MonthlyReport.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub
End Class