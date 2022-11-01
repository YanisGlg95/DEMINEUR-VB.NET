<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.ListBoxScoreTime = New System.Windows.Forms.ListBox()
        Me.ListBoxNbGames = New System.Windows.Forms.ListBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelNbGames = New System.Windows.Forms.Label()
        Me.ButtonReverse = New System.Windows.Forms.Button()
        Me.ListBoxTotalTime = New System.Windows.Forms.ListBox()
        Me.LabelTotalTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxNom
        '
        Me.ListBoxNom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(47, 75)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(117, 329)
        Me.ListBoxNom.TabIndex = 0
        '
        'ListBoxScore
        '
        Me.ListBoxScore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.Location = New System.Drawing.Point(189, 75)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(122, 329)
        Me.ListBoxScore.TabIndex = 1
        '
        'ListBoxScoreTime
        '
        Me.ListBoxScoreTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxScoreTime.FormattingEnabled = True
        Me.ListBoxScoreTime.Location = New System.Drawing.Point(342, 75)
        Me.ListBoxScoreTime.Name = "ListBoxScoreTime"
        Me.ListBoxScoreTime.Size = New System.Drawing.Size(119, 329)
        Me.ListBoxScoreTime.TabIndex = 2
        '
        'ListBoxNbGames
        '
        Me.ListBoxNbGames.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxNbGames.FormattingEnabled = True
        Me.ListBoxNbGames.Location = New System.Drawing.Point(496, 75)
        Me.ListBoxNbGames.Name = "ListBoxNbGames"
        Me.ListBoxNbGames.Size = New System.Drawing.Size(112, 329)
        Me.ListBoxNbGames.TabIndex = 3
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelNom.Location = New System.Drawing.Point(86, 47)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(42, 25)
        Me.LabelNom.TabIndex = 4
        Me.LabelNom.Text = "Nom"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelScore.Location = New System.Drawing.Point(212, 47)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(85, 25)
        Me.LabelScore.TabIndex = 5
        Me.LabelScore.Text = "Score Max"
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTime.Location = New System.Drawing.Point(376, 47)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(55, 25)
        Me.LabelTime.TabIndex = 6
        Me.LabelTime.Text = "Temps"
        '
        'LabelNbGames
        '
        Me.LabelNbGames.AutoSize = True
        Me.LabelNbGames.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelNbGames.Location = New System.Drawing.Point(493, 47)
        Me.LabelNbGames.Name = "LabelNbGames"
        Me.LabelNbGames.Size = New System.Drawing.Size(120, 25)
        Me.LabelNbGames.TabIndex = 7
        Me.LabelNbGames.Text = "Total de Parties"
        '
        'ButtonReverse
        '
        Me.ButtonReverse.BackColor = System.Drawing.Color.White
        Me.ButtonReverse.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonReverse.Location = New System.Drawing.Point(319, 434)
        Me.ButtonReverse.Name = "ButtonReverse"
        Me.ButtonReverse.Size = New System.Drawing.Size(152, 43)
        Me.ButtonReverse.TabIndex = 10
        Me.ButtonReverse.Text = "Retourner"
        Me.ButtonReverse.UseVisualStyleBackColor = False
        '
        'ListBoxTotalTime
        '
        Me.ListBoxTotalTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxTotalTime.FormattingEnabled = True
        Me.ListBoxTotalTime.Location = New System.Drawing.Point(642, 75)
        Me.ListBoxTotalTime.Name = "ListBoxTotalTime"
        Me.ListBoxTotalTime.Size = New System.Drawing.Size(112, 329)
        Me.ListBoxTotalTime.TabIndex = 11
        '
        'LabelTotalTime
        '
        Me.LabelTotalTime.AutoSize = True
        Me.LabelTotalTime.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalTime.Location = New System.Drawing.Point(643, 47)
        Me.LabelTotalTime.Name = "LabelTotalTime"
        Me.LabelTotalTime.Size = New System.Drawing.Size(111, 25)
        Me.LabelTotalTime.TabIndex = 12
        Me.LabelTotalTime.Text = "Temps cumulé"
        '
        'ScoreTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(809, 489)
        Me.Controls.Add(Me.LabelTotalTime)
        Me.Controls.Add(Me.ListBoxTotalTime)
        Me.Controls.Add(Me.ButtonReverse)
        Me.Controls.Add(Me.LabelNbGames)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ListBoxNbGames)
        Me.Controls.Add(Me.ListBoxScoreTime)
        Me.Controls.Add(Me.ListBoxScore)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Name = "ScoreTab"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxScore As ListBox
    Friend WithEvents ListBoxScoreTime As ListBox
    Friend WithEvents ListBoxNbGames As ListBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelNbGames As Label
    Friend WithEvents ButtonReverse As Button
    Friend WithEvents ListBoxTotalTime As ListBox
    Friend WithEvents LabelTotalTime As Label
End Class
