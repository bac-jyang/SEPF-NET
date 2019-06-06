
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
'Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.ReportSource

Public Class frmViewer

    Dim rptDoc As New ReportDocument
    Dim rptPath As String = "\\tile\IMU\IMU-GCOS\JYang\SEPF-Net\Reports\"
    Public rptFile As String
    Public rptSelectionCritera As String


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' rptDoc.Load("C:\SEPF\Reports\Vested.rpt")
        'Vested
        ' rptDoc.RecordSelectionFormula = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) < 2009 "
        ' rptDoc.RecordSelectionFormula = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) > 2008"

        'none Vested
        ' rptDoc.Load("C:\SEPF\Reports\NonVested.rpt")
        rptFile = "PensionerTest.rpt"
        rptDoc.Load(rptPath & rptFile)
        'rptDoc.RecordSelectionFormula = " isnull( {vwStatements.datevested})   And {vwStatements.Participant_IL_Service_Credits} = 0 And  {vwStatements.ITDContribution} > 0 and Year({vwStatements.HireDate}) < 2009 "
        'rptDoc.RecordSelectionFormula = " isnull ( {vwStatements.datevested} ) And {vwStatements.Participant_IL_Service_Credits} = 0 and {vwStatements.ITDContribution} > 0 and Year({vwStatements.HireDate}) >2008 "

        'Vested with LOEPF
        ' rptDoc.RecordSelectionFormula = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) < 2009 "
        ' rptDoc.RecordSelectionFormula = " Year({vwStatements.datevested}) > 0 And {vwStatements.Participant_IL_Service_Credits} = 0 And Year({vwStatements.HireDate}) < 2009 "
        'none Vested with LOEPF

        'If rptSelectionCritera.ToString.Length > 0 Then
        '    rptDoc.RecordSelectionFormula = rptSelectionCritera

        'End If

        CrViewer.ReportSource = rptDoc
        CrViewer.ShowLogo = False
        CrViewer.Show()
        'CrViewer.ExportReport()
        'CrViewer.RefreshReport()
        Me.CrViewer.RefreshReport()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' rptDoc.Load("C:\SEPF\Reports\Vested.rpt")
        ' Add any initialization after the InitializeComponent() call.
        ' rptDoc = frmYearEnd.rptDoc
        ' CrViewer.ReportSource = rptDoc
        ' CrViewer.ShowLogo = False
        ' CrViewer.RefreshReport()
    End Sub

    Private Sub frmViewer_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Me.MaximumSize.Height > 500 Then
            CrViewer.Height = Me.MaximumSize.Height - 500
        End If
        If Me.MaximumSize.Width > 120 Then
            CrViewer.Width = Me.MaximumSize.Width - 120
        End If
    End Sub
End Class