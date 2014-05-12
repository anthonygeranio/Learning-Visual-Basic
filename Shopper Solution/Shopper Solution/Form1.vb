Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim total As Integer
        Dim rewardPoints As Integer
        total = monthlyPurchase.Text

        Integer.TryParse(monthlyPurchase.Text, total)

        If total < 100 And basicRadio.Checked Then
            rewardPoints = total * 0.05
            rewardLabel.Text = rewardPoints
        End If

        If total >= 100 And basicRadio.Checked Then
            rewardPoints = total * 0.07
            rewardLabel.Text = rewardPoints
        End If

        If total < 150 And standardRadio.Checked Then
            rewardPoints = total * 0.06
            rewardLabel.Text = rewardPoints
        End If

        If total >= 150 <= 299.99 And standardRadio.Checked Then
            rewardPoints = total * 0.08
            rewardLabel.Text = rewardPoints
        End If

        If total >= 300 And standardRadio.Checked Then
            rewardPoints = total * 10.0
            rewardLabel.Text = rewardPoints
        End If

        If total < 200 And premiumRadio.Checked Then
            rewardPoints = total * 0.07
            rewardLabel.Text = rewardPoints
        End If

        If total >= 200 And premiumRadio.Checked Then
            rewardPoints = total * 15.0
            rewardLabel.Text = rewardPoints
        End If

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
