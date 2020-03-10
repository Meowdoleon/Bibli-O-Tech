Public Class Utilisateur
    Protected ReadOnly Property User As String = String.Empty
    Protected ReadOnly Property Pass As String = String.Empty
    Protected ReadOnly Property UserDB As New UtilisateursBD()
    Protected ReadOnly Property UserLst As List(Of String) = UserDB.Users
    ReadOnly Property IsAdmin As Boolean = False
    Private ReadOnly Property PassLst As List(Of String) = UserDB.Pass

    Public Sub New()

    End Sub

    Public Sub New(userConnect, passConnect)
        _User = userConnect
        _Pass = passConnect
    End Sub

    Protected Sub Connect(userConnect, passConnect)
        For Each usr In UserLst
            If usr.Equals(userConnect) Then
                If passConnect.Equals(PassLst.ElementAt(UserLst.IndexOf(userConnect))) Then
                    _User = userConnect
                    _Pass = passConnect
                End If
            End If
        Next
    End Sub
End Class