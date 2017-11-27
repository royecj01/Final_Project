Public Class HomePage

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Artist.Locations' table. You can move, or remove it, as needed.
        Me.LocationsTableAdapter.Fill(Me.Artist.Locations)
        'TODO: This line of code loads data into the 'Artist.Artists' table. You can move, or remove it, as needed.
        Me.ArtistsTableAdapter.Fill(Me.Artist.Artists)

        lblConcert.Visible = False
        lstOptions.Visible = False
        btnTickets.Visible = False


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lblConcert.Visible = True
        lstOptions.Visible = True
        btnTickets.Visible = True

        If radArtist.Checked = True Then
            lstOptions.DataSource = ((Me.Artist.Locations))

        End If

    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        TicketsPage.ShowDialog()
    End Sub
End Class