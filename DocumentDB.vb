Public Class DocumentDB
    Property Titre As String
    Property Type As String
    Property Reserve As Boolean
    Property TempsDemprunt As Short
    Property TempsReserve As Short

    Public Sub New(titre As String, type As String, rsrv As Boolean, tEmprunt As Short, tRsrv As Short)
        Me.Titre = titre
        Me.Type = type
        Me.Reserve = rsrv
        Me.TempsDemprunt = tEmprunt
    End Sub
End Class