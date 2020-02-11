Public Class UtilisateursBD
    Public ReadOnly Property Users As New List(Of String)
    Public ReadOnly Property Pass As New List(Of String)
    Public ReadOnly Property Nom As New List(Of String)
    Public ReadOnly Property TelephoneNum As New List(Of String)
    Public ReadOnly Property Courriel As New List(Of String)

    Public Sub New()
        Users.Add("xkcd")
        Users.Add("nurupo")

        Pass.Add("asdf")
        Pass.Add("Gah!")

        Nom.Add("Randall Tomska")
        Nom.Add("Hōhōin Kyōma")

        TelephoneNum.Add("444-444-4419")
        TelephoneNum.Add("624-808-6235")

        Courriel.Add("aaa@aaa.thats3as")
        Courriel.Add("Kurisu@waifu.club")
    End Sub
End Class