Public Class Main
    Public Shared Sub Main()
        Dim DocBD As New DocumentBD()
        Dim UserBD As New UtilisateursBD()

        Dim ValidClient As New Client("xkcd", "asdf")
        MsgBox("validClient has admin acess: " & ValidClient.IsAdmin.ToString _
               & vbCr & "validClient Name: " & ValidClient.Nom)

        Dim ValidClient2 As New Client("nurupo", "Gah!")
        MsgBox("validClient has admin acess: " & ValidClient2.IsAdmin.ToString _
               & vbCr & "validClient Name: " & ValidClient2.Nom)
    End Sub

End Class