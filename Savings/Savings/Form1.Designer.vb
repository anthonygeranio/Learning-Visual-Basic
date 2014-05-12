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
        Me.BalanceListBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BalanceListBox
        '
        Me.BalanceListBox.FormattingEnabled = True
        Me.BalanceListBox.ItemHeight = 17
        Me.BalanceListBox.Location = New System.Drawing.Point(51, 43)
        Me.BalanceListBox.Name = "BalanceListBox"
        Me.BalanceListBox.Size = New System.Drawing.Size(155, 276)
        Me.BalanceListBox.TabIndex = 2
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(282, 79)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(133, 58)
        Me.calculateButton.TabIndex = 3
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 397)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.BalanceListBox)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BalanceListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
