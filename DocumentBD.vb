Public Class DocumentBD
    Property Titre As New List(Of String) 'liste de titre de tout les documents
    Property Auteur As New List(Of String) 'liste de tout les auteurs des documents
    Property Type As New List(Of String) 'liste de tout les types des documents 
    Property Reserve As New List(Of Boolean) 'liste des �tats d'emprunt de tout les documents
    Property TempsDemprunt As New List(Of Short) 'liste des dur�es d'emprunt de tout les documents

    Public Sub New()
        Titre.Add("Elle meurt � la fin")
        Auteur.Add("Sylvie B�rard, Brigitte Caron")
        Type.Add("Livre")
        Reserve.Add(False)
        TempsDemprunt.Add(2)
    End Sub

    Public Sub New(AAAA As Integer)
        Titre.Add("MLP: Battle for Ponyland")
        Auteur.Add("Fr�d�ric Molas, S�bastien Rassiat")
        Type.Add("Film")
        Reserve.Add(True)
        TempsDemprunt.Add(5)
    End Sub
End Class