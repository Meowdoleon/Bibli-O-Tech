Public Class UtilisateursBD
    Public Property utilisateurs As New List(Of Utilisateur)

    Public Sub Connect(userConnect, passConnect)
        For Each utilisateur In utilisateurs
            If utilisateur.Equals(userConnect) Then
                If passConnect.Equals(PassLst.ElementAt(UserLst.IndexOf(userConnect))) Then
                    _User = userConnect
                    _Pass = passConnect
                End If
            End If
        Next
    End Sub
End Class