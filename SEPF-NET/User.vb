Imports System
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Collections
Imports BAC.Controls.BACenums.UserEnums
Imports BAC.Controls

Public Class User
    'Can not unhash a password
    Implements Security.Principal.IIdentity

    'Public Enum ProtectedUser
    '    None = 0
    '    DbAdmin = 1
    'End Enum
    '<FlagsAttribute()> _
    'Public Enum WhichSystemId As Integer
    '    None = 0
    '    Annuity = 2
    '    Reciprocity = 4
    '    Ice3 = 8
    '    RspDownload = 16
    '    BeneficiaryInfo = 32
    '    MeetingData = 64
    '    Letters = 128
    'End Enum

    Private Event NoComboBoxSelectionMade(ByVal sender As Object, _
                                            ByVal EventNumber As Integer, _
                                            ByVal EventMessage As String)
    Public Shared GlobalUserId As Long

    Private nameValue As String
    Private mUserName As String
    Private mUserPasswordHash As String
    Private mUserPasswordString As String
    Private mBuiltInRoleId As Long
    Private Shared mCustomRoleId As Long
    Private mUserActive As Boolean
    Private mUserId As Long
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole
    Private mDsnNameKey As Integer
    Private mDsnDateLoaded As Date

    ''' <summary>
    ''' Empty Constructor - sets oCnn connection object
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        authenticatedValue = False
    End Sub
    Sub New(ByVal userName As String)
        Me.New()
        authenticatedValue = ValidUser(userName)
    End Sub
    Sub New(ByVal userName As String, ByVal password As String)
        Me.New()
        If ValidUser(userName, password) = True Then
            authenticatedValue = True
        End If
    End Sub
    ''' <summary>
    ''' This sets implemented ReadOnly setting to "Custom Authentication"
    ''' </summary>
    ''' <value></value>
    ''' <returns>"Custom Authentication"</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AuthenticationType() As String _
        Implements Security.Principal.IIdentity.AuthenticationType
        Get
            Return "Custom Authentication"
        End Get
    End Property
    ''' <summary>
    ''' Returns the authenticatedValue from Interface
    ''' </summary>
    ''' <value></value>
    ''' <returns>True if Authenticated, False otherwise</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsAuthenticated() As Boolean _
        Implements Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property
    ''' <summary>
    ''' Gets value from SQL table
    ''' </summary>
    ''' <value></value>
    ''' <returns>UserName string</returns>
    ''' <remarks></remarks>
    Public Property UserName() As String
        Get
            Return mUserName
        End Get
        Set(ByVal value As String)
            mUserName = value
        End Set
    End Property
    '''<summary>
    ''' Returns the BuiltInRoleID from SQL table
    '''</summary>
    Public Property BuiltInRoleId() As Long
        Get
            Return mBuiltInRoleId
        End Get
        Set(ByVal value As Long)
            mBuiltInRoleId = value
        End Set
    End Property
    Public Shared Property CustomRoleId() As Long
        Get
            Return mCustomRoleId
        End Get
        Set(ByVal value As Long)
            mCustomRoleId = value
        End Set
    End Property
    '''<summary>
    ''' Returns the UserActive field from SQL table
    '''</summary>
    Public Property UserActive() As Boolean
        Get
            Return mUserActive
        End Get
        Set(ByVal value As Boolean)
            mUserActive = value
        End Set
    End Property
    '''<summary>
    ''' Returns the BuiltInRoleID from SQL table
    '''</summary>
    Public Property UserPasswordHash() As String
        Get
            Return mUserPasswordHash
        End Get
        Set(ByVal value As String)
            mUserPasswordHash = value
        End Set
    End Property
    '''<summary>
    ''' Returns the string Password before Hashed
    '''</summary>
    Public Property UserPasswordString() As String
        Get
            Return mUserPasswordString
        End Get
        Set(ByVal value As String)
            mUserPasswordString = value
        End Set
    End Property
    ''' <summary>
    ''' The UserID from SQL table
    ''' </summary>
    ''' <value></value>
    ''' <returns>Long UserID</returns>
    ''' <remarks></remarks>
    Public Property UserId() As Long
        Get
            Return mUserId
        End Get
        Set(ByVal value As Long)
            mUserId = value
        End Set
    End Property
    ''' <summary>
    ''' Interface Name from IIdentity
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Name() As String _
        Implements Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property
    ''' <summary>
    ''' The ApplicationsServices.BuiltInRole of person signed on
    ''' </summary>
    ''' <value></value>
    ''' <returns>Enum value of ApplicationsServices.BuiltInRole</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property
    ''' <summary>
    ''' Name of DSN needed for Crystal Reports
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DsnNameKey() As Integer
        Get
            Return mDsnNameKey
        End Get
        Set(ByVal value As Integer)
            mDsnNameKey = value
        End Set
    End Property
    ''' <summary>
    ''' The date the DSN needed for Crystal was loaded
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DsnDateLoaded() As Date
        Get
            Return mDsnDateLoaded
        End Get
        Set(ByVal value As Date)
            mDsnDateLoaded = value
        End Set
    End Property

    ''' <summary>
    ''' Calls stored Proc in SQL database to fill User object with
    ''' data from table Users.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="userID"></param>
    ''' <returns>True if call returns data, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function GetUserData(ByVal userName As String, _
                                ByVal userId As Long) As Boolean

        ' Dim sqlCon As New SqlConnection(Mine.ConnString.SEPFConnection)
        ' Dim cmd As New SqlCommand("UserGetData", sqlCon)
        Dim reader As SqlDataReader = Nothing
        Dim parmName As New SqlParameter
        Dim parmID As New SqlParameter


        Try

            If String.IsNullOrEmpty(userName) Then
                userName = String.Empty
            End If

            Using sqlCon As New SqlConnection(Mine.ConnString.SepfConnection)
                Using cmd As New SqlCommand("UserGetData", sqlCon)
                    cmd.CommandType = CommandType.StoredProcedure
                    parmName = cmd.Parameters.Add("@userName", SqlDbType.VarChar, 20)
                    parmID = cmd.Parameters.Add("@UserID", SqlDbType.Int)
                    parmName.Value = userName
                    parmID.Value = userId

                    sqlCon.Open()
                    reader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        Me.UserId = reader.GetInt32(0)

                        Me.UserName = reader.GetString(1)
                        Me.UserPasswordHash = reader.GetString(2)
                        Me.BuiltInRoleId = reader.GetInt32(3)
                        Me.UserActive = reader.GetBoolean(4)

                        Me.DsnNameKey = reader.GetInt32(5)
                        If reader.IsDBNull(6) Then
                            Me.DsnDateLoaded = Date.MinValue
                        Else
                            Me.DsnDateLoaded = reader.GetDateTime(6)
                        End If
                        User.CustomRoleId = reader.GetInt32(7)
                        Me.UserPasswordString = ""
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            Throw
        Finally

            If Not (reader Is Nothing) Then
                reader.Close()
            End If

        End Try
    End Function
    'Private Function SetBuiltInRole(ByVal roleToSet As Integer) As ApplicationServices.BuiltInRole
    '    Try
    '        Select Case roleToSet
    '            Case Is = ApplicationServices.BuiltInRole.AccountOperator '548
    '                Return ApplicationServices.BuiltInRole.AccountOperator
    '            Case Is = ApplicationServices.BuiltInRole.Administrator '544
    '                Return ApplicationServices.BuiltInRole.Administrator
    '            Case Is = ApplicationServices.BuiltInRole.BackupOperator '551
    '                Return ApplicationServices.BuiltInRole.BackupOperator
    '            Case Is = ApplicationServices.BuiltInRole.Guest '546
    '                Return ApplicationServices.BuiltInRole.Guest
    '            Case Is = ApplicationServices.BuiltInRole.PowerUser '547
    '                Return ApplicationServices.BuiltInRole.PowerUser
    '            Case Is = ApplicationServices.BuiltInRole.PrintOperator '550
    '                Return ApplicationServices.BuiltInRole.PrintOperator
    '            Case Is = ApplicationServices.BuiltInRole.Replicator '552
    '                Return ApplicationServices.BuiltInRole.Replicator
    '            Case Is = ApplicationServices.BuiltInRole.SystemOperator '549
    '                Return ApplicationServices.BuiltInRole.SystemOperator
    '            Case Is = ApplicationServices.BuiltInRole.User '545
    '                Return ApplicationServices.BuiltInRole.User
    '            Case Else
    '                Return ApplicationServices.BuiltInRole.Guest
    '        End Select
    '    Catch ex As Exception
    '        Return ApplicationServices.BuiltInRole.Guest
    '    End Try
    'End Function
    ''' <summary>
    ''' Determines, on logon, if userName and password
    ''' are valid, and user is active.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="passWord"></param>
    ''' <returns>True if good user, False otherwise</returns>
    ''' <remarks></remarks>
    Private Function ValidUser(ByVal userName As String, _
                                Optional ByVal passWord As String = "") As Boolean

        'Dim sqlCon As New SqlConnection(Mine.ConnString.SEPFConnection)
        '  Dim cmd As New SqlCommand("UserLookupByName", sqlCon)
        Dim parm As New SqlParameter
        Dim reader As SqlDataReader = Nothing
        Dim dbPasswordHash As String
        Dim salt As String
        Dim PasswordAndSalt As String

        Try
            Using sqlCon As New SqlConnection(Mine.ConnString.SepfConnection)
                Using cmd As New SqlCommand("UserLookupByName", sqlCon)
                    cmd.CommandType = CommandType.StoredProcedure
                    parm = cmd.Parameters.Add("@userName", SqlDbType.VarChar, 20)
                    parm.Value = userName

                    sqlCon.Open()
                    'read this
                    reader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()

                        '0 UserID,
                        '1 UserPasswordHash, 
                        '2 BuiltInRoleID, 
                        '3 UserActive,
                        '4 DSNnameKey,
                        '5 DSNdateLoaded
                        '6 CustomRoleId
                        Me.UserId = System.Convert.ToInt32(reader.GetValue(0))
                        User.GlobalUserId = Me.UserId
                        dbPasswordHash = reader.GetString(1)

                        Me.mDsnNameKey = reader.GetInt32(4)
                        If reader.IsDBNull(5) Then
                            Me.mDsnDateLoaded = Date.MinValue
                        Else
                            Me.mDsnDateLoaded = reader.GetDateTime(5)
                        End If
                        User.CustomRoleId = reader.GetInt32(6)


                        salt = dbPasswordHash.Substring(dbPasswordHash.Length - 8)


                        PasswordAndSalt = String.Concat(Me.CreatePasswordHash(passWord), salt)

                        If PasswordAndSalt.Equals(dbPasswordHash) Then

                            Dim ix As Integer = System.Convert.ToInt32(reader.GetValue(2))


                            If System.Enum.IsDefined(GetType(ApplicationServices.BuiltInRole), ix) Then
                                roleValue = DirectCast(ix, ApplicationServices.BuiltInRole)
                                'roleValue = Me.SetBuiltInRole(ix)

                                authenticatedValue = True
                                nameValue = userName
                                Return True
                            Else
                                Return False
                                roleValue = ApplicationServices.BuiltInRole.User
                                nameValue = userName
                            End If

                        Else
                            authenticatedValue = False
                            roleValue = ApplicationServices.BuiltInRole.User
                            nameValue = userName
                            Return False
                        End If
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception

            Throw
        Finally
            If Not (reader Is Nothing) Then
                reader.Close()
            End If
            'If sqlCon.State = ConnectionState.Open Then
            '    sqlCon.Close()
            'End If
        End Try
    End Function
    ''' <summary>
    ''' Makes a password from the password and salt word
    ''' </summary>
    ''' <param name="passWord"></param>
    ''' <returns>String, hashed password or Empty string on error</returns>
    ''' <remarks></remarks>
    Public Function MakePassword(ByVal password As String) As String
        Try
            Dim salt As String

            salt = Me.CreateSalt(5)

            Return String.Concat(Me.CreatePasswordHash(password), salt)

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
    ''' <summary>
    ''' Creates a string value hased password
    ''' </summary>
    ''' <param name="passWord"></param>
    ''' <returns> String, hashed password. On error empty string
    '''</returns>
    ''' <remarks></remarks>
    Private Function CreatePasswordHash(ByVal passWord As String) As String
        Dim SHhash As New SHA1Managed()
        Try

            Dim HashValue() As Byte
            Dim UE As New UnicodeEncoding()
            Dim MessageBytes As Byte() = UE.GetBytes(passWord)
            ' Dim SHhash As New SHA1Managed()

            HashValue = SHhash.ComputeHash(MessageBytes)


            Return Convert.ToBase64String(HashValue)

        Catch ex As Exception
            Return String.Empty
        Finally
            SHhash.Dispose()
        End Try

    End Function
    ''' <summary>
    ''' Creates "salted" hash value to use in making the password
    ''' </summary>
    ''' <param name="size"></param>
    ''' <returns>String, hashed value, or Empty string on error</returns>
    ''' <remarks></remarks>
    Private Function CreateSalt(ByVal size As Integer) As String

        Try

            Dim buff(size) As Byte
            'Dim rng As New RNGCryptoServiceProvider
            Using rng As New RNGCryptoServiceProvider
                rng.GetBytes(buff)
            End Using
            Return Convert.ToBase64String(buff)

        Catch ex As Exception
            Return String.Empty
        End Try

    End Function
    ''' <summary>
    ''' Adds new record to table Users
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="password"></param>
    ''' <param name="securityLevel"></param>
    ''' <returns>True if record added, False otherwise</returns>
    ''' <remarks>
    ''' Author: Andy Klages
    ''' Date: 01/10/2008
    ''' Updates: 
    ''' </remarks>
    Public Function SaveNewUser(ByVal userName As String, _
                             ByVal password As String, _
                             ByVal securityLevel As Integer) As Boolean

        ' Dim sqlCon As New SqlConnection(Mine.ConnString.SEPFConnection)
        'Dim cmd As New SqlCommand("UserSaveNew", sqlCon)
        Dim parmUserName As New SqlParameter
        Dim parmpasswordHash As New SqlParameter
        Dim parmsecurityLevel As New SqlParameter

        Try
            Using sqlCon As New SqlConnection(Mine.ConnString.SepfConnection)
                Using cmd As New SqlCommand("UserSaveNew", sqlCon)
                    cmd.CommandType = CommandType.StoredProcedure
                    parmUserName = cmd.Parameters.Add("@userName", SqlDbType.VarChar, 20)
                    parmpasswordHash = cmd.Parameters.Add("@passwordHash", SqlDbType.VarChar, 40)
                    parmsecurityLevel = cmd.Parameters.Add("@builtInRoleID", SqlDbType.Int, 8)

                    parmUserName.Value = userName.ToUpper
                    parmpasswordHash.Value = Me.MakePassword(password)
                    parmsecurityLevel.Value = securityLevel

                    sqlCon.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            SaveNewUser = True

        Catch e As Exception

            SaveNewUser = False

        End Try
    End Function
    Public Function SaveEdit(ByVal userId As Long, _
                             ByVal password As String, _
                             ByVal securityLevel As Integer, _
                             ByVal userActive As Boolean) As Boolean

        'Dim sqlCon As New SqlConnection(Mine.ConnString.SEPFConnection)
        '  Dim cmd As New SqlCommand("UserSaveEdit", sqlCon)
        Dim parmUserID As New SqlParameter
        Dim parmpasswordHash As New SqlParameter
        Dim parmsecurityLevel As New SqlParameter
        Dim parmUserActive As New SqlParameter

        Try
            Using sqlCon As New SqlConnection(Mine.ConnString.SepfConnection)
                Using cmd As New SqlCommand("UserSaveEdit", sqlCon)
                    cmd.CommandType = CommandType.StoredProcedure
                    parmUserID = cmd.Parameters.Add("@userID", SqlDbType.Int)
                    parmpasswordHash = cmd.Parameters.Add("@passwordHash", SqlDbType.VarChar, 40)
                    parmsecurityLevel = cmd.Parameters.Add("@builtInRoleID", SqlDbType.Int, 8)
                    parmUserActive = cmd.Parameters.Add("@UserActive", SqlDbType.Bit, 1)

                    parmUserID.Value = userId

                    '  If password.Equals(String.Empty) Then
                    If String.IsNullOrEmpty(password) Then
                        parmpasswordHash.Value = String.Empty
                    Else
                        parmpasswordHash.Value = Me.MakePassword(password)
                    End If
                    parmsecurityLevel.Value = securityLevel
                    parmUserActive.Value = userActive


                    sqlCon.Open()


                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
            'Finally
            '    If sqlCon.State = ConnectionState.Open Then
            '        sqlCon.Close()
            '    End If
        End Try

    End Function
    ''' <summary>
    ''' Fills an UNBOUND DataGridView with User info
    ''' </summary>
    ''' <param name="dataViewToUse"></param>
    ''' <returns>True if no errors filling, False otherwise.</returns>
    ''' <remarks></remarks>
    Public Function FillDataViewWithUsers(ByVal dataViewToUse As DataGridView) As Boolean


        'Dim sqlCon As New SqlConnection(Mine.ConnString.SEPFConnection)
        'Dim cmd As New SqlCommand("UserGetList", sqlCon)
        Dim reader As SqlDataReader = Nothing
        Dim intCol As Integer



        Try
            Using sqlCon As New SqlConnection(Mine.ConnString.SepfConnection)
                Using cmd As New SqlCommand("UserGetList", sqlCon)
                    cmd.CommandType = CommandType.StoredProcedure
                    sqlCon.Open()
                    reader = cmd.ExecuteReader
                    dataViewToUse.Rows.Clear()
                    If reader.HasRows Then
                        'column width
                        dataViewToUse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                        dataViewToUse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                        'add columns and Column name for each field in reader
                        dataViewToUse.Columns.Clear()


                        For intCol = 0 To reader.FieldCount - 1
                            dataViewToUse.Columns.Add(reader.GetName(intCol), reader.GetName(intCol))

                            Select Case intCol
                                Case Is = 0, 4
                                    dataViewToUse.Columns(intCol).FillWeight = 12.0!
                                Case Is = 1, 3
                                    dataViewToUse.Columns(intCol).FillWeight = 21.0!
                                Case Is = 2
                                    dataViewToUse.Columns(intCol).FillWeight = 40.0!
                                Case Else
                                    dataViewToUse.Columns(intCol).FillWeight = 0.5!
                            End Select
                        Next



                        'fill with data
                        While reader.Read
                            Dim oCells(intCol) As Object
                            reader.GetValues(oCells)
                            dataViewToUse.Rows.Add(oCells)
                        End While
                        ' reader.Close()
                    Else
                        Return False
                    End If
                End Using
            End Using

            Return True
        Catch e As Exception

            Return False
        Finally
            If Not (reader Is Nothing) Then
                reader.Close()
            End If
            'If sqlCon.State = ConnectionState.Open Then
            '    sqlCon.Close()
            'End If
        End Try
    End Function
    Public Function RemoveItemBuiltInRollComboBox(ByVal comboBoxToUse As ComboBox, _
                                                     ByVal itemToRemove As String) As Boolean
        comboBoxToUse.Items.Remove(itemToRemove)
        Return True
    End Function
    Public Sub SetIndexOnBuiltInRollComboBox(ByVal comboBoxToUse As ComboBox,
                                              ByVal BuiltInRoleId As Long)

        If comboBoxToUse Is Nothing Then
            Throw New ArgumentNullException("comboBoxToUse")
        End If
        Try


            comboBoxToUse.SelectedIndex =
                        comboBoxToUse.FindString([Enum].GetName(GetType(ApplicationServices.BuiltInRole),
                        BuiltInRoleId))
        Catch ex As Exception
            Throw
        End Try


    End Sub
    Public Function FillBuiltInRollComboBox(ByVal comboBoxToUse As ComboBox) As Boolean
        Try
            If comboBoxToUse Is Nothing Then
                Throw New ArgumentNullException("comboBoxToUse")
            End If

            comboBoxToUse.Sorted = True
            comboBoxToUse.DropDownStyle = ComboBoxStyle.DropDownList
            comboBoxToUse.Items.AddRange([Enum].GetNames(GetType(ApplicationServices.BuiltInRole)))

            'set the default to "User"
            comboBoxToUse.SelectedIndex = _
                comboBoxToUse.FindString([Enum].GetName(GetType(ApplicationServices.BuiltInRole), _
                ApplicationServices.BuiltInRole.User))

            Return True

        Catch e As Exception

            Throw

        End Try
    End Function
    ''' <summary>
    ''' When passed ComboBox filled with string values of enum ApplicationServices.BuiltInRole, will return
    ''' the integer representation of the string value, or -1 if no selection in Combo Box is made.
    ''' </summary>
    ''' <param name="comboBoxToUse"></param>
    ''' <returns>Integer</returns>
    ''' <remarks>Author: Andy Klages
    '''          Date: 01/10/2008
    '''          Updates:
    ''' </remarks>
    Public Function GetBuiltInRollComboBoxItemSelected(ByVal comboBoxToUse As ComboBox) As Integer
        'A value of negative one (-1) is returned if no item is selected. 
        Try
            If comboBoxToUse.SelectedIndex.Equals(-1) Then
                RaiseEvent NoComboBoxSelectionMade(comboBoxToUse, -1, "No Role Selected")
                Return -1
            Else
                'Return System.Enum.Parse(enumTypeRole, cbo.SelectedItem.ToString)
                Return System.Convert.ToInt32([Enum].Parse(GetType(ApplicationServices.BuiltInRole), comboBoxToUse.SelectedItem.ToString))
            End If
        Catch e As Exception

            Return -1
        End Try
    End Function
    ''' <summary>
    ''' Clears out data retreived with GetUserData function
    ''' </summary>
    ''' <returns>True if success, False otherwise</returns>
    ''' <remarks>
    ''' Author: Andy Klages
    ''' Date: 01/10/2008
    ''' Updates:
    '''</remarks>
    Public Function Clear() As Boolean
        Try
            mUserName = String.Empty
            mUserPasswordHash = String.Empty
            mUserPasswordString = String.Empty
            mBuiltInRoleId = 0
            mUserActive = False
            mUserId = 0
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Gets the value of the first column in a DataGridView
    ''' that has  Multiple selection set to false, because this
    ''' only reads one row.
    ''' </summary>
    ''' <returns> Long value of first column, or -1 on error
    ''' </returns>
    ''' <remarks>
    ''' Author: Andy Klages
    ''' Date: 01/10/2008
    ''' Updates:
    ''' </remarks>
    Public Function GetUserIdFromDataGridView(ByVal dataViewToUse As DataGridView) As Long
        Try
            Dim iRows As Integer
            iRows = dataViewToUse.SelectedRows.Count

            If iRows = 0 Then
                Return -1
            Else
                Dim i As Integer
                Dim idx As Integer

                For i = 0 To iRows - 1
                    idx = dataViewToUse.SelectedRows(i).Index
                Next
                Return System.Convert.ToInt32(dataViewToUse.Item(0, idx).Value)
            End If
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Public Shared Sub UpdateDsnDate(ByVal userId As Long, _
                              ByVal dsnNameKey As Integer, _
                              ByVal dateUse As Date)

        ' Dim sqlCon As New SqlConnection(Mine.ConnString.SEPFConnection)
        ' Dim cmd As New SqlCommand("UserUpdateDSNdate", sqlCon)
        Dim parmUserID As New SqlParameter
        Dim parmDSNnameKey As New SqlParameter
        Dim parmDate As New SqlParameter

        Try
            Using sqlCon As New SqlConnection(Mine.ConnString.SepfConnection)
                Using cmd As New SqlCommand("UserUpdateDSNdate", sqlCon)
                    cmd.CommandType = CommandType.StoredProcedure
                    parmUserID = cmd.Parameters.Add("@userID", SqlDbType.Int)
                    parmDSNnameKey = cmd.Parameters.Add("@DSNnameKey", SqlDbType.Int)
                    parmDate = cmd.Parameters.Add("@date", SqlDbType.DateTime)
                    parmUserID.Value = userId
                    parmDSNnameKey.Value = dsnNameKey

                    If Not dateUse.Equals(Date.MinValue) Then
                        parmDate.Value = dateUse
                    End If

                    sqlCon.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Finally
            '    If sqlCon.State = ConnectionState.Open Then
            '        sqlCon.Close()
            '    End If
        End Try

    End Sub
    ''' <summary>
    ''' Returns long value that is the highest square of the supplied base that
    ''' is less than the base.  For example, if value = 14 and base = 2 we want the
    ''' highest square of 2 that is not over 14.  In this case it would be 2^3 which 
    ''' would return 8.  the next square, 2^4 is 16, and it is over 14.
    ''' </summary>
    ''' <param name="value">the number we use as value to check squares against</param>
    ''' <param name="base">the base number to square</param>
    ''' <returns>long value</returns>
    ''' <author>Andy Klages</author>
    ''' <created>12/03/2010</created>
    ''' <history></history>
    Private Shared Function HighestSquareNotOverValue(ByVal value As Long, _
                                                       ByVal base As Double) As Long

        Try
            Dim square As Double = 0.0

            For i As Integer = 0 To CInt(value)
                square = Math.Pow(base, i)
                If square > value Then
                    'return the previous square, since we
                    'are now over
                    Return CLng(Math.Pow(base, i - 1))
                End If
            Next

            Return CLng(square)

        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' Determines if user is allowed into a system.
    ''' The systems have values of the squares of 2; 0,2,4,8,16,32,64,etc.
    ''' The users have as customRoleId a sum of the squares they are allowed into.
    ''' For example, a user with 14 would be allowed into 2,4 and 8 (2+4+8=14)
    ''' Will first fill an array with possible systems user is allowed into and then
    ''' see if the systemId requested is in the list of possibles.  If so, returns
    ''' true, else returns false.
    ''' To get into all excpet meeting stuff = 162, else 226
    ''' </summary>
    ''' <param name="customRoleId">Sum of systems user is allowed into</param>
    ''' <param name="systemId">the square of 2 that is system id</param>
    ''' <returns>True if user can get into system, false otherwise</returns>
    ''' <author>Andy Klages</author>
    ''' <created>12/03/2010</created>
    ''' <history></history>
    Public Shared Function AllowedIntoSystem(ByVal customRoleId As Long, _
                                             ByVal systemId As UserSecurityLevels) As Boolean

        Try

            'convert the enum to a long value
            Dim systemIdx As Long = _
               CLng(System.Enum.Parse(GetType(UserSecurityLevels), systemId.ToString(), True))

            'do some early out checking....
            If customRoleId = BACenums.UserEnums.UserSecurityLevels.None Then
                Return False
            End If
            If customRoleId = systemIdx Then
                Return True
            End If
            If customRoleId < systemIdx Then
                Return False
            End If


            '  Dim returnVal As Boolean = False

            Dim possible(0) As Long
            Dim newCustomRoleId As Long = customRoleId
            Dim highSquare As Long = 0
            Dim i As Integer = 0
            Dim returnValue As Boolean = False

            Do While newCustomRoleId > 0

                'find highest square of 2 less than value of newCustomRoleId
                highSquare = HighestSquareNotOverValue(newCustomRoleId, 2)
                'get new total for next check
                newCustomRoleId = newCustomRoleId - highSquare
                'store the highSquare in array to check later
                If i > 0 Then
                    ReDim Preserve possible(i)
                End If
                possible(i) = CLng(highSquare)

                If highSquare = systemIdx Then
                    returnValue = True
                    Exit Do
                End If

                i = i + 1

                'in case we get going somehow, lets get out
                If i > 100 Then
                    Exit Do
                End If
            Loop


            'Dim index As Integer = Array.IndexOf(possible, systemIdx)

            'If index = -1 Then
            '    returnValue = False
            'Else
            '    returnValue = True
            'End If

            Return returnValue


        Catch ex As Exception
            Throw
        End Try
    End Function
End Class


