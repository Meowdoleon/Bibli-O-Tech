Public Class Client
    Inherits Utilisateur
    ReadOnly Property Nom As String 'Nom du client
    ReadOnly Property TelephoneNum As String 'Le num�ro de t�l�phone du client
    ReadOnly Property Courriel As String 'le couriel du client

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
            Throw New UnauthorizedAccessException("Cr�dentiels Erron�s")
        End If
    End Sub

    ''' <summary>
    ''' R�serve un document pour le client si celui si n'est pas d�ja r�serv�
    ''' </summary>
    ''' <param name="docTitre"> Le titre du document � r�server </param>
    Public Sub ReserverSwitchDoc(docTitre As String)
        Dim docs As New DocumentBD
        Dim index As Integer = docs.Titre.IndexOf(docTitre)
        Dim notBool As Boolean = Not docs.Reserve.ElementAt(index)

        For Each doc In docs.Titre
            If doc.Equals(docTitre) Then
                docs.Reserve.Remove(docs.Reserve.ElementAt(index))
                docs.Reserve.Insert(index, notBool)
            End If
        Next
    End Sub

    Public Sub Renouveller()

    End Sub
End Class