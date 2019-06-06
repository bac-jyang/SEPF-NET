Option Strict Off
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmYearEnd

    Public rptDoc As ReportDocument
    Const sDrive As String = "C:\SEPF\Statements"
    Const sRptPath As String = "C:\SEPF\Reports"


    Private Sub DocMailMerge(sSourceFile As String, dt As DataTable)
        'open source word document
        'merge/import data from datatable
        Try
            'Dim wApp As New Word.Application
            'Dim wDoc As Word.Document
            'Dim strConnect As String
            'Dim sqlstr As String

            'wApp.Visible = False
            '' Open the template document.
            'wDoc = wApp.Documents.Add("C:\SEPF\modstatements\SEPFvested.doc")


            '' Clone the template instead of loading it from disk (for speed).
            '' Dim dstDoc As Word.Document = CType(wDoc.clone(True), Word.Document)
            '' doc = objWord.Documents.Add(FullPath)

            'strConnect = "DSN=Sepf;"
            'sqlstr = "Select * from vwStatements where (datevested > 0 AND Participant_IL_Service_Credits = 0 AND YEAR(Participant_Date_Hired) < 2009) order by Participant_LastName, Participant_FirstName"

            ''doc.OpenDataSource Name:="", _
            ''Connection:="DSN=SepfSQLDB;DATABASE=SEPF;uid=;pwd=;", SQLStatement:=sqlstr, SubType:=wdMergeSubTypeWord2000
            'wDoc.MailMerge.OpenDataSource(Name:="\\Tile\SEPF\SEPF.mdb", LinkToSource:=True, _
            '    ReadOnly:=True, Connection:=strConnect, SQLStatement:=sqlstr)
            ''
            'wDoc.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument 'mail merge destination is new doc
            'wDoc.MailMerge.Execute()      'false                'perform mail merge
            'wApp.Visible = True                      'go back to mail merge doc


            ''close without saving
            ''  wDoc.Close(SaveChanges:=Word.WdSaveOptions.wdDoNotSaveChanges)
            '' wApp.WordBasic.FileSaveAs(OutputPath & FileName)
            ''
            ''    'take appropriate action depending on what button was selected
            ''objWord.ActiveDocument.PrintOut '(False)     'print doc before exiting word
            '' objWord.WordBasic.FileClose(2)               'close (we already saved)
            '' objWord.Quit(savechanges:=wdDoNotSaveChanges) 'quit application



            '' Execute mail merge.
            '' wDoc.MailMerge.Execute(CType(dt, Object))
            '' Save the document.
            'wDoc.SaveAs("C:\SEPF\2014\modstatements\SEPFvested.doc")
            'wDoc.Close(SaveChanges:=Word.WdSaveOptions.wdDoNotSaveChanges)


            'wDoc = Nothing
            ' App = Nothing
        Catch ex As Exception
            MsgBox("error happened, " & ex.Message)
        Finally

            dt.Dispose()
        End Try


    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAcVested.Click
        'Dim sql As String = String.Empty
        'Dim da As SqlDataAdapter
        'Dim dt As New DataTable
        'Try
        '    sql = "Select * from vwStatements where (datevested > 0 AND Participant_IL_Service_Credits = 0 AND YEAR(Participant_Date_Hired) < 2009) order by Participant_LastName, Participant_FirstName"
        '    da = New SqlDataAdapter(sql, gCnn)
        '    da.Fill(dt)
        '    DocMailMerge("C:\SEPF\Statements\modstatements\SEPFvested.doc", dt)

        'Catch ex As Exception
        '    MsgBox(ex.Source & " -" & ex.Message)
        'Finally
        '    '  dt.Dispose()
        '    da.Dispose()
        'End Try

        ' rptDoc = New ReportDocument
        ' rptDoc.Load("C:\SEPF\Reports\Vested.rpt")
        ' Dim frm As New frmViewer

        ' frm.ShowDialog()
        '  frmViewer.ShowDialog()
        ' rptDoc.RecordSelectionFormula = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) < 2009 "
        ' rptDoc.RecordSelectionFormula = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) > 2008"
        Dim sCriteria As String
        sCriteria = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) < 2009 "
        Call CreateStatement("Vested", sCriteria)

        sCriteria = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) >2008  "
        Call CreateStatement("Vested", sCriteria)

        'MsgBox("Vested Statements generated successfully!")
        MessageBox.Show("Vested Statements generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub
    Public Sub CreateStatement(sName As String, sCriteria As String)

        Dim sExtension As String
        Dim sRptfile As String
        Dim sFile As String
        Dim sYearPath As String
        Dim sFilePdf As String
        Dim i As Integer
        Dim j As Integer

        rptDoc = New ReportDocument
        'load report
        sRptfile = sRptPath & "\" & sName & ".rpt"
        rptDoc.Load(sRptfile)
        rptDoc.RecordSelectionFormula = sCriteria
        'have to verify file existing?
        sExtension = ".pdf"

        sYearPath = sDrive & "\" & (Year(Today) - 1).ToString
        'make sure path exists
        If System.IO.Directory.Exists(sYearPath) = False Then
            System.IO.Directory.CreateDirectory(sYearPath)
        End If

        sFilePdf = sName & sExtension


        If System.IO.File.Exists(sYearPath & "\" & sFilePdf) = True Then 'file exists
            'ask user wethere he wants to replace existing one
            If MsgBox("The file already exists. Do you want to replace existing file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                sFile = sYearPath & "\" & sName & sExtension '"c:\temp\88_20070801.pdf"
            Else
                'save to different name?? increase count number
                j = 0
                For i = 1 To 5

                    If System.IO.File.Exists(sYearPath & "\" & sName & "_" & CStr(i) & sExtension) = False Then
                        sFile = ""
                        sFile = sYearPath & "\" & sName & "_" & CStr(i) & sExtension '"c:\temp\88_20070801_1.pdf"
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
            sFile = sYearPath & "\" & sName & sExtension '"c:\temp\88_20070801.pdf"

        End If



        Dim ExportOpts As New ExportOptions
        ExportOpts.ExportFormatType = ExportFormatType.PortableDocFormat
        ExportOpts.ExportDestinationType = ExportDestinationType.DiskFile


        Dim DestOpts As DiskFileDestinationOptions = ExportOptions.CreateDiskFileDestinationOptions()
        DestOpts.DiskFileName = sFile

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

    Private Sub frmYearEnd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAcNoVested_Click(sender As System.Object, e As System.EventArgs) Handles btnAcNoVested.Click

    End Sub
End Class