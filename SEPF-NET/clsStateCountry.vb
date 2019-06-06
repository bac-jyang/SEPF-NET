Imports System.Data.SqlClient
Imports BAC.Controls
Imports BAC.Controls.BacEditForm.EflFormControls

Public Class StateCountry
    Private mStCntry_StateCountryId As Integer
    Private mStCntry_CountryCode As Integer
    Private mStCntry_CountryName As String
    Private mStCntry_StateAbbreviation As String
    Private mStCntry_StateName As String
    Private ReadOnly mStoredProcedureName As String

    Public Sub New()
        mStoredProcedureName = "FillStateCountryClass"
    End Sub

    Public ReadOnly Property StateCountryId As Integer
        Get
            Return mStCntry_StateCountryId
        End Get
    End Property
    Public ReadOnly Property StoredProcedureName As String
        Get
            Return mStoredProcedureName
        End Get
    End Property

    Public Property CountryCode As Integer
        Get
            Return mStCntry_CountryCode
        End Get
        Set(value As Integer)
            mStCntry_CountryCode = value
        End Set
    End Property
    Public Property CountryName As String
        Get
            Return mStCntry_CountryName
        End Get
        Set(value As String)
            mStCntry_CountryName = value
        End Set
    End Property
    Public Property StateAbbreviation As String
        Get
            Return mStCntry_StateAbbreviation
        End Get
        Set(value As String)
            mStCntry_StateAbbreviation = value
        End Set
    End Property
    Public Property StateName As String
        Get
            Return mStCntry_StateName
        End Get
        Set(value As String)
            mStCntry_StateName = value
        End Set
    End Property
    Public ReadOnly Property Display As String
        Get
            If String.IsNullOrEmpty(mStCntry_StateAbbreviation) Then
                If String.IsNullOrEmpty(mStCntry_CountryName) Then
                    Return String.Empty
                Else
                    Return "FOR - " & mStCntry_CountryName
                End If

            Else
                Return mStCntry_StateAbbreviation & " - " & mStCntry_StateName

            End If

        End Get
    End Property

    Public Sub FillListOfStateCountry(combo As BacEflComboBox)

        If combo Is Nothing Then
            Throw New ArgumentNullException(NameOf(combo))
        End If

        Try

            Dim reader As SqlDataReader = Nothing

            Try
                Using sqlcon As New SqlConnection(Mine.ConnString.SEPFConnection)
                    Using cmd As New SqlCommand '(strStoreProcName, sqlcon)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = mStoredProcedureName
                        cmd.Connection = sqlcon
                        sqlcon.Open()

                        reader = cmd.ExecuteReader

                        If reader.HasRows Then
                            Dim p As New List(Of StateCountry)

                            Do While reader.Read

                                Dim countryData As New StateCountry

                                With countryData
                                    .mStCntry_StateCountryId = reader.GetInt32(0)
                                    .mStCntry_CountryCode = reader.GetInt32(1)
                                    .mStCntry_CountryName = reader.GetString(2)
                                    .mStCntry_StateAbbreviation = reader.GetString(3)
                                    .mStCntry_StateName = reader.GetString(4)
                                End With

                                p.Add(countryData)

                            Loop

                            If combo.ShowBlankLine = True Then
                                Dim blankCountry As New StateCountry
                                With blankCountry
                                    .mStCntry_StateCountryId = -1
                                    .mStCntry_CountryCode = -1
                                    .mStCntry_CountryName = String.Empty
                                    .mStCntry_StateAbbreviation = String.Empty
                                    .mStCntry_StateName = String.Empty
                                End With
                                p.Add(blankCountry)
                            End If

                            combo.DisplayMember = "Display"
                            combo.ValueMember = "StateAbbreviation"
                            combo.DataSource = New BindingSource(p, Nothing)
                            If combo.ShowBlankLine = True Then
                                combo.SelectedIndex = -1
                            End If

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

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub FillListOfStateCountry(combo As bacQbeCombo)

        If combo Is Nothing Then
            Throw New ArgumentNullException(NameOf(combo))
        End If

        Try

            Dim reader As SqlDataReader = Nothing

            Try
                Using sqlcon As New SqlConnection(Mine.ConnString.SEPFConnection)
                    Using cmd As New SqlCommand '(strStoreProcName, sqlcon)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = mStoredProcedureName
                        cmd.Connection = sqlcon
                        sqlcon.Open()

                        reader = cmd.ExecuteReader

                        If reader.HasRows Then
                            Dim p As New List(Of StateCountry)

                            Do While reader.Read

                                Dim countryData As New StateCountry

                                With countryData
                                    .mStCntry_StateCountryId = reader.GetInt32(0)
                                    .mStCntry_CountryCode = reader.GetInt32(1)
                                    .mStCntry_CountryName = reader.GetString(2)
                                    .mStCntry_StateAbbreviation = reader.GetString(3)
                                    .mStCntry_StateName = reader.GetString(4)
                                End With

                                p.Add(countryData)

                            Loop

                            If combo.ShowBlankLine = True Then
                                Dim blankCountry As New StateCountry
                                With blankCountry
                                    .mStCntry_StateCountryId = -1
                                    .mStCntry_CountryCode = -1
                                    .mStCntry_CountryName = String.Empty
                                    .mStCntry_StateAbbreviation = String.Empty
                                    .mStCntry_StateName = String.Empty
                                End With
                                p.Add(blankCountry)
                            End If

                            combo.DisplayMember = "Display"
                            combo.ValueMember = "StateAbbreviation"
                            combo.DataSource = New BindingSource(p, Nothing)
                            If combo.ShowBlankLine = True Then
                                combo.SelectedIndex = -1
                            End If
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

        Catch ex As Exception
            Throw
        End Try
    End Sub



End Class
