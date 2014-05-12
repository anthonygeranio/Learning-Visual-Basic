Public Class Form1

    Private Sub displayTable_Click(sender As Object, e As EventArgs) Handles displayTable.Click
        Dim numberFromText As Integer
        Integer.TryParse(numberTable.Text, numberFromText)

        Dim counter As Integer
        counter = 0
        Do While counter < 9
            counter += 1
            listBox.Items.Add(numberFromText & " x " & counter & " = " & numberFromText * counter)
        Loop
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numberTable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numberTable.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
