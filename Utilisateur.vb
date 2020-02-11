Public Class Utilisateur
    Private ReadOnly Property User As String = String.Empty
    Private ReadOnly Property Pass As String = String.Empty
    Private ReadOnly Property UserDB As New UtilisateursBD()
    Private ReadOnly Property UserLst As List(Of String) = UserDB.Users
    Private ReadOnly Property PassLst As List(Of String) = UserDB.Pass

    Public Sub New(user As String, pass As String)
        Connect(user, pass)
    End Sub

    Public Function IsAdmin() As Boolean
        If User.Equals("Admin") AndAlso Pass.Equals("Sp33n my grand-dad") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Connect(user, pass)
        For Each client In UserLst
            If user.Equals(client) Then
                If pass.Equals(PassLst.IndexOf(client)) Then
                    _User = user
                End If
            ElseIf user.Equals("Admin") AndAlso pass.Equals("Sp33n my grand-dad") Then
                _User = "Admin"
                _Pass = "Sp33n my grand-dad"
            End If
        Next
    End Sub
End Class