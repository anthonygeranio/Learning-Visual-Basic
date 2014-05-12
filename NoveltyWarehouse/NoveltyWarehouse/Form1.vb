Public Class Form1
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim itemPrice As Decimal
        Dim salesTax As Decimal
        Dim shippingPrice As Decimal
        Dim grandTotalDue As Decimal

        salesTax = 0.03

        Decimal.TryParse(itemPriceBox.Text, itemPrice)
        itemPrice = Convert.ToString(itemPrice)
        subTotalLabel.Text = itemPrice

        salesTax = Convert.ToString(salesTax)
        salesTaxLabel.Text = salesTax * itemPrice

        If (itemPrice >= 100) Then
            shippingPrice = 0
        Else
            shippingPrice = 15
        End If

        shippingPrice = Convert.ToString(shippingPrice)
        shippingLabel.Text = shippingPrice

        grandTotalDue = itemPrice + salesTax + shippingPrice
        grandTotalDue = Convert.ToString(grandTotalDue)
        totalDueLabel.Text = grandTotalDue
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
