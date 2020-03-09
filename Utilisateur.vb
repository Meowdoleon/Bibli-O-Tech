Public Class Utilisateur
    Public Property username As String
    Public Property pass As String
    Public Property IsAdmin As Boolean

    Public Sub New (username As String, pass As String, admin As Boolean)
        Me.username = username
        Me.pass = pass
        Me.IsAdmin = admin
    End Sub
End Class