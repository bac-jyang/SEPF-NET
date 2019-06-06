Imports System.ComponentModel
Imports BAC.Controls

<
ToolboxItem(True),
Browsable(True),
ToolboxBitmap(GetType(QbeDateBox), "Control_TextBox.bmp"),
DesignTimeVisibleAttribute(True)
>
Public Class QbeDateBox
    Implements IBacQbeTextControl

    Implements IBacQbeControl

    Public Enum DateBoxStyle
        Unkown = 0
        FromBox = 1
        ToBox = 2
        SingleBox = 3

    End Enum
#Region "Private var"
    Private mDefaultValue As String = String.Empty
    Private mQbeBackColorOnEnter As System.Drawing.Color = Color.Aqua
    Private mQbeBackColorOnExit As System.Drawing.Color = Color.White
    Private mQbeBackColorOnError As System.Drawing.Color = Color.Yellow

    Private mShowAlphaNumericErrorBackColor As Boolean = True

    Private mDatabaseFieldName As String = String.Empty
    Private mDatabaseTableName As String = String.Empty
    Private mQbeFieldName As String = String.Empty
    Private mClearTextEntryOnEscape As Boolean = True

    Private mStatusLabelError As ToolStripStatusLabel

    Private mBoxStyle As DateBoxStyle

#End Region

#Region "Public Property"


    <Browsable(True),
  Category("BAC Qbe Properties"),
  Description("databox style ")>
    Public Property BoxStyle As DateBoxStyle

        Get
            Return mBoxStyle
        End Get
        Set(value As DateBoxStyle)
            mBoxStyle = value

        End Set
    End Property

#End Region


