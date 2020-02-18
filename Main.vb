Imports System.Text
Imports System.IO

Public Class Main
    Public Shared Sub Main()
        Dim DocBD As New DocumentBD()
        Dim UserBD As New UtilisateursBD()

        Dim inputStream As Stream = Console.OpenStandardInput()
        Dim bytes(Byte.MaxValue) As Byte
        Dim chars As Char()
        Dim username As String
        Dim password As String

        Console.Write("Enter your username: ")
        chars = Encoding.UTF8.GetChars(bytes)
        username = New String(chars)
        username = Console.ReadLine()

        Console.Write("Enter your password: ")
        chars = Encoding.UTF8.GetChars(bytes)
        password = New String(chars)
        password = Console.ReadLine()

        If username.Equals("Admin") AndAlso password.Equals("Sp33n my grand-dad") Then
            Dim user = New Utilisateur(username, password)

            Console.WriteLine("Does the user have admin acces? " & user.IsAdmin)
            Console.Write("Press enter to continue... ")
            Console.ReadLine()
        Else
            Dim client = New Client(username, password)

            Console.WriteLine("Does the user have admin acces? " & client.IsAdmin)
            Console.WriteLine("Name of the user: " & client.Nom)
            Console.Write("Press enter to continue... ")
            Console.ReadLine()
        End If
    End Sub

End Class