Public Class Utilisateur
    Private ReadOnly Property User As String
    Private ReadOnly Property Pass As String
    Private ReadOnly Property UserDB As New UtilisateurDB()
    Private ReadOnly Property UserLst As List(Of String)
    Private ReadOnly Property PassLst As List(Of String)

    Public Function IsAdmin() As Boolean
        If User.Equals("Admin") AndAlso Pass.Equals("Sp33n my grand-dad") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Connect(UserLst, PassLst)
        For Each client In UserLst

        Next
    End Sub
End Class