Public Class Utilisateur
    Private ReadOnly Property User As String
    Private ReadOnly Property Pass As String
    Private ReadOnly Property UserDB As New UtilisateursBD()
    Private ReadOnly Property UserLst As List(Of String) = UserDB.Users
    Private ReadOnly Property PassLst As List(Of String) = UserDB.Pass

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
            ElseIf user.Equals("Admin") AndAlso Pass.Equals("Sp33n my grand-dad") Then
                _User = "Admin"
            End If
        Next
    End Sub
End Class