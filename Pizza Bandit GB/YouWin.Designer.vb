<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YouWin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YouWin))
        Me.continuebutton = New System.Windows.Forms.Button()
        Me.Quitbutton = New System.Windows.Forms.Button()
        Me.youwinlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'continuebutton
        '
        Me.continuebutton.BackColor = System.Drawing.Color.Maroon
        Me.continuebutton.Location = New System.Drawing.Point(255, 201)
        Me.continuebutton.Name = "continuebutton"
        Me.continuebutton.Size = New System.Drawing.Size(157, 53)
        Me.continuebutton.TabIndex = 0
        Me.continuebutton.Text = "Continue"
        Me.continuebutton.UseVisualStyleBackColor = False
        '
        'Quitbutton
        '
        Me.Quitbutton.BackColor = System.Drawing.Color.Maroon
        Me.Quitbutton.Location = New System.Drawing.Point(255, 256)
        Me.Quitbutton.Name = "Quitbutton"
        Me.Quitbutton.Size = New System.Drawing.Size(157, 27)
        Me.Quitbutton.TabIndex = 1
        Me.Quitbutton.Text = "Quit"
        Me.Quitbutton.UseVisualStyleBackColor = False
        '
        'youwinlabel
        '
        Me.youwinlabel.AutoSize = True
        Me.youwinlabel.BackColor = System.Drawing.Color.Transparent
        Me.youwinlabel.Font = New System.Drawing.Font("Mistral", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.youwinlabel.Location = New System.Drawing.Point(180, 84)
        Me.youwinlabel.Name = "youwinlabel"
        Me.youwinlabel.Size = New System.Drawing.Size(338, 114)
        Me.youwinlabel.TabIndex = 2
        Me.youwinlabel.Text = "You Win!"
        '
        'YouWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 380)
        Me.Controls.Add(Me.youwinlabel)
        Me.Controls.Add(Me.Quitbutton)
        Me.Controls.Add(Me.continuebutton)
        Me.Name = "YouWin"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents continuebutton As Button
    Friend WithEvents Quitbutton As Button
    Friend WithEvents youwinlabel As Label
End Class
