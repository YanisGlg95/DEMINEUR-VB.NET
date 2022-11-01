<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBoxPlayer = New System.Windows.Forms.ComboBox()
        Me.ButtonLancer = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.LabelAccueil = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ButtonReglages = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxPlayer
        '
        Me.ComboBoxPlayer.FormattingEnabled = True
        Me.ComboBoxPlayer.Location = New System.Drawing.Point(322, 270)
        Me.ComboBoxPlayer.Name = "ComboBoxPlayer"
        Me.ComboBoxPlayer.Size = New System.Drawing.Size(145, 21)
        Me.ComboBoxPlayer.TabIndex = 0
        '
        'ButtonLancer
        '
        Me.ButtonLancer.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonLancer.Location = New System.Drawing.Point(339, 364)
        Me.ButtonLancer.Name = "ButtonLancer"
        Me.ButtonLancer.Size = New System.Drawing.Size(107, 50)
        Me.ButtonLancer.TabIndex = 2
        Me.ButtonLancer.Text = "Lancer"
        Me.ButtonLancer.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonQuitter.Location = New System.Drawing.Point(592, 364)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(107, 50)
        Me.ButtonQuitter.TabIndex = 3
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonScore
        '
        Me.ButtonScore.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonScore.Location = New System.Drawing.Point(87, 364)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(105, 50)
        Me.ButtonScore.TabIndex = 4
        Me.ButtonScore.Text = "Score"
        Me.ButtonScore.UseVisualStyleBackColor = True
        '
        'LabelAccueil
        '
        Me.LabelAccueil.AutoSize = True
        Me.LabelAccueil.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelAccueil.Location = New System.Drawing.Point(386, 47)
        Me.LabelAccueil.Name = "LabelAccueil"
        Me.LabelAccueil.Size = New System.Drawing.Size(63, 25)
        Me.LabelAccueil.TabIndex = 5
        Me.LabelAccueil.Text = "Accueil"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.Location = New System.Drawing.Point(362, 12)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(105, 25)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "MineSweeper"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelNom.Location = New System.Drawing.Point(172, 237)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(492, 25)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Veuillez introduire votre Nom / Pseudo avant de commencer la partie"
        '
        'ButtonReglages
        '
        Me.ButtonReglages.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonReglages.Location = New System.Drawing.Point(22, 12)
        Me.ButtonReglages.Name = "ButtonReglages"
        Me.ButtonReglages.Size = New System.Drawing.Size(97, 55)
        Me.ButtonReglages.TabIndex = 7
        Me.ButtonReglages.Text = "Reglages"
        Me.ButtonReglages.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(322, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(841, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonReglages)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.LabelAccueil)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonLancer)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ComboBoxPlayer)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPlayer As ComboBox
    Friend WithEvents ButtonLancer As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonScore As Button
    Friend WithEvents LabelAccueil As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents ButtonReglages As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
