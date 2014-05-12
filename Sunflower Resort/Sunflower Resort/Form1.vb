Public Class Form1

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim numberOfRooms As Integer
        Dim lengthOfStay As Integer
        Dim numberOfAdults As Integer
        Dim numberOfChilds As Integer
        Dim totalGuest As Integer
        Dim totalDueWithoutRooms As Decimal
        Dim totalDueWithRooms As Decimal

        Dim roomCharge As Integer
        Dim salesTaxCharge As Decimal
        Dim resortFeeCharge As Integer

        Integer.TryParse(lengthOfStayBox.Text, lengthOfStay)

        roomCharge = 284
        salesTaxCharge = roomCharge * 0.1525
        resortFeeCharge = 15

        Integer.TryParse(adultGuestBox.Text, numberOfAdults)
        Integer.TryParse(childGuestBox.Text, numberOfChilds)

        totalGuest = numberOfAdults + numberOfChilds
        If totalGuest >= 6 Then
            MessageBox.Show("You have exceeded the maximum guests per room")
        End If

        totalDueWithoutRooms = roomCharge * lengthOfStay + salesTaxCharge + resortFeeCharge

        Integer.TryParse(numberOfRoomsBox.Text, numberOfRooms)
        totalDueWithRooms = totalDueWithoutRooms * numberOfRooms

        totalDueLabel.Text = totalDueWithRooms.ToString("C2")

    End Sub


    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
