Public Class ScoreTab
    Dim Space() As String
    Dim StreamReader As System.IO.StreamReader

    Private Sub ButtonReverse_Click(sender As Object, e As EventArgs) Handles ButtonReverse.Click
        Me.Close()
        Form1.Show()
    End Sub

    'Lire et ajouter les données du fichier txt dans chaque liste
    Private Sub ScoreTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StreamReader = My.Computer.FileSystem.OpenTextFileReader(Form1.Fichiertxt)
        While Not StreamReader.EndOfStream
            Space = StreamReader.ReadLine().Split(",")
            ListBoxNom.Items.Add(Space(0))
            ListBoxScore.Items.Add(Space(1) & " cases decouverte")
            ListBoxScoreTime.Items.Add(Space(2) & " secondes")
            ListBoxNbGames.Items.Add(Space(3) & " parties")
            ListBoxTotalTime.Items.Add(Space(4) & " secondes")
        End While
        StreamReader.Close()
    End Sub
End Class