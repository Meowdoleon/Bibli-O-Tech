Public Class UtilisateursBD
    Public ReadOnly Property Users As New List(Of String)
    Public ReadOnly Property Pass As New List(Of String)

    Public Sub New()
        Users.Add("xkcd")
        Users.Add("nuropo")

        Pass.Add("asdf")
        Pass.Add("Gah!")
    End Sub
End Class