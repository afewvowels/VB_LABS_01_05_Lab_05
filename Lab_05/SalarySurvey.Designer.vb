<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalarySurvey
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.valuesLabel = New System.Windows.Forms.Label()
        Me.rangesLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'valuesLabel
        '
        Me.valuesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valuesLabel.Location = New System.Drawing.Point(150, 83)
        Me.valuesLabel.Name = "valuesLabel"
        Me.valuesLabel.Size = New System.Drawing.Size(51, 149)
        Me.valuesLabel.TabIndex = 14
        '
        'rangesLabel
        '
        Me.rangesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rangesLabel.Location = New System.Drawing.Point(12, 83)
        Me.rangesLabel.Name = "rangesLabel"
        Me.rangesLabel.Size = New System.Drawing.Size(113, 149)
        Me.rangesLabel.TabIndex = 13
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(12, 44)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(189, 24)
        Me.calculateButton.TabIndex = 12
        Me.calculateButton.Text = "Calculate"
        '
        'amountTextBox
        '
        Me.amountTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountTextBox.Location = New System.Drawing.Point(128, 12)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(73, 23)
        Me.amountTextBox.TabIndex = 11
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLabel.Location = New System.Drawing.Point(12, 15)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(110, 15)
        Me.amountLabel.TabIndex = 10
        Me.amountLabel.Text = "Enter sales amount:"
        '
        'SalarySurvey
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 253)
        Me.Controls.Add(Me.valuesLabel)
        Me.Controls.Add(Me.rangesLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.amountLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SalarySurvey"
        Me.Text = "Salary Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents valuesLabel As System.Windows.Forms.Label
   Friend WithEvents rangesLabel As System.Windows.Forms.Label
   Friend WithEvents calculateButton As System.Windows.Forms.Button
   Friend WithEvents amountTextBox As System.Windows.Forms.TextBox
   Friend WithEvents amountLabel As System.Windows.Forms.Label

End Class
