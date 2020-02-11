Public Class Main
    Private Doc1 As New DocumentDB("Elle meurt à la fin", "Livre", False, 2)

    Public Shared Sub Main()
        MsgBox(Doc1.Titre)
    End Sub

End Class