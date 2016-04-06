Public Class setupMenu
    Dim count As Integer = 2
    Dim cStone(2) As Color

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        If player1RadioButton.Checked Then
            board.gameboard.setPlayer(player1RadioButton.Text, player2RadioButton.Text)
            GroupBox2.Text = board.gameboard.player1.name + " choose your color."
            If player2RadioButton.Text = "Vader" Then
                GroupBox1.Visible = False
                GroupBox3.Visible = True
            Else
                GroupBox2.Visible = True
                GroupBox1.Visible = False
            End If
        Else
            board.gameboard.setPlayer(player2RadioButton.Text, player1RadioButton.Text)
            GroupBox2.Text = board.gameboard.player1.name + " choose your color."
            If player2RadioButton.Text = "Vader" Then
                GroupBox1.Visible = False
                GroupBox3.Visible = True
            Else
                GroupBox2.Visible = True
                GroupBox1.Visible = False
            End If
        End If

        If easyRadioButton.Checked Or medRadioButton.Checked Or hardRadioButton.Checked Then
            GroupBox2.Visible = True
            GroupBox3.Visible = False
            count -= 1
        End If

        If count >= 1 Then
            If blueRadioButton.Checked Then
                blueRadioButton.Visible = False
                GroupBox2.Text = board.gameboard.player2.name + " choose your color."
                count -= 1
                cStone(count) = Color.Blue
            ElseIf greenRadioButton.Checked Then
                greenRadioButton.Visible = False
                GroupBox2.Text = board.gameboard.player2.name + " choose your color."
                count -= 1
                cStone(count) = Color.Green
            ElseIf yellowRadioButton.Checked Then
                yellowRadioButton.Visible = False
                GroupBox2.Text = board.gameboard.player2.name + " choose your color."
                count -= 1
                cStone(count) = Color.Yellow
            ElseIf redRadioButton.Checked Then
                redRadioButton.Visible = False
                GroupBox2.Text = board.gameboard.player2.name + " choose your color."
                count -= 1
                cStone(count) = Color.Red
            End If
        End If
        If count = 0 Then
            Me.Close()
            board.Show()
            If player2RadioButton.Text = "Vader" Then
                board.gameboard.setStone(cStone(1), Color.Black)
            Else
                board.gameboard.setStone(cStone(1), cStone(0))
            End If
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        gameMenu.Show()
    End Sub

    Private Sub setupMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player1RadioButton.Text = board.gameboard.player1.name
        player2RadioButton.Text = board.gameboard.player2.name
    End Sub
End Class