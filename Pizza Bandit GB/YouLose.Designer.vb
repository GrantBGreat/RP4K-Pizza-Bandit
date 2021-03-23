<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YouLose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YouLose))
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.YouLosebackround = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.YouLosebackround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RestartButton
        '
        Me.RestartButton.BackColor = System.Drawing.Color.Maroon
        Me.RestartButton.Location = New System.Drawing.Point(425, 337)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(304, 107)
        Me.RestartButton.TabIndex = 0
        Me.RestartButton.Text = "Restart"
        Me.RestartButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.Maroon
        Me.QuitButton.Location = New System.Drawing.Point(425, 450)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(304, 42)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'YouLosebackround
        '
        Me.YouLosebackround.Image = CType(resources.GetObject("YouLosebackround.Image"), System.Drawing.Image)
        Me.YouLosebackround.Location = New System.Drawing.Point(-271, -253)
        Me.YouLosebackround.Name = "YouLosebackround"
        Me.YouLosebackround.Size = New System.Drawing.Size(2153, 1307)
        Me.YouLosebackround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.YouLosebackround.TabIndex = 2
        Me.YouLosebackround.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Viner Hand ITC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(849, 271)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "You Lose!"
        '
        'YouLose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1156, 610)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.YouLosebackround)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YouLose"
        Me.Text = "You Lose!"
        CType(Me.YouLosebackround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RestartButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents YouLosebackround As PictureBox
    Friend WithEvents Label2 As Label
End Class
