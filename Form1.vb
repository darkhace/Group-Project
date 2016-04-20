Public Class gameMenu
    Dim history As history = New history()

    Private Sub vsVaderBtn_Click(sender As Object, e As EventArgs) Handles vsVaderBtn.Click
        board.gameboard.player1.Login()
        setupMenu.player1RadioButton.Text = board.gameboard.player1.name
        board.gameboard.player2.setVader()
        setupMenu.player2RadioButton.Text = board.gameboard.player2.name
        Me.Hide()
        setupMenu.Show()
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        board.gameboard.player1.Register()
    End Sub

    Private Sub historyBtn_Click(sender As Object, e As EventArgs) Handles historyBtn.Click
        board.gameboard.player1.Login()
        'history.getName(player1.name)
    End Sub

    Private Sub vsPlayerBtn_Click(sender As Object, e As EventArgs) Handles vsPlayerBtn.Click
        board.gameboard.player1.Login()
        setupMenu.player1RadioButton.Text = board.gameboard.player1.name
        board.gameboard.player2.Login()
        setupMenu.player2RadioButton.Text = board.gameboard.player2.name
        Me.Hide()
        setupMenu.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
