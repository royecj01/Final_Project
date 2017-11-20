Public Class HomePage


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ArtistSearchResultsPage.ShowDialog()
    End Sub
End Class
