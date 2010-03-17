Imports System.Web.Mail ' pour l'envoi du mail
Imports System.IO
Public Class Form_Envoyer
    Inherits System.Windows.Forms.Form

#Region "Variable(s)"

    Friend MyParentForm As Form_Index ''' permet d'importer la Listview adequat de cette form

#End Region

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()
        Application.EnableVisualStyles() '''' Active le stye Xp
        Application.DoEvents() ''''''''''''''

        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    Public Sub New(ByVal Value As System.Windows.Forms.Form) ''''
        MyBase.New()                                            '
        InitializeComponent()                                   ' Utile pour pouvoir récupérer des infos 
        'Initialisation de MyParentForm                         ' A partir d'autre form que celle là
        MyParentForm = Value                                    '
    End Sub '''''''''''''''''''''''''''''''''''''''''''''''''''''

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
    Friend WithEvents ComboBoxDésignation As System.Windows.Forms.ComboBox
    Friend WithEvents Tooltip_Commentaires As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox_Type As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Envoyer As System.Windows.Forms.Button
    Friend WithEvents TextBox_Expediteur As System.Windows.Forms.TextBox
    Friend WithEvents Label_Destinataire As System.Windows.Forms.Label
    Friend WithEvents TextBox_SMTP As System.Windows.Forms.TextBox
    Friend WithEvents Label_Expediteur As System.Windows.Forms.Label
    Friend WithEvents TextBox_Destinataire As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_PieceJointe As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_TexteBrut As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_Paramètre As System.Windows.Forms.GroupBox
    Friend WithEvents Label_SMTP As System.Windows.Forms.Label
    Friend WithEvents PièceJointe As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox_CheminPièceJointe As System.Windows.Forms.TextBox
    Friend WithEvents Label_CheminPièceJointe As System.Windows.Forms.Label
    Friend WithEvents Button_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents Button_Annuler As System.Windows.Forms.Button
    Friend WithEvents ListBox_Contact As System.Windows.Forms.ListBox
    Friend WithEvents Button_Ajouter As System.Windows.Forms.Button
    Friend WithEvents Button_Retirer As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Contact As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_Envoyer))
        Me.Button_Envoyer = New System.Windows.Forms.Button
        Me.TextBox_Expediteur = New System.Windows.Forms.TextBox
        Me.Label_Destinataire = New System.Windows.Forms.Label
        Me.TextBox_SMTP = New System.Windows.Forms.TextBox
        Me.Label_Expediteur = New System.Windows.Forms.Label
        Me.TextBox_Destinataire = New System.Windows.Forms.TextBox
        Me.Tooltip_Commentaires = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton_PieceJointe = New System.Windows.Forms.RadioButton
        Me.Button_Annuler = New System.Windows.Forms.Button
        Me.RadioButton_TexteBrut = New System.Windows.Forms.RadioButton
        Me.Button_Ajouter = New System.Windows.Forms.Button
        Me.TextBox_CheminPièceJointe = New System.Windows.Forms.TextBox
        Me.Button_Enregistrer = New System.Windows.Forms.Button
        Me.ListBox_Contact = New System.Windows.Forms.ListBox
        Me.Button_Retirer = New System.Windows.Forms.Button
        Me.GroupBox_Paramètre = New System.Windows.Forms.GroupBox
        Me.Label_SMTP = New System.Windows.Forms.Label
        Me.GroupBox_Type = New System.Windows.Forms.GroupBox
        Me.Label_CheminPièceJointe = New System.Windows.Forms.Label
        Me.PièceJointe = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox = New System.Windows.Forms.PictureBox
        Me.GroupBox_Contact = New System.Windows.Forms.GroupBox
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox_Paramètre.SuspendLayout()
        Me.GroupBox_Type.SuspendLayout()
        Me.GroupBox_Contact.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Envoyer
        '
        Me.Button_Envoyer.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.Button_Envoyer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Envoyer.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Envoyer.ForeColor = System.Drawing.Color.White
        Me.Button_Envoyer.Image = CType(resources.GetObject("Button_Envoyer.Image"), System.Drawing.Image)
        Me.Button_Envoyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Envoyer.Location = New System.Drawing.Point(256, 136)
        Me.Button_Envoyer.Name = "Button_Envoyer"
        Me.Button_Envoyer.Size = New System.Drawing.Size(104, 32)
        Me.Button_Envoyer.TabIndex = 1
        Me.Button_Envoyer.Text = "&Envoyer"
        Me.Tooltip_Commentaires.SetToolTip(Me.Button_Envoyer, "Valide les données écrites et envoi le mail")
        '
        'TextBox_Expediteur
        '
        Me.TextBox_Expediteur.Location = New System.Drawing.Point(120, 48)
        Me.TextBox_Expediteur.Name = "TextBox_Expediteur"
        Me.TextBox_Expediteur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Expediteur.Size = New System.Drawing.Size(224, 23)
        Me.TextBox_Expediteur.TabIndex = 1
        Me.TextBox_Expediteur.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_Expediteur, "Indique ici ton adresse internet")
        '
        'Label_Destinataire
        '
        Me.Label_Destinataire.AutoSize = True
        Me.Label_Destinataire.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Destinataire.Location = New System.Drawing.Point(8, 72)
        Me.Label_Destinataire.Name = "Label_Destinataire"
        Me.Label_Destinataire.Size = New System.Drawing.Size(93, 22)
        Me.Label_Destinataire.TabIndex = 37
        Me.Label_Destinataire.Text = "Destinataire:"
        '
        'TextBox_SMTP
        '
        Me.TextBox_SMTP.Location = New System.Drawing.Point(120, 24)
        Me.TextBox_SMTP.Name = "TextBox_SMTP"
        Me.TextBox_SMTP.Size = New System.Drawing.Size(224, 23)
        Me.TextBox_SMTP.TabIndex = 0
        Me.TextBox_SMTP.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_SMTP, "Indique ici l'adresse du serveur SMTP correspondant à ton fournisseur d'accès")
        '
        'Label_Expediteur
        '
        Me.Label_Expediteur.AutoSize = True
        Me.Label_Expediteur.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Expediteur.Location = New System.Drawing.Point(8, 48)
        Me.Label_Expediteur.Name = "Label_Expediteur"
        Me.Label_Expediteur.Size = New System.Drawing.Size(82, 22)
        Me.Label_Expediteur.TabIndex = 40
        Me.Label_Expediteur.Text = "Expediteur:"
        '
        'TextBox_Destinataire
        '
        Me.TextBox_Destinataire.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Destinataire.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Destinataire.Location = New System.Drawing.Point(120, 72)
        Me.TextBox_Destinataire.Name = "TextBox_Destinataire"
        Me.TextBox_Destinataire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_Destinataire.Size = New System.Drawing.Size(224, 23)
        Me.TextBox_Destinataire.TabIndex = 2
        Me.TextBox_Destinataire.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_Destinataire, "Indique ici l'adresse du destinataire")
        '
        'Tooltip_Commentaires
        '
        Me.Tooltip_Commentaires.AutoPopDelay = 5000
        Me.Tooltip_Commentaires.InitialDelay = 50
        Me.Tooltip_Commentaires.ReshowDelay = 50
        '
        'RadioButton_PieceJointe
        '
        Me.RadioButton_PieceJointe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_PieceJointe.Location = New System.Drawing.Point(8, 64)
        Me.RadioButton_PieceJointe.Name = "RadioButton_PieceJointe"
        Me.RadioButton_PieceJointe.Size = New System.Drawing.Size(112, 24)
        Me.RadioButton_PieceJointe.TabIndex = 3
        Me.RadioButton_PieceJointe.Text = "Pièce jointe"
        Me.Tooltip_Commentaires.SetToolTip(Me.RadioButton_PieceJointe, "Envoi carrément un fichier complet avec toutes les recettes")
        '
        'Button_Annuler
        '
        Me.Button_Annuler.BackColor = System.Drawing.Color.Red
        Me.Button_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Annuler.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Annuler.ForeColor = System.Drawing.Color.White
        Me.Button_Annuler.Image = CType(resources.GetObject("Button_Annuler.Image"), System.Drawing.Image)
        Me.Button_Annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Annuler.Location = New System.Drawing.Point(408, 136)
        Me.Button_Annuler.Name = "Button_Annuler"
        Me.Button_Annuler.Size = New System.Drawing.Size(104, 32)
        Me.Button_Annuler.TabIndex = 42
        Me.Button_Annuler.Text = "&Annuler"
        Me.Tooltip_Commentaires.SetToolTip(Me.Button_Annuler, "Ferme la fenêtre sans envoyer de mail")
        '
        'RadioButton_TexteBrut
        '
        Me.RadioButton_TexteBrut.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton_TexteBrut.Location = New System.Drawing.Point(8, 32)
        Me.RadioButton_TexteBrut.Name = "RadioButton_TexteBrut"
        Me.RadioButton_TexteBrut.Size = New System.Drawing.Size(112, 24)
        Me.RadioButton_TexteBrut.TabIndex = 1
        Me.RadioButton_TexteBrut.Text = "Texte brut"
        Me.Tooltip_Commentaires.SetToolTip(Me.RadioButton_TexteBrut, "Envoi le mail en texte brut")
        '
        'Button_Ajouter
        '
        Me.Button_Ajouter.Enabled = False
        Me.Button_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Ajouter.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ajouter.Location = New System.Drawing.Point(352, 72)
        Me.Button_Ajouter.Name = "Button_Ajouter"
        Me.Button_Ajouter.Size = New System.Drawing.Size(56, 23)
        Me.Button_Ajouter.TabIndex = 46
        Me.Button_Ajouter.Text = "Ajouter"
        Me.Tooltip_Commentaires.SetToolTip(Me.Button_Ajouter, "Ajoute l'adresse inscrite dans la liste des contacts")
        '
        'TextBox_CheminPièceJointe
        '
        Me.TextBox_CheminPièceJointe.Location = New System.Drawing.Point(104, 104)
        Me.TextBox_CheminPièceJointe.Name = "TextBox_CheminPièceJointe"
        Me.TextBox_CheminPièceJointe.Size = New System.Drawing.Size(456, 23)
        Me.TextBox_CheminPièceJointe.TabIndex = 4
        Me.TextBox_CheminPièceJointe.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_CheminPièceJointe, "Ici l'adresse de la pièce jointe")
        Me.TextBox_CheminPièceJointe.Visible = False
        '
        'Button_Enregistrer
        '
        Me.Button_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Enregistrer.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Enregistrer.Image = CType(resources.GetObject("Button_Enregistrer.Image"), System.Drawing.Image)
        Me.Button_Enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Enregistrer.Location = New System.Drawing.Point(8, 136)
        Me.Button_Enregistrer.Name = "Button_Enregistrer"
        Me.Button_Enregistrer.Size = New System.Drawing.Size(192, 32)
        Me.Button_Enregistrer.TabIndex = 41
        Me.Button_Enregistrer.Text = "En&registrer les paramêtres"
        Me.Tooltip_Commentaires.SetToolTip(Me.Button_Enregistrer, "Permet d'enregistrer les paramètres et la liste des contacts")
        '
        'ListBox_Contact
        '
        Me.ListBox_Contact.ItemHeight = 15
        Me.ListBox_Contact.Location = New System.Drawing.Point(8, 16)
        Me.ListBox_Contact.Name = "ListBox_Contact"
        Me.ListBox_Contact.ScrollAlwaysVisible = True
        Me.ListBox_Contact.Size = New System.Drawing.Size(168, 139)
        Me.ListBox_Contact.TabIndex = 51
        Me.Tooltip_Commentaires.SetToolTip(Me.ListBox_Contact, "Liste des contacts")
        '
        'Button_Retirer
        '
        Me.Button_Retirer.Enabled = False
        Me.Button_Retirer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Retirer.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Retirer.Location = New System.Drawing.Point(8, 160)
        Me.Button_Retirer.Name = "Button_Retirer"
        Me.Button_Retirer.Size = New System.Drawing.Size(168, 24)
        Me.Button_Retirer.TabIndex = 52
        Me.Button_Retirer.Text = "R&etirer"
        Me.Tooltip_Commentaires.SetToolTip(Me.Button_Retirer, "Retirer l'élement sélectionné de la liste")
        '
        'GroupBox_Paramètre
        '
        Me.GroupBox_Paramètre.Controls.Add(Me.Button_Ajouter)
        Me.GroupBox_Paramètre.Controls.Add(Me.TextBox_Destinataire)
        Me.GroupBox_Paramètre.Controls.Add(Me.TextBox_Expediteur)
        Me.GroupBox_Paramètre.Controls.Add(Me.Label_SMTP)
        Me.GroupBox_Paramètre.Controls.Add(Me.TextBox_SMTP)
        Me.GroupBox_Paramètre.Controls.Add(Me.Label_Expediteur)
        Me.GroupBox_Paramètre.Controls.Add(Me.Label_Destinataire)
        Me.GroupBox_Paramètre.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox_Paramètre.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox_Paramètre.Name = "GroupBox_Paramètre"
        Me.GroupBox_Paramètre.Size = New System.Drawing.Size(416, 104)
        Me.GroupBox_Paramètre.TabIndex = 0
        Me.GroupBox_Paramètre.TabStop = False
        Me.GroupBox_Paramètre.Text = "Paramètre"
        '
        'Label_SMTP
        '
        Me.Label_SMTP.AutoSize = True
        Me.Label_SMTP.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SMTP.Location = New System.Drawing.Point(8, 24)
        Me.Label_SMTP.Name = "Label_SMTP"
        Me.Label_SMTP.Size = New System.Drawing.Size(107, 22)
        Me.Label_SMTP.TabIndex = 45
        Me.Label_SMTP.Text = "Serveur SMTP:"
        '
        'GroupBox_Type
        '
        Me.GroupBox_Type.Controls.Add(Me.RadioButton_PieceJointe)
        Me.GroupBox_Type.Controls.Add(Me.RadioButton_TexteBrut)
        Me.GroupBox_Type.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox_Type.Location = New System.Drawing.Point(432, 0)
        Me.GroupBox_Type.Name = "GroupBox_Type"
        Me.GroupBox_Type.Size = New System.Drawing.Size(136, 104)
        Me.GroupBox_Type.TabIndex = 2
        Me.GroupBox_Type.TabStop = False
        Me.GroupBox_Type.Text = "Type"
        '
        'Label_CheminPièceJointe
        '
        Me.Label_CheminPièceJointe.AutoSize = True
        Me.Label_CheminPièceJointe.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CheminPièceJointe.Location = New System.Drawing.Point(16, 104)
        Me.Label_CheminPièceJointe.Name = "Label_CheminPièceJointe"
        Me.Label_CheminPièceJointe.Size = New System.Drawing.Size(88, 22)
        Me.Label_CheminPièceJointe.TabIndex = 38
        Me.Label_CheminPièceJointe.Text = "Pièce jointe:"
        Me.Label_CheminPièceJointe.Visible = False
        '
        'PièceJointe
        '
        Me.PièceJointe.Filter = "Horaire v1.1fr (*.Hor1)|*.Hor1"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(544, 176)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox.TabIndex = 43
        Me.PictureBox.TabStop = False
        '
        'GroupBox_Contact
        '
        Me.GroupBox_Contact.Controls.Add(Me.Button_Retirer)
        Me.GroupBox_Contact.Controls.Add(Me.ListBox_Contact)
        Me.GroupBox_Contact.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox_Contact.Location = New System.Drawing.Point(576, 0)
        Me.GroupBox_Contact.Name = "GroupBox_Contact"
        Me.GroupBox_Contact.Size = New System.Drawing.Size(192, 192)
        Me.GroupBox_Contact.TabIndex = 52
        Me.GroupBox_Contact.TabStop = False
        Me.GroupBox_Contact.Text = "Gestion des contacts"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form_Envoyer
        '
        Me.AcceptButton = Me.Button_Envoyer
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.CancelButton = Me.Button_Annuler
        Me.ClientSize = New System.Drawing.Size(778, 200)
        Me.Controls.Add(Me.TextBox_CheminPièceJointe)
        Me.Controls.Add(Me.Label_CheminPièceJointe)
        Me.Controls.Add(Me.GroupBox_Contact)
        Me.Controls.Add(Me.Button_Annuler)
        Me.Controls.Add(Me.Button_Enregistrer)
        Me.Controls.Add(Me.GroupBox_Paramètre)
        Me.Controls.Add(Me.Button_Envoyer)
        Me.Controls.Add(Me.GroupBox_Type)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Envoyer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envoyer"
        Me.GroupBox_Paramètre.ResumeLayout(False)
        Me.GroupBox_Type.ResumeLayout(False)
        Me.GroupBox_Contact.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Aperçu As String = "" ' Pour l'aperçu
    Dim Adresse As String = "" ' Pour l'adresse d'un fichier Ex: dans l'aperçu
    Dim Save_Listview As String ' Variable pour l'envoi des ListView
    Dim Save_Temps As String ' Variable pour L'envoi des temps
    Dim i As Integer

    Structure Fiche ''''''''''''''''''
        Dim Nom_Contact As String    '
        Dim Adresse_Email As String  '
    End Structure                    ' Structure pour les contacts
    Structure Calepin                ' 
        Dim Papier As Fiche()        '
    End Structure                    '
    Dim Livre As Calepin             '
    Dim NotCour As Integer ''''''''''' Numérote les élements dans la structure

    Private Sub RadioButton_PieceJointe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_PieceJointe.Click
        Dim Retour As Integer 'Variable de la fenêtre PièceJointe
        'Ouvre la fenêtre OpenFileDialog
        Retour = PièceJointe.ShowDialog()
        PièceJointe.InitialDirectory = Application.StartupPath & "\Save\" & MyParentForm.StatusBar_Utilisateur.Text

        If Retour = 1 Then
            'Remplit la TextBox adéquat
            TextBox_CheminPièceJointe.Text = PièceJointe.FileName
            'Rend visible la TextBox du chemin et le Label du chemin adéquat
            TextBox_CheminPièceJointe.Visible = True
            Label_CheminPièceJointe.Visible = True
        Else
            'Rend invisible la TextBox du chemin et le Label du chemin adéquat
            TextBox_CheminPièceJointe.Visible = False
            Label_CheminPièceJointe.Visible = False
            RadioButton_PieceJointe.Checked = False
        End If
    End Sub

    Private Sub RadioButton_TexteBrut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_TexteBrut.CheckedChanged
        'Remplit la TextBox adéquat
        TextBox_CheminPièceJointe.Text = ""

        'Rend invisible la TextBox du chemin et le Label du chemin adéquat
        TextBox_CheminPièceJointe.Visible = False
        Label_CheminPièceJointe.Visible = False
    End Sub

    Private Sub Button_Envoyer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Envoyer.Click
        Dim Msg As New Web.Mail.MailMessage
        Dim Body As String

        'Si aucun type de message n'est sélectionné
        If RadioButton_TexteBrut.Checked = False And RadioButton_PieceJointe.Checked = False Then
            MessageBox.Show("Il faut sélectionné un type d'envoi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Je pense que vs avez compris
            Exit Sub ' Sinon on se casse
        ElseIf TextBox_SMTP.Text = "" Then
            MessageBox.Show("Il faut remplir la case pour le serveur SMTP", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Je pense que vs avez compris
            TextBox_SMTP.Select() ' Sélectionne TextBox_SMTP 
            Exit Sub ' Et on se casse
        ElseIf TextBox_Expediteur.Text = "" Then
            MessageBox.Show("Il faut remplir la case pour l'adresse de l'expediteur", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Je pense que vs avez compris
            TextBox_Expediteur.Select() ' Sélectionne TextBox_Expediteur 
            Exit Sub ' On se barre
        ElseIf TextBox_Destinataire.Text = "" Then
            MessageBox.Show("Il faut remplir la case pour l'adresse de destinataire", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Je pense que vs avez compris
            TextBox_Destinataire.Select() ' Sélectionne TextBox_Destinataire
            Exit Sub ' On se ......
        End If

        If RadioButton_TexteBrut.Checked = True Then ' Si le RadioButton_TexteBrut est coché
            Try
                SmtpMail.SmtpServer = TextBox_SMTP.Text ' Adresse SMTP
                Msg.From = TextBox_Expediteur.Text ' Adresse de l'expediteur
                Msg.To = TextBox_Destinataire.Text ' Adresse du destinataire
                Msg.Priority = MailPriority.High ' On met en priorité haute tant qu'à faire
                Msg.BodyFormat = MailFormat.Text ' Type de mail
                Msg.Subject = "Horaire de travail v1.1fr ; " & MyParentForm.StatusBar_Utilisateur.Text & " Pour le mois de Janvier" ' Sujet
                Body = "DATE | ENTREPRISE | HEURE | MINUTE" & vbCrLf ' Corps du message

                ' Sauvegarde la Listview ds la variable "Save_Listview"
                Save_Listview = ""
                Save_Temps = ""
                If MyParentForm.TabControl.SelectedIndex = 0 Then
                    For i = 0 To MyParentForm.ListView1.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView1.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView1.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView1.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView1.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure1.Text & " H " & MyParentForm.Label_TotalMinute1.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 1 Then
                    For i = 0 To MyParentForm.ListView2.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView2.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView2.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView2.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView2.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure2.Text & " H " & MyParentForm.Label_TotalMinute2.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 2 Then
                    For i = 0 To MyParentForm.ListView3.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView3.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView3.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView3.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView3.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure3.Text & " H " & MyParentForm.Label_TotalMinute3.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 3 Then
                    For i = 0 To MyParentForm.ListView4.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView4.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView4.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView4.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView4.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure4.Text & " H " & MyParentForm.Label_TotalMinute4.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 4 Then
                    For i = 0 To MyParentForm.ListView5.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView5.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView5.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView5.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView5.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure5.Text & " H " & MyParentForm.Label_TotalMinute5.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 5 Then
                    For i = 0 To MyParentForm.ListView6.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView6.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView6.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView6.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView6.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure6.Text & " H " & MyParentForm.Label_TotalMinute6.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 6 Then
                    For i = 0 To MyParentForm.ListView7.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView7.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView7.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView7.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView7.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure7.Text & " H " & MyParentForm.Label_TotalMinute7.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 7 Then
                    For i = 0 To MyParentForm.ListView8.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView8.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView8.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView8.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView8.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure8.Text & " H " & MyParentForm.Label_TotalMinute8.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 8 Then
                    For i = 0 To MyParentForm.ListView9.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView9.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView9.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView9.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView9.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure9.Text & " H " & MyParentForm.Label_TotalMinute9.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 9 Then
                    For i = 0 To MyParentForm.ListView10.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView10.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView10.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView10.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView10.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure10.Text & " H " & MyParentForm.Label_TotalMinute10.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 10 Then
                    For i = 0 To MyParentForm.ListView11.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView11.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView11.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView11.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView11.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure11.Text & " H " & MyParentForm.Label_TotalMinute11.Text & " Minutes"

                ElseIf MyParentForm.TabControl.SelectedIndex = 11 Then
                    For i = 0 To MyParentForm.ListView12.Items.Count - 1
                        Save_Listview = Save_Listview & MyParentForm.ListView12.Items(i).SubItems(0).Text & " | " & MyParentForm.ListView12.Items(i).SubItems(1).Text & " | " & MyParentForm.ListView12.Items(i).SubItems(2).Text & " | " & MyParentForm.ListView12.Items(i).SubItems(3).Text & vbCrLf
                    Next i
                    Save_Temps = MyParentForm.Label_TotalHeure12.Text & " H " & MyParentForm.Label_TotalMinute12.Text & " Minutes"
                End If

                Body &= Save_Listview & vbCrLf & Save_Temps & vbCrLf & vbCrLf
                Body &= "Ce mail à été envoyé avec le logiciel Horaire de travail v1.1fr qui à été crée par Ludo"
                Msg.Body = Body
                SmtpMail.Send(Msg) ' Envoi du message
                'Message de confirmation
                MessageBox.Show("Le mail a bien été envoyer", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PictureBox.Image = ImageList.Images(0) ' Met l'icone vert dans la PictureBox
            Catch ex As Exception ' Et si ca marche pô 
                'on met un message d'erreur
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PictureBox.Image = ImageList.Images(1) ' Met l'icone rouge dans la PictureBox
            End Try

        ElseIf RadioButton_PieceJointe.Checked = True Then ' Si le RadioButton_PièceJointe est coché
            If TextBox_CheminPièceJointe.Text = "" Then
                'on met un message d'erreur
                MessageBox.Show("Il faut remplir la case de la pièce jointe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub 'et on se barre
            Else
                Try
                    Dim Attachement As New MailAttachment(TextBox_CheminPièceJointe.Text)
                    SmtpMail.SmtpServer = TextBox_SMTP.Text ' Adresse SMTP
                    Msg.From = TextBox_Expediteur.Text ' Adresse de l'expediteur
                    Msg.To = TextBox_Destinataire.Text ' Adresse du destinataire
                    Msg.Priority = MailPriority.High ' On met en priorité haute tant qu'à faire
                    Msg.BodyFormat = MailFormat.Text ' Type de mail
                    Msg.Subject = "Recette de cuisine" ' Sujet
                    Msg.Body = "Ce mail à été envoyer avec le logiciel Recette de cuisine et créer par Ludo en 2004" ' Corps du message
                    Msg.Attachments.Add(Attachement)
                    SmtpMail.Send(Msg) ' Envoi du message
                    'Message de confirmation
                    MessageBox.Show("Le mail a bien été envoyer", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PictureBox.Image = ImageList.Images(0) ' Met l'icone vert dans la PictureBox
                Catch ' Et si ca marche pô 
                    'on met un message d'erreur
                    MessageBox.Show("Le mail n'a pas pû être envoyer." & vbCrLf & "Verifiez votre connection internet, l'adresse de l'expediteur ou l'adresse SMTP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PictureBox.Image = ImageList.Images(1) ' Met l'icone rouge dans la PictureBox
                End Try
            End If
        End If
    End Sub

    Private Sub Button_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Enregistrer.Click
        'Sauvegarde le Fichier Mail.ini
        Try
            FileOpen(1, Application.StartupPath & "\config\Mail.ini", OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
            WriteLine(1, TextBox_SMTP.Text)
            WriteLine(1, TextBox_Expediteur.Text)
            FileClose(1)
        Catch ex As Exception ' En cas d'erreur
            MsgBox("Impossible d'enregistrer car " + ex.Message, MsgBoxStyle.Critical)
        End Try

        'Sauvegarde le Fichier Gestion des contact
        FileOpen(1, Application.StartupPath & "\Config\Gestion Contact.txt", OpenMode.Binary)
        FilePut(1, Livre)
        FileClose(1)
    End Sub

    Private Sub Form_Envoyer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim Livre.Papier(0)
        Try '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim s As String                                                             '
            Dim i As String                                                             '
            FileOpen(1, Application.StartupPath & "\Config\Mail.ini", OpenMode.Input)   ' 
            Input(1, s) : TextBox_SMTP.Text = s ' Lit le fichier                        ' Ouvre le Fichier Mail.ini
            Input(1, i) : TextBox_Expediteur.Text = i ' Pareil                          '
            FileClose(1) ' Referme le fichier après avoir sauvegardé                    '
        Catch ex As Exception                                                           ' En cas d'erreur
            MsgBox("Impossible de lire le fichier config car " + ex.Message)            ' 
            FileClose(1)                                                                '
        End Try '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        FileOpen(1, Application.StartupPath & "\Config\Gestion Contact.txt", OpenMode.Binary) '''
        FileGet(1, Livre)                                                                       ' Restaure la structure des contacts
        FileClose(1)                                                                            '
        Liste_Nouvelle() ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        PictureBox.Image = ImageList.Images(1) ' Met l'icone rouge dans la PictureBox
        Me.Height = 224 'Redimensionne la Form
    End Sub

    Private Sub Button_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ajouter.Click
        ReDim Preserve Livre.Papier(UBound(Livre.Papier) + 1)
        NotCour = UBound(Livre.Papier)
        Livre.Papier(UBound(Livre.Papier)).Nom_Contact = InputBox("Veuillez indiquer le nom & le prénom de l'adresse E-mail à ajouter", "Nom & Prénom")
        Livre.Papier(UBound(Livre.Papier)).Adresse_Email = TextBox_Destinataire.Text
        Liste_Nouvelle()
    End Sub
    Private Sub Liste_Nouvelle()
        Dim i As Integer
        ListBox_Contact.Items.Clear()

        For i = 1 To UBound(Livre.Papier)
            ListBox_Contact.Items.Add(Livre.Papier(i).Nom_Contact)
        Next
        ListBox_Contact.SelectedIndex = NotCour - 1
    End Sub

    Private Sub ListBox_Contact_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_Contact.SelectedIndexChanged
        'Et ca alors
        NotCour = ListBox_Contact.SelectedIndex + 1
        TextBox_Destinataire.Text = Livre.Papier(NotCour).Adresse_Email

        If ListBox_Contact.SelectedIndex > -1 Then ''''''''''''''
            Button_Retirer.Enabled = True                       '
        Else                                                    ' Verrouille le boutton retirer si la liste est vide
            Button_Retirer.Enabled = False                      '
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Button_Retirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Retirer.Click
        If UBound(Livre.Papier) <> 0 Then '''''''''''''''''''''''''''''''''''''''
            Livre.Papier(NotCour) = Livre.Papier(UBound(Livre.Papier))          '
            ReDim Preserve Livre.Papier(UBound(Livre.Papier) - 1)               '
            If NotCour > UBound(Livre.Papier) Then                              ' Et ouhai vs savez faire ça aussi
                NotCour = UBound(Livre.Papier)                                  '
            End If                                                              '
            Liste_Nouvelle()                                                    '
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If ListBox_Contact.SelectedIndex > -1 Then ''''''''''''''
            Button_Retirer.Enabled = True                       '
        Else                                                    ' Verrouille le bouton retirer si la liste est vide
            Button_Retirer.Enabled = False                      '
            ReDim Livre.Papier(0)                               ' Redimensione ls structure afin d'y inscrire de nouvelles données
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub TextBox_Destinataire_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Destinataire.TextChanged
        If TextBox_Destinataire.Text = "" Then ''''''
            Button_Ajouter.Enabled = False          '
        Else                                        ' Verrouille le bouton Ajouter si la TextBox_Destinataire est vide
            Button_Ajouter.Enabled = True           '
        End If ''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Button_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Annuler.Click
        Me.Close()
    End Sub
End Class