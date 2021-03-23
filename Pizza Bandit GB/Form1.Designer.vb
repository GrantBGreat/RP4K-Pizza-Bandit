<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Reggie = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hroad1 = New System.Windows.Forms.PictureBox()
        Me.hroad0 = New System.Windows.Forms.PictureBox()
        Me.vroad0 = New System.Windows.Forms.PictureBox()
        Me.vroad1 = New System.Windows.Forms.PictureBox()
        Me.vroad2 = New System.Windows.Forms.PictureBox()
        Me.vroad3 = New System.Windows.Forms.PictureBox()
        Me.Cage0 = New System.Windows.Forms.PictureBox()
        Me.Cage1 = New System.Windows.Forms.PictureBox()
        Me.Cage2 = New System.Windows.Forms.PictureBox()
        Me.Cage3 = New System.Windows.Forms.PictureBox()
        Me.lives0 = New System.Windows.Forms.PictureBox()
        Me.lives1 = New System.Windows.Forms.PictureBox()
        Me.lives2 = New System.Windows.Forms.PictureBox()
        CType(Me.Reggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hroad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hroad0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vroad0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vroad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vroad2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vroad3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lives0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lives2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reggie
        '
        Me.Reggie.BackColor = System.Drawing.Color.Transparent
        Me.Reggie.Image = CType(resources.GetObject("Reggie.Image"), System.Drawing.Image)
        Me.Reggie.Location = New System.Drawing.Point(128, 558)
        Me.Reggie.Name = "Reggie"
        Me.Reggie.Size = New System.Drawing.Size(50, 48)
        Me.Reggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Reggie.TabIndex = 0
        Me.Reggie.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'hroad1
        '
        Me.hroad1.Location = New System.Drawing.Point(-32, 556)
        Me.hroad1.Margin = New System.Windows.Forms.Padding(2)
        Me.hroad1.Name = "hroad1"
        Me.hroad1.Size = New System.Drawing.Size(1378, 50)
        Me.hroad1.TabIndex = 2
        Me.hroad1.TabStop = False
        Me.hroad1.Visible = False
        '
        'hroad0
        '
        Me.hroad0.Location = New System.Drawing.Point(-41, 200)
        Me.hroad0.Margin = New System.Windows.Forms.Padding(2)
        Me.hroad0.Name = "hroad0"
        Me.hroad0.Size = New System.Drawing.Size(1378, 50)
        Me.hroad0.TabIndex = 3
        Me.hroad0.TabStop = False
        Me.hroad0.Visible = False
        '
        'vroad0
        '
        Me.vroad0.Location = New System.Drawing.Point(128, -56)
        Me.vroad0.Margin = New System.Windows.Forms.Padding(2)
        Me.vroad0.Name = "vroad0"
        Me.vroad0.Size = New System.Drawing.Size(50, 1100)
        Me.vroad0.TabIndex = 4
        Me.vroad0.TabStop = False
        Me.vroad0.Visible = False
        '
        'vroad1
        '
        Me.vroad1.Location = New System.Drawing.Point(330, -71)
        Me.vroad1.Margin = New System.Windows.Forms.Padding(2)
        Me.vroad1.Name = "vroad1"
        Me.vroad1.Size = New System.Drawing.Size(50, 1100)
        Me.vroad1.TabIndex = 5
        Me.vroad1.TabStop = False
        Me.vroad1.Visible = False
        '
        'vroad2
        '
        Me.vroad2.Location = New System.Drawing.Point(742, -56)
        Me.vroad2.Margin = New System.Windows.Forms.Padding(2)
        Me.vroad2.Name = "vroad2"
        Me.vroad2.Size = New System.Drawing.Size(50, 1100)
        Me.vroad2.TabIndex = 6
        Me.vroad2.TabStop = False
        Me.vroad2.Visible = False
        '
        'vroad3
        '
        Me.vroad3.Location = New System.Drawing.Point(1030, -71)
        Me.vroad3.Margin = New System.Windows.Forms.Padding(2)
        Me.vroad3.Name = "vroad3"
        Me.vroad3.Size = New System.Drawing.Size(50, 1100)
        Me.vroad3.TabIndex = 7
        Me.vroad3.TabStop = False
        Me.vroad3.Visible = False
        '
        'Cage0
        '
        Me.Cage0.BackColor = System.Drawing.Color.Transparent
        Me.Cage0.Image = CType(resources.GetObject("Cage0.Image"), System.Drawing.Image)
        Me.Cage0.Location = New System.Drawing.Point(489, 344)
        Me.Cage0.Margin = New System.Windows.Forms.Padding(2)
        Me.Cage0.Name = "Cage0"
        Me.Cage0.Size = New System.Drawing.Size(42, 41)
        Me.Cage0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Cage0.TabIndex = 8
        Me.Cage0.TabStop = False
        '
        'Cage1
        '
        Me.Cage1.BackColor = System.Drawing.Color.Transparent
        Me.Cage1.Image = CType(resources.GetObject("Cage1.Image"), System.Drawing.Image)
        Me.Cage1.Location = New System.Drawing.Point(580, 344)
        Me.Cage1.Margin = New System.Windows.Forms.Padding(2)
        Me.Cage1.Name = "Cage1"
        Me.Cage1.Size = New System.Drawing.Size(42, 41)
        Me.Cage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Cage1.TabIndex = 9
        Me.Cage1.TabStop = False
        '
        'Cage2
        '
        Me.Cage2.BackColor = System.Drawing.Color.Transparent
        Me.Cage2.Image = CType(resources.GetObject("Cage2.Image"), System.Drawing.Image)
        Me.Cage2.Location = New System.Drawing.Point(580, 411)
        Me.Cage2.Margin = New System.Windows.Forms.Padding(2)
        Me.Cage2.Name = "Cage2"
        Me.Cage2.Size = New System.Drawing.Size(42, 41)
        Me.Cage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Cage2.TabIndex = 10
        Me.Cage2.TabStop = False
        '
        'Cage3
        '
        Me.Cage3.BackColor = System.Drawing.Color.Transparent
        Me.Cage3.Image = CType(resources.GetObject("Cage3.Image"), System.Drawing.Image)
        Me.Cage3.Location = New System.Drawing.Point(489, 411)
        Me.Cage3.Margin = New System.Windows.Forms.Padding(2)
        Me.Cage3.Name = "Cage3"
        Me.Cage3.Size = New System.Drawing.Size(42, 41)
        Me.Cage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Cage3.TabIndex = 11
        Me.Cage3.TabStop = False
        '
        'lives0
        '
        Me.lives0.BackColor = System.Drawing.Color.Transparent
        Me.lives0.Image = CType(resources.GetObject("lives0.Image"), System.Drawing.Image)
        Me.lives0.Location = New System.Drawing.Point(489, 726)
        Me.lives0.Name = "lives0"
        Me.lives0.Size = New System.Drawing.Size(64, 66)
        Me.lives0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.lives0.TabIndex = 12
        Me.lives0.TabStop = False
        '
        'lives1
        '
        Me.lives1.BackColor = System.Drawing.Color.Transparent
        Me.lives1.Image = CType(resources.GetObject("lives1.Image"), System.Drawing.Image)
        Me.lives1.Location = New System.Drawing.Point(559, 726)
        Me.lives1.Name = "lives1"
        Me.lives1.Size = New System.Drawing.Size(64, 66)
        Me.lives1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.lives1.TabIndex = 13
        Me.lives1.TabStop = False
        '
        'lives2
        '
        Me.lives2.BackColor = System.Drawing.Color.Transparent
        Me.lives2.Image = CType(resources.GetObject("lives2.Image"), System.Drawing.Image)
        Me.lives2.Location = New System.Drawing.Point(629, 726)
        Me.lives2.Name = "lives2"
        Me.lives2.Size = New System.Drawing.Size(64, 66)
        Me.lives2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.lives2.TabIndex = 14
        Me.lives2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1238, 804)
        Me.Controls.Add(Me.lives2)
        Me.Controls.Add(Me.lives1)
        Me.Controls.Add(Me.lives0)
        Me.Controls.Add(Me.Cage3)
        Me.Controls.Add(Me.Cage2)
        Me.Controls.Add(Me.Cage1)
        Me.Controls.Add(Me.Cage0)
        Me.Controls.Add(Me.Reggie)
        Me.Controls.Add(Me.vroad3)
        Me.Controls.Add(Me.vroad2)
        Me.Controls.Add(Me.vroad1)
        Me.Controls.Add(Me.vroad0)
        Me.Controls.Add(Me.hroad0)
        Me.Controls.Add(Me.hroad1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Pizza Bandit"
        CType(Me.Reggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hroad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hroad0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vroad0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vroad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vroad2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vroad3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lives0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lives2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Reggie As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents hroad1 As PictureBox
    Friend WithEvents hroad0 As PictureBox
    Friend WithEvents vroad0 As PictureBox
    Friend WithEvents vroad1 As PictureBox
    Friend WithEvents vroad2 As PictureBox
    Friend WithEvents vroad3 As PictureBox
    Friend WithEvents Cage0 As PictureBox
    Friend WithEvents Cage1 As PictureBox
    Friend WithEvents Cage2 As PictureBox
    Friend WithEvents Cage3 As PictureBox
    Friend WithEvents lives0 As PictureBox
    Friend WithEvents lives1 As PictureBox
    Friend WithEvents lives2 As PictureBox
End Class
