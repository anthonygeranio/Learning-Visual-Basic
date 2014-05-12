<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class radioWholesaler
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
        Me.numUnits = New System.Windows.Forms.TextBox()
        Me.radioWholesale = New System.Windows.Forms.RadioButton()
        Me.radioRetailer = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Units:"
        '
        'numUnits
        '
        Me.numUnits.Location = New System.Drawing.Point(25, 44)
        Me.numUnits.Name = "numUnits"
        Me.numUnits.Size = New System.Drawing.Size(50, 20)
        Me.numUnits.TabIndex = 1
        '
        'radioWholesale
        '
        Me.radioWholesale.AutoSize = True
        Me.radioWholesale.Location = New System.Drawing.Point(173, 45)
        Me.radioWholesale.Name = "radioWholesale"
        Me.radioWholesale.Size = New System.Drawing.Size(78, 17)
        Me.radioWholesale.TabIndex = 2
        Me.radioWholesale.TabStop = True
        Me.radioWholesale.Text = "&Wholesaler"
        Me.radioWholesale.UseVisualStyleBackColor = True
        '
        'radioRetailer
        '
        Me.radioRetailer.AutoSize = True
        Me.radioRetailer.Location = New System.Drawing.Point(173, 67)
        Me.radioRetailer.Name = "radioRetailer"
        Me.radioRetailer.Size = New System.Drawing.Size(61, 17)
        Me.radioRetailer.TabIndex = 3
        Me.radioRetailer.TabStop = True
        Me.radioRetailer.Text = "&Retailer"
        Me.radioRetailer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Order price:"
        '
        'totalPrice
        '
        Me.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPrice.Location = New System.Drawing.Point(28, 155)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(223, 23)
        Me.totalPrice.TabIndex = 5
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(28, 191)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(109, 191)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'radioWholesaler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 256)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radioRetailer)
        Me.Controls.Add(Me.radioWholesale)
        Me.Controls.Add(Me.numUnits)
        Me.Controls.Add(Me.Label1)
        Me.Name = "radioWholesaler"
        Me.Text = "Johnson Supply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numUnits As System.Windows.Forms.TextBox
    Friend WithEvents radioWholesale As System.Windows.Forms.RadioButton
    Friend WithEvents radioRetailer As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totalPrice As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
