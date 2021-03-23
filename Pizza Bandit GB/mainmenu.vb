Public Class mainmenu
    Dim charnum As Integer = 0

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mainmenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D And charnum < 2 Or e.KeyCode = Keys.Right And charnum < 2 Then
            charnum = charnum + 1
        End If
        If e.KeyCode = Keys.A And charnum > 0 Or e.KeyCode = Keys.Left And charnum > 0 Then
            charnum = charnum - 1
        End If

        If charnum = 0 Then
            Me.BackgroundImage = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/PB B Choose 1 Reggie.bmp")
        ElseIf charnum = 1 Then
            Me.BackgroundImage = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/PB B Choose 2 Cheeky.bmp")
        ElseIf charnum = 2 Then
            Me.BackgroundImage = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/PB B Choose 3 Suzie.bmp")
        End If

        If e.KeyCode = Keys.Enter Then
            If titlescreen.Visible = False Then
                Me.Hide()
                If charnum = 0 Then
                    foldername = "reggie"
                    charicter = "RR"
                ElseIf charnum = 1 Then
                    foldername = "Cheeky Pete"
                    charicter = "CP"
                ElseIf charnum = 2 Then
                    foldername = "Suzie Coo"
                    charicter = "SC"
                End If
                MainForm.Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/pics/" & foldername & "/" & charicter & "Up2.png")
            Else
                titlescreen.Visible = False
            End If
        End If
    End Sub
End Class