#Region "Public common Property"



    <Browsable(True),
 Category("BAC Qbe Properties"),
 Description("Set to show BackColor error on improper Alpha/numeric entry ")>
    Public Property ShowAlphaNumericErrorBackColor As Boolean Implements IBacQbeTextControl.ShowAlphaNumericErrorBackColor
        Get
            Return mShowAlphaNumericErrorBackColor
        End Get
        Set(value As Boolean)
            mShowAlphaNumericErrorBackColor = value
        End Set
    End Property
    <Browsable(True),
  Category("BAC Qbe Properties"),
  Description("Set Default value ")>
    Public Property DefaultValue As String Implements IBacQbeTextControl.DefaultValue
        Get

            Return mDefaultValue
        End Get
        Set(value As String)

            mDefaultValue = value
        End Set
    End Property



    <Browsable(True),
 Category("BAC Qbe Properties"),
 Description("True sets text to String.Empty when Esc Key is hit ")>
    Public Property ClearTextEntryOnEscape As Boolean Implements IBacQbeTextControl.ClearTextEntryOnEscape
        Get
            Return mClearTextEntryOnEscape
        End Get
        Set(value As Boolean)
            mClearTextEntryOnEscape = value
        End Set
    End Property


    <Category("BAC Qbe Appearance"), Description("The background color of the component for QbeEntering Data on OnEnter Event")>
    <Browsable(True)>
    Public Property QbeBackColorOnEnter As System.Drawing.Color Implements IBacQbeTextControl.QbeBackColorOnEnter
        Get
            Return mQbeBackColorOnEnter
        End Get
        Set(value As System.Drawing.Color)
            mQbeBackColorOnEnter = value
        End Set
    End Property
    '------
    <Category("BAC Qbe Appearance"), Description("The background color of the component for Qbe leaving field Data on Onleave Event")>
    <Browsable(True)>
    Public Property QbeBackColorOnExit As System.Drawing.Color Implements IBacQbeTextControl.QbeBackColorOnExit
        Get
            Return mQbeBackColorOnExit
        End Get
        Set(value As System.Drawing.Color)
            mQbeBackColorOnExit = value
        End Set
    End Property
    <Category("BAC Qbe Appearance"), Description("The background color of the component for Qbe Alpha/Numeric errors.  ShowError must be set to True.")>
    <Browsable(True)>
    Public Property QbeBackColorOnError As System.Drawing.Color Implements IBacQbeTextControl.QbeBackColorOnError
        Get
            Return mQbeBackColorOnError
        End Get
        Set(value As System.Drawing.Color)
            mQbeBackColorOnError = value
        End Set
    End Property


    <Category("BAC Qbe Properties"), Description("The field name in the Qbe view to match the column Where Clause.")>
    <Browsable(True)>
    Public Property QbeFieldName As String Implements IBacQbeControl.QbeFieldName
        Get
            Return mQbeFieldName
        End Get
        Set(value As String)
            mQbeFieldName = value
        End Set
    End Property

    <Browsable(True),
  Category("BAC Qbe Properties"),
  Description("ToolStrip message for a particular StatusStrip ")>
    Public Property StatusLabelError As ToolStripStatusLabel Implements IBacQbeControl.StatusLabelError
        Get
            Return mStatusLabelError
        End Get
        Set(value As ToolStripStatusLabel)
            mStatusLabelError = value
        End Set
    End Property

    Public Property ResetToValue As String Implements IBacQbeControl.ResetToValue
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property
#End Region
    Public Function GetQbeSQLstring() As String Implements IBacQbeControl.GetQbeSQLstring

        Dim returnValue As String = String.Empty
        Try
            If String.IsNullOrEmpty(Me.QbeFieldName) Then
                Return String.Empty
            End If

            If String.IsNullOrEmpty(Me.Text) Then
                Return String.Empty
            End If

            Select Case BoxStyle
                Case DateBoxStyle.Unkown  'return text string
                    returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"

                Case DateBoxStyle.SingleBox  'return date
                    returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"

                Case DateBoxStyle.FromBox
                        returnValue = "(" & Me.QbeFieldName & " >= " & "'" & Me.Text & "')"
                Case DateBoxStyle.ToBox
                    returnValue = "(" & Me.QbeFieldName & " <= " & "'" & Me.Text & "')"
            End Select

            '    Case QbeEntrySqlOutput.EntryAlphaSqlString
            '        'EntryAlphaSqlString()             'field = 'x'
            '        returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"

            '    Case QbeEntrySqlOutput.EntryAlphaSqlStringLike
            '        'EntryAlphaSqlStringLike()         'field like 'x%'
            '        returnValue = "(" & Me.QbeFieldName & " Like " & "'" & Me.Text & "%')"

            '    Case QbeEntrySqlOutput.EntryAlphaSpaceSqlString
            '        'EntryAlphaSpaceSqlString()        'field = 'z s'
            '        returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"

            '    Case QbeEntrySqlOutput.EntryAlphaSpaceSqlStringLike
            '        'EntryAlphaSpaceSqlStringLike()    'field like 'z s%'
            '        returnValue = "(" & Me.QbeFieldName & " Like " & "'" & Me.Text & "%')"

            '    Case QbeEntrySqlOutput.EntryNumberSingleSqlNumber
            '        'EntryNumberSingleSqlNumber()      'field = 1
            '        returnValue = "(" & Me.QbeFieldName & " = " & Me.Text & ")"
            '    Case QbeEntrySqlOutput.EntryNumberSingleSqlString
            '        'EntryNumberSingleSqlString()      'field = '100'
            '        returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"
            '    Case QbeEntrySqlOutput.EntryNumberSingleSqlStringLike
            '        'EntryNumberSingleSqlStringLike()  'field like '100%'
            '        returnValue = "(" & Me.QbeFieldName & " Like " & "'" & Me.Text & "%')"

            '    Case QbeEntrySqlOutput.EntryNumberSpaceSqlString
            '        'EntryNumberSpaceSqlString()       'field = '1 3'
            '        returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"
            '    Case QbeEntrySqlOutput.EntryNumberSpaceSqlStringLike
            '        'EntryNumberSpaceSqlStringLike()   'field like '1 3%'
            '        returnValue = "(" & Me.QbeFieldName & " Like " & "'" & Me.Text & "%')"

            '    Case QbeEntrySqlOutput.EntryNumberBetweenSqlBetweenNum
            '        'EntryNumberBetweenSqlBetweenNum() 'field BETWEEN 1 and 3 / AND IN(2,3,4) / IN(1,2,3,4)
            '        returnValue = MakeInBetweenSQL(ReturnSqlType.ReturnInteger)
            '    Case QbeEntrySqlOutput.EntryNumberListSqlINString
            '        'EntryNumberListSqlINString()       'field IN('1','2','3')
            '        'don't allow '-' or space, just comma
            '        returnValue = MakeInBetweenSQL(ReturnSqlType.ReturnString)

            '    Case QbeEntrySqlOutput.EntryNumberListSqlNumber
            '        'EntryNumberListSqlNumber()        'field IN(1,2,3)
            '        returnValue = MakeInBetweenSQL(ReturnSqlType.ReturnInteger)
            '    Case QbeEntrySqlOutput.EntryNoCheckSqlString
            '        'EntryNoCheckSqlString()            'field = '?'
            '        returnValue = "(" & Me.QbeFieldName & " = " & "'" & Me.Text & "')"

            '    Case QbeEntrySqlOutput.EntryNoCheckSqlStringLike
            '        ' EntryNoCheckSqlStringLike()         'field Like 'a %'
            '        returnValue = "(" & Me.QbeFieldName & " Like " & "'" & Me.Text & "%')"


            'End Select
        Catch ex As Exception
            Throw
        End Try

        Return returnValue


    End Function
End Class
