Imports System.IO

Public Class player
    Public name As String
    Private guest As String = "guest"
    Public Sub New()
        name = ""
    End Sub

    Public Sub Register()
        'Dim historyFile As Stream
        'open the file 
        name = InputBox("Enter player's username.", "Enter name")
        While name <> " "
            name = InputBox("Invalid username.", "Enter name")
        End While 'historyFile.
        'historyFile.WriteLine(name)
        'historyFile.Close()
        'Ask for the username 
        'If Nm is not in file add name to file 
        'else send error message
    End Sub

    Public Sub Login()
        'Dim historyFile As StreamReader
        'historyFile = File.OpenText("history.txt")
        name = InputBox("Enter player.", "Enter name")
            'If Nm exist in file
            'name = Nm
            'else send error message
    End Sub

    Public Sub setVader()
        name = "Vader"
    End Sub
End Class
