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
        Me.businessOption = New System.Windows.Forms.RadioButton()
        Me.residentialOption = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.channelsBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.connectionsBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalDueLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'businessOption
        '
        Me.businessOption.AutoSize = True
        Me.businessOption.Location = New System.Drawing.Point(13, 28)
        Me.businessOption.Name = "businessOption"
        Me.businessOption.Size = New System.Drawing.Size(67, 17)
        Me.businessOption.TabIndex = 0
        Me.businessOption.TabStop = True
        Me.businessOption.Text = "&Business"
        Me.businessOption.UseVisualStyleBackColor = True
        '
        'residentialOption
        '
        Me.residentialOption.AutoSize = True
        Me.residentialOption.Location = New System.Drawing.Point(13, 52)
        Me.residentialOption.Name = "residentialOption"
        Me.residentialOption.Size = New System.Drawing.Size(77, 17)
        Me.residentialOption.TabIndex = 1
        Me.residentialOption.TabStop = True
        Me.residentialOption.Text = "&Residential"
        Me.residentialOption.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Premium Channels:"
        '
        'channelsBox
        '
        Me.channelsBox.FormattingEnabled = True
        Me.channelsBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.channelsBox.Location = New System.Drawing.Point(126, 52)
        Me.channelsBox.Name = "channelsBox"
        Me.channelsBox.Size = New System.Drawing.Size(94, 95)
        Me.channelsBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Connections"
        '
        'connectionsBox
        '
        Me.connectionsBox.FormattingEnabled = True
        Me.connectionsBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.connectionsBox.Location = New System.Drawing.Point(285, 52)
        Me.connectionsBox.Name = "connectionsBox"
        Me.connectionsBox.Size = New System.Drawing.Size(91, 95)
        Me.connectionsBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Due"
        '
        'totalDueLabel
        '
        Me.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDueLabel.Location = New System.Drawing.Point(13, 216)
        Me.totalDueLabel.Name = "totalDueLabel"
        Me.totalDueLabel.Size = New System.Drawing.Size(167, 23)
        Me.totalDueLabel.TabIndex = 7
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(212, 215)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(301, 216)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 277)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalDueLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.connectionsBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.channelsBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.residentialOption)
        Me.Controls.Add(Me.businessOption)
        Me.Name = "Form1"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents businessOption As System.Windows.Forms.RadioButton
    Friend WithEvents residentialOption As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents channelsBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents connectionsBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalDueLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
