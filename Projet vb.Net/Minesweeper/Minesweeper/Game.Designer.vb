<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TLayoutPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.LabelGTemps = New System.Windows.Forms.Label()
        Me.LabelGJoueur = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelGTimer = New System.Windows.Forms.Label()
        Me.LabelGPlayerName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelMines = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.BackColor = System.Drawing.Color.Red
        Me.ButtonAbandonner.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonAbandonner.Location = New System.Drawing.Point(281, 579)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(120, 36)
        Me.ButtonAbandonner.TabIndex = 77
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = False
        '
        'LabelGTemps
        '
        Me.LabelGTemps.BackColor = System.Drawing.Color.Transparent
        Me.LabelGTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelGTemps.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelGTemps.ForeColor = System.Drawing.Color.Black
        Me.LabelGTemps.Location = New System.Drawing.Point(38, 36)
        Me.LabelGTemps.Name = "LabelGTemps"
        Me.LabelGTemps.Size = New System.Drawing.Size(125, 29)
        Me.LabelGTemps.TabIndex = 76
        Me.LabelGTemps.Text = "Temps restant:"
        Me.LabelGTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGJoueur
        '
        Me.LabelGJoueur.BackColor = System.Drawing.Color.Transparent
        Me.LabelGJoueur.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGJoueur.ForeColor = System.Drawing.Color.Black
        Me.LabelGJoueur.Location = New System.Drawing.Point(469, 36)
        Me.LabelGJoueur.Name = "LabelGJoueur"
        Me.LabelGJoueur.Size = New System.Drawing.Size(74, 28)
        Me.LabelGJoueur.TabIndex = 75
        Me.LabelGJoueur.Text = "Joueur:"
        Me.LabelGJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'LabelGTimer
        '
        Me.LabelGTimer.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGTimer.Location = New System.Drawing.Point(195, 36)
        Me.LabelGTimer.Name = "LabelGTimer"
        Me.LabelGTimer.Size = New System.Drawing.Size(46, 29)
        Me.LabelGTimer.TabIndex = 143
        Me.LabelGTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelGPlayerName
        '
        Me.LabelGPlayerName.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGPlayerName.Location = New System.Drawing.Point(550, 39)
        Me.LabelGPlayerName.Name = "LabelGPlayerName"
        Me.LabelGPlayerName.Size = New System.Drawing.Size(111, 22)
        Me.LabelGPlayerName.TabIndex = 145
        Me.LabelGPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(145, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(415, 369)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelMines
        '
        Me.LabelMines.AutoSize = True
        Me.LabelMines.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelMines.Location = New System.Drawing.Point(33, 585)
        Me.LabelMines.Name = "LabelMines"
        Me.LabelMines.Size = New System.Drawing.Size(61, 25)
        Me.LabelMines.TabIndex = 146
        Me.LabelMines.Text = "Mines: "
        '
        'TLayoutPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(673, 633)
        Me.Controls.Add(Me.LabelMines)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LabelGPlayerName)
        Me.Controls.Add(Me.LabelGTimer)
        Me.Controls.Add(Me.ButtonAbandonner)
        Me.Controls.Add(Me.LabelGTemps)
        Me.Controls.Add(Me.LabelGJoueur)
        Me.Name = "TLayoutPanel"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents LabelGTemps As Label
    Friend WithEvents LabelGJoueur As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelGTimer As Label
    Friend WithEvents LabelGPlayerName As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelMines As Label
End Class
