Public Class Client
    Inherits Utilisateur
    ReadOnly Property Nom As String
    ReadOnly Property TelephoneNum As String
    ReadOnly Property Courriel As String

    Public Sub New(userConnect As String, passConnect As String)
        Connect(userConnect, passConnect)

        If User IsNot String.Empty Then
            For Each usr In UserLst
                If usr.Equals(User) Then
                    _Nom = UserDB.Nom.ElementAt(UserLst.IndexOf(User))
                    _TelephoneNum = UserDB.TelephoneNum.ElementAt(UserLst.IndexOf(User))
                    _Courriel = UserDB.Courriel.ElementAt(UserLst.IndexOf(User))
                End If
            Next

        Else
            Throw New UnauthorizedAccessException("Crédentiel Erroné")
        End If
    End Sub

    Private Sub ReserverDoc()

    End Sub

    Private Sub UnreserveDoc()

    End Sub

    Private Sub Renouveller()

    End Sub
End Class