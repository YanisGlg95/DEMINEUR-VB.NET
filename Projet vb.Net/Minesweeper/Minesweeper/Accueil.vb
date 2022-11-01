Public Class Form1

    Dim StreamReader As System.IO.StreamReader
    Public Fichiertxt As String = "DataPlayer.txt"
    Public nbBox As Integer = 8

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        'MsgBox de confirmation avant de quitter l'application

        Dim Sortie As Integer
        Sortie = MsgBox("Voulez vous vraiment quitter?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
        If Sortie = vbYes Then
            Close()
        End If
    End Sub

    Private Sub ButtonLancer_Click(sender As Object, e As EventArgs) Handles ButtonLancer.Click

        'Si le nom saisi < 3, MsgBox, si non, ouvrir demineur
        If ComboBoxPlayer.Text.Length < 3 Then
            MsgBox("Veuillez introduire un nom avec 3 letres minimum")
            Exit Sub
        End If
        TLayoutPanel.Show()
        Me.Hide()
    End Sub


    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        ScoreTab.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonReglages.Click
        Settings.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StreamReader = My.Computer.FileSystem.OpenTextFileReader(Fichiertxt)
        While Not StreamReader.EndOfStream
            Dim Space = StreamReader.ReadLine().Split(" | ")
            ComboBoxPlayer.Items.Add(Space(0))
        End While
        StreamReader.Close()
    End Sub

    Private Sub ComboBoxPlayer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPlayer.SelectedIndexChanged

    End Sub
End Class
