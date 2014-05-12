Public Class Form1

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        Dim principal As Integer
        Dim terms As Integer
        Dim rate As Decimal

        Dim monthlyInterest, monthlyPrincipal As Decimal

        Integer.TryParse(principalText.Text, principal)
        Decimal.TryParse(annualBox.Text, rate)
        Integer.TryParse(termBox.Text, terms)

        piBox.Items.Clear()
        piBox.Items.Add("Principal            Interest")

        monthlyPayment.Text = -Financial.Pmt(rate / 12, 12 * terms, principal)

        For i As Decimal = 1 To terms * 12 Step 1
            monthlyInterest = -Financial.IPmt(rate / 12, i, terms * 12, principal)
            monthlyPrincipal = -Financial.PPmt(rate / 12, i, terms * 12, principal)
            piBox.Items.Add(monthlyPrincipal.ToString("c2") & "              " & monthlyInterest.ToString("P1"))
        Next

    End Sub
End Class
