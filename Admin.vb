Imports System.Text
Imports System.IO

Public Class Admin
    Inherits Utilisateur

    Overloads ReadOnly Property IsAdmin As Boolean
    Private ReadOnly Property Docs As New DocumentBD

    Public Sub New()
        _IsAdmin = True
    End Sub

    Public Sub New(userConnect As String, passConnect As String)
        Try
            Connect(userConnect, passConnect)
            _IsAdmin = True
        Catch wrongLogin As UnauthorizedAccessException
            Console.WriteLine("Crédentiels erronés")
        End Try
    End Sub

    Public Sub AddDocument(docBD As DocumentBD)
        AddDoc(docBD.Titre)
        AddDoc(docBD.Auteur)
        AddDoc(docBD.Type)
        AddDoc(docBD.Reserve)
        AddDoc(docBD.TempsDemprunt)
    End Sub

    Private Sub AddDoc(Of T)(docListToAdd As List(Of T))
        For i = 0 To docListToAdd.Count - 1
            docListToAdd.Remove(docListToAdd.ElementAt(i))
        Next
    End Sub

    Public Sub DeleteDocument(docBD As DocumentBD)
        DeleteDoc(docBD.Titre)
        DeleteDoc(docBD.Auteur)
        DeleteDoc(docBD.Type)
        DeleteDoc(docBD.Reserve)
        DeleteDoc(docBD.TempsDemprunt)
    End Sub

    Private Sub DeleteDoc(Of T)(docListToDelete As List(Of T))
        For i = 0 To docListToDelete.Count - 1
            docListToDelete.Remove(docListToDelete.ElementAt(i))
        Next
    End Sub

    Public Sub ModifyDocuments(Of ID)(docBDToModify As DocumentBD, docBDModified As DocumentBD)
        ReplaceDoc(docBDToModify.Titre, docBDModified.Titre)
        ReplaceDoc(docBDToModify.Auteur, docBDModified.Auteur)
        ReplaceDoc(docBDToModify.Type, docBDModified.Type)
        ReplaceDoc(docBDToModify.Reserve, docBDModified.Reserve)
        ReplaceDoc(docBDToModify.TempsDemprunt, docBDModified.TempsDemprunt)
    End Sub

    Private Sub ReplaceDoc(Of T)(docListToModify As List(Of T), docListModified As List(Of T))
        For i = 0 To docListToModify.Count - 1
            docListToModify.Remove(docListToModify.ElementAt(i))
            docListToModify.Add(docListModified.ElementAt(i))
        Next
    End Sub
End Class
