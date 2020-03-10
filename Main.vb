Imports System.Text
Imports System.IO

Public Class Main
    Public Shared Sub Main()
        Dim DocBD As New DocumentBD()
        Dim DocBDTestModify As New DocumentBD(69)
        Dim UserBD As New UtilisateursBD()

        Dim inputStream As Stream = Console.OpenStandardInput()
        Dim bytes(Byte.MaxValue) As Byte
        Dim chars As Char()

        Console.Write("Enter your username: ")
        chars = Encoding.UTF8.GetChars(bytes)
        Dim username = New String(chars)
        username = Console.ReadLine()

        Console.Write("Enter your password: ")
        chars = Encoding.UTF8.GetChars(bytes)
        Dim password = New String(chars)
        password = Console.ReadLine()

        If username.Equals("Admin") AndAlso password.Equals("Sp33n my grand-dad") Then
            Dim admin = New Admin()

            Console.WriteLine("Does the user have admin access? " & admin.IsAdmin)

            admin.ModifyDocuments(Of Integer)(DocBD, DocBDTestModify)

            For Each doc In DocBD.Titre
                Console.WriteLine(doc)
            Next

            Console.Write("Press enter to continue... ")
            Console.ReadLine()
        Else
            Dim client = New Client(username, password)

            Console.WriteLine("Does the user have admin access? " & client.IsAdmin)
            Console.WriteLine("Name of the user: " & client.Nom)
            Console.WriteLine(String.Empty)

            Dim docs As New DocumentBD()

            For Each doc In docs.Titre
                Console.WriteLine(doc)
                client.ReserverSwitchDoc(doc)
            Next

            For Each doc In docs.Reserve
                Console.WriteLine(doc)
            Next

            Console.Write("Press enter to continue... ")
            Console.ReadLine()
        End If
    End Sub

End Class