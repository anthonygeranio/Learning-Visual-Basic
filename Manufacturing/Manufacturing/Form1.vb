Public Class Form1

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim index As Integer

        Dim foundInA As Boolean
        foundInA = False

        Dim foundInB As Boolean
        foundInB = False

        If index <= warehouseA.Items.Count - 1 Then
            If warehouseA.Items(index) = idBox.Text Then
                foundInA = True
            ElseIf index <= warehouseB.Items.Count - 1 Then
                If warehouseB.Items(index) = idBox.Text Then
                    foundInB = True
                End If
            End If
        End If

        If foundInA = True Then
            locationLabel.Text = "A"
        End If

        If foundInB = True Then
            locationLabel.Text = "B"
        End If

        If foundInA = False And foundInB = False Then
            MessageBox.Show("Not Found")
        End If

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
