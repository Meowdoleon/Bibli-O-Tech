Imports System.Text
Imports System.IO

Public Class Main
    Public Shared Sub Main()
        Dim DocBD As New DocumentBD()
        Dim UserBD As New UtilisateursBD()

        Dim inputStream As Stream = Console.OpenStandardInput()
        Dim bytes(Integer.MaxValue) As Byte
        Dim chars As Char()
        Dim username As String
        Dim password As String

        Console.WriteLine("Enter your username: ")
        chars = Encoding.UTF8.GetChars(bytes)
        username = New String(chars)

        Console.WriteLine("Enter your password: ")
        chars = Encoding.UTF8.GetChars(bytes)
        password = New String(chars)

        If username.Equals("Admin") AndAlso password.Equals("Sp33n my grand-dad") Then
            Dim admin = New Admin()
        End If
    End Sub

End Class