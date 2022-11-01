Module GameInfoAndSetting
    Private StreamWriter As System.IO.StreamWriter
    Private FinalGameTime As Integer
    Private nbLabelledBoxes As Integer = 0
    Private GameTime As Integer
    Private PlayerID As String = Form1.ComboBoxPlayer.Text
    Private Readlines() As String = IO.File.ReadAllLines(Form1.Fichiertxt)
    Private TotalGamesPlayed As Integer

    Public Sub DeleteNbOfLabelledBoxes()
        nbLabelledBoxes = 0
    End Sub

    Public Sub LabelledBoxesConfig(n As Integer)
        nbLabelledBoxes = n
    End Sub

    Public Sub DeleteGameData()
        nbLabelledBoxes = 0
        GameTime = 0
        TotalGamesPlayed = 0
        FinalGameTime = 0
    End Sub

    Public Function TotalGameTime() As Integer
        Return GameTime
    End Function

    Public Sub GameTimeConfig(setTime As Integer)
        GameTime = setTime
    End Sub

    Public Function NbOfLabelledBoxes() As Integer
        Return nbLabelledBoxes
    End Function

    ' Regarde si le joueur existe dans le fichier txt
    Public Sub SaveData()
        nbLabelledBoxes += 1
        For i As Integer = 0 To Readlines.Length - 1
            If Readlines(i).Contains(PlayerID) Then
                Dim Space() As String = Readlines(i).Split(",")
                TotalGamesPlayed = Space(3) + 1
                FinalGameTime = Space(4) + GameTime
                If nbLabelledBoxes > Space(2) Then
                    Readlines(i) = Space(0) & "," & nbLabelledBoxes & "," & GameTime & "," & TotalGamesPlayed & "," & FinalGameTime
                Else
                    Readlines(i) = Space(0) & "," & Space(1) & "," & Space(2) & "," & TotalGamesPlayed & "," & FinalGameTime
                End If
                IO.File.WriteAllLines(Form1.Fichiertxt, Readlines)
                Exit Sub
            End If
        Next

        'Enregistre les donnés d'un nouveau joueur
        StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Form1.Fichiertxt, True)
        StreamWriter.WriteLine(PlayerID & "," & nbLabelledBoxes & "," & GameTime & "," & TotalGamesPlayed + 1 & "," & FinalGameTime + GameTime)
        StreamWriter.Close()
    End Sub
End Module
