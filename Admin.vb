Imports System.Text
Imports System.IO

Public Class Admin
    Inherits Utilisateur

    Overloads ReadOnly Property IsAdmin As Boolean ' boolean qui détermine si l'utilisateur est un admin
    Private ReadOnly Property Docs As New DocumentBD ' la liste de documents

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

    ''' <summary>
    ''' Ajoute un document à la base de données de documents
    ''' </summary>
    ''' <param name="docBD"> Base de données de documents </param>
    Public Sub AddDocument(docBD As DocumentBD)
        AddDoc(docBD.Titre)
        AddDoc(docBD.Auteur)
        AddDoc(docBD.Type)
        AddDoc(docBD.Reserve)
        AddDoc(docBD.TempsDemprunt)
    End Sub

    ''' <summary>
    ''' Ajoute une propriété dans la liste de proprété de documents appropriée
    ''' </summary>
    ''' <typeparam name="T"> Objet Générique </typeparam>
    ''' <param name="docListToAdd">La Liste de propriété de document visée</param>
    Private Sub AddDoc(Of T)(docListToAdd As List(Of T))
        For i = 0 To docListToAdd.Count - 1
            docListToAdd.Remove(docListToAdd.ElementAt(i))
        Next
    End Sub

    ''' <summary>
    ''' Enleve un document de la base de données de documents
    ''' </summary>
    ''' <param name="docBD"> Base de données de documents </param>
    Public Sub DeleteDocument(docBD As DocumentBD)
        DeleteDoc(docBD.Titre)
        DeleteDoc(docBD.Auteur)
        DeleteDoc(docBD.Type)
        DeleteDoc(docBD.Reserve)
        DeleteDoc(docBD.TempsDemprunt)
    End Sub

    ''' <summary>
    ''' Enleve une certaine propriété de sa liste de propriété de documents 
    ''' </summary>
    ''' <typeparam name="T"> Objet générique </typeparam>
    ''' <param name="docListToDelete"> La Liste de propriété de document visée </param>
    Private Sub DeleteDoc(Of T)(docListToDelete As List(Of T))
        For i = 0 To docListToDelete.Count - 1
            docListToDelete.Remove(docListToDelete.ElementAt(i))
        Next
    End Sub

    ''' <summary>
    ''' Modifie les propriété d'un document
    ''' </summary>
    ''' <typeparam name="ID"></typeparam>
    ''' <param name="docBDToModify"> La Base de données de documents avant modification </param>
    ''' <param name="docBDModified"> La base de données de documents après modification </param>
    Public Sub ModifyDocuments(Of ID)(docBDToModify As DocumentBD, docBDModified As DocumentBD)
        ReplaceDoc(docBDToModify.Titre, docBDModified.Titre)
        ReplaceDoc(docBDToModify.Auteur, docBDModified.Auteur)
        ReplaceDoc(docBDToModify.Type, docBDModified.Type)
        ReplaceDoc(docBDToModify.Reserve, docBDModified.Reserve)
        ReplaceDoc(docBDToModify.TempsDemprunt, docBDModified.TempsDemprunt)
    End Sub

    ''' <summary>
    ''' Modifie une certaine propriété dans sa liste de propriété de documents
    ''' </summary>
    ''' <typeparam name="T"> Objet générique </typeparam>
    ''' <param name="docListToModify"> La liste de propriété de document visée </param>
    ''' <param name="docListModified"> La liste de propriété de document visée </param>
    Private Sub ReplaceDoc(Of T)(docListToModify As List(Of T), docListModified As List(Of T))
        For i = 0 To docListToModify.Count - 1
            docListToModify.Remove(docListToModify.ElementAt(i))
            docListToModify.Add(docListModified.ElementAt(i))
        Next
    End Sub
End Class
