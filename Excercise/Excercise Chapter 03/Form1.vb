Public Class Form1

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()      'Close application'
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'Declare variables for calories burned per hour'
        Dim stairCalories As Integer
        Dim elipticalCalories As Integer
        Dim bicycleCalories As Integer

        'Set values for calories burned per hour'
        stairCalories = 446
        elipticalCalories = 670
        bicycleCalories = 520

        'Declare variables for text box results'
        Dim stairHours As Double
        Dim elipticalHours As Double
        Dim bicycleHours As Double

        Double.TryParse(stairStepper.Text, stairHours)
        Double.TryParse(elipticalTrainer.Text, elipticalHours)
        Double.TryParse(stationaryBicycle.Text, bicycleHours)

        'Declare variables for total results per machine'
        Dim stairTotal As Double
        Dim elipticalTotal As Double
        Dim bicycleTotal As Double

        'Calculate total results per machine'
        stairTotal = stairHours * stairCalories
        Console.WriteLine("Stair Total: " & stairTotal)
        elipticalTotal = elipticalHours * elipticalCalories
        Console.WriteLine("Eliptical Total: " & elipticalTotal)
        bicycleTotal = bicycleHours * bicycleCalories
        Console.WriteLine("Bicycle Total: " & bicycleTotal)

        'Declare variable for total calories burned'
        Dim totalCaloriesBurned = stairTotal + elipticalTotal + bicycleTotal
        Console.WriteLine("Total Calories Burned: " & totalCaloriesBurned)

        'Declare variable for total pounds lost'
        Dim totalPoundsLost As Double
        totalPoundsLost = (totalCaloriesBurned) / 3500
        Console.WriteLine("Total Pounds Lost: " & totalPoundsLost)

        Convert.ToString(totalPoundsLost)
        poundsLeftLabel.Text = totalPoundsLost

    End Sub
End Class
