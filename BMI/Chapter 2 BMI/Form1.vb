Public Class Form1

    Private Sub fontButton_Click(sender As Object, e As EventArgs) Handles fontButton.Click
        FontDialog.Font = Me.Font   'sets the initial start value of the fontDialog box to the form's font'
        FontDialog.ShowDialog()     'opens fontDialog Box'
        titleLabel.Font = FontDialog.Font() 'sets the titleLabel font to the selected font'
    End Sub


    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog.Apply

    End Sub

    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        ColorDialog.ShowDialog()
        titleLabel.ForeColor = ColorDialog.Color()
    End Sub

    Private Sub musicButton_Click(sender As Object, e As EventArgs) Handles musicButton.Click
        My.Computer.Audio.Play("gold.wav")
    End Sub
End Class
