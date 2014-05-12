Public Class Form1

    Dim finalPrice As Double

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dealer(priceTextBox.Text, rebateTextBox.Text, dealerRateBox.SelectedItem, bankRateBox.SelectedItem, yearsBox.SelectedItem)
        Bank(priceTextBox.Text, rebateTextBox.Text, dealerRateBox.SelectedItem, bankRateBox.SelectedItem, yearsBox.SelectedItem)
    End Sub

    Function Dealer(ByVal price As Double, ByVal rebate As Double, ByVal dealerRate As Double, ByVal bankRate As Double, ByVal years As Integer)
        finalPrice = price - rebate
        dMonthPaymentLabel.Text = Financial.PPmt(dealerRate / 12, 1, years * 12, -finalPrice, 0)
    End Function

    Function Bank(ByVal price As Double, ByVal rebate As Double, ByVal dealerRate As Double, ByVal bankRate As Double, ByVal years As Integer)
        finalPrice = price - rebate
        bMonthlyPaymentLabel.Text = Financial.PPmt(bankRate / 12, 1, years * 12, -finalPrice, 0)
        Return finalPrice
    End Function

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class

