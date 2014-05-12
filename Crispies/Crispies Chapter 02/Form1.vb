Public Class Form1

    'handles the fontButton being selected'
    Private Sub fontButton_Click(sender As Object, e As EventArgs) Handles fontButton.Click
        FontDialog.Font = Me.Font   'sets the initial start value of the fontDialog box to the form's font'
        FontDialog.ShowDialog()     'opens fontDialog Box'
        Me.Font = FontDialog.Font() 'sets the final value of the fontDialog box to the form's font'
    End Sub

    'handles the exitButton being selected'
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()  'close the Crispies Windows application'
    End Sub

    'handles the colorButton being selected'
    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        ColorDialog.Color = Me.BackColor    'sets the initial start value of the colorDialog box to the form's background color'
        ColorDialog.ShowDialog()    'opens the colorDialog box'
        finalPrice.BackColor = ColorDialog.Color    'sets the final value of the colorDialog box to the totalPrice background color'
    End Sub

    'handles the calculatePriceButton being selected'
    Private Sub calculatePriceButton_Click(sender As Object, e As EventArgs) Handles calculatePriceButton.Click
        Dim bagelsTotal As Double   'declare a double for the price of the bagels'
        Dim donutsTotal As Double   'declare a double for the price of the donuts'
        Dim coffeeTotal As Double   'declare a double for the price of the coffee'
        Dim totalPrice As Double    'declare a double for the total price of all the items'

        bagelsTotal = Convert.ToDouble(bagelsPrice.Text)    'convert the users bagelsPrice to a double so the complier knows its a number'
        donutsTotal = Convert.ToDouble(donutsPrice.Text)    'convert the users donutsPrice to a double so the compiler knows its a number'
        coffeeTotal = Convert.ToDouble(coffeePrice.Text)    'convert the users coffeePrice to a double so the compiler knows its a number'

        totalPrice = bagelsTotal + donutsTotal + coffeeTotal    'calculate the totalPrice of the items'

        finalPrice.Text = Convert.ToString(totalPrice)  'convert the totalPrice of all of the items to a string that can be read in a label'
    End Sub
End Class
