Public Class HomePage


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Artist1.Locations' table. You can move, or remove it, as needed.
        Me.LocationsTableAdapter.Fill(Me.Artist1.Locations)
        'TODO: This line of code loads data into the 'Artist.Artists' table. You can move, or remove it, as needed.
        Me.ArtistsTableAdapter.Fill(Me.Artist.Artists)


    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ArtistSearchResultsPage.ShowDialog()
    End Sub

    Private Sub cboArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArtist.SelectedIndexChanged

    End Sub
End Class
