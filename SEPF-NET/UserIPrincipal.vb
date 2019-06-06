Public Class UserIPrincipal
    'Author: Andy Klages
    'Date: 01/09/2007
    'Used to allow filling of CurrentPrincipal and expose our
    'data to the My.User object
    'Example of use:
    'Dim oUser As New UserIPrincipal(userName, strPassWord)
    'My.User.CurrentPrincipal = oUser
    'Now My.User can be used throughout the program
    Implements Security.Principal.IPrincipal

   Private identityValue As User


    Public ReadOnly Property Identity() As Security.Principal.IIdentity Implements Security.Principal.IPrincipal.Identity
        Get
         Return identityValue
        End Get
    End Property
     
    Public Function IsInRole(ByVal role As String) As Boolean Implements Security.Principal.IPrincipal.IsInRole
        Return role = identityValue.Role.ToString
    End Function
   Public ReadOnly Property UserInfo() As User
      Get
         UserInfo = identityValue
      End Get

   End Property
    Public Sub New(ByVal userName As String, ByVal password As String)
        identityValue = New User(userName, password)

    End Sub
   
End Class
