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
        Me.displayTable = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numberTable = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'displayTable
        '
        Me.displayTable.Location = New System.Drawing.Point(384, 40)
        Me.displayTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.displayTable.Name = "displayTable"
        Me.displayTable.Size = New System.Drawing.Size(112, 37)
        Me.displayTable.TabIndex = 2
        Me.displayTable.Text = "&Display Table"
        Me.displayTable.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(384, 87)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(112, 37)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.ItemHeight = 21
        Me.listBox.Location = New System.Drawing.Point(47, 192)
        Me.listBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(178, 319)
        Me.listBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Multiplication Table:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Number:"
        '
        'numberTable
        '
        Me.numberTable.Location = New System.Drawing.Point(128, 40)
        Me.numberTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numberTable.Name = "numberTable"
        Me.numberTable.Size = New System.Drawing.Size(97, 29)
        Me.numberTable.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 556)
        Me.Controls.Add(Me.numberTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayTable)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Multiplication Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayTable As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents listBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numberTable As System.Windows.Forms.TextBox

End Class
