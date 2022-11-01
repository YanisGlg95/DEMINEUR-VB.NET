<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.CheckBoxTime = New System.Windows.Forms.CheckBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDeleteData = New System.Windows.Forms.Button()
        Me.ButtonFeinte = New System.Windows.Forms.Button()
        Me.RadioButtonEz = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNormal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHard = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBoxTime
        '
        Me.CheckBoxTime.AutoSize = True
        Me.CheckBoxTime.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxTime.Location = New System.Drawing.Point(391, 216)
        Me.CheckBoxTime.Name = "CheckBoxTime"
        Me.CheckBoxTime.Size = New System.Drawing.Size(165, 29)
        Me.CheckBoxTime.TabIndex = 0
        Me.CheckBoxTime.Text = "Desactiver le timer"
        Me.CheckBoxTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxTime.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonSave.Location = New System.Drawing.Point(325, 356)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(117, 40)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Sauvegarder"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDeleteData
        '
        Me.ButtonDeleteData.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonDeleteData.Location = New System.Drawing.Point(52, 356)
        Me.ButtonDeleteData.Name = "ButtonDeleteData"
        Me.ButtonDeleteData.Size = New System.Drawing.Size(192, 40)
        Me.ButtonDeleteData.TabIndex = 2
        Me.ButtonDeleteData.Text = "Supprimer données"
        Me.ButtonDeleteData.UseVisualStyleBackColor = True
        '
        'ButtonFeinte
        '
        Me.ButtonFeinte.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonFeinte.Location = New System.Drawing.Point(518, 356)
        Me.ButtonFeinte.Name = "ButtonFeinte"
        Me.ButtonFeinte.Size = New System.Drawing.Size(233, 40)
        Me.ButtonFeinte.TabIndex = 3
        Me.ButtonFeinte.Text = "Quitter sans sauvegarder"
        Me.ButtonFeinte.UseVisualStyleBackColor = True
        '
        'RadioButtonEz
        '
        Me.RadioButtonEz.AutoSize = True
        Me.RadioButtonEz.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonEz.Location = New System.Drawing.Point(391, 119)
        Me.RadioButtonEz.Name = "RadioButtonEz"
        Me.RadioButtonEz.Size = New System.Drawing.Size(94, 29)
        Me.RadioButtonEz.TabIndex = 4
        Me.RadioButtonEz.TabStop = True
        Me.RadioButtonEz.Text = "Debutant"
        Me.RadioButtonEz.UseVisualStyleBackColor = True
        '
        'RadioButtonNormal
        '
        Me.RadioButtonNormal.AutoSize = True
        Me.RadioButtonNormal.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonNormal.Location = New System.Drawing.Point(520, 119)
        Me.RadioButtonNormal.Name = "RadioButtonNormal"
        Me.RadioButtonNormal.Size = New System.Drawing.Size(129, 29)
        Me.RadioButtonNormal.TabIndex = 5
        Me.RadioButtonNormal.TabStop = True
        Me.RadioButtonNormal.Text = "Intermediaire "
        Me.RadioButtonNormal.UseVisualStyleBackColor = True
        '
        'RadioButtonHard
        '
        Me.RadioButtonHard.AutoSize = True
        Me.RadioButtonHard.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButtonHard.Location = New System.Drawing.Point(678, 119)
        Me.RadioButtonHard.Name = "RadioButtonHard"
        Me.RadioButtonHard.Size = New System.Drawing.Size(75, 29)
        Me.RadioButtonHard.TabIndex = 6
        Me.RadioButtonHard.TabStop = True
        Me.RadioButtonHard.Text = "Expert"
        Me.RadioButtonHard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(40, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Choisissez un niveau (Debutant par defaut) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(40, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Options de timer :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(352, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Réglages"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButtonHard)
        Me.Controls.Add(Me.RadioButtonNormal)
        Me.Controls.Add(Me.RadioButtonEz)
        Me.Controls.Add(Me.ButtonFeinte)
        Me.Controls.Add(Me.ButtonDeleteData)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.CheckBoxTime)
        Me.Name = "Settings"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxTime As CheckBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDeleteData As Button
    Friend WithEvents ButtonFeinte As Button
    Friend WithEvents RadioButtonEz As RadioButton
    Friend WithEvents RadioButtonNormal As RadioButton
    Friend WithEvents RadioButtonHard As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
