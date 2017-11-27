Imports System.IO

Public Class TicketsPage

    Private Sub TicketsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = String.Empty
        lblConcert.Text = "Concert name"
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim total As Decimal
        Dim numTickets As Integer
        Dim price As Decimal
        Dim tixCounter As Integer



        If cboLevel.SelectedIndex = 0 Then
            price = 15.0
            tixCounter = 5
        ElseIf cboLevel.SelectedIndex = 1 Then
            price = 20.0
            tixCounter = 4
        ElseIf cboLevel.SelectedIndex = 2 Then
            price = 25.0
            tixCounter = 3
        ElseIf cboLevel.SelectedIndex = 3 Then
            price = 30.0
            tixCounter = 2
        Else
            MessageBox.Show("Please select a seat level.", "Error")
            cboLevel.Focus()
        End If

        If cboSeats.SelectedItem = Nothing Then
            MessageBox.Show("Please select the number of seats you would like to purchase.", "Error")
            cboSeats.Focus()
        Else
            numTickets = cboSeats.SelectedItem.ToString

        End If


        Dim discount As Decimal = 0.1
        If chkParking.Checked = False Then
            total = numTickets * price
            lblTotal.Text = total.ToString("C")
            'MessageBox.Show("Thank you for your purchase! Total Amount Paid: " & lblTotal.Text, "Purchase Complete")
        Else
            Dim subT As Decimal

            subT = (numTickets * price) * discount
            total = (numTickets * price) - subT
            lblTotal.Text = total.ToString("C")
            'MessageBox.Show("Thank you for your purchase! Total Amount Paid: " & lblTotal.Text, "Purchase Complete")
        End If

        If lblTotal.Text > 0 Then
            MessageBox.Show("Thank you for your purchase! Total Amount Paid: " & lblTotal.Text, "Purchase Complete")
        End If

        tixCounter -= 1
        If tixCounter < numTickets Then
            MessageBox.Show("There are only " & tixCounter & " tickets available for purchase.")
        ElseIf tixCounter = 0 Then
            MessageBox.Show("Sorry, this concert is sold out.")
        End If

    End Sub
End Class