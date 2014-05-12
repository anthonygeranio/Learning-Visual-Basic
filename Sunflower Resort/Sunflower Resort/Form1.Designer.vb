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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numberOfRoomsBox = New System.Windows.Forms.TextBox()
        Me.lengthOfStayBox = New System.Windows.Forms.TextBox()
        Me.adultGuestBox = New System.Windows.Forms.TextBox()
        Me.childGuestBox = New System.Windows.Forms.TextBox()
        Me.totalDueLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Rooms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Length of stay (in nights)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of adult guests"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of child guests"
        '
        'numberOfRoomsBox
        '
        Me.numberOfRoomsBox.Location = New System.Drawing.Point(162, 26)
        Me.numberOfRoomsBox.Name = "numberOfRoomsBox"
        Me.numberOfRoomsBox.Size = New System.Drawing.Size(95, 20)
        Me.numberOfRoomsBox.TabIndex = 1
        '
        'lengthOfStayBox
        '
        Me.lengthOfStayBox.Location = New System.Drawing.Point(162, 83)
        Me.lengthOfStayBox.Name = "lengthOfStayBox"
        Me.lengthOfStayBox.Size = New System.Drawing.Size(95, 20)
        Me.lengthOfStayBox.TabIndex = 3
        '
        'adultGuestBox
        '
        Me.adultGuestBox.Location = New System.Drawing.Point(162, 135)
        Me.adultGuestBox.Name = "adultGuestBox"
        Me.adultGuestBox.Size = New System.Drawing.Size(95, 20)
        Me.adultGuestBox.TabIndex = 5
        '
        'childGuestBox
        '
        Me.childGuestBox.Location = New System.Drawing.Point(162, 190)
        Me.childGuestBox.Name = "childGuestBox"
        Me.childGuestBox.Size = New System.Drawing.Size(95, 20)
        Me.childGuestBox.TabIndex = 7
        '
        'totalDueLabel
        '
        Me.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDueLabel.Location = New System.Drawing.Point(310, 190)
        Me.totalDueLabel.Name = "totalDueLabel"
        Me.totalDueLabel.Size = New System.Drawing.Size(149, 23)
        Me.totalDueLabel.TabIndex = 13
        Me.totalDueLabel.Text = "Total Not Calculated Yet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Room: $284 per night"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(310, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sales and lodging tax: 15.25%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(310, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Resort Fee: $15"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(25, 253)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(126, 253)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 322)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.totalDueLabel)
        Me.Controls.Add(Me.childGuestBox)
        Me.Controls.Add(Me.adultGuestBox)
        Me.Controls.Add(Me.lengthOfStayBox)
        Me.Controls.Add(Me.numberOfRoomsBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sunflower Resort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numberOfRoomsBox As System.Windows.Forms.TextBox
    Friend WithEvents lengthOfStayBox As System.Windows.Forms.TextBox
    Friend WithEvents adultGuestBox As System.Windows.Forms.TextBox
    Friend WithEvents childGuestBox As System.Windows.Forms.TextBox
    Friend WithEvents totalDueLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
