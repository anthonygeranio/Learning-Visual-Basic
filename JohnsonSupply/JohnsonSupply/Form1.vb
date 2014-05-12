Public Class radioWholesaler

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim units As Integer
        Dim orderPrice As Integer

        Integer.TryParse(numUnits.Text, units)

        If units >= 1 <= 10 And radioWholesale.Checked Then
            orderPrice = 20 * units
            totalPrice.Text = Convert.ToString(orderPrice)
        End If

        If units >= 11 And radioWholesale.Checked Then
            orderPrice = 15 * units
            totalPrice.Text = Convert.ToString(orderPrice)
        End If

        If units >= 1 <= 5 And radioRetailer.Checked Then
            orderPrice = 30 * units
            totalPrice.Text = Convert.ToString(orderPrice)
        End If

        If units >= 6 <= 15 And radioRetailer.Checked Then
            orderPrice = 28 * units
            totalPrice.Text = Convert.ToString(orderPrice)
        End If

        If units >= 15 And radioRetailer.Checked Then
            orderPrice = 25 * units
            totalPrice.Text = Convert.ToString(orderPrice)
        End If
    End Sub


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
