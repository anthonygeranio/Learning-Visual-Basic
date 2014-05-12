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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.finalPrice = New System.Windows.Forms.Label()
        Me.calculatePriceButton = New System.Windows.Forms.Button()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.bagelsPrice = New System.Windows.Forms.TextBox()
        Me.donutsPrice = New System.Windows.Forms.TextBox()
        Me.coffeePrice = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bagels:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Donuts:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Coffee:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price:"
        '
        'finalPrice
        '
        Me.finalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.finalPrice.Location = New System.Drawing.Point(304, 253)
        Me.finalPrice.Name = "finalPrice"
        Me.finalPrice.Size = New System.Drawing.Size(226, 25)
        Me.finalPrice.TabIndex = 7
        '
        'calculatePriceButton
        '
        Me.calculatePriceButton.Location = New System.Drawing.Point(46, 322)
        Me.calculatePriceButton.Name = "calculatePriceButton"
        Me.calculatePriceButton.Size = New System.Drawing.Size(138, 61)
        Me.calculatePriceButton.TabIndex = 8
        Me.calculatePriceButton.Text = "Calculate Price"
        Me.calculatePriceButton.UseVisualStyleBackColor = True
        '
        'colorButton
        '
        Me.colorButton.Location = New System.Drawing.Point(203, 322)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(138, 61)
        Me.colorButton.TabIndex = 9
        Me.colorButton.Text = "Color"
        Me.colorButton.UseVisualStyleBackColor = True
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(367, 322)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(138, 61)
        Me.fontButton.TabIndex = 10
        Me.fontButton.Text = "Font"
        Me.fontButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(450, 427)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(103, 36)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'bagelsPrice
        '
        Me.bagelsPrice.Location = New System.Drawing.Point(304, 45)
        Me.bagelsPrice.Name = "bagelsPrice"
        Me.bagelsPrice.Size = New System.Drawing.Size(226, 33)
        Me.bagelsPrice.TabIndex = 1
        '
        'donutsPrice
        '
        Me.donutsPrice.Location = New System.Drawing.Point(304, 112)
        Me.donutsPrice.Name = "donutsPrice"
        Me.donutsPrice.Size = New System.Drawing.Size(226, 33)
        Me.donutsPrice.TabIndex = 3
        '
        'coffeePrice
        '
        Me.coffeePrice.Location = New System.Drawing.Point(304, 183)
        Me.coffeePrice.Name = "coffeePrice"
        Me.coffeePrice.Size = New System.Drawing.Size(226, 33)
        Me.coffeePrice.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.coffeePrice)
        Me.Controls.Add(Me.donutsPrice)
        Me.Controls.Add(Me.bagelsPrice)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.colorButton)
        Me.Controls.Add(Me.calculatePriceButton)
        Me.Controls.Add(Me.finalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Crispies Bagels and Bites"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents finalPrice As System.Windows.Forms.Label
    Friend WithEvents calculatePriceButton As System.Windows.Forms.Button
    Friend WithEvents colorButton As System.Windows.Forms.Button
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents bagelsPrice As System.Windows.Forms.TextBox
    Friend WithEvents donutsPrice As System.Windows.Forms.TextBox
    Friend WithEvents coffeePrice As System.Windows.Forms.TextBox

End Class
