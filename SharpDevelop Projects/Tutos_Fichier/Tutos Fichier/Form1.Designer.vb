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
    	Me.Label1 = New System.Windows.Forms.Label
    	Me.RTB = New System.Windows.Forms.RichTextBox
    	Me.B_Save = New System.Windows.Forms.Button
    	Me.RTBL = New System.Windows.Forms.RichTextBox
    	Me.B_Load = New System.Windows.Forms.Button
    	Me.GroupBox1 = New System.Windows.Forms.GroupBox
    	Me.Label2 = New System.Windows.Forms.Label
    	Me.RTBF = New System.Windows.Forms.RichTextBox
    	Me.B_Parcourir = New System.Windows.Forms.Button
    	Me.OFD = New System.Windows.Forms.OpenFileDialog
    	Me.SuspendLayout
    	'
    	'Label1
    	'
    	Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
    	Me.Label1.Location = New System.Drawing.Point(12, 9)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(431, 30)
    	Me.Label1.TabIndex = 0
    	Me.Label1.Text = "Comment créer, écrire et lire dans un fichier texte ?"
    	'
    	'RTB
    	'
    	Me.RTB.Location = New System.Drawing.Point(238, 42)
    	Me.RTB.Name = "RTB"
    	Me.RTB.Size = New System.Drawing.Size(205, 58)
    	Me.RTB.TabIndex = 1
    	Me.RTB.Text = "Ecrivez quelque chose dedans"
    	'
    	'B_Save
    	'
    	Me.B_Save.Location = New System.Drawing.Point(368, 117)
    	Me.B_Save.Name = "B_Save"
    	Me.B_Save.Size = New System.Drawing.Size(75, 23)
    	Me.B_Save.TabIndex = 2
    	Me.B_Save.Text = "Save"
    	Me.B_Save.UseVisualStyleBackColor = true
    	'
    	'RTBL
    	'
    	Me.RTBL.Location = New System.Drawing.Point(16, 42)
    	Me.RTBL.Name = "RTBL"
    	Me.RTBL.ReadOnly = true
    	Me.RTBL.Size = New System.Drawing.Size(205, 58)
    	Me.RTBL.TabIndex = 3
    	Me.RTBL.Text = ""
    	'
    	'B_Load
    	'
    	Me.B_Load.Location = New System.Drawing.Point(16, 117)
    	Me.B_Load.Name = "B_Load"
    	Me.B_Load.Size = New System.Drawing.Size(75, 23)
    	Me.B_Load.TabIndex = 4
    	Me.B_Load.Text = "Load"
    	Me.B_Load.UseVisualStyleBackColor = true
  
    	'
    	'GroupBox1
    	'
    	Me.GroupBox1.Location = New System.Drawing.Point(89, 162)
    	Me.GroupBox1.Name = "GroupBox1"
    	Me.GroupBox1.Size = New System.Drawing.Size(279, 8)
    	Me.GroupBox1.TabIndex = 5
    	Me.GroupBox1.TabStop = false
    	'
    	'Label2
    	'
    	Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
    	Me.Label2.Location = New System.Drawing.Point(12, 178)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(431, 26)
    	Me.Label2.TabIndex = 6
    	Me.Label2.Text = "Comment lire un fichier ?"
    	'
    	'RTBF
    	'
    	Me.RTBF.Location = New System.Drawing.Point(25, 207)
    	Me.RTBF.Name = "RTBF"
    	Me.RTBF.ReadOnly = true
    	Me.RTBF.Size = New System.Drawing.Size(326, 84)
    	Me.RTBF.TabIndex = 7
    	Me.RTBF.Text = ""
    	'
    	'B_Parcourir
    	'
    	Me.B_Parcourir.Location = New System.Drawing.Point(368, 242)
    	Me.B_Parcourir.Name = "B_Parcourir"
    	Me.B_Parcourir.Size = New System.Drawing.Size(75, 23)
    	Me.B_Parcourir.TabIndex = 8
    	Me.B_Parcourir.Text = "Parcourir"
    	Me.B_Parcourir.UseVisualStyleBackColor = true
    	'
    	'OFD
    	'
    	Me.OFD.FileName = "OpenFileDialog1"
    	'
    	'Form1
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(455, 303)
    	Me.Controls.Add(Me.B_Parcourir)
    	Me.Controls.Add(Me.RTBF)
    	Me.Controls.Add(Me.Label2)
    	Me.Controls.Add(Me.GroupBox1)
    	Me.Controls.Add(Me.B_Load)
    	Me.Controls.Add(Me.RTBL)
    	Me.Controls.Add(Me.B_Save)
    	Me.Controls.Add(Me.RTB)
    	Me.Controls.Add(Me.Label1)
    	Me.Name = "Form1"
    	Me.Text = "Tutoriel sur les fichiers"
    	Me.ResumeLayout(false)
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RTB As System.Windows.Forms.RichTextBox
    Friend WithEvents B_Save As System.Windows.Forms.Button
    Friend WithEvents RTBL As System.Windows.Forms.RichTextBox
    Friend WithEvents B_Load As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RTBF As System.Windows.Forms.RichTextBox
    Friend WithEvents B_Parcourir As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog

End Class
