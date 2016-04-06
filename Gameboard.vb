Public Class Gameboard
    Private vaderFlag As Integer
    Public stone(2) As Drawing.Color
    Private board As Array
    Public player1 As player = New player()
    Public player2 As player = New player()
    Private score1 As Integer
    Private score2 As Integer
    Private exitBtn As Button
    Private backBtn As Button

    Public Sub New()
        player1.name = ""
        player2.name = ""
        score1 = 0
        score2 = 0
        vaderFlag = 0
    End Sub

    Public Sub setDiff(ByVal Vader As Integer)
        vaderFlag = Vader
    End Sub
    Public Sub setPlayer(ByVal Nm1 As String, ByVal Nm2 As String)
        player1.name = Nm1
        player2.name = Nm2
    End Sub
    Public Sub easyVader()
        'If vaderflag is easy then run easy algorithm
    End Sub
    Public Sub medVader()
        'If vaderflag is medium then run hard algorithm
    End Sub
    Public Sub hardVader()
        'If vaderflag is hard then run hard algorithm
    End Sub
    Public Sub getScores(ByVal score1 As Integer, ByVal score2 As Integer)
        'Calculate the score 
        score1 = score1
        score2 = score2
    End Sub
    Public Sub setScores()
        'Open the file and add the scores
    End Sub
    Public Sub setStone(ByVal color As Color, ByVal color2 As Color)
        'Place the stone on the board
        stone(0) = Drawing.Color.Blue
        stone(1) = color2
    End Sub
    Public Sub exitButton()
        'Exit the board 
    End Sub
    Public Sub backButton()
        'Goes back to the previous menu
    End Sub
End Class
