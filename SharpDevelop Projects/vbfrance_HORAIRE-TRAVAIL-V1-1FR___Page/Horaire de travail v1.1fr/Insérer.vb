Imports System.Xml
Public Class Form_Insérer
    Inherits System.Windows.Forms.Form

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()
        Application.EnableVisualStyles() '''' Active le stye Xp
        Application.DoEvents() ''''''''''''''
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
    Friend WithEvents ComboBoxDésignation As System.Windows.Forms.ComboBox
    Friend WithEvents Calendrier_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Date As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Insérer As System.Windows.Forms.GroupBox
    Friend WithEvents Label_Entreprise As System.Windows.Forms.Label
    Friend WithEvents Tooltip_Commentaires As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox_Heure As System.Windows.Forms.TextBox
    Friend WithEvents Label_Heure As System.Windows.Forms.Label
    Friend WithEvents Label_Autre_Lieu As System.Windows.Forms.Label
    Friend WithEvents Label_Minutes As System.Windows.Forms.Label
    Friend WithEvents TextBox_Minute As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Entreprise As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_AutreEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents Button_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Button_Ajouter As System.Windows.Forms.Button
    Friend WithEvents Button_Valider As System.Windows.Forms.Button
    Friend WithEvents Bouton_Annuler As System.Windows.Forms.Button
    Friend WithEvents Button_TempReel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Calcul As System.Windows.Forms.Button
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents TextBox_Heure1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Minute1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Heure2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Minute2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Minute4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Heure4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Minute3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Heure3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_Insérer))
        Me.Bouton_Annuler = New System.Windows.Forms.Button
        Me.Button_Valider = New System.Windows.Forms.Button
        Me.ComboBox_Entreprise = New System.Windows.Forms.ComboBox
        Me.Calendrier_Date = New System.Windows.Forms.DateTimePicker
        Me.TextBox_Heure = New System.Windows.Forms.TextBox
        Me.Label_Heure = New System.Windows.Forms.Label
        Me.TextBox_AutreEntreprise = New System.Windows.Forms.TextBox
        Me.Label_Autre_Lieu = New System.Windows.Forms.Label
        Me.Label_Minutes = New System.Windows.Forms.Label
        Me.TextBox_Minute = New System.Windows.Forms.TextBox
        Me.Tooltip_Commentaires = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label_Date = New System.Windows.Forms.Label
        Me.Button_Supprimer = New System.Windows.Forms.Button
        Me.GroupBox_Insérer = New System.Windows.Forms.GroupBox
        Me.Label_Entreprise = New System.Windows.Forms.Label
        Me.Button_Ajouter = New System.Windows.Forms.Button
        Me.Button_TempReel = New System.Windows.Forms.Button
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox_Minute4 = New System.Windows.Forms.TextBox
        Me.TextBox_Heure4 = New System.Windows.Forms.TextBox
        Me.TextBox_Minute3 = New System.Windows.Forms.TextBox
        Me.TextBox_Heure3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox_Minute2 = New System.Windows.Forms.TextBox
        Me.TextBox_Heure2 = New System.Windows.Forms.TextBox
        Me.TextBox_Minute1 = New System.Windows.Forms.TextBox
        Me.TextBox_Heure1 = New System.Windows.Forms.TextBox
        Me.Button_Calcul = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox_Insérer.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bouton_Annuler
        '
        Me.Bouton_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bouton_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Bouton_Annuler.Image = CType(resources.GetObject("Bouton_Annuler.Image"), System.Drawing.Image)
        Me.Bouton_Annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bouton_Annuler.Location = New System.Drawing.Point(120, 144)
        Me.Bouton_Annuler.Name = "Bouton_Annuler"
        Me.Bouton_Annuler.Size = New System.Drawing.Size(72, 23)
        Me.Bouton_Annuler.TabIndex = 8
        Me.Bouton_Annuler.Text = "&Annuler"
        Me.Tooltip_Commentaires.SetToolTip(Me.Bouton_Annuler, "Cancel")
        '
        'Button_Valider
        '
        Me.Button_Valider.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Valider.Image = CType(resources.GetObject("Button_Valider.Image"), System.Drawing.Image)
        Me.Button_Valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Valider.Location = New System.Drawing.Point(32, 144)
        Me.Button_Valider.Name = "Button_Valider"
        Me.Button_Valider.Size = New System.Drawing.Size(72, 23)
        Me.Button_Valider.TabIndex = 7
        Me.Button_Valider.Text = "&Valider"
        Me.Tooltip_Commentaires.SetToolTip(Me.Button_Valider, "Enregistrer les valeurs dans le TABLEAU")
        '
        'ComboBox_Entreprise
        '
        Me.ComboBox_Entreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Entreprise.ForeColor = System.Drawing.Color.Red
        Me.ComboBox_Entreprise.Location = New System.Drawing.Point(128, 24)
        Me.ComboBox_Entreprise.MaxDropDownItems = 15
        Me.ComboBox_Entreprise.Name = "ComboBox_Entreprise"
        Me.ComboBox_Entreprise.Size = New System.Drawing.Size(170, 23)
        Me.ComboBox_Entreprise.Sorted = True
        Me.ComboBox_Entreprise.TabIndex = 1
        Me.Tooltip_Commentaires.SetToolTip(Me.ComboBox_Entreprise, "Insérer ICI l'entreprise")
        '
        'Calendrier_Date
        '
        Me.Calendrier_Date.CustomFormat = "  dddd dd MMMM yyyy"
        Me.Calendrier_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Calendrier_Date.Location = New System.Drawing.Point(168, 104)
        Me.Calendrier_Date.Name = "Calendrier_Date"
        Me.Calendrier_Date.Size = New System.Drawing.Size(208, 23)
        Me.Calendrier_Date.TabIndex = 6
        Me.Tooltip_Commentaires.SetToolTip(Me.Calendrier_Date, "Et ICI la date")
        '
        'TextBox_Heure
        '
        Me.TextBox_Heure.Location = New System.Drawing.Point(16, 104)
        Me.TextBox_Heure.MaxLength = 2
        Me.TextBox_Heure.Name = "TextBox_Heure"
        Me.TextBox_Heure.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox_Heure.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Heure.TabIndex = 4
        Me.TextBox_Heure.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_Heure, "Indiquez ICI le nombre d'heures travaillé")
        '
        'Label_Heure
        '
        Me.Label_Heure.AutoSize = True
        Me.Label_Heure.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Heure.Location = New System.Drawing.Point(40, 104)
        Me.Label_Heure.Name = "Label_Heure"
        Me.Label_Heure.Size = New System.Drawing.Size(18, 26)
        Me.Label_Heure.TabIndex = 37
        Me.Label_Heure.Text = "H"
        '
        'TextBox_AutreEntreprise
        '
        Me.TextBox_AutreEntreprise.Enabled = False
        Me.TextBox_AutreEntreprise.Location = New System.Drawing.Point(128, 64)
        Me.TextBox_AutreEntreprise.Name = "TextBox_AutreEntreprise"
        Me.TextBox_AutreEntreprise.Size = New System.Drawing.Size(170, 23)
        Me.TextBox_AutreEntreprise.TabIndex = 2
        Me.TextBox_AutreEntreprise.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_AutreEntreprise, "Indiquez ICI une autre entreprise")
        '
        'Label_Autre_Lieu
        '
        Me.Label_Autre_Lieu.AutoSize = True
        Me.Label_Autre_Lieu.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Autre_Lieu.Location = New System.Drawing.Point(8, 64)
        Me.Label_Autre_Lieu.Name = "Label_Autre_Lieu"
        Me.Label_Autre_Lieu.Size = New System.Drawing.Size(123, 22)
        Me.Label_Autre_Lieu.TabIndex = 40
        Me.Label_Autre_Lieu.Text = "Autre entreprise:"
        '
        'Label_Minutes
        '
        Me.Label_Minutes.AutoSize = True
        Me.Label_Minutes.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Minutes.Location = New System.Drawing.Point(80, 104)
        Me.Label_Minutes.Name = "Label_Minutes"
        Me.Label_Minutes.Size = New System.Drawing.Size(67, 26)
        Me.Label_Minutes.TabIndex = 36
        Me.Label_Minutes.Text = "Minutes"
        '
        'TextBox_Minute
        '
        Me.TextBox_Minute.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Minute.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Minute.Location = New System.Drawing.Point(56, 104)
        Me.TextBox_Minute.MaxLength = 2
        Me.TextBox_Minute.Name = "TextBox_Minute"
        Me.TextBox_Minute.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox_Minute.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Minute.TabIndex = 5
        Me.TextBox_Minute.Text = ""
        Me.Tooltip_Commentaires.SetToolTip(Me.TextBox_Minute, "Indiquez ICI le nombre de minutes travaillé")
        '
        'Tooltip_Commentaires
        '
        Me.Tooltip_Commentaires.AutoPopDelay = 5000
        Me.Tooltip_Commentaires.InitialDelay = 100
        Me.Tooltip_Commentaires.ReshowDelay = 50
        '
        'Label_Date
        '
        Me.Label_Date.Location = New System.Drawing.Point(408, 8)
        Me.Label_Date.Name = "Label_Date"
        Me.Label_Date.Size = New System.Drawing.Size(100, 24)
        Me.Label_Date.TabIndex = 41
        Me.Label_Date.Visible = False
        '
        'Button_Supprimer
        '
        Me.Button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Supprimer.Location = New System.Drawing.Point(304, 24)
        Me.Button_Supprimer.Name = "Button_Supprimer"
        Me.Button_Supprimer.TabIndex = 2
        Me.Button_Supprimer.Text = "&Retirer"
        '
        'GroupBox_Insérer
        '
        Me.GroupBox_Insérer.Controls.Add(Me.Label_Entreprise)
        Me.GroupBox_Insérer.Controls.Add(Me.ComboBox_Entreprise)
        Me.GroupBox_Insérer.Controls.Add(Me.Button_Supprimer)
        Me.GroupBox_Insérer.Controls.Add(Me.TextBox_AutreEntreprise)
        Me.GroupBox_Insérer.Controls.Add(Me.Label_Autre_Lieu)
        Me.GroupBox_Insérer.Controls.Add(Me.Label_Minutes)
        Me.GroupBox_Insérer.Controls.Add(Me.TextBox_Minute)
        Me.GroupBox_Insérer.Controls.Add(Me.Label_Heure)
        Me.GroupBox_Insérer.Controls.Add(Me.TextBox_Heure)
        Me.GroupBox_Insérer.Controls.Add(Me.Calendrier_Date)
        Me.GroupBox_Insérer.Controls.Add(Me.Bouton_Annuler)
        Me.GroupBox_Insérer.Controls.Add(Me.Button_Valider)
        Me.GroupBox_Insérer.Controls.Add(Me.Button_Ajouter)
        Me.GroupBox_Insérer.Controls.Add(Me.Button_TempReel)
        Me.GroupBox_Insérer.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox_Insérer.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox_Insérer.Name = "GroupBox_Insérer"
        Me.GroupBox_Insérer.Size = New System.Drawing.Size(392, 184)
        Me.GroupBox_Insérer.TabIndex = 1
        Me.GroupBox_Insérer.TabStop = False
        Me.GroupBox_Insérer.Text = "Insérer"
        '
        'Label_Entreprise
        '
        Me.Label_Entreprise.AutoSize = True
        Me.Label_Entreprise.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Entreprise.Location = New System.Drawing.Point(48, 24)
        Me.Label_Entreprise.Name = "Label_Entreprise"
        Me.Label_Entreprise.Size = New System.Drawing.Size(80, 22)
        Me.Label_Entreprise.TabIndex = 45
        Me.Label_Entreprise.Text = "Entreprise:"
        '
        'Button_Ajouter
        '
        Me.Button_Ajouter.Enabled = False
        Me.Button_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Ajouter.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ajouter.Location = New System.Drawing.Point(304, 64)
        Me.Button_Ajouter.Name = "Button_Ajouter"
        Me.Button_Ajouter.TabIndex = 3
        Me.Button_Ajouter.Text = "&Ajouter"
        '
        'Button_TempReel
        '
        Me.Button_TempReel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_TempReel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_TempReel.ImageIndex = 0
        Me.Button_TempReel.ImageList = Me.ImageList
        Me.Button_TempReel.Location = New System.Drawing.Point(232, 144)
        Me.Button_TempReel.Name = "Button_TempReel"
        Me.Button_TempReel.Size = New System.Drawing.Size(136, 23)
        Me.Button_TempReel.TabIndex = 47
        Me.Button_TempReel.Text = "Calcul de temps réel >>"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(112, 64)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox_Minute4)
        Me.GroupBox1.Controls.Add(Me.TextBox_Heure4)
        Me.GroupBox1.Controls.Add(Me.TextBox_Minute3)
        Me.GroupBox1.Controls.Add(Me.TextBox_Heure3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Minute2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Heure2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Minute1)
        Me.GroupBox1.Controls.Add(Me.TextBox_Heure1)
        Me.GroupBox1.Controls.Add(Me.Button_Calcul)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 112)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "C&alcul de temps réel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 26)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Minutes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 26)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "H"
        '
        'TextBox_Minute4
        '
        Me.TextBox_Minute4.Location = New System.Drawing.Point(184, 80)
        Me.TextBox_Minute4.MaxLength = 2
        Me.TextBox_Minute4.Name = "TextBox_Minute4"
        Me.TextBox_Minute4.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Minute4.TabIndex = 56
        Me.TextBox_Minute4.Text = ""
        '
        'TextBox_Heure4
        '
        Me.TextBox_Heure4.Location = New System.Drawing.Point(144, 80)
        Me.TextBox_Heure4.MaxLength = 2
        Me.TextBox_Heure4.Name = "TextBox_Heure4"
        Me.TextBox_Heure4.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Heure4.TabIndex = 55
        Me.TextBox_Heure4.Text = ""
        '
        'TextBox_Minute3
        '
        Me.TextBox_Minute3.Location = New System.Drawing.Point(48, 80)
        Me.TextBox_Minute3.MaxLength = 2
        Me.TextBox_Minute3.Name = "TextBox_Minute3"
        Me.TextBox_Minute3.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Minute3.TabIndex = 54
        Me.TextBox_Minute3.Text = ""
        '
        'TextBox_Heure3
        '
        Me.TextBox_Heure3.Location = New System.Drawing.Point(8, 80)
        Me.TextBox_Heure3.MaxLength = 2
        Me.TextBox_Heure3.Name = "TextBox_Heure3"
        Me.TextBox_Heure3.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Heure3.TabIndex = 53
        Me.TextBox_Heure3.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 26)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "H"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 26)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 26)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Minutes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 26)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "H"
        '
        'TextBox_Minute2
        '
        Me.TextBox_Minute2.Location = New System.Drawing.Point(184, 24)
        Me.TextBox_Minute2.MaxLength = 2
        Me.TextBox_Minute2.Name = "TextBox_Minute2"
        Me.TextBox_Minute2.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Minute2.TabIndex = 3
        Me.TextBox_Minute2.Text = ""
        '
        'TextBox_Heure2
        '
        Me.TextBox_Heure2.Location = New System.Drawing.Point(144, 24)
        Me.TextBox_Heure2.MaxLength = 2
        Me.TextBox_Heure2.Name = "TextBox_Heure2"
        Me.TextBox_Heure2.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Heure2.TabIndex = 2
        Me.TextBox_Heure2.Text = ""
        '
        'TextBox_Minute1
        '
        Me.TextBox_Minute1.Location = New System.Drawing.Point(48, 24)
        Me.TextBox_Minute1.MaxLength = 2
        Me.TextBox_Minute1.Name = "TextBox_Minute1"
        Me.TextBox_Minute1.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Minute1.TabIndex = 1
        Me.TextBox_Minute1.Text = ""
        '
        'TextBox_Heure1
        '
        Me.TextBox_Heure1.Location = New System.Drawing.Point(8, 24)
        Me.TextBox_Heure1.MaxLength = 2
        Me.TextBox_Heure1.Name = "TextBox_Heure1"
        Me.TextBox_Heure1.Size = New System.Drawing.Size(24, 23)
        Me.TextBox_Heure1.TabIndex = 0
        Me.TextBox_Heure1.Text = ""
        '
        'Button_Calcul
        '
        Me.Button_Calcul.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Calcul.Location = New System.Drawing.Point(296, 56)
        Me.Button_Calcul.Name = "Button_Calcul"
        Me.Button_Calcul.TabIndex = 48
        Me.Button_Calcul.Text = "&Calcul"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 26)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "H"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 26)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Minutes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(120, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 26)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "et"
        '
        'Form_Insérer
        '
        Me.AcceptButton = Me.Button_Valider
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.CancelButton = Me.Bouton_Annuler
        Me.ClientSize = New System.Drawing.Size(546, 312)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox_Insérer)
        Me.Controls.Add(Me.Label_Date)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Insérer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau horaire"
        Me.GroupBox_Insérer.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Lieu, Autre_Entreprise As String
    Dim Calendrier As Date
    Dim Heure, Minute As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemplirListeAtteindre() ' Remplit la ComboBox

        ComboBox_Entreprise.SelectedIndex = 0 ' Remet la ComboBox en position 0

        'Remplit le label des dates caché
        Label_Date.Text = Calendrier_Date.Value.ToShortDateString

        Me.Size = New Size(416, 216)
    End Sub

    Sub RemplirListeAtteindre()
        ComboBox_Entreprise.Items.Clear() ' Vide la ComboBox

        Dim xmlr As New XmlTextReader(Application.StartupPath & "\Config\Insérer (ComboBox).xml") '''''''
        Do While xmlr.Read                                                                              '
            If xmlr.NodeType = XmlNodeType.Element Then                                                 ' Lit le fichier <.xml>
                If xmlr.Name = "Entreprise" Then                                                        '
                    ComboBox_Entreprise.Items.Add(xmlr.ReadElementString)                               ' Remplit la ComboBox
                End If                                                                                  '
            End If                                                                                      '
        Loop                                                                                            '
        xmlr.Close() '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Ferme le fichier XML
    End Sub

    Private Sub Button_Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ajouter.Click
        Dim DocXml As New XmlDocument
        Dim ComboBox As XmlElement
        Dim Element As XmlElement

        DocXml.Load(Application.StartupPath & "\Config\Insérer (ComboBox).xml") ' Charge le fichier <.xml>

        ComboBox = DocXml.CreateElement("ComboBox") ' Créer un nouvel élément ComboBox

        Element = DocXml.CreateElement("Entreprise") '''''''' Créer un nouvel élément Entreprise
        Element.InnerText = TextBox_AutreEntreprise.Text ''''

        ComboBox.AppendChild(Element) ' Rattacher l'élément au noeud ComboBox


        DocXml.DocumentElement.AppendChild(ComboBox) ' Rattacher l'élément ComboBox sous la racine du document

        DocXml.Save(Application.StartupPath & "\Config\Insérer (ComboBox).xml") ' Sauvegarde le fichier <.xml>

        RemplirListeAtteindre() ' Remplit le ComboBox

        ComboBox_Entreprise.SelectedItem = TextBox_AutreEntreprise.Text ' Remet la ComboBox par rapport à la TextBox

        TextBox_AutreEntreprise.Text = "" ' Vide la textBox <Autre Entreprise>

        TextBox_AutreEntreprise.Text = String.Empty ' Vérifie si il y a quelque chose dans la TextBox <Autre Entreprise>
    End Sub

    Private Sub Button_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Supprimer.Click
        Dim DocXml As New XmlDocument
        Dim Noeud As XmlNode
        Dim NoeudPere As XmlNode
        Dim sCritere As String

        DocXml.Load(Application.StartupPath & "\Config\Insérer (ComboBox).xml") ' Charge le fichier Option

        sCritere = "//ComboBox[Entreprise=""" & ComboBox_Entreprise.SelectedItem & """]" '''' 
        Noeud = DocXml.SelectSingleNode(sCritere)                                           ' Refait la liste dans le fichier <.xml>
        NoeudPere = Noeud.ParentNode                                                        ' & Enlève les élements qu'il y a ds scritère
        NoeudPere.RemoveChild(Noeud) ''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DocXml.Save(Application.StartupPath & "\Config\Insérer (ComboBox).xml") ' Sauvegarde le fichier <.xml>

        RemplirListeAtteindre() ' Remplit la ComboBox

        ComboBox_Entreprise.SelectedIndex = 0 ' Remet la ComboBox en position 0
    End Sub

    Private Sub Calendrier_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendrier_Date.ValueChanged
        ' Remplit le label des dates si le calendrier change
        Label_Date.Text = Calendrier_Date.Value.ToShortDateString
    End Sub

    Private Sub Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Valider.Click
        Try
            Changement_De_Numéro()
            If TextBox_Heure.Text = "" Then
                MessageBox.Show("Il faut mettre le temps que tu as travailler", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Heure.Select()
            ElseIf TextBox_Heure.Text > 24 Then
                MessageBox.Show("Dsl, tu ne peux pô avoir travaillé plus que 24 heures dans la même journée", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Heure.Text = ""
                TextBox_Heure.Select()
            ElseIf TextBox_Minute.Text = "" Then
                MessageBox.Show("Il faut mettre le temps que tu as travailler", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Minute.Select()
            ElseIf TextBox_Minute.Text > 59 Then
                MessageBox.Show("Dsl, il ne peux pô y avoir plus de 60 minutes", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Minute.Text = ""
                TextBox_Minute.Select()
            Else
                DialogResult = DialogResult.OK ' Quitte la fenêtre
            End If
        Catch ex As Exception ' En cas d'erreur
            MessageBox.Show("Il doit y avoir une lettre d'insérer dans le temps de travail", "Problême de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBox_Entreprise_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Entreprise.SelectedIndexChanged
        If ComboBox_Entreprise.SelectedItem = "Autre" Then ''''''''''
            TextBox_AutreEntreprise.Enabled = True                  '
        Else                                                        ' Enabled des boutons si la ComboBox affiche <Autre>
            TextBox_AutreEntreprise.Enabled = False                 '
            Button_Ajouter.Enabled = False                          '
            TextBox_AutreEntreprise.Text = ""                       '
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If ComboBox_Entreprise.SelectedItem = "Repos" Then ''''''''''
            TextBox_Heure.Enabled = False                           '
            TextBox_Heure.Text = "0"                                '
            TextBox_Minute.Enabled = False                          '
            TextBox_Minute.Text = "0"                               '
        Else                                                        ' Enabled des boutons si la ComboBox affiche <Repos>
            TextBox_Heure.Enabled = True                            '
            TextBox_Minute.Enabled = True                           '
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If ComboBox_Entreprise.SelectedItem = "Autre" Then ''''''''''
            Button_Supprimer.Enabled = False                        '
        ElseIf ComboBox_Entreprise.SelectedItem = "Repos" Then      '
            Button_Supprimer.Enabled = False                        ' Enabled du bouton <Supprimer> si la ComboBox affiche <Autre ou Repos>
        Else                                                        '
            Button_Supprimer.Enabled = True                         '
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub TextBox_AutreEntreprise_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_AutreEntreprise.TextChanged
        If TextBox_AutreEntreprise.Text = "" Then '''''''''''''''
            Button_Ajouter.Enabled = False                      '
        Else                                                    ' Enabled du bouton <Ajouter> si la TextBox <Autre Entreprise> est vide
            Button_Ajouter.Enabled = True                       '
        End If ''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Button_TempReel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_TempReel.Click
        If Button_TempReel.Text = "Calcul de temps réel >>" Then
            Me.Size = New Size(416, 336)
            Button_TempReel.Text = "Calcul de temps réel <<"
        Else
            Me.Size = New Size(416, 216)
            Button_TempReel.Text = "Calcul de temps réel >>"
        End If
    End Sub

    Private Sub Button_Calcul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Calcul.Click
        Try
            Dim Conversion1 As Integer = 0 ''''''''''''''''''''''''''''''''''''''''''    
            Dim Conversion2 As Integer = 0                                          '
            Dim Conversion3 As Integer = 0                                          '
            Dim conversion4 As Integer = 0                                          '
            Dim TotalConvertion1 As Integer = 0                                     '
            Dim TotalConvertion2 As Integer = 0                                     '
            Dim TotalConvertion3 As Integer = 0                                     '
            Conversion1 = 0                                                         '
            Conversion1 = (TextBox_Heure1.Text * 60) + TextBox_Minute1.Text         '
            Conversion2 = 0                                                         '
            Conversion2 = (TextBox_Heure2.Text * 60) + TextBox_Minute2.Text         '
            Conversion3 = 0                                                         '
            Conversion3 = (TextBox_Heure3.Text * 60) + TextBox_Minute3.Text         '
            conversion4 = 0                                                         '
            conversion4 = (TextBox_Heure4.Text * 60) + TextBox_Minute4.Text         ' Calcul
            TotalConvertion1 = 0                                                    '
            TotalConvertion1 = Conversion2 - Conversion1                            '
            TotalConvertion2 = 0                                                    '
            TotalConvertion2 = conversion4 - Conversion3                            '
            TotalConvertion3 = 0                                                    '
            TotalConvertion3 = TotalConvertion1 + TotalConvertion2                  '
            TextBox_Minute.Text = 0                                                 '
            TextBox_Heure.Text = 0                                                  '
            TextBox_Minute.Text = TotalConvertion3                                  '
            While TextBox_Minute.Text > 59                                          '
                TextBox_Heure.Text = TextBox_Heure.Text + 1                         '
                TextBox_Minute.Text = TextBox_Minute.Text - 60                      '
            End While                                                               '
        Catch ex As Exception                                                       '
            MessageBox.Show(ex.Message)                                             '
        End Try '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Button_TempReel.PerformClick() ' Clique sur ce bouton
    End Sub
    Private Sub Changement_De_Numéro()
        If TextBox_Heure.Text = "0" Then ''''''''''''
            TextBox_Heure.Text = "00"               '
        ElseIf TextBox_Heure.Text = "1" Then        '
            TextBox_Heure.Text = "01"               '
        ElseIf TextBox_Heure.Text = "2" Then        '
            TextBox_Heure.Text = "02"               '
        ElseIf TextBox_Heure.Text = "3" Then        '
            TextBox_Heure.Text = "03"               '
        ElseIf TextBox_Heure.Text = "4" Then        '
            TextBox_Heure.Text = "04"               ' Change la TextBox des heures si el contient qu'un seul numéro
        ElseIf TextBox_Heure.Text = "5" Then        '
            TextBox_Heure.Text = "05"               '
        ElseIf TextBox_Heure.Text = "6" Then        '
            TextBox_Heure.Text = "06"               '
        ElseIf TextBox_Heure.Text = "7" Then        '
            TextBox_Heure.Text = "07"               '
        ElseIf TextBox_Heure.Text = "8" Then        '
            TextBox_Heure.Text = "08"               '
        ElseIf TextBox_Heure.Text = "9" Then        '
            TextBox_Heure.Text = "09"               '
        End If ''''''''''''''''''''''''''''''''''''''
        If TextBox_Minute.Text = "0" Then '''''''''''
            TextBox_Minute.Text = "00"              '
        ElseIf TextBox_Minute.Text = "1" Then       '
            TextBox_Minute.Text = "01"              '
        ElseIf TextBox_Minute.Text = "2" Then       '
            TextBox_Minute.Text = "02"              '
        ElseIf TextBox_Minute.Text = "3" Then       '
            TextBox_Minute.Text = "03"              '
        ElseIf TextBox_Minute.Text = "4" Then       '
            TextBox_Minute.Text = "04"              ' Change la TextBox des minutes si el contient qu'un seul numéro
        ElseIf TextBox_Minute.Text = "5" Then       '
            TextBox_Minute.Text = "05"              '
        ElseIf TextBox_Minute.Text = "6" Then       '
            TextBox_Minute.Text = "06"              '
        ElseIf TextBox_Minute.Text = "7" Then       '
            TextBox_Minute.Text = "07"              '
        ElseIf TextBox_Minute.Text = "8" Then       '
            TextBox_Minute.Text = "08"              '
        ElseIf TextBox_Minute.Text = "9" Then       '
            TextBox_Minute.Text = "09"              '
        End If ''''''''''''''''''''''''''''''''''''''
    End Sub
End Class
