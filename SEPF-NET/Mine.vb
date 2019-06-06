Namespace Mine

    'Public NotInheritable Class ApplicationEnums
    '    Public Enum DataStyle
    '        SingleTable
    '        StoredProcView
    '    End Enum
    'End Class
   Public NotInheritable Class AppData
        Private Sub New()

        End Sub
        Public Shared Sub SetFormSize(activeForm As Form, setAsDialog As Boolean)

            If activeForm Is Nothing Then
                Throw New ArgumentNullException("activeForm")
            End If

            Dim width As Integer = 1000
            Dim height As Integer = 700

            If setAsDialog = True Then
                width = CInt(width * 0.9)
                height = CInt(height * 0.9)
            End If

            Dim formSize As New Size(width, height)

            activeForm.Size = formSize
            activeForm.MinimumSize = formSize
            activeForm.MaximumSize = formSize

            If setAsDialog = True Then
                activeForm.StartPosition = FormStartPosition.CenterParent
            Else
                activeForm.StartPosition = FormStartPosition.CenterScreen
            End If

        End Sub
        Public Shared ReadOnly Property Version() As String
         Get
            Try


               Dim strDash As String = "-"
               Return "Version: " & _
                              My.Application.Info.Version.Major.ToString & strDash & _
                              My.Application.Info.Version.Minor.ToString & strDash & _
                              My.Application.Info.Version.Build.ToString & strDash & _
                              My.Application.Info.Version.Revision.ToString

            Catch ex As Exception
               Throw
            End Try
         End Get
      End Property
   End Class
   Public NotInheritable Class LastViewed

      Private Sub New()

      End Sub
        'Public Shared Function Add(ByVal annMemberData As AnnMember) As Boolean
        '    Return SaveSetting(annMemberData)
        'End Function
        'Public Shared Function Add(pensionMember As ClassPensionMember) As Boolean
        '    Return SaveSetting(pensionMember)
        'End Function
        'Private Shared Function SaveSetting(obj As ClassPensionMember) As Boolean
        '    Try
        '        Dim item As String = String.Empty
        '        Dim listName As String = String.Empty

        '        If My.Settings.LastViewedMember1099 Is Nothing Then
        '            My.Settings.LastViewedMember1099 = New ArrayList
        '            My.Settings.Reload()
        '            'Reload will set My.Settings.LastViewedMember _
        '            'to nothing if no user.config file
        '        End If
        '        If My.Settings.LastViewedMember1099 Is Nothing Then
        '            'reload set to Nothing, so we have to start over
        '            'this will only happen Very first time a user.Config
        '            'file is deleted or created
        '            My.Settings.LastViewedMember1099 = New ArrayList
        '        End If

        '        listName = obj.LastName.ToString & ", " & obj.FirstName.ToString

        '        If listName <> ", " Then
        '            item = obj.PensionPayrollId.ToString() & _
        '           My.Settings.LastViewedDelimiter & listName

        '            'add to user.config
        '            Return FillConfigLastUsed(My.Settings.LastViewedMember1099, item)
        '        Else
        '            Return False
        '        End If

        '        Return True

        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End Function
        'Private Shared Function SaveSetting(ByVal Obj As AnnMember) As Boolean

        '    Try
        '        Dim item As String = String.Empty
        '        Dim listName As String = String.Empty

        '        ' If TypeOf (Obj) Is AnnMember Then
        '        'Dim ox As Member = Obj
        '        Dim ox As AnnMember = DirectCast(Obj, AnnMember)


        '        If My.Settings.LastViewedMember Is Nothing Then
        '            My.Settings.LastViewedMember = New ArrayList
        '            My.Settings.Reload()
        '            'Reload will set My.Settings.LastViewedMember _
        '            'to nothing if no user.config file
        '        End If
        '        If My.Settings.LastViewedMember Is Nothing Then
        '            'reload set to Nothing, so we have to start over
        '            'this will only happen Very first time a user.Config
        '            'file is deleted or created
        '            My.Settings.LastViewedMember = New ArrayList
        '        End If

        '        listName = ox.LastName.ToString & ", " & ox.FirstName.ToString

        '        If listName <> ", " Then
        '            item = ox.MemberId.ToString() & _
        '           My.Settings.LastViewedDelimiter & listName

        '            'add to user.config
        '            Return FillConfigLastUsed(My.Settings.LastViewedMember, item)
        '        Else
        '            Return False
        '        End If

        '        '   End If




        '        Return True

        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End Function
        'Private Shared Function FillConfigLastUsed(ByVal al As ArrayList, _
        '                                            ByVal newItem As String) As Boolean
        '   Try
        '      ' Dim blnHave As Boolean = False
        '      Dim blnFound As Boolean = False

        '      'now add records to user.Config
        '      If Not al.Contains(newItem) Then 'we don't have exact match

        '         'do we have this ID with different name?
        '         Dim iPosMarkNew As Integer = InStr(newItem, My.Settings.LastViewedDelimiter)
        '         Dim strIDNew As String = Left(newItem, iPosMarkNew - 1)
        '         Dim iPosMarkOld As Integer = 0
        '         Dim strIDOld As String = String.Empty

        '         For Each oldValue As String In al
        '            iPosMarkOld = InStr(oldValue, My.Settings.LastViewedDelimiter)
        '            strIDOld = Left(oldValue, iPosMarkOld - 1)
        '            If strIDOld = strIDNew Then
        '               Dim idxOldValue As Integer = al.IndexOf(oldValue)
        '               al.RemoveAt(idxOldValue)
        '               al.Insert(0, newItem)
        '               blnFound = True
        '               Exit For
        '            End If
        '         Next

        '         If blnFound = False Then
        '            al.Insert(0, newItem)
        '            If al.Count > My.Settings.MaxNumberLastSaved Then
        '               al.RemoveAt(My.Settings.MaxNumberLastSaved)
        '               'not at Max - 1 since we did add one already
        '            End If
        '         End If

        '      Else 'we have move it to top of list
        '         Dim idx As Integer = al.IndexOf(newItem)
        '         al.RemoveAt(idx)
        '         al.Insert(0, newItem)
        '      End If

        '      My.Settings.Save()

        '      Return True

        '   Catch ex As Exception
        '      Return False
        '   End Try
        'End Function


   End Class

    ''' <summary>
    ''' Class ConnString.  Gets either the RAS or SEPF connection strings
    ''' </summary>
    ''' <remarks>
    ''' Both are ReadOnly properties.
    ''' </remarks>
    ''' 
    Public NotInheritable Class ConnString
      Private Sub New()

      End Sub
        Shared ReadOnly Property RasConnection() As String
            Get
                Return "server=RASSERVER;trusted_connection=yes;" & _
                            "database=RAS_PRODUCTION;Connection Timeout=45"

            End Get
        End Property

        Public Shared ReadOnly Property SEPFConnection() As String
            Get

                Return "data source=BRICKYARD;" &
                                 "initial catalog=SEPF-NET; Connection Timeout=45;" &
                                "Integrated Security=SSPI"

            End Get
        End Property

    End Class

End Namespace

