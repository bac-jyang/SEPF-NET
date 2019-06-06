Option Strict Off
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel


Imports System.IO
Imports Microsoft.Office.Interop

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module modMain


    Public gCnn As SqlConnection
    Public rptDoc As ReportDocument

    Public Sub ExportToExcel(ByVal dt As Data.DataTable, ByVal filepath As String)
        Dim strFileName As String = filepath
        If System.IO.File.Exists(strFileName) Then
            If (MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                System.IO.File.Delete(strFileName)
            Else
                Return
            End If

        End If
        Dim Aexcel As New Application
        Dim wBook As Workbook
        Dim wSheet As Worksheet

        wBook = Aexcel.Workbooks.Add()
        wSheet = CType(wBook.ActiveSheet(), Worksheet)

        Dim dc As DataColumn
        Dim dr As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        wBook.SaveAs(strFileName)

        ReleaseObject(wSheet)
        wBook.Close(False)
        ReleaseObject(wBook)
        Aexcel.Quit()
        ReleaseObject(Aexcel)
        GC.Collect()

        MessageBox.Show("File Export Successfully!")
    End Sub
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    'Public Sub ImportDataFromExcel(excelFilePath As String)
    'Imports System.Data.SqlClient 
    'Imports System.Data.OleDb
    '    'declare variables - edit these based on your particular situation 
    '    Dim ssqltable As String = "Table1"
    '    ' make sure your sheet name is correct, here sheet name is sheet1, so you can change your sheet name if have    different 
    '    Dim myexceldataquery As String = "select student,rollno,course from [sheet1$]"
    '    Try
    '        'create our connection strings 
    '        Dim sexcelconnectionstring As String = (Convert.ToString("provider=microsoft.jet.oledb.4.0;data source=") & excelFilePath) + ";extended properties=" + """excel 8.0;hdr=yes;"""
    '        Dim ssqlconnectionstring As String = "Data Source=SAYYED;Initial Catalog=SyncDB;Integrated Security=True"
    '        'execute a query to erase any previous data from our destination table 
    '        Dim sclearsql As String = Convert.ToString("delete from ") & ssqltable
    '        Dim sqlconn As New SqlConnection(ssqlconnectionstring)
    '        Dim sqlcmd As New SqlCommand(sclearsql, sqlconn)
    '        sqlconn.Open()
    '        sqlcmd.ExecuteNonQuery()
    '        sqlconn.Close()
    '        'series of commands to bulk copy data from the excel file into our sql table 
    '        Dim oledbconn As New OleDbConnection(sexcelconnectionstring)
    '        Dim oledbcmd As New OleDbCommand(myexceldataquery, oledbconn)
    '        oledbconn.Open()
    '        Dim dr As OleDbDataReader = oledbcmd.ExecuteReader()
    '        Dim bulkcopy As New SqlBulkCopy(ssqlconnectionstring)
    '        bulkcopy.DestinationTableName = ssqltable
    '        While dr.Read()
    '            bulkcopy.WriteToServer(dr)
    '        End While
    '        dr.Close()
    '        oledbconn.Close()
    '        Label1.Text = "File imported into sql server."
    '        'handle exception 
    '    Catch ex As Exception
    '    End Try
    'End Sub


    Public Sub CreateReport(sName As String)

        Dim sExtension As String
        Dim sRptfile As String
        Dim sFile As String
        Dim sYearPath As String
        Dim sFilePdf As String
        Dim i As Integer
        Dim j As Integer

        Dim sRptPath As String = "\\tile\sepf\reports-DotNet\1210"
        Dim sDrive As String

        rptDoc = New ReportDocument
        sName = "EmpInvoice"
        'load report
        sRptfile = sRptPath & "\" & sName & ".rpt"
        'rptDoc.Load(sRptfile)

        rptDoc.Load("\\tile\sepf\reports-DotNet\EmpInvoice.rpt")
        'set main report parameter
        rptDoc.SetParameterValue("@EmpID", 1210)
        'set sub-report parameter
        rptDoc.SetParameterValue("@EmpID", 1210, rptDoc.Subreports(0).Name.ToString)
        ' rptDoc.Subreports(0).SetParameterValue("@EmpID", 1210)
        'rptDoc.RecordSelectionFormula = sCriteria

        'have to verify file existing?
        sExtension = ".pdf"

        'sYearPath = sDrive & "\" & (Year(Today) - 1).ToString
        'make sure path exists
        ' If System.IO.Directory.Exists(sYearPath) = False Then
        'System.IO.Directory.CreateDirectory(sYearPath)
        ' End If

        sFilePdf = sName & sExtension


        If System.IO.File.Exists(sFilePdf) = True Then 'file exists
            'ask user wethere he wants to replace existing one
            If MsgBox("The file already exists. Do you want to replace existing file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                sFile = sName & sExtension '"c:\temp\88_20070801.pdf"
            Else
                'save to different name?? increase count number
                j = 0
                For i = 1 To 5

                    If System.IO.File.Exists(sName & "_" & CStr(i) & sExtension) = False Then
                        sFile = ""
                        sFile = sName & "_" & CStr(i) & sExtension '"c:\temp\88_20070801_1.pdf"
                        Exit For
                    Else
                        j = j + 1
                    End If
                Next

                If j = 5 Then
                    MessageBox.Show("Same file can only be saved maximum 5 times.")
                End If

            End If

        Else
            sFile = sName & sExtension '"c:\temp\88_20070801.pdf"

        End If



        Dim ExportOpts As New ExportOptions
        ExportOpts.ExportFormatType = ExportFormatType.PortableDocFormat
        ExportOpts.ExportDestinationType = ExportDestinationType.DiskFile


        Dim DestOpts As DiskFileDestinationOptions = ExportOptions.CreateDiskFileDestinationOptions()
        DestOpts.DiskFileName = "c:\temp\testInvoice1210.pdf" 'sFile

        ExportOpts.ExportDestinationOptions = DestOpts


        'create bookmark on reports
        Dim obj As New PdfFormatOptions()
        obj.CreateBookmarksFromGroupTree = True
        ExportOpts.ExportFormatOptions = obj


        rptDoc.Export(ExportOpts)
        rptDoc.Close()
        rptDoc.Dispose()

        '  MsgBox("Export successfully!")

    End Sub
End Module
