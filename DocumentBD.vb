Public Class DocumentBD
    Property Titre As New List(Of String)
    Property Auteur As New List(Of String)
    Property Type As New List(Of String)
    Property Reserve As New List(Of Boolean)
    Property TempsDemprunt As New List(Of Short)

    Public Sub New()
        Titre.Add("Elle meurt à la fin")
        Auteur.Add("Sylvie Bérard, Brigitte Caron")
        Type.Add("Livre")
        Reserve.Add(False)
        TempsDemprunt.Add(2)
    End Sub
End Class