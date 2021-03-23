Public Class YouWin
    Private Sub Continuebutton_Click(sender As Object, e As EventArgs) Handles continuebutton.Click
        Me.Hide()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles Quitbutton.Click
        Me.Hide()
        Quit = True
    End Sub
End Class