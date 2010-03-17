Public Class Form_Aproposde
    Inherits System.Windows.Forms.Form

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents LinkLabel_EMail As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_Titre As System.Windows.Forms.Label
    Friend WithEvents Label_auteur As System.Windows.Forms.Label
    Friend WithEvents Label_Droit As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Renseignement As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel_Logiciel As System.Windows.Forms.LinkLabel
    Friend WithEvents Button_Ok As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_Aproposde))
        Me.Button_Ok = New System.Windows.Forms.Button
        Me.LinkLabel_EMail = New System.Windows.Forms.LinkLabel
        Me.Label_Titre = New System.Windows.Forms.Label
        Me.Label_auteur = New System.Windows.Forms.Label
        Me.Label_Droit = New System.Windows.Forms.Label
        Me.GroupBox_Renseignement = New System.Windows.Forms.GroupBox
        Me.LinkLabel_Logiciel = New System.Windows.Forms.LinkLabel
        Me.PictureBox = New System.Windows.Forms.PictureBox
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_Renseignement.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Ok
        '
        Me.Button_Ok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Ok.Location = New System.Drawing.Point(112, 184)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.TabIndex = 0
        Me.Button_Ok.Text = "&Ok"
        '
        'LinkLabel_EMail
        '
        Me.LinkLabel_EMail.ActiveLinkColor = System.Drawing.Color.Magenta
        Me.LinkLabel_EMail.AutoSize = True
        Me.LinkLabel_EMail.DisabledLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel_EMail.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_EMail.LinkArea = New System.Windows.Forms.LinkArea(9, 26)
        Me.LinkLabel_EMail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_EMail.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel_EMail.Location = New System.Drawing.Point(8, 88)
        Me.LinkLabel_EMail.Name = "LinkLabel_EMail"
        Me.LinkLabel_EMail.Size = New System.Drawing.Size(289, 26)
        Me.LinkLabel_EMail.TabIndex = 1
        Me.LinkLabel_EMail.TabStop = True
        Me.LinkLabel_EMail.Text = "E-Mail : ludovicanceaux@hotmail.com"
        Me.LinkLabel_EMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel_EMail.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'Label_Titre
        '
        Me.Label_Titre.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.ForeColor = System.Drawing.Color.Red
        Me.Label_Titre.Location = New System.Drawing.Point(8, 16)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(288, 41)
        Me.Label_Titre.TabIndex = 2
        Me.Label_Titre.Text = "Horaire de travail v1.1fr"
        Me.Label_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_auteur
        '
        Me.Label_auteur.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_auteur.Location = New System.Drawing.Point(16, 64)
        Me.Label_auteur.Name = "Label_auteur"
        Me.Label_auteur.Size = New System.Drawing.Size(112, 23)
        Me.Label_auteur.TabIndex = 3
        Me.Label_auteur.Text = "Auteur : Ludo"
        '
        'Label_Droit
        '
        Me.Label_Droit.AutoSize = True
        Me.Label_Droit.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Droit.Location = New System.Drawing.Point(16, 152)
        Me.Label_Droit.Name = "Label_Droit"
        Me.Label_Droit.Size = New System.Drawing.Size(139, 18)
        Me.Label_Droit.TabIndex = 4
        Me.Label_Droit.Text = "©2004 Tous droit résérvé"
        '
        'GroupBox_Renseignement
        '
        Me.GroupBox_Renseignement.Controls.Add(Me.Label_Droit)
        Me.GroupBox_Renseignement.Controls.Add(Me.Label_Titre)
        Me.GroupBox_Renseignement.Controls.Add(Me.Label_auteur)
        Me.GroupBox_Renseignement.Controls.Add(Me.LinkLabel_EMail)
        Me.GroupBox_Renseignement.Controls.Add(Me.LinkLabel_Logiciel)
        Me.GroupBox_Renseignement.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox_Renseignement.Name = "GroupBox_Renseignement"
        Me.GroupBox_Renseignement.Size = New System.Drawing.Size(304, 176)
        Me.GroupBox_Renseignement.TabIndex = 7
        Me.GroupBox_Renseignement.TabStop = False
        '
        'LinkLabel_Logiciel
        '
        Me.LinkLabel_Logiciel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Logiciel.LinkArea = New System.Windows.Forms.LinkArea(54, 0)
        Me.LinkLabel_Logiciel.Location = New System.Drawing.Point(16, 120)
        Me.LinkLabel_Logiciel.Name = "LinkLabel_Logiciel"
        Me.LinkLabel_Logiciel.Size = New System.Drawing.Size(152, 32)
        Me.LinkLabel_Logiciel.TabIndex = 0
        Me.LinkLabel_Logiciel.Text = "Conçus par Ludo avec " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Microsoft Visual Basic.net"
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(8, 208)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(302, 79)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox.TabIndex = 8
        Me.PictureBox.TabStop = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1
        '
        'Form_Aproposde
        '
        Me.AcceptButton = Me.Button_Ok
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.CancelButton = Me.Button_Ok
        Me.ClientSize = New System.Drawing.Size(322, 296)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.GroupBox_Renseignement)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Aproposde"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A propos de"
        Me.TopMost = True
        Me.GroupBox_Renseignement.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel_EMail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_EMail.LinkClicked
        System.Diagnostics.Process.Start("mailto:ludovicanceanceaux@hotmail.com")
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.01
        Else
            Timer.Enabled = False
        End If
    End Sub
End Class
