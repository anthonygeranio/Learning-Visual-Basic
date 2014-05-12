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
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.monthlyPurchase = New System.Windows.Forms.TextBox()
        Me.rewardLabel = New System.Windows.Forms.Label()
        Me.basicRadio = New System.Windows.Forms.RadioButton()
        Me.standardRadio = New System.Windows.Forms.RadioButton()
        Me.premiumRadio = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(198, 207)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(279, 207)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Total monthly purchase ($):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reward points:"
        '
        'monthlyPurchase
        '
        Me.monthlyPurchase.Location = New System.Drawing.Point(26, 60)
        Me.monthlyPurchase.Name = "monthlyPurchase"
        Me.monthlyPurchase.Size = New System.Drawing.Size(132, 20)
        Me.monthlyPurchase.TabIndex = 1
        '
        'rewardLabel
        '
        Me.rewardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rewardLabel.Location = New System.Drawing.Point(26, 207)
        Me.rewardLabel.Name = "rewardLabel"
        Me.rewardLabel.Size = New System.Drawing.Size(132, 23)
        Me.rewardLabel.TabIndex = 6
        '
        'basicRadio
        '
        Me.basicRadio.AutoSize = True
        Me.basicRadio.Location = New System.Drawing.Point(279, 60)
        Me.basicRadio.Name = "basicRadio"
        Me.basicRadio.Size = New System.Drawing.Size(51, 17)
        Me.basicRadio.TabIndex = 2
        Me.basicRadio.TabStop = True
        Me.basicRadio.Text = "&Basic"
        Me.basicRadio.UseVisualStyleBackColor = True
        '
        'standardRadio
        '
        Me.standardRadio.AutoSize = True
        Me.standardRadio.Location = New System.Drawing.Point(279, 92)
        Me.standardRadio.Name = "standardRadio"
        Me.standardRadio.Size = New System.Drawing.Size(68, 17)
        Me.standardRadio.TabIndex = 3
        Me.standardRadio.TabStop = True
        Me.standardRadio.Text = "&Standard"
        Me.standardRadio.UseVisualStyleBackColor = True
        '
        'premiumRadio
        '
        Me.premiumRadio.AutoSize = True
        Me.premiumRadio.Location = New System.Drawing.Point(279, 126)
        Me.premiumRadio.Name = "premiumRadio"
        Me.premiumRadio.Size = New System.Drawing.Size(65, 17)
        Me.premiumRadio.TabIndex = 4
        Me.premiumRadio.TabStop = True
        Me.premiumRadio.Text = "&Premium"
        Me.premiumRadio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 260)
        Me.Controls.Add(Me.premiumRadio)
        Me.Controls.Add(Me.standardRadio)
        Me.Controls.Add(Me.basicRadio)
        Me.Controls.Add(Me.rewardLabel)
        Me.Controls.Add(Me.monthlyPurchase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Name = "Form1"
        Me.Text = "Shopper Stoppers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents monthlyPurchase As System.Windows.Forms.TextBox
    Friend WithEvents rewardLabel As System.Windows.Forms.Label
    Friend WithEvents basicRadio As System.Windows.Forms.RadioButton
    Friend WithEvents standardRadio As System.Windows.Forms.RadioButton
    Friend WithEvents premiumRadio As System.Windows.Forms.RadioButton

End Class
