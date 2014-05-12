Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles compareOptions.Click

        Dim optionOneSum As Integer
        Dim optionOneFinal As Integer
        Dim optionOnePayment = 2

        Dim optionTwoPayment = 100
        Dim optionTwoFinal As Integer

        For N = 1 To 10 Step 1
            optionOneSum = optionOnePayment ^ N
            optionOneBox.Items.Add(optionOneSum)
            optionOneFinal = optionOneSum * optionOnePayment
            optionOneTotal.Text = optionOneFinal.ToString("c2")
        Next

        For i = 1 To 10 Step 1  
            optionTwoFinal = optionTwoPayment * i
            optionTwoTotal.Text = optionTwoFinal.ToString("c2")
            optionTwoBox.Items.Add(optionTwoPayment)
        Next

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
