Public Class board
    'Dim Gameboard As Gameboard = New Gameboard(gameMenu.player1.name, gameMenu.player2.name)
    Public gameboard As Gameboard = New Gameboard()
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        setupMenu.Show()
    End Sub

    Private Sub board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player1stone.FillColor = gameboard.stone(0)
        player2stone.FillColor = gameboard.stone(1)
    End Sub
End Class