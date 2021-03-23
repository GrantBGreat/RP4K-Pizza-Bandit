Public Class YouLose
    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        Me.Hide()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Hide()
        Quit = True
    End Sub
End Class