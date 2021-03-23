Public Class YouLost
    Private Sub RestartButton1_Click(sender As Object, e As EventArgs) Handles RestartButton1.Click
        Me.Hide()
    End Sub

    Private Sub Quit1_Click(sender As Object, e As EventArgs) Handles Quit1.Click
        Me.Hide()
        Quit = True
    End Sub
End Class