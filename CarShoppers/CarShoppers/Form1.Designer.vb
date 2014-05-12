<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rebateTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dMonthPaymentLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bMonthlyPaymentLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dealerRateBox = New System.Windows.Forms.ListBox()
        Me.bankRateBox = New System.Windows.Forms.ListBox()
        Me.yearsBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price:"
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(16, 29)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(84, 20)
        Me.priceTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rebate:"
        '
        'rebateTextBox
        '
        Me.rebateTextBox.Location = New System.Drawing.Point(127, 29)
        Me.rebateTextBox.Name = "rebateTextBox"
        Me.rebateTextBox.Size = New System.Drawing.Size(84, 20)
        Me.rebateTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dealer Monthly Payment:"
        '
        'dMonthPaymentLabel
        '
        Me.dMonthPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dMonthPaymentLabel.Location = New System.Drawing.Point(78, 212)
        Me.dMonthPaymentLabel.Name = "dMonthPaymentLabel"
        Me.dMonthPaymentLabel.Size = New System.Drawing.Size(122, 23)
        Me.dMonthPaymentLabel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Bank Monthly Payment:"
        '
        'bMonthlyPaymentLabel
        '
        Me.bMonthlyPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bMonthlyPaymentLabel.Location = New System.Drawing.Point(271, 212)
        Me.bMonthlyPaymentLabel.Name = "bMonthlyPaymentLabel"
        Me.bMonthlyPaymentLabel.Size = New System.Drawing.Size(122, 23)
        Me.bMonthlyPaymentLabel.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dealer Rate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Bank Rate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(404, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Year(s)"
        '
        'dealerRateBox
        '
        Me.dealerRateBox.FormattingEnabled = True
        Me.dealerRateBox.Items.AddRange(New Object() {"0.01", "0.02", "0.03", "0.04", "0.05", "0.06", "0.07", "0.08", "0.09", "0.10"})
        Me.dealerRateBox.Location = New System.Drawing.Point(241, 29)
        Me.dealerRateBox.Name = "dealerRateBox"
        Me.dealerRateBox.Size = New System.Drawing.Size(64, 95)
        Me.dealerRateBox.TabIndex = 11
        '
        'bankRateBox
        '
        Me.bankRateBox.FormattingEnabled = True
        Me.bankRateBox.Items.AddRange(New Object() {"0.01", "0.02", "0.03", "0.04", "0.05", "0.06", "0.07", "0.08", "0.09", "0.10"})
        Me.bankRateBox.Location = New System.Drawing.Point(326, 29)
        Me.bankRateBox.Name = "bankRateBox"
        Me.bankRateBox.Size = New System.Drawing.Size(64, 95)
        Me.bankRateBox.TabIndex = 12
        '
        'yearsBox
        '
        Me.yearsBox.FormattingEnabled = True
        Me.yearsBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.yearsBox.Location = New System.Drawing.Point(407, 29)
        Me.yearsBox.Name = "yearsBox"
        Me.yearsBox.Size = New System.Drawing.Size(64, 95)
        Me.yearsBox.TabIndex = 13
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(78, 268)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(122, 23)
        Me.calculateButton.TabIndex = 14
        Me.calculateButton.Text = "Calculate Payments"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(271, 268)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(122, 23)
        Me.exitButton.TabIndex = 15
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 334)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.yearsBox)
        Me.Controls.Add(Me.bankRateBox)
        Me.Controls.Add(Me.dealerRateBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bMonthlyPaymentLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dMonthPaymentLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rebateTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Car Shoppers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rebateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dMonthPaymentLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bMonthlyPaymentLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dealerRateBox As System.Windows.Forms.ListBox
    Friend WithEvents bankRateBox As System.Windows.Forms.ListBox
    Friend WithEvents yearsBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
