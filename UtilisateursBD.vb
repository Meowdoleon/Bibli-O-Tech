Public Class UtilisateursBD
    Public ReadOnly Property Users As List(Of String)
    Public ReadOnly Property Pass As List(Of String)

    Public Sub New()
        _Users = {"xkcd", "nuropo"}
        _Pass = {"asdf", "Gah!"}
    End Sub
End Class