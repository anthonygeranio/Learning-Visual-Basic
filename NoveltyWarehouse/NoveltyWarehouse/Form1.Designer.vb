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
        Me.itemPriceBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.salesTaxLabel = New System.Windows.Forms.Label()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.totalDueLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item price:"
        '
        'itemPriceBox
        '
        Me.itemPriceBox.Location = New System.Drawing.Point(112, 27)
        Me.itemPriceBox.Name = "itemPriceBox"
        Me.itemPriceBox.Size = New System.Drawing.Size(127, 20)
        Me.itemPriceBox.TabIndex = 1
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(285, 22)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(106, 23)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "Calculate Total"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(285, 51)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(106, 23)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subtotal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sales tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Shipping:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total due: "
        '
        'subTotalLabel
        '
        Me.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subTotalLabel.Location = New System.Drawing.Point(112, 120)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(127, 23)
        Me.subTotalLabel.TabIndex = 5
        '
        'salesTaxLabel
        '
        Me.salesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesTaxLabel.Location = New System.Drawing.Point(112, 159)
        Me.salesTaxLabel.Name = "salesTaxLabel"
        Me.salesTaxLabel.Size = New System.Drawing.Size(127, 23)
        Me.salesTaxLabel.TabIndex = 7
        '
        'shippingLabel
        '
        Me.shippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shippingLabel.Location = New System.Drawing.Point(112, 200)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(127, 23)
        Me.shippingLabel.TabIndex = 9
        '
        'totalDueLabel
        '
        Me.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDueLabel.Location = New System.Drawing.Point(112, 241)
        Me.totalDueLabel.Name = "totalDueLabel"
        Me.totalDueLabel.Size = New System.Drawing.Size(127, 23)
        Me.totalDueLabel.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 330)
        Me.Controls.Add(Me.totalDueLabel)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.salesTaxLabel)
        Me.Controls.Add(Me.subTotalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.itemPriceBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Novelty Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemPriceBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents subTotalLabel As System.Windows.Forms.Label
    Friend WithEvents salesTaxLabel As System.Windows.Forms.Label
    Friend WithEvents shippingLabel As System.Windows.Forms.Label
    Friend WithEvents totalDueLabel As System.Windows.Forms.Label

End Class
