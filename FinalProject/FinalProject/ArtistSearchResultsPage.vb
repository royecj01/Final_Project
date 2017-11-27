Public Class ArtistSearchResultsPage


    Private Sub ArtistSearchResultsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        TicketsPage.ShowDialog()
    End Sub

    Private Sub lstOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOptions.SelectedIndexChanged

    End Sub
End Class