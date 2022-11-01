Public Class Settings
    Public Timer As Boolean



    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If RadioButtonEz.Checked Then
            Form1.nbBox = 8
        End If
        If RadioButtonNormal.Checked Then
            Form1.nbBox = 15
        End If
        If RadioButtonHard.Checked Then
            Form1.nbBox = 18
        End If


        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFeinte_Click(sender As Object, e As EventArgs) Handles ButtonFeinte.Click
        If MsgBox("Aucune donnée ne sera pas prise en compte", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBoxTime_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTime.CheckedChanged
        ' Timer
        If CheckBoxTime.Checked = True Then
            TLayoutPanel.Timer1.Enabled = False
        ElseIf CheckBoxTime.Checked = False Then
            TLayoutPanel.Timer1.Enabled = True
        End If
    End Sub
End Class