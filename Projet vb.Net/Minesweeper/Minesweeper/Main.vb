Module Main
    Private ClickTimes As Integer = 0
    Private Box(Form1.nbBox, Form1.nbBox) As Button
    Private GameStatus As Boolean = False
    Private BoxSize As Double = TLayoutPanel.TableLayoutPanel1.Height / Form1.nbBox

    Public Sub SetMines(nbMines As Integer)

        ' Configuration de la grille + mines
        Dim i As Integer
        Dim j As Integer
        For y As Integer = 1 To Form1.nbBox
            For x As Integer = 1 To Form1.nbBox
                Box(x, y) = New Button()
                Box(x, y).Location = New Point(i, j)
                AddHandler Box(x, y).MouseDown, AddressOf ClickBox
                Box(x, y).Width = BoxSize
                Box(x, y).Height = BoxSize
                Box(x, y).FlatStyle = FlatStyle.Flat
                Box(x, y).BackColor = Color.Gray
                Box(x, y).Tag = "Nothing"
                TLayoutPanel.TableLayoutPanel1.Controls.Add(Box(x, y))
                i += BoxSize
            Next
            i = 0
            j += BoxSize
        Next
        For m As Integer = 1 To nbMines
            Dim XPosition As Integer = CInt(Int((Form1.nbBox * Rnd()) + 1))
            Dim YPosition As Integer = CInt(Int((Form1.nbBox * Rnd()) + 1))
            Box(XPosition, YPosition).Tag = "Boom"
        Next
    End Sub

    Private Function MineIsThere(x As Integer, y As Integer)
        'Verifier si une case contient des mines
        If Box(x, y).Tag = "Boom" Or Box(x, y).Tag = "TargetedMine" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function NbMineSides(Box As Button)
        'Retourne le nombre de mines qui entoure une case
        Dim L As Point = Box.Location
        Dim xLoc As Integer = L.X / BoxSize + 1
        Dim YLoc As Integer = L.Y / BoxSize + 1
        Dim NbMines As Integer = 0
        For Lx As Integer = -1 To 1
            For Ly As Integer = -1 To 1
                Dim a As Integer = xLoc + Lx
                Dim b As Integer = YLoc + Ly
                If a > Form1.nbBox Or b > Form1.nbBox Or a < 1 Or b < 1 Then
                    Continue For
                End If
                If MineIsThere(a, b) Then
                    NbMines += 1
                End If
            Next
        Next
        Box.Tag = "Reveal"
        Return NbMines
    End Function

    Private Sub BoxExpansion(B As Button)
        'Découvre les cases avoisinante une autre case
        Dim p As Point = B.Location
        Dim px As Integer = p.X / BoxSize + 1
        Dim py As Integer = p.Y / BoxSize + 1
        Dim nbAdjaccentMines As Integer = 0
        For dx As Integer = -1 To 1
            For dy As Integer = -1 To 1
                Dim x As Integer = px + dx
                Dim y As Integer = py + dy
                If x > Form1.nbBox Or y > Form1.nbBox Or x < 1 Or y < 1 Then
                    Continue For
                End If
                Box(x, y).Text = NbMineSides(Box(x, y))
                Box(x, y).BackColor = Color.WhiteSmoke
                Box(x, y).Tag = "Reveal"
            Next
        Next
    End Sub

    Private Function EmptyBox() As Integer
        'Retourne la quantité de cases vides deja decouvertes sur la grille
        Dim Empty As Integer = 0
        For Each Button As Control In TLayoutPanel.TableLayoutPanel1.Controls
            If Button.Text = "0" Then
                Empty += 1
            End If
        Next
        Return EmptyBox
    End Function

    Private Function HiddenBox() As Integer
        'Retourne la quantitée de cases masquées sur la grille
        Dim HiddenBoxes As Integer = 0
        For Each Button As Control In TLayoutPanel.TableLayoutPanel1.Controls
            If Button.Tag = "Nothing" Then
                HiddenBoxes += 1
            End If
        Next
        Return HiddenBoxes
    End Function

    Private Function FindedBox() As Integer
        'Retourne la quantité de cases révélées sur la grille
        Dim FindedBoxes As Integer = 0
        For Each Button As Control In TLayoutPanel.TableLayoutPanel1.Controls
            If Button.Tag = "Reveal" Then
                FindedBoxes += 1
            End If
        Next
        Return FindedBox
    End Function

    Private Sub MarkBox(Box As Button)
        'Marque et démarque et colorie une case selon la situatuation
        Select Case Box.Tag
            Case "Labelled"
                Box.Tag = "Nothing"
                Box.Text = ""
                Box.BackColor = Color.Gray
                Exit Sub

            Case "Nothing"
                Box.Tag = "Marked"
                Box.Text = "X"
                Box.BackColor = Color.Gray

            Case "TargetedMine"
                Box.Tag = "Boom"
                Box.Text = ""
                Box.BackColor = Color.Yellow
                Exit Sub

            Case "Boom"
                Box.Tag = "TargetedMine"
                Box.Text = "X"
                Box.BackColor = Color.Gray
            Case "Reveal"
                Exit Sub
        End Select
    End Sub

    Private Sub BoxGameSituation(Boxes As Button)
        Select Case Boxes.Tag
            Case "Boom"
                ' Partie perdue
                If Settings.Timer = True Then
                    TLayoutPanel.Timer1.Stop()
                    GameTimeConfig(TLayoutPanel.Time - CInt(TLayoutPanel.LabelGTimer.Text))
                    MsgBox("Game Over :( . Temps joué: " & TotalGameTime() & " secondes. Cases découvertes: " & FindedBox())
                    SaveData()
                    DeleteNbOfLabelledBoxes()
                    Application.Restart()
                    Exit Sub
                Else
                    MsgBox("Game Over :( . Cases découvertes et temps joué: " & FindedBox() & "cases et " & TotalGameTime())
                    Application.Restart()
                    Exit Sub
                End If

            Case "Nothing"
                GameTimeConfig(FindedBox())
            Case "Labelled"
                Exit Sub
            Case "TargetedMine"
                Exit Sub
        End Select

        'Affiche le nombre de mines adjacentes

        Boxes.Text = NbMineSides(Boxes)

        'Decouvre les cases aux allentours s'il y a pas des mines
        If NbMineSides(Boxes) = 0 Then
            BoxExpansion(Boxes)
        End If
        Boxes.BackColor = Color.WhiteSmoke
        Boxes.Tag = "Reveal"

        'Découvre les cases autour de la grille sans mine adjacente
        For i As Integer = 0 To EmptyBox()
            For Each Button As Control In TLayoutPanel.TableLayoutPanel1.Controls
                If Button.Text = "0" Then
                    BoxExpansion(Button)
                End If
            Next
        Next

        If EmptyBox() = 0 Then
            'Si le timer est activé donc MsgBox avec le temps de partie + nobre de cases decouvertes
            'Sauvegarder la partie
            'Supprimer le nombre des cases decouvertes et redemarrer l'application
            If Settings.Timer = True Then
                TLayoutPanel.Timer1.Stop()
                GameTimeConfig(TLayoutPanel.Time - CInt(TLayoutPanel.LabelGTemps.Text))
                MsgBox("Vous avez gagné! Vous avez joué pendant " & TotalGameTime() & " secondes et découvert " & FindedBox() & " cases.")
                SaveData()
                DeleteNbOfLabelledBoxes()
                Application.Restart()
            End If
        End If

        'Remplace les 0 par des cases vides
        For Each Button As Control In TLayoutPanel.TableLayoutPanel1.Controls
            If Button.Text = "0" Then
                Button.Text = " "
            End If
        Next
    End Sub

    Private Sub ClickBox(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If Not GameStatus Then
            GameStatus = True
        End If

        If GameStatus And Not TLayoutPanel.Timer1.Enabled Then
            If Settings.Timer = True Then
                TLayoutPanel.Timer(sender, e)
            End If
        End If

        ' Configuration de chaque bouton de la souris
        If e.Button = MouseButtons.Left Then
            BoxGameSituation(sender)
        End If
        If e.Button = MouseButtons.Right Then
            MarkBox(sender)
        End If
    End Sub

End Module
