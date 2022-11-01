Public Class TLayoutPanel
    Public Time As Integer = 60
    Public Mines As Integer = 10
    Public TimeLeft As Integer = Time
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialiser le timer et affichage du nom du joueur des l'ouverture de la fenetre
        LabelMines.Text = "Mines: " & Mines
        LabelGPlayerName.Text = Form1.ComboBoxPlayer.Text
        LabelGTimer.Text = Time
        Timer1.Interval = 1000
        Timer1.Start()
        If Settings.Timer = False Then
            LabelGTimer.Visible = True
        End If
        SetMines(Mines)

    End Sub

    Public Sub Timer(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelGTimer.Visible = True
        TimeLeft -= 1
        LabelGTimer.Text = TimeLeft
        If TimeLeft = 0 Then
            Timer1.Stop()
            MsgBox("Temps écoulé!!")
            MsgBox("Temps de partie: " & TotalGameTime() & " secondes." & " Cases découvertes: " & NbOfLabelledBoxes() & "  cases")
            GameTimeConfig(CInt(LabelGTimer.Text))
            SaveData()
            DeleteNbOfLabelledBoxes()
            Me.Hide()
            Form1.Show()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAbandonner.Click
        ' Config btn abandonner

        Timer1.Stop()

        If MsgBox("Voulez vous abandonner la partie ?" & vbCrLf & "La partie ne sera pas pris en compte.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Restart()
        ElseIf MsgBoxResult.No Then
            Timer1.Start()
        End If
    End Sub

End Class


