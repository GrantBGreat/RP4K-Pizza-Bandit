Public Class MainForm
    Public Shared mainmenuform As New mainmenu
    Dim TouchingCage As Integer
    Dim PlayCaught As Boolean
    Dim Caughtanimationtime As Integer
    Public Shared YouLostForm As New YouLost
    Dim lifepics(2) As PictureBox
    Dim lives As Integer
    Dim Pizzaseaten As Integer
    Dim numpizzas As Integer
    Dim Pizzas() As PictureBox
    Dim movingcagenum As Integer
    Dim screenOffset As PointF
    Dim firstfootforward As Boolean
    Dim direction As Integer
    Dim hroads(1) As PictureBox
    Dim vroads(3) As PictureBox
    Dim Cages(3) As PictureBox
    Dim Cagedirections(3) As Integer
    Dim Cagestate(3) As Integer
    Const INBOX As Integer = 0
    Const LEAVINGBOX As Integer = 1
    Const REGULAR As Integer = 2
    Const CAUGHTFRAMETIME As Integer = 5
    Public Shared YouLoseForm As New YouLose
    Public Shared YouWinForm As New YouWin


    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Or e.KeyCode = Keys.W Or e.KeyCode = Keys.A Or e.KeyCode = Keys.D Then
            direction = e.KeyCode
        End If
    End Sub

    Private Sub MoveUp(ByVal guy As PictureBox, ByVal speed As Integer)
        guy.Top = guy.Top - speed
        If guy.Top < 0 Then
            guy.Top = Me.Size.Height
        End If
    End Sub
    Private Sub MoveLeft(ByVal guy As PictureBox, ByVal speed As Integer)
        guy.Left = guy.Left - speed
        If guy.Left < 0 Then
            guy.Left = Me.Size.Width
        End If
    End Sub
    Private Sub MoveRight(ByVal guy As PictureBox, ByVal speed As Integer)
        guy.Left = guy.Left + speed
        If guy.Left > Me.Size.Width Then
            guy.Left = 0
        End If
    End Sub
    Private Sub MoveDown(ByVal guy As PictureBox, ByVal speed As Integer)
        guy.Top = guy.Top + speed
        If guy.Top > Me.Size.Height Then
            guy.Top = 0
        End If


    End Sub
    Private Sub AnimateUp()
        If firstfootforward Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "Up1.png")
            firstfootforward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "Up2.png")
            firstfootforward = True
        End If
    End Sub
    Private Sub AnimateLeft()
        If firstfootforward Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "lt1.png")
            firstfootforward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "lt2.png")
            firstfootforward = True
        End If
    End Sub
    Private Sub AnimateRight()
        If firstfootforward Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "Rt1.png")
            firstfootforward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "Rt2.png")
            firstfootforward = True
        End If
    End Sub
    Private Sub AnimateDown()
        If firstfootforward Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "dn1.png")
            firstfootforward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "dn2.png")
            firstfootforward = True
        End If
    End Sub

    Private Sub AnimateCages(ByVal cagenum As Integer)
        If Cagedirections(cagenum) = Keys.W Then
            Cages(cagenum).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/Cages/RoboCage" & cagenum & "T.png")
        End If
        If Cagedirections(cagenum) = Keys.A Then
            Cages(cagenum).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/Cages/RoboCage" & cagenum & "L.png")
        End If
        If Cagedirections(cagenum) = Keys.S Then
            Cages(cagenum).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/Cages/RoboCage" & cagenum & "D.png")
        End If
        If Cagedirections(cagenum) = Keys.D Then
            Cages(cagenum).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/Cages/RoboCage" & cagenum & "R.png")
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quit = False
        mainmenuform.ShowDialog
        lifepics(0) = lives0
        lifepics(1) = lives1
        lifepics(2) = lives2
        lives = 3
        Timer1.Start()
        Pizzaseaten = 0
        hroads(0) = hroad0
        hroads(1) = hroad1

        vroads(0) = vroad0
        vroads(1) = vroad1
        vroads(2) = vroad2
        vroads(3) = vroad3

        Cages(0) = Cage0
        Cages(1) = Cage1
        Cages(2) = Cage2

        Cages(3) = Cage3

        ResetLevel()
        Pizzaset()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Quit = True Then
            Me.Close()
        End If

        If PlayCaught = False Then
            rungame()
        Else
            AnimateCaught()
        End If
    End Sub

    Private Sub rungame()
        Eatpizzas()
        MoveReggie()
        Moveoutofbox()
        For index = 0 To 3
            MoveCages(index)
            AnimateCages(index)
            If (AtInterSection(index) = True) Then
                Chasereggie(index)
            End If
            If Touching(Cages(index), Reggie) Then
                Reggie.Visible = False
                TouchingCage = index  ' Which cage is touching reggie
                PlayCaught = True
                Caughtanimationtime = 0
            End If
        Next index
    End Sub

    Private Sub AnimateCaught()
        Caughtanimationtime = Caughtanimationtime + 1

        Dim picnum As Integer = Math.Floor(Caughtanimationtime / CAUGHTFRAMETIME)
        Cages(TouchingCage).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
             "/pics/" & foldername & "/Trapped Sequence/" & charicter & "trapped" & picnum & ".bmp")

        If Caughtanimationtime = CAUGHTFRAMETIME * 5 - 1 Then
            killReggie()
        End If
    End Sub

    Private Sub killReggie()
        Timer1.Stop()
        If lives > 0 Then
            lives = lives - 1
            If lifepics(lives).Visible = True Then
                lifepics(lives).Visible = False
            End If
            YouLoseForm.ShowDialog()
        Else
            YouLostForm.ShowDialog()
            For i = 0 To numpizzas - 1
                Pizzas(i).Visible = True
            Next i
            lives = 3
            lifepics(0).Visible = True
            lifepics(1).Visible = True
            lifepics(2).Visible = True
        End If
        ResetLevel()
        Timer1.Start()
    End Sub
    Private Sub MoveReggie()
        For index = 0 To 3
            If Touching(Reggie, vroads(index)) Then
                If direction = Keys.W Then
                    MoveUp(Reggie, 10)
                    AnimateUp()
                    Reggie.Left = vroads(index).Left
                End If
                If direction = Keys.S Then
                    MoveDown(Reggie, 10)
                    AnimateDown()
                    Reggie.Left = vroads(index).Left
                End If
            End If
        Next index
        For index = 0 To 1
            If Touching(Reggie, hroads(index)) Then
                If direction = Keys.A Then
                    MoveLeft(Reggie, 10)
                    AnimateLeft()
                    Reggie.Top = hroads(index).Top
                End If
                If direction = Keys.D Then
                    MoveRight(Reggie, 10)
                    AnimateRight()
                    Reggie.Top = hroads(index).Top
                End If
            End If
        Next index
    End Sub

    Private Sub MoveCages(ByVal CageNum As Integer)
        For index = 0 To 3
            If Touching(Cages(CageNum), vroads(index)) Then
                If Cagedirections(CageNum) = Keys.W Then
                    MoveUp(Cages(CageNum), 7)
                    Cages(CageNum).Left = vroads(index).Left
                End If
                If Cagedirections(CageNum) = Keys.S Then
                    MoveDown(Cages(CageNum), 7)
                    Cages(CageNum).Left = vroads(index).Left
                End If
            End If
        Next index

        For index = 0 To 1
            If Touching(Cages(CageNum), hroads(index)) Then
                If Cagedirections(CageNum) = Keys.A Then
                    MoveLeft(Cages(CageNum), 7)
                    Cages(CageNum).Top = hroads(index).Top
                End If
                If Cagedirections(CageNum) = Keys.D Then
                    MoveRight(Cages(CageNum), 7)
                    Cages(CageNum).Top = hroads(index).Top
                End If
            End If
        Next index
    End Sub

    Private Sub Cageset()
        Cages(0).Left = 500
        Cages(0).Top = 335
        Cages(1).Left = 586
        Cages(1).Top = 335
        Cages(2).Left = 500
        Cages(2).Top = 400
        Cages(3).Left = 586
        Cages(3).Top = 400
        Cagedirections(0) = Keys.A
        Cagedirections(1) = Keys.D
        Cagedirections(2) = Keys.A
        Cagedirections(3) = Keys.D
        Cagestate(0) = INBOX
        Cagestate(1) = INBOX
        Cagestate(2) = INBOX
        Cagestate(3) = INBOX
        movingcagenum = 0
    End Sub

    Private Sub Moveoutofbox()
        If Cagestate(movingcagenum) = INBOX Then
            Cages(movingcagenum).Left = 529
            Cages(movingcagenum).Top = 415
            Cagestate(movingcagenum) = LEAVINGBOX
        ElseIf Cagestate(movingcagenum) = LEAVINGBOX Then
            MoveUp(Cages(movingcagenum), 5)
            If Touching(Cages(movingcagenum), hroads(0)) Then
                Cagestate(movingcagenum) = REGULAR
                If movingcagenum < 3 Then
                    movingcagenum = movingcagenum + 1
                End If
            End If
        End If
    End Sub

    Private Sub Chasereggie(ByVal Cagenum As Integer)
        Dim xdistance As Integer
        Dim ydistance As Integer

        xdistance = Math.Abs(Cages(Cagenum).Left - Reggie.Left)
        ydistance = Math.Abs(Cages(Cagenum).Top - Reggie.Top)

        If xdistance > ydistance Then
            If Reggie.Left > Cages(Cagenum).Left Then
                Cagedirections(Cagenum) = Keys.D
            ElseIf Reggie.Left < Cages(Cagenum).Left Then
                Cagedirections(Cagenum) = Keys.A
            End If
        Else
            If Reggie.Top < Cages(Cagenum).Top Then
                Cagedirections(Cagenum) = Keys.W
            ElseIf Reggie.Top > Cages(Cagenum).Top Then
                Cagedirections(Cagenum) = Keys.S
            End If
        End If
    End Sub

    Private Function AtInterSection(ByVal Cagenum As Integer)
        For index = 0 To 3
            For index1 = 0 To 1
                If Touching(Cages(Cagenum), vroads(index)) And Touching(Cages(Cagenum), hroads(index1)) Then
                    Return True
                End If
            Next index1
        Next index
        Return False
    End Function

    Private Sub Pizzaset()
        Dim vspace As Integer = 70
        Dim hspace As Integer = 78
        Dim vpizzas As Integer = Me.Height / vspace
        Dim hpizzas As Integer = Me.Width / hspace
        Dim X, Y As Integer
        Dim pindex As Integer = 0
        numpizzas = vpizzas * 4 + hpizzas * 2
        Array.Resize(Pizzas, numpizzas)
        For index = 0 To 1
            X = hspace - 11
            Y = hroads(index).Top + hroads(index).Height / 2
            For i = 0 To hpizzas - 1
                Pizzas(pindex) = New PictureBox
                Pizzas(pindex).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/pizzasmall.png")
                Pizzas(pindex).Left = X
                Pizzas(pindex).Top = Y - Pizzas(pindex).Image.Height / 2
                Pizzas(pindex).SizeMode = PictureBoxSizeMode.AutoSize
                Pizzas(pindex).Visible = True
                Pizzas(pindex).BackColor = Color.Transparent
                Me.Controls.Add(Pizzas(pindex))
                pindex = pindex + 1
                X = X + hspace
            Next i
        Next index
        For index = 0 To 3
            Y = vspace - 11
            X = vroads(index).Left + vroads(index).Width / 2
            For i = 0 To vpizzas - 1
                Pizzas(pindex) = New PictureBox
                Pizzas(pindex).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/pizzasmall.png")
                Pizzas(pindex).Left = X - Pizzas(pindex).Image.Width / 2
                Pizzas(pindex).Top = Y
                Pizzas(pindex).SizeMode = PictureBoxSizeMode.AutoSize
                Pizzas(pindex).Visible = True
                Pizzas(pindex).BackColor = Color.Transparent
                Me.Controls.Add(Pizzas(pindex))
                pindex = pindex + 1
                Y = Y + vspace
            Next i
        Next index
    End Sub

    Private Sub Eatpizzas()
        For index = 0 To numpizzas - 1
            If Touching(Reggie, Pizzas(index)) And Pizzas(index).Visible = True Then
                Pizzas(index).Visible = False
                Pizzaseaten = Pizzaseaten + 1
            End If
        Next index
        If Pizzaseaten = numpizzas Then
            Timer1.Stop()
            YouWinForm.ShowDialog()
            ResetLevel()
            For index = 0 To numpizzas - 1
                Pizzas(index).Visible = True
            Next index
            Pizzaseaten = 0
            Timer1.Start()
        End If
    End Sub

    Private Sub ResetLevel()
        Cageset()
        Reggie.Top = 561
        Reggie.Left = 133
        Reggie.Visible = True
        PlayCaught = False
    End Sub



    Private Function Touching(ByVal objl As PictureBox, ByVal obj2 As PictureBox)
        If objl.Left < obj2.Right And objl.Right > obj2.Left Then
            If objl.Top < obj2.Bottom And objl.Bottom > obj2.Top Then
                Return True
            End If
        End If
        Return False
    End Function

End Class
