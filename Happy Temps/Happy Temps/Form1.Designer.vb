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
        Me.optionOneTotal = New System.Windows.Forms.Label()
        Me.optionTwoTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optionOneBox = New System.Windows.Forms.ListBox()
        Me.optionTwoBox = New System.Windows.Forms.ListBox()
        Me.compareOptions = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Option &1 (starts at $1 and then doubles each day for the next 9 days"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(191, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Option &2 ($100 per day for 10 days):"
        '
        'optionOneTotal
        '
        Me.optionOneTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optionOneTotal.Location = New System.Drawing.Point(26, 82)
        Me.optionOneTotal.Name = "optionOneTotal"
        Me.optionOneTotal.Size = New System.Drawing.Size(127, 23)
        Me.optionOneTotal.TabIndex = 2
        '
        'optionTwoTotal
        '
        Me.optionTwoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optionTwoTotal.Location = New System.Drawing.Point(194, 82)
        Me.optionTwoTotal.Name = "optionTwoTotal"
        Me.optionTwoTotal.Size = New System.Drawing.Size(130, 23)
        Me.optionTwoTotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Daily Pay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Daily Pay"
        '
        'optionOneBox
        '
        Me.optionOneBox.FormattingEnabled = True
        Me.optionOneBox.Location = New System.Drawing.Point(26, 195)
        Me.optionOneBox.Name = "optionOneBox"
        Me.optionOneBox.Size = New System.Drawing.Size(127, 173)
        Me.optionOneBox.TabIndex = 6
        '
        'optionTwoBox
        '
        Me.optionTwoBox.FormattingEnabled = True
        Me.optionTwoBox.Location = New System.Drawing.Point(194, 195)
        Me.optionTwoBox.Name = "optionTwoBox"
        Me.optionTwoBox.Size = New System.Drawing.Size(127, 173)
        Me.optionTwoBox.TabIndex = 7
        '
        'compareOptions
        '
        Me.compareOptions.Location = New System.Drawing.Point(375, 24)
        Me.compareOptions.Name = "compareOptions"
        Me.compareOptions.Size = New System.Drawing.Size(75, 23)
        Me.compareOptions.TabIndex = 8
        Me.compareOptions.Text = "&Compare"
        Me.compareOptions.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(375, 54)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 379)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.compareOptions)
        Me.Controls.Add(Me.optionTwoBox)
        Me.Controls.Add(Me.optionOneBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.optionTwoTotal)
        Me.Controls.Add(Me.optionOneTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Happy Temps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optionOneTotal As System.Windows.Forms.Label
    Friend WithEvents optionTwoTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optionOneBox As System.Windows.Forms.ListBox
    Friend WithEvents optionTwoBox As System.Windows.Forms.ListBox
    Friend WithEvents compareOptions As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
