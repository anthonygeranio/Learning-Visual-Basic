Public Class Form1

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        If residentialOption.Checked Then
            Residential(4.5, 30, 5, channelsBox.SelectedItem)
        End If

        If businessOption.Checked Then
            Business(16.5, 80, 50, channelsBox.SelectedItem, connectionsBox.SelectedItem)
        End If


    End Sub

    Function Residential(ByVal processingFee As Double, ByVal basicServiceFee As Double, ByVal premiumChannelFee As Double, ByVal channels As Integer)
        totalDueLabel.Text = processingFee + basicServiceFee + (premiumChannelFee * channels)

        Return processingFee
        Return basicServiceFee
        Return premiumChannelFee
        Return channels
    End Function

    Function Business(ByVal processingFee As Double, ByVal basicServiceFee As Double, ByVal premiumChannelFee As Double, ByVal channels As Integer, ByVal connections As Integer)
        Dim channelAdditions As Integer

        Dim channelCount As Integer = channelsBox.SelectedItem
        If (channelCount <= 10) Then
            channelAdditions = 0
            totalDueLabel.Text = processingFee + basicServiceFee + (premiumChannelFee * channels)
        ElseIf (channelCount >= 10) Then
            channelAdditions = channelsBox.SelectedItem - 10
            totalDueLabel.Text = processingFee + basicServiceFee + (premiumChannelFee * channels) + channelAdditions * 4
        End If

        Console.Write(connections)
        Console.Write(channels)

        Return processingFee
        Return basicServiceFee
        Return premiumChannelFee
        Return channels
        Return connections
    End Function

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
