Public Class Gameboard
    Private vaderFlag As Integer
    Public stone(2) As Drawing.Color
    Private board(6, 6) As Integer
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
        player1.turnNum = 1
        player2.name = Nm2
        player2.turnNum = 2
    End Sub

    Public Sub easyVader()

        Dim vaderTurn As Integer                        'variable to hold the numerical value for the AI's turn
        Dim playerTurn As Integer                       'variable to hold the numerical value for the player's turn
        Dim flagFound As Boolean = False                'variable used to control the while loop
        Dim vaderMove1 As Integer                       'variable to hold AI selection of the first dimension of the array
        Dim vaderMove2 As Integer                       'variable to hold AI selection of the second dimension of the array

        If player1.name = "Vader" Then                  'if statement to set the vaderTurn and playerTurn variables
            vaderTurn = 1                               'to their corresponding values to use in Vader's move selection
            playerTurn = 2
        Else
            vaderTurn = 2
            playerTurn = 1
        End If

        Do                                                           'Do While loop to select a random position and check it for vader's selection. If position is taken the loop iterates again and checks a new position

            vaderMove1 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0   'assigns a random integer between and including 0 and 5
            vaderMove2 = CInt(Math.Floor((5 - 0 + 1) * Rnd())) + 0   'assigns a random integer between and including 0 and 5

            If board(vaderMove1, vaderMove2) = 0 Then
                board(vaderMove1, VaderMove2) = vaderTurn
                flagFound = True
            End If

        Loop While flagFound = False

    End Sub

    Public Sub medVader()

        Dim vaderTurn As Integer                        'variable to hold the numerical value for the AI's turn
        Dim playerTurn As Integer                       'variable to hold the numerical value for the player's turn
        Dim flagFound As Boolean = False                'variable used to control the while loop
        Dim vaderMove1 As Integer                       'variable to hold AI selection of the first dimension of the array
        Dim vaderMove2 As Integer                       'variable to hold AI selection of the second dimension of the array
        Dim loopFlag As Boolean = False                 'variable to tell if the AI has selected a move

        If player1.name = "Vader" Then                  'if statement to set the vaderTurn and playerTurn variables
            vaderTurn = 1                               'to their corresponding values to use in Vader's move selection
            playerTurn = 2
        Else
            vaderTurn = 2
            playerTurn = 1
        End If

        For i As Integer = 0 To 5
            If i = 
            End Select
        Next

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
