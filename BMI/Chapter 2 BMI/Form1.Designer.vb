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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.weightField = New System.Windows.Forms.TextBox()
        Me.heightField = New System.Windows.Forms.TextBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.bmiLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.resultsLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.musicButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Height"
        '
        'weightField
        '
        Me.weightField.Location = New System.Drawing.Point(150, 88)
        Me.weightField.Name = "weightField"
        Me.weightField.Size = New System.Drawing.Size(258, 33)
        Me.weightField.TabIndex = 2
        '
        'heightField
        '
        Me.heightField.Location = New System.Drawing.Point(150, 156)
        Me.heightField.Name = "heightField"
        Me.heightField.Size = New System.Drawing.Size(258, 33)
        Me.heightField.TabIndex = 4
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(238, 31)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(136, 25)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "BMI Calculator"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(83, 282)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(131, 42)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'bmiLabel
        '
        Me.bmiLabel.AutoSize = True
        Me.bmiLabel.Location = New System.Drawing.Point(91, 415)
        Me.bmiLabel.Name = "bmiLabel"
        Me.bmiLabel.Size = New System.Drawing.Size(0, 25)
        Me.bmiLabel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BMI:"
        '
        'resultsLabel
        '
        Me.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultsLabel.Location = New System.Drawing.Point(150, 229)
        Me.resultsLabel.Name = "resultsLabel"
        Me.resultsLabel.Size = New System.Drawing.Size(258, 25)
        Me.resultsLabel.TabIndex = 8
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(220, 282)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(121, 42)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'FontDialog
        '
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(347, 282)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(128, 42)
        Me.fontButton.TabIndex = 10
        Me.fontButton.Text = "Font"
        Me.fontButton.UseVisualStyleBackColor = True
        '
        'colorButton
        '
        Me.colorButton.Location = New System.Drawing.Point(482, 282)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(135, 42)
        Me.colorButton.TabIndex = 11
        Me.colorButton.Text = "Color"
        Me.colorButton.UseVisualStyleBackColor = True
        '
        'musicButton
        '
        Me.musicButton.Location = New System.Drawing.Point(83, 357)
        Me.musicButton.Name = "musicButton"
        Me.musicButton.Size = New System.Drawing.Size(131, 46)
        Me.musicButton.TabIndex = 12
        Me.musicButton.Text = "Music"
        Me.musicButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 426)
        Me.Controls.Add(Me.musicButton)
        Me.Controls.Add(Me.colorButton)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resultsLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bmiLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.heightField)
        Me.Controls.Add(Me.weightField)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents weightField As System.Windows.Forms.TextBox
    Friend WithEvents heightField As System.Windows.Forms.TextBox
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents bmiLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents resultsLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents colorButton As System.Windows.Forms.Button
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents musicButton As System.Windows.Forms.Button

End Class
