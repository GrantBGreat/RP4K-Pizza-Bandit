<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Me.titlescreen = New System.Windows.Forms.PictureBox()
        CType(Me.titlescreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlescreen
        '
        Me.titlescreen.Image = CType(resources.GetObject("titlescreen.Image"), System.Drawing.Image)
        Me.titlescreen.Location = New System.Drawing.Point(0, 0)
        Me.titlescreen.Name = "titlescreen"
        Me.titlescreen.Size = New System.Drawing.Size(872, 559)
        Me.titlescreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.titlescreen.TabIndex = 0
        Me.titlescreen.TabStop = False
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(876, 558)
        Me.Controls.Add(Me.titlescreen)
        Me.DoubleBuffered = True
        Me.Name = "mainmenu"
        Me.Text = "mainmenu"
        CType(Me.titlescreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titlescreen As PictureBox
End Class
