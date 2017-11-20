Imports System.IO

Public Class TicketsPage

    Private Sub TicketsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim total As Decimal
        Dim numTickets As Integer
        Dim price As Decimal
        numTickets = cboSeats.SelectedItem.ToString

        If cboLevel.SelectedIndex = 0 Then
            price = 15.0
        ElseIf cboLevel.SelectedIndex = 1 Then
            price = 20.0
        ElseIf cboLevel.SelectedIndex = 2 Then
            price = 25.0
        ElseIf cboLevel.SelectedIndex = 3 Then
            price = 30.0
        End If

        Dim discount As Decimal = 0.1
        If chkParking.Checked = False Then
            total = numTickets * price
            lblTotal.Text = total.ToString("C")
        Else
            Dim subT As Decimal

            subT = (numTickets * price) * discount
            total = (numTickets * price) - subT
            lblTotal.Text = total.ToString("C")
        End If
    End Sub
End Class