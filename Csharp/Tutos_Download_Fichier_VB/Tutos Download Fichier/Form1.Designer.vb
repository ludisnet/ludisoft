<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        Me.T_Source = New System.Windows.Forms.TextBox
        Me.T_Path = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.B_Parcourir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.B_Dl1 = New System.Windows.Forms.Button
        Me.B_dl2 = New System.Windows.Forms.Button
        Me.B_dl3 = New System.Windows.Forms.Button
        Me.pb = New System.Windows.Forms.ProgressBar
        Me.L_Info = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'T_Source
        '
        Me.T_Source.Location = New System.Drawing.Point(15, 30)
        Me.T_Source.Name = "T_Source"
        Me.T_Source.Size = New System.Drawing.Size(307, 20)
        Me.T_Source.TabIndex = 0
        '
        'T_Path
        '
        Me.T_Path.Location = New System.Drawing.Point(15, 92)
        Me.T_Path.Name = "T_Path"
        Me.T_Path.ReadOnly = True
        Me.T_Path.Size = New System.Drawing.Size(307, 20)
        Me.T_Path.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Url de téléchargement :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destination du fichier téléchargé :"
        '
        'B_Parcourir
        '
        Me.B_Parcourir.Location = New System.Drawing.Point(340, 92)
        Me.B_Parcourir.Name = "B_Parcourir"
        Me.B_Parcourir.Size = New System.Drawing.Size(28, 23)
        Me.B_Parcourir.TabIndex = 4
        Me.B_Parcourir.Text = "..."
        Me.B_Parcourir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(111, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 8)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'B_Dl1
        '
        Me.B_Dl1.Location = New System.Drawing.Point(90, 152)
        Me.B_Dl1.Name = "B_Dl1"
        Me.B_Dl1.Size = New System.Drawing.Size(75, 23)
        Me.B_Dl1.TabIndex = 6
        Me.B_Dl1.Text = "Download 1"
        Me.B_Dl1.UseVisualStyleBackColor = True
        '
        'B_dl2
        '
        Me.B_dl2.Location = New System.Drawing.Point(186, 152)
        Me.B_dl2.Name = "B_dl2"
        Me.B_dl2.Size = New System.Drawing.Size(75, 23)
        Me.B_dl2.TabIndex = 7
        Me.B_dl2.Text = "Download 2"
        Me.B_dl2.UseVisualStyleBackColor = True
        '
        'B_dl3
        '
        Me.B_dl3.Location = New System.Drawing.Point(280, 152)
        Me.B_dl3.Name = "B_dl3"
        Me.B_dl3.Size = New System.Drawing.Size(75, 23)
        Me.B_dl3.TabIndex = 8
        Me.B_dl3.Text = "Download 3"
        Me.B_dl3.UseVisualStyleBackColor = True
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(31, 213)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(399, 12)
        Me.pb.TabIndex = 9
        '
        'L_Info
        '
        Me.L_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Info.Location = New System.Drawing.Point(31, 192)
        Me.L_Info.Name = "L_Info"
        Me.L_Info.Size = New System.Drawing.Size(399, 18)
        Me.L_Info.TabIndex = 10
        Me.L_Info.Text = "Etat d'avancement (pour la méthode 3) :"
        Me.L_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 248)
        Me.Controls.Add(Me.L_Info)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.B_dl3)
        Me.Controls.Add(Me.B_dl2)
        Me.Controls.Add(Me.B_Dl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.B_Parcourir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_Path)
        Me.Controls.Add(Me.T_Source)
        Me.Name = "Form1"
        Me.Text = "Tutos : Telechargement d'un fichier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents T_Source As System.Windows.Forms.TextBox
    Friend WithEvents T_Path As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents B_Parcourir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents B_Dl1 As System.Windows.Forms.Button
    Friend WithEvents B_dl2 As System.Windows.Forms.Button
    Friend WithEvents B_dl3 As System.Windows.Forms.Button
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents L_Info As System.Windows.Forms.Label

End Class
