Public Class Utilisateur
    Protected ReadOnly Property User As String = String.Empty 'Nom d'utilisateur du client
    Protected ReadOnly Property Pass As String = String.Empty 'Mot de passe de l'utilisateur
    Protected ReadOnly Property UserDB As New UtilisateursBD() 'La liste des utilisateurs de la base de données 
    Protected ReadOnly Property UserLst As List(Of String) = UserDB.Users 'la liste des noms d'utilisateurs
    ReadOnly Property IsAdmin As Boolean = False 'Boolean  qui détermine si l'utilisateur est un Admin
    Private ReadOnly Property PassLst As List(Of String) = UserDB.Pass 'La liste des mots de passe des Utilisateurs

    Public Sub New()

    End Sub

    Public Sub New(userConnect, passConnect)
        _User = userConnect
        _Pass = passConnect
    End Sub

    ''' <summary>
    ''' Connecte l'utilisateur correspondant au userConnect et passConnect à la base de données
    ''' </summary>
    ''' <param name="userConnect"> Le nom d'utilisateur </param>
    ''' <param name="passConnect"> Le mot de passe </param>
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