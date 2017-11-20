Imports System.IO

Public Class TicketsPage

    Private Sub TicketsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim total As Decimal
        Dim numTickets As Integer
        Dim price As Decimal = 25.0
        numTickets =

        total = numTickets * price
        If chkParking.Checked = True Then
            Dim discount As Decimal = 0.1
            total = (numTickets * price) * discount
            lblTotal.Text = total.ToString("C")
        End If
    End Sub
End Class