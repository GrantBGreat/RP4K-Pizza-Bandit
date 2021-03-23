<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YouLost
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
        Me.RestartButton1 = New System.Windows.Forms.Button()
        Me.Quit1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You Lose!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(And ran out of lives)"
        '
        'RestartButton1
        '
        Me.RestartButton1.BackColor = System.Drawing.Color.DarkRed
        Me.RestartButton1.Location = New System.Drawing.Point(254, 177)
        Me.RestartButton1.Name = "RestartButton1"
        Me.RestartButton1.Size = New System.Drawing.Size(138, 59)
        Me.RestartButton1.TabIndex = 2
        Me.RestartButton1.Text = "Restart"
        Me.RestartButton1.UseVisualStyleBackColor = False
        '
        'Quit1
        '
        Me.Quit1.BackColor = System.Drawing.Color.DarkRed
        Me.Quit1.Location = New System.Drawing.Point(254, 242)
        Me.Quit1.Name = "Quit1"
        Me.Quit1.Size = New System.Drawing.Size(138, 23)
        Me.Quit1.TabIndex = 3
        Me.Quit1.Text = "Quit"
        Me.Quit1.UseVisualStyleBackColor = False
        '
        'YouLost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(701, 361)
        Me.Controls.Add(Me.Quit1)
        Me.Controls.Add(Me.RestartButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "YouLost"
        Me.Text = "YouLost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RestartButton1 As Button
    Friend WithEvents Quit1 As Button
End Class
