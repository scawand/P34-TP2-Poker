Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 2 To 4
            cbNbJoueur.Items.Add(i)
        Next
    End Sub
End Class
