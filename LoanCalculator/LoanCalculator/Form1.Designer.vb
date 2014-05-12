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
        Me.principalText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.annualBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.termBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.monthlyPayment = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.piBox = New System.Windows.Forms.ListBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Principal"
        '
        'principalText
        '
        Me.principalText.Location = New System.Drawing.Point(27, 59)
        Me.principalText.Name = "principalText"
        Me.principalText.Size = New System.Drawing.Size(69, 20)
        Me.principalText.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Annual interest rate"
        '
        'annualBox
        '
        Me.annualBox.FormattingEnabled = True
        Me.annualBox.Items.AddRange(New Object() {"0.02", "0.03", "0.04", "0.05", "0.06", "0.07", "0.08", "0.09", "0.10"})
        Me.annualBox.Location = New System.Drawing.Point(129, 57)
        Me.annualBox.Name = "annualBox"
        Me.annualBox.Size = New System.Drawing.Size(95, 21)
        Me.annualBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Term (years)"
        '
        'termBox
        '
        Me.termBox.FormattingEnabled = True
        Me.termBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.termBox.Location = New System.Drawing.Point(274, 56)
        Me.termBox.Name = "termBox"
        Me.termBox.Size = New System.Drawing.Size(62, 21)
        Me.termBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Monthly payment:"
        '
        'monthlyPayment
        '
        Me.monthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monthlyPayment.Location = New System.Drawing.Point(123, 125)
        Me.monthlyPayment.Name = "monthlyPayment"
        Me.monthlyPayment.Size = New System.Drawing.Size(149, 21)
        Me.monthlyPayment.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Principal and interest:"
        '
        'piBox
        '
        Me.piBox.FormattingEnabled = True
        Me.piBox.Location = New System.Drawing.Point(30, 222)
        Me.piBox.Name = "piBox"
        Me.piBox.Size = New System.Drawing.Size(149, 186)
        Me.piBox.TabIndex = 9
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(304, 125)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(75, 23)
        Me.displayButton.TabIndex = 10
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(304, 155)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 451)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.piBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.monthlyPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.termBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.annualBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.principalText)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents principalText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents annualBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents termBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents monthlyPayment As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents piBox As System.Windows.Forms.ListBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
