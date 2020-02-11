Public Class Main
    Public Shared Sub Main()
        Dim DocBD As New DocumentBD()
        Dim UserBD As New UtilisateursBD()

        Dim validAdminUser As New Utilisateur("Admin", "Sp33n my grand-dad")
        MsgBox("validAdminUser has admin acess: " & validAdminUser.IsAdmin.ToString)

        Dim invalidAdminUsername As New Utilisateur("admin", "Sp33n my grand-dad")
        MsgBox("invalidAdminUsername has admin acess: " & invalidAdminUsername.IsAdmin.ToString)

        Dim invalidAdminPass As New Utilisateur("admin", "Speen my grand-dad")
        MsgBox("invalidAdminPass has admin acess: " & invalidAdminPass.IsAdmin.ToString)

        Dim ValidClient As New Utilisateur("xkcd", "asdf")
        MsgBox("validClient has admin acess: " & ValidClient.IsAdmin.ToString)
    End Sub

End Class