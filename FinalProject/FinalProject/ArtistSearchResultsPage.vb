Public Class ArtistSearchResultsPage
    ' Inherits HomePage

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ArtistSearchResultsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If MyBase.radArtist.Checked = True Then
        '    lstOptions.Items.Add("Fort Wayne, IN")
        '    lstOptions.Items.Add("Seattle, WA")
        '    lstOptions.Items.Add("Panama City, FL")
        'ElseIf MyBase.radLocation.Checked = True Then
        '    lstOptions.Items.Add("Taylor Swift")
        '    lstOptions.Items.Add("Mackelmore")
        '    lstOptions.Items.Add("Twenty-One Pilots")

        'End If
    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        TicketsPage.ShowDialog()

    End Sub
End Class