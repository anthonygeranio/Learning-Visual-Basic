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
        Me.searchButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.warehouseA = New System.Windows.Forms.ListBox()
        Me.warehouseB = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Location:"
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(309, 37)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 36)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "&Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(309, 93)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 36)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(28, 75)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(87, 29)
        Me.idBox.TabIndex = 3
        '
        'locationLabel
        '
        Me.locationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.locationLabel.Location = New System.Drawing.Point(167, 75)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(72, 26)
        Me.locationLabel.TabIndex = 4
        '
        'warehouseA
        '
        Me.warehouseA.FormattingEnabled = True
        Me.warehouseA.ItemHeight = 21
        Me.warehouseA.Items.AddRange(New Object() {"AB11", "AB14", "AB21", "HY16", "JK56", "MM12", "PY63", "PY64"})
        Me.warehouseA.Location = New System.Drawing.Point(28, 172)
        Me.warehouseA.Name = "warehouseA"
        Me.warehouseA.Size = New System.Drawing.Size(87, 193)
        Me.warehouseA.TabIndex = 8
        '
        'warehouseB
        '
        Me.warehouseB.FormattingEnabled = True
        Me.warehouseB.ItemHeight = 21
        Me.warehouseB.Items.AddRange(New Object() {"AB20", "JK52", "JM17", "PJ23", "TR16"})
        Me.warehouseB.Location = New System.Drawing.Point(171, 172)
        Me.warehouseB.Name = "warehouseB"
        Me.warehouseB.Size = New System.Drawing.Size(87, 193)
        Me.warehouseB.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Warehouse &A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Warehouse &B"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 383)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.warehouseB)
        Me.Controls.Add(Me.warehouseA)
        Me.Controls.Add(Me.locationLabel)
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Zena Manufacturing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents idBox As System.Windows.Forms.TextBox
    Friend WithEvents locationLabel As System.Windows.Forms.Label
    Friend WithEvents warehouseA As System.Windows.Forms.ListBox
    Friend WithEvents warehouseB As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
