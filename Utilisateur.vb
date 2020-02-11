Public Class Utilisateur
    Protected ReadOnly Property User As String = String.Empty
    Protected ReadOnly Property Pass As String = String.Empty
    Protected ReadOnly Property UserDB As New UtilisateursBD()
    Protected ReadOnly Property UserLst As List(Of String) = UserDB.Users
    Private ReadOnly Property PassLst As List(Of String) = UserDB.Pass



    Public Sub New()

    End Sub

    Public Function IsAdmin() As Boolean
        If User.Equals("Admin") AndAlso Pass.Equals("Sp33n my grand-dad") Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Sub Connect(userConnect, passConnect)
        For Each usr In UserLst
            If usr.Equals(userConnect) Then
                If passConnect.Equals(PassLst.ElementAt(UserLst.IndexOf(userConnect))) Then
                    _User = userConnect
                    _Pass = passConnect
                End If
            ElseIf User.Equals("Admin") AndAlso Pass.Equals("Sp33n my grand-dad") Then
                _User = "Admin"
                _Pass = "Sp33n my grand-dad"
            End If
        Next
    End Sub
End Class