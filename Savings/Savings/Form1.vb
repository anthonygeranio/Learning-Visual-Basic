Public Class Form1

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim balance As Integer
        Const years As Integer = 18

        For r As Decimal = 0.02 To 0.05 Step 0.01
            BalanceListBox.Items.Add("Interest Rate:     " & r.ToString("p1"))
            For j As Integer = 100 To 200 Step 50
                balance = -Financial.FV(r / 12, years * 12, j)
                BalanceListBox.Items.Add(j.ToString("c2") & "        " & balance.ToString("c2"))
            Next
        Next
    End Sub
End Class
