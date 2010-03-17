Imports System.IO
Public Class Form_Index
    Inherits System.Windows.Forms.Form

    Private mIntSelectedCol As Integer ' Variable pour le tri de la Listview

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
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents StatusBar_Fichier As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBar_Heure As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBar_Date As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Tooltip_Commentaires As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ListView5 As System.Windows.Forms.ListView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ListView6 As System.Windows.Forms.ListView
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ListView7 As System.Windows.Forms.ListView
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents ListView8 As System.Windows.Forms.ListView
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ListView9 As System.Windows.Forms.ListView
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ListView10 As System.Windows.Forms.ListView
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents ListView11 As System.Windows.Forms.ListView
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ListView12 As System.Windows.Forms.ListView
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute1 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure1 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti1 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti2 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure2 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute2 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti3 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure3 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute3 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti4 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure4 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute4 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti5 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure5 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute5 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti6 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure6 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute6 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti7 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure7 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute7 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti8 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure8 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute8 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti9 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure9 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute9 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti10 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure10 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute10 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti11 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure11 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute11 As System.Windows.Forms.Label
    Friend WithEvents Label_MinutesConverti12 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalHeure12 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalMinute12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents StatusBar_Utilisateur As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents TBSession As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBEnregistrer As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBImprimer As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBInsérer As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBMail As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBInfo As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBSéparateur1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBSéparateur2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBSéparateur3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBSéparateur4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBSéparateur5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TBSéparateur6 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_Index))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar = New System.Windows.Forms.StatusBar
        Me.StatusBar_Fichier = New System.Windows.Forms.StatusBarPanel
        Me.StatusBar_Utilisateur = New System.Windows.Forms.StatusBarPanel
        Me.StatusBar_Heure = New System.Windows.Forms.StatusBarPanel
        Me.StatusBar_Date = New System.Windows.Forms.StatusBarPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label_TotalMinute1 = New System.Windows.Forms.Label
        Me.Label_TotalHeure1 = New System.Windows.Forms.Label
        Me.Tooltip_Commentaires = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label_MinutesConverti1 = New System.Windows.Forms.Label
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.Label_MinutesConverti2 = New System.Windows.Forms.Label
        Me.Label_TotalHeure2 = New System.Windows.Forms.Label
        Me.Label_TotalMinute2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.Label_MinutesConverti3 = New System.Windows.Forms.Label
        Me.Label_TotalHeure3 = New System.Windows.Forms.Label
        Me.Label_TotalMinute3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.Label_MinutesConverti4 = New System.Windows.Forms.Label
        Me.Label_TotalHeure4 = New System.Windows.Forms.Label
        Me.Label_TotalMinute4 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti5 = New System.Windows.Forms.Label
        Me.ListView5 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure5 = New System.Windows.Forms.Label
        Me.Label_TotalMinute5 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti6 = New System.Windows.Forms.Label
        Me.ListView6 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure6 = New System.Windows.Forms.Label
        Me.Label_TotalMinute6 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti7 = New System.Windows.Forms.Label
        Me.ListView7 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure7 = New System.Windows.Forms.Label
        Me.Label_TotalMinute7 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti8 = New System.Windows.Forms.Label
        Me.ListView8 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure8 = New System.Windows.Forms.Label
        Me.Label_TotalMinute8 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti9 = New System.Windows.Forms.Label
        Me.ListView9 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure9 = New System.Windows.Forms.Label
        Me.Label_TotalMinute9 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti10 = New System.Windows.Forms.Label
        Me.ListView10 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure10 = New System.Windows.Forms.Label
        Me.Label_TotalMinute10 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti11 = New System.Windows.Forms.Label
        Me.ListView11 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure11 = New System.Windows.Forms.Label
        Me.Label_TotalMinute11 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.Label_MinutesConverti12 = New System.Windows.Forms.Label
        Me.ListView12 = New System.Windows.Forms.ListView
        Me.Label_TotalHeure12 = New System.Windows.Forms.Label
        Me.Label_TotalMinute12 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.TBSession = New System.Windows.Forms.ToolBarButton
        Me.TBSéparateur1 = New System.Windows.Forms.ToolBarButton
        Me.TBEnregistrer = New System.Windows.Forms.ToolBarButton
        Me.TBSéparateur2 = New System.Windows.Forms.ToolBarButton
        Me.TBImprimer = New System.Windows.Forms.ToolBarButton
        Me.TBSéparateur3 = New System.Windows.Forms.ToolBarButton
        Me.TBInsérer = New System.Windows.Forms.ToolBarButton
        Me.TBSéparateur4 = New System.Windows.Forms.ToolBarButton
        Me.TBDelete = New System.Windows.Forms.ToolBarButton
        Me.TBSéparateur5 = New System.Windows.Forms.ToolBarButton
        Me.TBMail = New System.Windows.Forms.ToolBarButton
        Me.TBSéparateur6 = New System.Windows.Forms.ToolBarButton
        Me.TBInfo = New System.Windows.Forms.ToolBarButton
        CType(Me.StatusBar_Fichier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBar_Utilisateur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBar_Heure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBar_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 706)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBar_Fichier, Me.StatusBar_Utilisateur, Me.StatusBar_Heure, Me.StatusBar_Date})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(602, 22)
        Me.StatusBar.SizingGrip = False
        Me.StatusBar.TabIndex = 0
        '
        'StatusBar_Fichier
        '
        Me.StatusBar_Fichier.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBar_Fichier.Text = "Aucun fichier n'est pour l'instant ouvert"
        Me.StatusBar_Fichier.Width = 572
        '
        'StatusBar_Utilisateur
        '
        Me.StatusBar_Utilisateur.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBar_Utilisateur.Width = 10
        '
        'StatusBar_Heure
        '
        Me.StatusBar_Heure.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBar_Heure.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBar_Heure.Width = 10
        '
        'StatusBar_Date
        '
        Me.StatusBar_Date.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBar_Date.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBar_Date.Width = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 567)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 26)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "H"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 567)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Minutes"
        '
        'Label_TotalMinute1
        '
        Me.Label_TotalMinute1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute1.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute1.Name = "Label_TotalMinute1"
        Me.Label_TotalMinute1.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute1.TabIndex = 42
        Me.Label_TotalMinute1.Text = "00"
        Me.Label_TotalMinute1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalHeure1
        '
        Me.Label_TotalHeure1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label_TotalHeure1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure1.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure1.Name = "Label_TotalHeure1"
        Me.Label_TotalHeure1.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure1.TabIndex = 41
        Me.Label_TotalHeure1.Text = "000"
        Me.Label_TotalHeure1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tooltip_Commentaires
        '
        Me.Tooltip_Commentaires.AutoPopDelay = 5000
        Me.Tooltip_Commentaires.InitialDelay = 50
        Me.Tooltip_Commentaires.ReshowDelay = 100
        '
        'Label_MinutesConverti1
        '
        Me.Label_MinutesConverti1.Location = New System.Drawing.Point(24, 568)
        Me.Label_MinutesConverti1.Name = "Label_MinutesConverti1"
        Me.Label_MinutesConverti1.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti1.TabIndex = 49
        Me.Label_MinutesConverti1.Text = "0"
        Me.Label_MinutesConverti1.Visible = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.TabPage5)
        Me.TabControl.Controls.Add(Me.TabPage6)
        Me.TabControl.Controls.Add(Me.TabPage7)
        Me.TabControl.Controls.Add(Me.TabPage8)
        Me.TabControl.Controls.Add(Me.TabPage9)
        Me.TabControl.Controls.Add(Me.TabPage10)
        Me.TabControl.Controls.Add(Me.TabPage11)
        Me.TabControl.Controls.Add(Me.TabPage12)
        Me.TabControl.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.ItemSize = New System.Drawing.Size(52, 20)
        Me.TabControl.Location = New System.Drawing.Point(8, 40)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(584, 656)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label_MinutesConverti1)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Controls.Add(Me.Label_TotalHeure1)
        Me.TabPage1.Controls.Add(Me.Label_TotalMinute1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(576, 608)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Janvier"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 7)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(536, 541)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Controls.Add(Me.Label_MinutesConverti2)
        Me.TabPage2.Controls.Add(Me.Label_TotalHeure2)
        Me.TabPage2.Controls.Add(Me.Label_TotalMinute2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(576, 608)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Février"
        '
        'ListView2
        '
        Me.ListView2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(8, 7)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(536, 541)
        Me.ListView2.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView2.TabIndex = 56
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'Label_MinutesConverti2
        '
        Me.Label_MinutesConverti2.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti2.Name = "Label_MinutesConverti2"
        Me.Label_MinutesConverti2.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti2.TabIndex = 55
        Me.Label_MinutesConverti2.Text = "0"
        Me.Label_MinutesConverti2.Visible = False
        '
        'Label_TotalHeure2
        '
        Me.Label_TotalHeure2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure2.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure2.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure2.Name = "Label_TotalHeure2"
        Me.Label_TotalHeure2.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure2.TabIndex = 53
        Me.Label_TotalHeure2.Text = "000"
        Me.Label_TotalHeure2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute2
        '
        Me.Label_TotalMinute2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute2.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute2.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute2.Name = "Label_TotalMinute2"
        Me.Label_TotalMinute2.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute2.TabIndex = 54
        Me.Label_TotalMinute2.Text = "00"
        Me.Label_TotalMinute2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 567)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 26)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Minutes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 567)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 26)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "H"
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.ListView3)
        Me.TabPage3.Controls.Add(Me.Label_MinutesConverti3)
        Me.TabPage3.Controls.Add(Me.Label_TotalHeure3)
        Me.TabPage3.Controls.Add(Me.Label_TotalMinute3)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(576, 608)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mars"
        '
        'ListView3
        '
        Me.ListView3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(8, 7)
        Me.ListView3.MultiSelect = False
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(536, 541)
        Me.ListView3.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView3.TabIndex = 56
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'Label_MinutesConverti3
        '
        Me.Label_MinutesConverti3.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti3.Name = "Label_MinutesConverti3"
        Me.Label_MinutesConverti3.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti3.TabIndex = 55
        Me.Label_MinutesConverti3.Text = "0"
        Me.Label_MinutesConverti3.Visible = False
        '
        'Label_TotalHeure3
        '
        Me.Label_TotalHeure3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure3.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure3.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure3.Name = "Label_TotalHeure3"
        Me.Label_TotalHeure3.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure3.TabIndex = 53
        Me.Label_TotalHeure3.Text = "000"
        Me.Label_TotalHeure3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute3
        '
        Me.Label_TotalMinute3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute3.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute3.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute3.Name = "Label_TotalMinute3"
        Me.Label_TotalMinute3.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute3.TabIndex = 54
        Me.Label_TotalMinute3.Text = "00"
        Me.Label_TotalMinute3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(296, 567)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 26)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Minutes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(232, 567)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 26)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "H"
        '
        'TabPage4
        '
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.ListView4)
        Me.TabPage4.Controls.Add(Me.Label_MinutesConverti4)
        Me.TabPage4.Controls.Add(Me.Label_TotalHeure4)
        Me.TabPage4.Controls.Add(Me.Label_TotalMinute4)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(576, 608)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Avril"
        '
        'ListView4
        '
        Me.ListView4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(8, 7)
        Me.ListView4.MultiSelect = False
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(536, 541)
        Me.ListView4.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView4.TabIndex = 56
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'Label_MinutesConverti4
        '
        Me.Label_MinutesConverti4.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti4.Name = "Label_MinutesConverti4"
        Me.Label_MinutesConverti4.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti4.TabIndex = 55
        Me.Label_MinutesConverti4.Text = "0"
        Me.Label_MinutesConverti4.Visible = False
        '
        'Label_TotalHeure4
        '
        Me.Label_TotalHeure4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure4.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure4.Name = "Label_TotalHeure4"
        Me.Label_TotalHeure4.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure4.TabIndex = 53
        Me.Label_TotalHeure4.Text = "000"
        Me.Label_TotalHeure4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute4
        '
        Me.Label_TotalMinute4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute4.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute4.Name = "Label_TotalMinute4"
        Me.Label_TotalMinute4.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute4.TabIndex = 54
        Me.Label_TotalMinute4.Text = "00"
        Me.Label_TotalMinute4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(296, 567)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 26)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Minutes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(232, 567)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 26)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "H"
        '
        'TabPage5
        '
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage5.Controls.Add(Me.Label_MinutesConverti5)
        Me.TabPage5.Controls.Add(Me.ListView5)
        Me.TabPage5.Controls.Add(Me.Label_TotalHeure5)
        Me.TabPage5.Controls.Add(Me.Label_TotalMinute5)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Location = New System.Drawing.Point(4, 44)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(576, 608)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Mai"
        '
        'Label_MinutesConverti5
        '
        Me.Label_MinutesConverti5.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti5.Name = "Label_MinutesConverti5"
        Me.Label_MinutesConverti5.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti5.TabIndex = 55
        Me.Label_MinutesConverti5.Text = "0"
        Me.Label_MinutesConverti5.Visible = False
        '
        'ListView5
        '
        Me.ListView5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView5.FullRowSelect = True
        Me.ListView5.GridLines = True
        Me.ListView5.Location = New System.Drawing.Point(8, 7)
        Me.ListView5.MultiSelect = False
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(536, 541)
        Me.ListView5.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView5.TabIndex = 50
        Me.ListView5.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure5
        '
        Me.Label_TotalHeure5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure5.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure5.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure5.Name = "Label_TotalHeure5"
        Me.Label_TotalHeure5.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure5.TabIndex = 53
        Me.Label_TotalHeure5.Text = "000"
        Me.Label_TotalHeure5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute5
        '
        Me.Label_TotalMinute5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute5.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute5.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute5.Name = "Label_TotalMinute5"
        Me.Label_TotalMinute5.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute5.TabIndex = 54
        Me.Label_TotalMinute5.Text = "00"
        Me.Label_TotalMinute5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(296, 567)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 26)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Minutes"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(232, 567)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 26)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "H"
        '
        'TabPage6
        '
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage6.Controls.Add(Me.Label_MinutesConverti6)
        Me.TabPage6.Controls.Add(Me.ListView6)
        Me.TabPage6.Controls.Add(Me.Label_TotalHeure6)
        Me.TabPage6.Controls.Add(Me.Label_TotalMinute6)
        Me.TabPage6.Controls.Add(Me.Label24)
        Me.TabPage6.Controls.Add(Me.Label25)
        Me.TabPage6.Location = New System.Drawing.Point(4, 44)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(576, 608)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Juin"
        '
        'Label_MinutesConverti6
        '
        Me.Label_MinutesConverti6.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti6.Name = "Label_MinutesConverti6"
        Me.Label_MinutesConverti6.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti6.TabIndex = 55
        Me.Label_MinutesConverti6.Text = "0"
        Me.Label_MinutesConverti6.Visible = False
        '
        'ListView6
        '
        Me.ListView6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView6.FullRowSelect = True
        Me.ListView6.GridLines = True
        Me.ListView6.Location = New System.Drawing.Point(8, 7)
        Me.ListView6.MultiSelect = False
        Me.ListView6.Name = "ListView6"
        Me.ListView6.Size = New System.Drawing.Size(536, 541)
        Me.ListView6.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView6.TabIndex = 50
        Me.ListView6.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure6
        '
        Me.Label_TotalHeure6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure6.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure6.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure6.Name = "Label_TotalHeure6"
        Me.Label_TotalHeure6.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure6.TabIndex = 53
        Me.Label_TotalHeure6.Text = "000"
        Me.Label_TotalHeure6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute6
        '
        Me.Label_TotalMinute6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute6.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute6.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute6.Name = "Label_TotalMinute6"
        Me.Label_TotalMinute6.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute6.TabIndex = 54
        Me.Label_TotalMinute6.Text = "00"
        Me.Label_TotalMinute6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(296, 567)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 26)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Minutes"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(232, 567)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 26)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "H"
        '
        'TabPage7
        '
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage7.Controls.Add(Me.Label_MinutesConverti7)
        Me.TabPage7.Controls.Add(Me.ListView7)
        Me.TabPage7.Controls.Add(Me.Label_TotalHeure7)
        Me.TabPage7.Controls.Add(Me.Label_TotalMinute7)
        Me.TabPage7.Controls.Add(Me.Label29)
        Me.TabPage7.Controls.Add(Me.Label30)
        Me.TabPage7.Location = New System.Drawing.Point(4, 44)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(576, 608)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Juillet"
        '
        'Label_MinutesConverti7
        '
        Me.Label_MinutesConverti7.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti7.Name = "Label_MinutesConverti7"
        Me.Label_MinutesConverti7.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti7.TabIndex = 55
        Me.Label_MinutesConverti7.Text = "0"
        Me.Label_MinutesConverti7.Visible = False
        '
        'ListView7
        '
        Me.ListView7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView7.FullRowSelect = True
        Me.ListView7.GridLines = True
        Me.ListView7.Location = New System.Drawing.Point(8, 7)
        Me.ListView7.MultiSelect = False
        Me.ListView7.Name = "ListView7"
        Me.ListView7.Size = New System.Drawing.Size(536, 541)
        Me.ListView7.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView7.TabIndex = 50
        Me.ListView7.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure7
        '
        Me.Label_TotalHeure7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure7.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure7.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure7.Name = "Label_TotalHeure7"
        Me.Label_TotalHeure7.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure7.TabIndex = 53
        Me.Label_TotalHeure7.Text = "000"
        Me.Label_TotalHeure7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute7
        '
        Me.Label_TotalMinute7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute7.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute7.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute7.Name = "Label_TotalMinute7"
        Me.Label_TotalMinute7.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute7.TabIndex = 54
        Me.Label_TotalMinute7.Text = "00"
        Me.Label_TotalMinute7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(296, 567)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(67, 26)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "Minutes"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label30.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(232, 567)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(18, 26)
        Me.Label30.TabIndex = 51
        Me.Label30.Text = "H"
        '
        'TabPage8
        '
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage8.Controls.Add(Me.Label_MinutesConverti8)
        Me.TabPage8.Controls.Add(Me.ListView8)
        Me.TabPage8.Controls.Add(Me.Label_TotalHeure8)
        Me.TabPage8.Controls.Add(Me.Label_TotalMinute8)
        Me.TabPage8.Controls.Add(Me.Label34)
        Me.TabPage8.Controls.Add(Me.Label35)
        Me.TabPage8.Location = New System.Drawing.Point(4, 44)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(576, 608)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Août"
        '
        'Label_MinutesConverti8
        '
        Me.Label_MinutesConverti8.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti8.Name = "Label_MinutesConverti8"
        Me.Label_MinutesConverti8.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti8.TabIndex = 55
        Me.Label_MinutesConverti8.Text = "0"
        Me.Label_MinutesConverti8.Visible = False
        '
        'ListView8
        '
        Me.ListView8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView8.FullRowSelect = True
        Me.ListView8.GridLines = True
        Me.ListView8.Location = New System.Drawing.Point(8, 7)
        Me.ListView8.MultiSelect = False
        Me.ListView8.Name = "ListView8"
        Me.ListView8.Size = New System.Drawing.Size(536, 541)
        Me.ListView8.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView8.TabIndex = 50
        Me.ListView8.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure8
        '
        Me.Label_TotalHeure8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure8.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure8.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure8.Name = "Label_TotalHeure8"
        Me.Label_TotalHeure8.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure8.TabIndex = 53
        Me.Label_TotalHeure8.Text = "000"
        Me.Label_TotalHeure8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute8
        '
        Me.Label_TotalMinute8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute8.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute8.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute8.Name = "Label_TotalMinute8"
        Me.Label_TotalMinute8.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute8.TabIndex = 54
        Me.Label_TotalMinute8.Text = "00"
        Me.Label_TotalMinute8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label34.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(296, 567)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 26)
        Me.Label34.TabIndex = 52
        Me.Label34.Text = "Minutes"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label35.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(232, 567)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(18, 26)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "H"
        '
        'TabPage9
        '
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage9.Controls.Add(Me.Label_MinutesConverti9)
        Me.TabPage9.Controls.Add(Me.ListView9)
        Me.TabPage9.Controls.Add(Me.Label_TotalHeure9)
        Me.TabPage9.Controls.Add(Me.Label_TotalMinute9)
        Me.TabPage9.Controls.Add(Me.Label39)
        Me.TabPage9.Controls.Add(Me.Label40)
        Me.TabPage9.Location = New System.Drawing.Point(4, 44)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(576, 608)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Septembre"
        '
        'Label_MinutesConverti9
        '
        Me.Label_MinutesConverti9.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti9.Name = "Label_MinutesConverti9"
        Me.Label_MinutesConverti9.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti9.TabIndex = 55
        Me.Label_MinutesConverti9.Text = "0"
        Me.Label_MinutesConverti9.Visible = False
        '
        'ListView9
        '
        Me.ListView9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView9.FullRowSelect = True
        Me.ListView9.GridLines = True
        Me.ListView9.Location = New System.Drawing.Point(8, 7)
        Me.ListView9.MultiSelect = False
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(536, 541)
        Me.ListView9.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView9.TabIndex = 50
        Me.ListView9.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure9
        '
        Me.Label_TotalHeure9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure9.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure9.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure9.Name = "Label_TotalHeure9"
        Me.Label_TotalHeure9.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure9.TabIndex = 53
        Me.Label_TotalHeure9.Text = "000"
        Me.Label_TotalHeure9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute9
        '
        Me.Label_TotalMinute9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute9.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute9.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute9.Name = "Label_TotalMinute9"
        Me.Label_TotalMinute9.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute9.TabIndex = 54
        Me.Label_TotalMinute9.Text = "00"
        Me.Label_TotalMinute9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label39.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(296, 567)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(67, 26)
        Me.Label39.TabIndex = 52
        Me.Label39.Text = "Minutes"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label40.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(232, 567)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(18, 26)
        Me.Label40.TabIndex = 51
        Me.Label40.Text = "H"
        '
        'TabPage10
        '
        Me.TabPage10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage10.Controls.Add(Me.Label_MinutesConverti10)
        Me.TabPage10.Controls.Add(Me.ListView10)
        Me.TabPage10.Controls.Add(Me.Label_TotalHeure10)
        Me.TabPage10.Controls.Add(Me.Label_TotalMinute10)
        Me.TabPage10.Controls.Add(Me.Label44)
        Me.TabPage10.Controls.Add(Me.Label45)
        Me.TabPage10.Location = New System.Drawing.Point(4, 44)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(576, 608)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Octobre"
        '
        'Label_MinutesConverti10
        '
        Me.Label_MinutesConverti10.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti10.Name = "Label_MinutesConverti10"
        Me.Label_MinutesConverti10.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti10.TabIndex = 55
        Me.Label_MinutesConverti10.Text = "0"
        Me.Label_MinutesConverti10.Visible = False
        '
        'ListView10
        '
        Me.ListView10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView10.FullRowSelect = True
        Me.ListView10.GridLines = True
        Me.ListView10.Location = New System.Drawing.Point(8, 7)
        Me.ListView10.MultiSelect = False
        Me.ListView10.Name = "ListView10"
        Me.ListView10.Size = New System.Drawing.Size(536, 541)
        Me.ListView10.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView10.TabIndex = 50
        Me.ListView10.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure10
        '
        Me.Label_TotalHeure10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure10.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure10.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure10.Name = "Label_TotalHeure10"
        Me.Label_TotalHeure10.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure10.TabIndex = 53
        Me.Label_TotalHeure10.Text = "000"
        Me.Label_TotalHeure10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute10
        '
        Me.Label_TotalMinute10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute10.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute10.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute10.Name = "Label_TotalMinute10"
        Me.Label_TotalMinute10.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute10.TabIndex = 54
        Me.Label_TotalMinute10.Text = "00"
        Me.Label_TotalMinute10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(296, 567)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(67, 26)
        Me.Label44.TabIndex = 52
        Me.Label44.Text = "Minutes"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label45.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(232, 567)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(18, 26)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "H"
        '
        'TabPage11
        '
        Me.TabPage11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage11.Controls.Add(Me.Label_MinutesConverti11)
        Me.TabPage11.Controls.Add(Me.ListView11)
        Me.TabPage11.Controls.Add(Me.Label_TotalHeure11)
        Me.TabPage11.Controls.Add(Me.Label_TotalMinute11)
        Me.TabPage11.Controls.Add(Me.Label49)
        Me.TabPage11.Controls.Add(Me.Label50)
        Me.TabPage11.Location = New System.Drawing.Point(4, 44)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(576, 608)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "Novembre"
        '
        'Label_MinutesConverti11
        '
        Me.Label_MinutesConverti11.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti11.Name = "Label_MinutesConverti11"
        Me.Label_MinutesConverti11.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti11.TabIndex = 55
        Me.Label_MinutesConverti11.Text = "0"
        Me.Label_MinutesConverti11.Visible = False
        '
        'ListView11
        '
        Me.ListView11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView11.FullRowSelect = True
        Me.ListView11.GridLines = True
        Me.ListView11.Location = New System.Drawing.Point(8, 7)
        Me.ListView11.MultiSelect = False
        Me.ListView11.Name = "ListView11"
        Me.ListView11.Size = New System.Drawing.Size(536, 541)
        Me.ListView11.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView11.TabIndex = 50
        Me.ListView11.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure11
        '
        Me.Label_TotalHeure11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure11.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure11.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure11.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure11.Name = "Label_TotalHeure11"
        Me.Label_TotalHeure11.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure11.TabIndex = 53
        Me.Label_TotalHeure11.Text = "000"
        Me.Label_TotalHeure11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute11
        '
        Me.Label_TotalMinute11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute11.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute11.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute11.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute11.Name = "Label_TotalMinute11"
        Me.Label_TotalMinute11.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute11.TabIndex = 54
        Me.Label_TotalMinute11.Text = "00"
        Me.Label_TotalMinute11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(296, 567)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(67, 26)
        Me.Label49.TabIndex = 52
        Me.Label49.Text = "Minutes"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label50.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(232, 567)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(18, 26)
        Me.Label50.TabIndex = 51
        Me.Label50.Text = "H"
        '
        'TabPage12
        '
        Me.TabPage12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage12.Controls.Add(Me.Label_MinutesConverti12)
        Me.TabPage12.Controls.Add(Me.ListView12)
        Me.TabPage12.Controls.Add(Me.Label_TotalHeure12)
        Me.TabPage12.Controls.Add(Me.Label_TotalMinute12)
        Me.TabPage12.Controls.Add(Me.Label54)
        Me.TabPage12.Controls.Add(Me.Label55)
        Me.TabPage12.Location = New System.Drawing.Point(4, 44)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(576, 608)
        Me.TabPage12.TabIndex = 11
        Me.TabPage12.Text = "Décembre"
        '
        'Label_MinutesConverti12
        '
        Me.Label_MinutesConverti12.Location = New System.Drawing.Point(24, 567)
        Me.Label_MinutesConverti12.Name = "Label_MinutesConverti12"
        Me.Label_MinutesConverti12.Size = New System.Drawing.Size(100, 24)
        Me.Label_MinutesConverti12.TabIndex = 55
        Me.Label_MinutesConverti12.Text = "0"
        Me.Label_MinutesConverti12.Visible = False
        '
        'ListView12
        '
        Me.ListView12.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView12.FullRowSelect = True
        Me.ListView12.GridLines = True
        Me.ListView12.Location = New System.Drawing.Point(8, 7)
        Me.ListView12.MultiSelect = False
        Me.ListView12.Name = "ListView12"
        Me.ListView12.Size = New System.Drawing.Size(536, 541)
        Me.ListView12.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView12.TabIndex = 50
        Me.ListView12.View = System.Windows.Forms.View.Details
        '
        'Label_TotalHeure12
        '
        Me.Label_TotalHeure12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalHeure12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalHeure12.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalHeure12.Location = New System.Drawing.Point(184, 567)
        Me.Label_TotalHeure12.Name = "Label_TotalHeure12"
        Me.Label_TotalHeure12.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalHeure12.TabIndex = 53
        Me.Label_TotalHeure12.Text = "000"
        Me.Label_TotalHeure12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalMinute12
        '
        Me.Label_TotalMinute12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_TotalMinute12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalMinute12.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label_TotalMinute12.Location = New System.Drawing.Point(248, 567)
        Me.Label_TotalMinute12.Name = "Label_TotalMinute12"
        Me.Label_TotalMinute12.Size = New System.Drawing.Size(48, 23)
        Me.Label_TotalMinute12.TabIndex = 54
        Me.Label_TotalMinute12.Text = "00"
        Me.Label_TotalMinute12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(296, 567)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(67, 26)
        Me.Label54.TabIndex = 52
        Me.Label54.Text = "Minutes"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label55.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(232, 567)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(18, 26)
        Me.Label55.TabIndex = 51
        Me.Label55.Text = "H"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar
        '
        Me.ToolBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.TBSession, Me.TBSéparateur1, Me.TBEnregistrer, Me.TBSéparateur2, Me.TBImprimer, Me.TBSéparateur3, Me.TBInsérer, Me.TBSéparateur4, Me.TBDelete, Me.TBSéparateur5, Me.TBMail, Me.TBSéparateur6, Me.TBInfo})
        Me.ToolBar.ButtonSize = New System.Drawing.Size(23, 22)
        Me.ToolBar.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(608, 30)
        Me.ToolBar.TabIndex = 52
        '
        'TBSession
        '
        Me.TBSession.ImageIndex = 0
        Me.TBSession.Tag = "TBSession"
        '
        'TBSéparateur1
        '
        Me.TBSéparateur1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TBEnregistrer
        '
        Me.TBEnregistrer.Enabled = False
        Me.TBEnregistrer.ImageIndex = 1
        Me.TBEnregistrer.Tag = "TBEnregistrer"
        '
        'TBSéparateur2
        '
        Me.TBSéparateur2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TBImprimer
        '
        Me.TBImprimer.Enabled = False
        Me.TBImprimer.ImageIndex = 2
        Me.TBImprimer.Tag = "TBImprimer"
        '
        'TBSéparateur3
        '
        Me.TBSéparateur3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TBInsérer
        '
        Me.TBInsérer.ImageIndex = 3
        Me.TBInsérer.Tag = "TBInsérer"
        '
        'TBSéparateur4
        '
        Me.TBSéparateur4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TBDelete
        '
        Me.TBDelete.Enabled = False
        Me.TBDelete.ImageIndex = 4
        Me.TBDelete.Tag = "TBDelete"
        '
        'TBSéparateur5
        '
        Me.TBSéparateur5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TBMail
        '
        Me.TBMail.Enabled = False
        Me.TBMail.ImageIndex = 5
        Me.TBMail.Tag = "TBMail"
        '
        'TBSéparateur6
        '
        Me.TBSéparateur6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'TBInfo
        '
        Me.TBInfo.ImageIndex = 6
        Me.TBInfo.Tag = "TBInfo"
        '
        'Form_Index
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(602, 728)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "Form_Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horaire de travail v1.1fr - Aucun fichier n'est pour l'instant ouvert"
        CType(Me.StatusBar_Fichier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBar_Utilisateur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBar_Heure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBar_Date, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Structure Total_TousLesMois
        Dim StructureMinute_Janvier As Integer ''''''''''''''''''
        Dim StructureHeure_Janvier As Integer                   ' Janvier
        Dim StructureConversionMinute_Janvier As Integer ''''''''

        Dim StructureMinute_Février As Integer ''''''''''''''''''
        Dim StructureHeure_Février As Integer                   ' Février
        Dim StructureConversionMinute_Février As Integer ''''''''

        Dim StructureMinute_Mars As Integer '''''''''''''''''''''
        Dim StructureHeure_Mars As Integer                      ' Mars
        Dim StructureConversionMinute_Mars As Integer '''''''''''

        Dim StructureMinute_Avril As Integer ''''''''''''''''''''
        Dim StructureHeure_Avril As Integer                     ' Avril
        Dim StructureConversionMinute_Avril As Integer ''''''''''

        Dim StructureMinute_Mai As Integer ''''''''''''''''''''''
        Dim StructureHeure_Mai As Integer                       ' Mai
        Dim StructureConversionMinute_Mai As Integer ''''''''''''

        Dim StructureMinute_Juin As Integer '''''''''''''''''''''
        Dim StructureHeure_Juin As Integer                      ' Juin
        Dim StructureConversionMinute_Juin As Integer '''''''''''

        Dim StructureMinute_Juillet As Integer ''''''''''''''''''
        Dim StructureHeure_Juillet As Integer                   ' Juillet
        Dim StructureConversionMinute_Juillet As Integer ''''''''

        Dim StructureMinute_Août As Integer '''''''''''''''''''''
        Dim StructureHeure_Août As Integer                      ' Août
        Dim StructureConversionMinute_Août As Integer '''''''''''

        Dim StructureMinute_Septembre As Integer ''''''''''''''''
        Dim StructureHeure_Septembre As Integer                 ' Septembre
        Dim StructureConversionMinute_Septembre As Integer ''''''

        Dim StructureMinute_Octobre As Integer ''''''''''''''''''
        Dim StructureHeure_Octobre As Integer                   ' Octobre
        Dim StructureConversionMinute_Octobre As Integer ''''''''

        Dim StructureMinute_Novembre As Integer '''''''''''''''''
        Dim StructureHeure_Novembre As Integer                  ' Novembre
        Dim StructureConversionMinute_Novembre As Integer '''''''

        Dim StructureMinute_Décembre As Integer '''''''''''''''''
        Dim StructureHeure_Décembre As Integer                  ' Décembre
        Dim StructureConversionMinute_Décembre As Integer '''''''
    End Structure

    Dim ObjTotal As Total_TousLesMois ' Variable de la structure
    Dim Retour As Integer ' Insérer
    Dim HeureCalcul, MinuteCalcul As Integer ' Temps de travail
    Dim Addition As Integer = 0 ' Additionne le temps de travail
    Dim i As Integer = 0 ' Toutes les boucles for
    Dim Save_Listview1 As String = "" ''''''' 
    Dim Save_Listview2 As String = ""       ' 
    Dim Save_Listview3 As String = ""       ' 
    Dim Save_Listview4 As String = ""       ' 
    Dim Save_Listview5 As String = ""       ' Variable qui enregistre & ouvre les Listview
    Dim Save_Listview6 As String = ""       ' 
    Dim Save_Listview7 As String = ""       ' 
    Dim Save_Listview8 As String = ""       ' 
    Dim Save_Listview9 As String = ""       ' 
    Dim Save_Listview10 As String = ""      ' 
    Dim Save_Listview11 As String = ""      '
    Dim Save_Listview12 As String = "" '''''' 
    Dim Val() As String ' Tou les split
    Private Sub Changement_De_Session()
        Dim Form_Utilisateur As New Form_Utilisateur ''''' Affiche la form pour savoir kel utilisateur se connecte
        Form_Utilisateur.ShowDialog()

        Efface_Tout()
            If Form_Utilisateur.TextBox_Utilisateur.Text <> "" Then '''''''''''''''''''''''''''''''''''''''''''''
                StatusBar.Panels(1).Text = Form_Utilisateur.TextBox_Utilisateur.Text                            '
                Dim FormAttente As New Form_Attente ' Ouvre la page qui permet d'attendre un pe pres 3 seconde
                FormAttente.ShowDialog() ' Avant d'enregistrer des trucs ds les fichiers qu'on vien de creer
                MenuEnregistrer() ' Enregistre un document vide si c'est un nouvel utilisateur                  '
            Else                                                                                                ' Remplit la StatusBar
                StatusBar.Panels(1).Text = Form_Utilisateur.ListBox_Utilisateur.SelectedItem                    '
                Ouvrir()                                                                                        '
            End If ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If Date.Now.Month = 1 Then '''''''''''''''''''''' 
                TabControl.SelectedIndex = 0                '
                If ListView1.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 2 Then                  '
                TabControl.SelectedIndex = 1                '
                If ListView2.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 3 Then                  '
                TabControl.SelectedIndex = 2                '
                If ListView3.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 4 Then                  '
                TabControl.SelectedIndex = 3                '
                If ListView4.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 5 Then                  '
                TabControl.SelectedIndex = 4                '
                If ListView5.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 6 Then                  ' Met la Tabcontrol suivant le mois
                TabControl.SelectedIndex = 5                '
                If ListView6.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 7 Then                  '
                TabControl.SelectedIndex = 6                '  
                If ListView7.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 8 Then                  '
                TabControl.SelectedIndex = 7                '
                If ListView8.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 9 Then                  '
                TabControl.SelectedIndex = 8                '
                If ListView9.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 10 Then                 '
                TabControl.SelectedIndex = 9                '
                If ListView10.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 11 Then                 '
                TabControl.SelectedIndex = 10               '
                If ListView11.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf Date.Now.Month = 12 Then                 '
                TabControl.SelectedIndex = 11               '
                If ListView12.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            End If ''''''''''''''''''''''''''''''''''''''''''

            TBEnregistrer.Enabled = False ' ToolBar enregistrer
            MainMenu.MenuItems(0).MenuItems(1).Visible = False ''' Bouton Enregistrer
            MainMenu.MenuItems(0).MenuItems(1).Enabled = False '''
    End Sub

    Private Sub Index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim TabP As TabPage                                                             '
        For Each TabP In TabControl.Controls                                            '
            x = x + 1                                                                   '
            Dim BackTabControl As New TabControl                                        ' Paramêtre la Tabcontrol
            BackTabControl.Name = "BackTabControl" & x                                  ' a cause de style Xp
            BackTabControl.Location = New Point(-4, -4)                                 '
            BackTabControl.Size = New Size(TabPage1.Width + 8, TabPage1.Height + 8)     '
            TabP.Controls.Add(BackTabControl)                                           '
        Next TabP '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' Ajoute le MainMenu
        MainMenu.MenuItems.Add("&Fichier") '''''' 
        MainMenu.MenuItems.Add("&Edition")      ' Met le premier niveau
        MainMenu.MenuItems.Add("&Options")      '
        MainMenu.MenuItems.Add("&?") ''''''''''''

        Dim miFile As MenuItem = MainMenu.MenuItems(0) ''''''''''''''
        Dim miEdit As MenuItem = MainMenu.MenuItems(1)              ' Déclaration du noeud de 1 er niveau
        Dim miOpt As MenuItem = MainMenu.MenuItems(2)               '
        Dim miInterrogation As MenuItem = MainMenu.MenuItems(3) '''''

        Dim handlerFile As EventHandler = New EventHandler(AddressOf MenuFichier_Click) '''''''''''''''''''''
        Dim handlerSubFile As EventHandler = New EventHandler(AddressOf MenuEnvoyerVers_Click)              ' Déclaration pour les évènements click
        Dim handlerEdit As EventHandler = New EventHandler(AddressOf MenuEdition_Click)                     '
        Dim handlerOption As EventHandler = New EventHandler(AddressOf MenuOptions_Click)                   '
        Dim handlerPoint As EventHandler = New EventHandler(AddressOf MenuPoint_d_interrogation_Click) ''''''

        ' Ajout des éléments au menu Fichier  
        miFile.MenuItems.Add(New DllMenu.MyMenu("C&hanger de session", Color.LightBlue, Color.Pink, New Icon("Icones\Session.ico"), _
        New Font("Comic Sans Ms", 9), handlerFile, Shortcut.CtrlO))

        miFile.MenuItems.Add(New DllMenu.MyMenu("&Enregistrer", Color.LightBlue, Color.Pink, New Icon("Icones\Enregistrer.ico"), _
        New Font("Comic Sans Ms", 9), handlerFile, Shortcut.CtrlS))

        miFile.MenuItems.Add(New MenuItem("-"))

        ' Ajout d'un sous menu de 2ème niveau à sauvegarder
        miFile.MenuItems.Add(New DllMenu.MyMenu("En&voyer vers", Color.LightBlue, Color.Pink, Nothing, _
        New Font("Comic Sans Ms", 9), handlerFile, Shortcut.None))
        miFile.MenuItems(3).MenuItems.Add(New DllMenu.MyMenu("&Destinataire", Color.LightBlue, Color.Pink, New Icon("Icones\Mail.ico"), _
        New Font("Comic Sans Ms", 9), handlerSubFile, Shortcut.CtrlM))

        ' Ajout des éléments au menu Fichiers  
        miFile.MenuItems.Add(New DllMenu.MyMenu("&Imprimer", Color.LightBlue, Color.Pink, New Icon("Icones\Imprimer.ico"), _
        New Font("Comic Sans Ms", 9), handlerFile, Shortcut.CtrlP))

        miFile.MenuItems.Add(New MenuItem("-"))

        miFile.MenuItems.Add(New DllMenu.MyMenu("&Quitter", Color.LightBlue, Color.Pink, New Icon("Icones\Quitter.ico"), _
        New Font("Comic Sans Ms", 9), handlerFile, Shortcut.AltF4))

        ' Ajout des eléments au menu Edition 
        miEdit.MenuItems.Add(New DllMenu.MyMenu("&Insérer", Color.LightBlue, Color.Pink, New Icon("Icones\Insérer.ico"), _
        New Font("Comic Sans Ms", 9), handlerEdit, Shortcut.F12))

        miEdit.MenuItems.Add(New DllMenu.MyMenu("&Effacer", Color.LightBlue, Color.Pink, New Icon("Icones\delete.ico"), _
        New Font("Comic Sans Ms", 9), handlerEdit, Shortcut.Del))

        ' Ajout des éléments au menu Option
        miOpt.MenuItems.Add(New DllMenu.MyMenu("&Options...", Color.LightBlue, Color.Pink, New Icon("Icones\Paramètre.ico"), _
        New Font("Comic Sans Ms", 9), handlerOption, Shortcut.ShiftF12))

        ' Ajout des eléments au menu Point d'interrogation 
        miInterrogation.MenuItems.Add(New DllMenu.MyMenu("&A propos de", Color.LightBlue, Color.Pink, New Icon("Icones\A propos de.ico"), _
        New Font("Comic Sans Ms", 9), handlerPoint, Shortcut.F12))

        With ListView1 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView2 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView3 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView4 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView5 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView6 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView7 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView8 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView9 '''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView10 '''''''''''''''''''''''''''''''''''''''''''''''''''''
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView11 ''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With ListView12 ''''''''''''''''''''''''''''''''''''''''''''''''''''' 
            .View = View.Details                                            '
            .CheckBoxes = False                                             '
            .GridLines = True                                               '
            .Columns.Add("Date", 100, HorizontalAlignment.Center)           ' Configure la ListView
            .Columns.Add("Entreprise", 305, HorizontalAlignment.Center)     '
            .Columns.Add("Heure(s)", 60, HorizontalAlignment.Center)        '
            .Columns.Add("Minute(s)", 67, HorizontalAlignment.Center)       '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Changement_De_Session()
    End Sub

    Private Sub MenuInsérer()
        Dim InsérerDialog As New Form_Insérer ' Déclare la nouvelle Form
        Retour = InsérerDialog.ShowDialog()
        If Retour = 1 Then
            Dim LVI As New ListViewItem
            If InsérerDialog.Calendrier_Date.Value.Month = 1 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView1.Items.Add(LVI) '''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti1.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti1.Text = 0                                                  '
                Label_MinutesConverti1.Text = Addition                                           '
                Label_TotalMinute1.Text = "00"                                                   ' 
                Label_TotalHeure1.Text = "000"                                                   '
                Label_TotalMinute1.Text = Label_MinutesConverti1.Text                            '
                While Label_TotalMinute1.Text > 59                                               '
                    Label_TotalHeure1.Text = Label_TotalHeure1.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute1.Text = Label_TotalMinute1.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 0 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 2 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView2.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti2.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti2.Text = 0                                                  '
                Label_MinutesConverti2.Text = Addition                                           '
                Label_TotalMinute2.Text = "00"                                                   ' 
                Label_TotalHeure2.Text = "000"                                                   '
                Label_TotalMinute2.Text = Label_MinutesConverti2.Text                            '
                While Label_TotalMinute2.Text > 59                                               '
                    Label_TotalHeure2.Text = Label_TotalHeure2.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute2.Text = Label_TotalMinute2.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 1 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 3 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView3.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti3.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti3.Text = 0                                                  '
                Label_MinutesConverti3.Text = Addition                                           '
                Label_TotalMinute3.Text = "00"                                                   ' 
                Label_TotalHeure3.Text = "000"                                                   '
                Label_TotalMinute3.Text = Label_MinutesConverti3.Text                            '
                While Label_TotalMinute3.Text > 59                                               '
                    Label_TotalHeure3.Text = Label_TotalHeure3.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute3.Text = Label_TotalMinute3.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 2 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 4 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView4.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti4.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti4.Text = 0                                                  '
                Label_MinutesConverti4.Text = Addition                                           '
                Label_TotalMinute4.Text = "00"                                                   ' 
                Label_TotalHeure4.Text = "000"                                                   '
                Label_TotalMinute4.Text = Label_MinutesConverti4.Text                            '
                While Label_TotalMinute4.Text > 59                                               '
                    Label_TotalHeure4.Text = Label_TotalHeure4.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute4.Text = Label_TotalMinute4.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 3 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 5 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView5.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti5.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti5.Text = 0                                                  '
                Label_MinutesConverti5.Text = Addition                                           '
                Label_TotalMinute5.Text = "00"                                                   ' 
                Label_TotalHeure5.Text = "000"                                                   '
                Label_TotalMinute5.Text = Label_MinutesConverti5.Text                            '
                While Label_TotalMinute5.Text > 59                                               '
                    Label_TotalHeure5.Text = Label_TotalHeure5.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute5.Text = Label_TotalMinute5.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 4 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 6 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView6.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti6.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti6.Text = 0                                                  '
                Label_MinutesConverti6.Text = Addition                                           '
                Label_TotalMinute6.Text = "00"                                                   ' 
                Label_TotalHeure6.Text = "000"                                                   '
                Label_TotalMinute6.Text = Label_MinutesConverti6.Text                            '
                While Label_TotalMinute6.Text > 59                                               '
                    Label_TotalHeure6.Text = Label_TotalHeure6.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute6.Text = Label_TotalMinute6.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 5 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 7 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView7.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti7.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti7.Text = 0                                                  '
                Label_MinutesConverti7.Text = Addition                                           '
                Label_TotalMinute7.Text = "00"                                                   ' 
                Label_TotalHeure7.Text = "000"                                                   '
                Label_TotalMinute7.Text = Label_MinutesConverti7.Text                            '
                While Label_TotalMinute7.Text > 59                                               '
                    Label_TotalHeure7.Text = Label_TotalHeure7.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute7.Text = Label_TotalMinute7.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 6 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 8 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView8.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti8.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti8.Text = 0                                                  '
                Label_MinutesConverti8.Text = Addition                                           '
                Label_TotalMinute8.Text = "00"                                                   ' 
                Label_TotalHeure8.Text = "000"                                                   '
                Label_TotalMinute8.Text = Label_MinutesConverti8.Text                            '
                While Label_TotalMinute8.Text > 59                                               '
                    Label_TotalHeure8.Text = Label_TotalHeure8.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute8.Text = Label_TotalMinute8.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 7 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 9 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView9.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti9.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti9.Text = 0                                                  '
                Label_MinutesConverti9.Text = Addition                                           '
                Label_TotalMinute9.Text = "00"                                                   ' 
                Label_TotalHeure9.Text = "000"                                                   '
                Label_TotalMinute9.Text = Label_MinutesConverti9.Text                            '
                While Label_TotalMinute9.Text > 59                                               '
                    Label_TotalHeure9.Text = Label_TotalHeure9.Text + 1                          ' Reconverti en H:MM
                    Label_TotalMinute9.Text = Label_TotalMinute9.Text - 60                       '
                End While ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 8 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 10 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView10.Items.Add(LVI) ''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti10.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti10.Text = 0                                                  '
                Label_MinutesConverti10.Text = Addition                                           '
                Label_TotalMinute10.Text = "00"                                                   ' 
                Label_TotalHeure10.Text = "000"                                                   '
                Label_TotalMinute10.Text = Label_MinutesConverti10.Text                           '
                While Label_TotalMinute10.Text > 59                                               '
                    Label_TotalHeure10.Text = Label_TotalHeure10.Text + 1                         ' Reconverti en H:MM
                    Label_TotalMinute10.Text = Label_TotalMinute10.Text - 60                      '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 9 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 11 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView11.Items.Add(LVI) '''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti11.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti11.Text = 0                                                  '
                Label_MinutesConverti11.Text = Addition                                           '
                Label_TotalMinute11.Text = "00"                                                   ' 
                Label_TotalHeure11.Text = "000"                                                   '
                Label_TotalMinute11.Text = Label_MinutesConverti11.Text                           '
                While Label_TotalMinute11.Text > 59                                               '
                    Label_TotalHeure11.Text = Label_TotalHeure11.Text + 1                         ' Reconverti en H:MM
                    Label_TotalMinute11.Text = Label_TotalMinute11.Text - 60                      '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 10 ' On sélectionne la TabPage approprié

            ElseIf InsérerDialog.Calendrier_Date.Value.Month = 12 Then
                LVI.Text = InsérerDialog.Label_Date.Text '''''''''''''''''''''''''''''''
                If InsérerDialog.TextBox_AutreEntreprise.Text = "" Then                '
                    LVI.SubItems.Add(InsérerDialog.ComboBox_Entreprise.Text)           '
                Else                                                                   ' Remplit la Listview
                    LVI.SubItems.Add(InsérerDialog.TextBox_AutreEntreprise.Text)       '
                End If                                                                 '
                LVI.SubItems.Add(InsérerDialog.TextBox_Heure.Text)                     '
                LVI.SubItems.Add(InsérerDialog.TextBox_Minute.Text)                    '
                ListView12.Items.Add(LVI) '''''''''''''''''''''''''''''''''''''''''''''''

                Addition = 0 ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Addition = Label_MinutesConverti12.Text + (InsérerDialog.TextBox_Minute.Text + (InsérerDialog.TextBox_Heure.Text * 60))
                Label_MinutesConverti12.Text = 0                                                  '
                Label_MinutesConverti12.Text = Addition                                           '
                Label_TotalMinute12.Text = "00"                                                   ' 
                Label_TotalHeure12.Text = "000"                                                   '
                Label_TotalMinute12.Text = Label_MinutesConverti12.Text                           '
                While Label_TotalMinute12.Text > 59                                               '
                    Label_TotalHeure12.Text = Label_TotalHeure12.Text + 1                         ' Reconverti en H:MM
                    Label_TotalMinute12.Text = Label_TotalMinute12.Text - 60                      '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TabControl.SelectedIndex = 11 ' On sélectionne la TabPage approprié
            End If

            Coloration_Toutes_ListView()

            ' Déverrouillage des touches
            MainMenu.MenuItems(0).MenuItems(1).Visible = True ''' Bouton Enregistrer
            MainMenu.MenuItems(0).MenuItems(1).Enabled = True '''
            MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
            MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
            MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
            MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
            MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
            MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
            TBEnregistrer.Enabled = True ''''''''
            TBImprimer.Enabled = True           ' ToolBar
            TBDelete.Enabled = True             '
            TBMail.Enabled = True '''''''''''''''
        End If
    End Sub

    Private Sub MenuEffacer()
        Try
            If TabControl.SelectedIndex = 0 Then
                Dim Nb_Index As Integer = ListView1.SelectedItems.Item(0).Index
                Label_TotalHeure1.Text = "000" ' Met tout à zéro
                Label_TotalMinute1.Text = "00" '
                ' Calcul
                Label_MinutesConverti1.Text = Label_MinutesConverti1.Text - (ListView1.Items(Nb_Index).SubItems(2).Text * 60 + ListView1.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute1.Text = Label_MinutesConverti1.Text '''''''''
                While Label_TotalMinute1.Text > 59                            '
                    Label_TotalHeure1.Text = Label_TotalHeure1.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute1.Text = Label_TotalMinute1.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView1.Items.Remove(ListView1.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView1.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 1 Then
                Dim Nb_Index As Integer = ListView2.SelectedItems.Item(0).Index
                Label_TotalHeure2.Text = "000" ' Met tout à zéro
                Label_TotalMinute2.Text = "00" '
                ' Calcul
                Label_MinutesConverti2.Text = Label_MinutesConverti2.Text - (ListView2.Items(Nb_Index).SubItems(2).Text * 60 + ListView2.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute2.Text = Label_MinutesConverti2.Text '''''''''
                While Label_TotalMinute2.Text > 59                            '
                    Label_TotalHeure2.Text = Label_TotalHeure2.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute2.Text = Label_TotalMinute2.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView2.Items.Remove(ListView2.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView2.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 2 Then
                Dim Nb_Index As Integer = ListView3.SelectedItems.Item(0).Index
                Label_TotalHeure3.Text = "000" ' Met tout à zéro
                Label_TotalMinute3.Text = "00" '
                ' Calcul
                Label_MinutesConverti3.Text = Label_MinutesConverti3.Text - (ListView3.Items(Nb_Index).SubItems(2).Text * 60 + ListView3.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute3.Text = Label_MinutesConverti3.Text '''''''''
                While Label_TotalMinute3.Text > 59                            '
                    Label_TotalHeure3.Text = Label_TotalHeure3.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute3.Text = Label_TotalMinute3.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView3.Items.Remove(ListView3.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView3.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 3 Then
                Dim Nb_Index As Integer = ListView4.SelectedItems.Item(0).Index
                Label_TotalHeure4.Text = "000" ' Met tout à zéro
                Label_TotalMinute4.Text = "00" '
                ' Calcul
                Label_MinutesConverti4.Text = Label_MinutesConverti4.Text - (ListView4.Items(Nb_Index).SubItems(2).Text * 60 + ListView4.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute4.Text = Label_MinutesConverti4.Text '''''''''
                While Label_TotalMinute4.Text > 59                            '
                    Label_TotalHeure4.Text = Label_TotalHeure4.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute4.Text = Label_TotalMinute4.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView4.Items.Remove(ListView4.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView4.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 4 Then
                Dim Nb_Index As Integer = ListView5.SelectedItems.Item(0).Index
                Label_TotalHeure5.Text = "000" ' Met tout à zéro
                Label_TotalMinute5.Text = "00" '
                ' Calcul
                Label_MinutesConverti5.Text = Label_MinutesConverti5.Text - (ListView5.Items(Nb_Index).SubItems(2).Text * 60 + ListView5.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute5.Text = Label_MinutesConverti5.Text '''''''''
                While Label_TotalMinute5.Text > 59                            '
                    Label_TotalHeure5.Text = Label_TotalHeure5.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute5.Text = Label_TotalMinute5.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView5.Items.Remove(ListView5.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView5.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 5 Then
                Dim Nb_Index As Integer = ListView6.SelectedItems.Item(0).Index
                Label_TotalHeure6.Text = "000" ' Met tout à zéro
                Label_TotalMinute6.Text = "00" '
                ' Calcul
                Label_MinutesConverti6.Text = Label_MinutesConverti6.Text - (ListView6.Items(Nb_Index).SubItems(2).Text * 60 + ListView6.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute6.Text = Label_MinutesConverti6.Text '''''''''
                While Label_TotalMinute6.Text > 59                            '
                    Label_TotalHeure6.Text = Label_TotalHeure6.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute6.Text = Label_TotalMinute6.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView6.Items.Remove(ListView6.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView6.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 6 Then
                Dim Nb_Index As Integer = ListView7.SelectedItems.Item(0).Index
                Label_TotalHeure7.Text = "000" ' Met tout à zéro
                Label_TotalMinute7.Text = "00" '
                ' Calcul
                Label_MinutesConverti7.Text = Label_MinutesConverti7.Text - (ListView7.Items(Nb_Index).SubItems(2).Text * 60 + ListView7.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute7.Text = Label_MinutesConverti7.Text '''''''''
                While Label_TotalMinute7.Text > 59                            '
                    Label_TotalHeure7.Text = Label_TotalHeure7.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute7.Text = Label_TotalMinute7.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView7.Items.Remove(ListView7.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView7.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 7 Then
                Dim Nb_Index As Integer = ListView8.SelectedItems.Item(0).Index
                Label_TotalHeure8.Text = "000" ' Met tout à zéro
                Label_TotalMinute8.Text = "00" '
                ' Calcul
                Label_MinutesConverti8.Text = Label_MinutesConverti8.Text - (ListView8.Items(Nb_Index).SubItems(2).Text * 60 + ListView8.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute8.Text = Label_MinutesConverti8.Text '''''''''
                While Label_TotalMinute8.Text > 59                            '
                    Label_TotalHeure8.Text = Label_TotalHeure8.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute8.Text = Label_TotalMinute8.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView8.Items.Remove(ListView8.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView8.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 8 Then
                Dim Nb_Index As Integer = ListView9.SelectedItems.Item(0).Index
                Label_TotalHeure9.Text = "000" ' Met tout à zéro
                Label_TotalMinute9.Text = "00" '
                ' Calcul
                Label_MinutesConverti9.Text = Label_MinutesConverti9.Text - (ListView9.Items(Nb_Index).SubItems(2).Text * 60 + ListView9.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute9.Text = Label_MinutesConverti9.Text '''''''''
                While Label_TotalMinute9.Text > 59                            '
                    Label_TotalHeure9.Text = Label_TotalHeure9.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute9.Text = Label_TotalMinute9.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView9.Items.Remove(ListView9.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView9.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 9 Then
                Dim Nb_Index As Integer = ListView10.SelectedItems.Item(0).Index
                Label_TotalHeure10.Text = "000" ' Met tout à zéro
                Label_TotalMinute10.Text = "00" '
                ' Calcul
                Label_MinutesConverti10.Text = Label_MinutesConverti10.Text - (ListView10.Items(Nb_Index).SubItems(2).Text * 60 + ListView10.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute10.Text = Label_MinutesConverti10.Text '''''''''
                While Label_TotalMinute10.Text > 59                            '
                    Label_TotalHeure10.Text = Label_TotalHeure10.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute10.Text = Label_TotalMinute10.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView10.Items.Remove(ListView10.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView10.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 10 Then
                Dim Nb_Index As Integer = ListView11.SelectedItems.Item(0).Index
                Label_TotalHeure11.Text = "000" ' Met tout à zéro
                Label_TotalMinute11.Text = "00" '
                ' Calcul
                Label_MinutesConverti11.Text = Label_MinutesConverti11.Text - (ListView11.Items(Nb_Index).SubItems(2).Text * 60 + ListView11.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute11.Text = Label_MinutesConverti11.Text '''''''''
                While Label_TotalMinute11.Text > 59                             '
                    Label_TotalHeure11.Text = Label_TotalHeure11.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute11.Text = Label_TotalMinute11.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView11.Items.Remove(ListView11.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView11.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 11 Then
                Dim Nb_Index As Integer = ListView12.SelectedItems.Item(0).Index
                Label_TotalHeure12.Text = "000" ' Met tout à zéro
                Label_TotalMinute12.Text = "00" '
                ' Calcul
                Label_MinutesConverti12.Text = Label_MinutesConverti12.Text - (ListView12.Items(Nb_Index).SubItems(2).Text * 60 + ListView12.Items(Nb_Index).SubItems(3).Text)
                Label_TotalMinute12.Text = Label_MinutesConverti12.Text '''''''''
                While Label_TotalMinute12.Text > 59                             '
                    Label_TotalHeure12.Text = Label_TotalHeure12.Text + 1       ' Reconverti en H:MM
                    Label_TotalMinute12.Text = Label_TotalMinute12.Text - 60    '
                End While '''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ListView12.Items.Remove(ListView12.Items(Nb_Index)) ' Efface l'élement sélectionné
                If ListView12.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            End If
            MainMenu.MenuItems(0).MenuItems(1).Visible = True ''' 
            MainMenu.MenuItems(0).MenuItems(1).Enabled = True   ' Bouton Enregistrer
            TBEnregistrer.Enabled = True ''''''''''''''''''''''''

            Coloration_Toutes_ListView()

        Catch ex As Exception 'En cas d'erreur
            MessageBox.Show("Il faut sélectionné un élement", "Pas de séléction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Confirmation_Avant_Ouverture()
        If TBEnregistrer.Enabled = False Then
            Changement_De_Session()
        Else
            Select Case MessageBox.Show("Voulez vous enregistrer les modifications?", "Confirmation avant ouverture", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    MenuEnregistrer()
                    Changement_De_Session()
                Case DialogResult.No
                    Changement_De_Session()
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub Efface_Tout()
        ListView1.Items.Clear() '''''''''''''''''''''
        ListView2.Items.Clear()                     '
        ListView3.Items.Clear()                     '   
        ListView4.Items.Clear()                     '
        ListView5.Items.Clear()                     '
        ListView6.Items.Clear()                     ' Vide toutes les Listview
        ListView7.Items.Clear()                     '
        ListView8.Items.Clear()                     '
        ListView9.Items.Clear()                     '
        ListView10.Items.Clear()                    '
        ListView11.Items.Clear()                    '
        ListView12.Items.Clear() ''''''''''''''''''''

        Label_MinutesConverti1.Text = "0" ''''
        Label_TotalHeure1.Text = "0"         '
        Label_TotalMinute1.Text = "0"        '
        Label_MinutesConverti2.Text = "0"    '
        Label_TotalHeure2.Text = "0"         '
        Label_TotalMinute2.Text = "0"        '
        Label_MinutesConverti3.Text = "0"    '
        Label_TotalHeure3.Text = "0"         '
        Label_TotalMinute3.Text = "0"        '
        Label_MinutesConverti4.Text = "0"    '
        Label_TotalHeure4.Text = "0"         '
        Label_TotalMinute4.Text = "0"        '
        Label_MinutesConverti5.Text = "0"    '
        Label_TotalHeure5.Text = "0"         '
        Label_TotalMinute5.Text = "0"        '
        Label_MinutesConverti6.Text = "0"    '
        Label_TotalHeure6.Text = "0"         '
        Label_TotalMinute6.Text = "0"        ' & les labels
        Label_MinutesConverti7.Text = "0"    '
        Label_TotalHeure7.Text = "0"         '
        Label_TotalMinute7.Text = "0"        '
        Label_MinutesConverti8.Text = "0"    '
        Label_TotalHeure8.Text = "0"         '
        Label_TotalMinute8.Text = "0"        '
        Label_MinutesConverti9.Text = "0"    '
        Label_TotalHeure9.Text = "0"         '
        Label_TotalMinute9.Text = "0"        '
        Label_MinutesConverti10.Text = "0"   '
        Label_TotalHeure10.Text = "0"        '
        Label_TotalMinute10.Text = "0"       '
        Label_MinutesConverti11.Text = "0"   '
        Label_TotalHeure11.Text = "0"        '
        Label_TotalMinute11.Text = "0"       '
        Label_MinutesConverti12.Text = "0"   '
        Label_TotalHeure12.Text = "0"        '
        Label_TotalMinute12.Text = "0" '''''''
    End Sub

    Private Sub Ouvrir()
        Efface_Tout()
        ' Ouvre la structure
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Horaire.hor1", OpenMode.Binary)
        FileGet(1, ObjTotal)
        FileClose(1) ' Et la referme

        Label_MinutesConverti1.Text = ObjTotal.StructureConversionMinute_Janvier ''''''''
        Label_TotalHeure1.Text = ObjTotal.StructureHeure_Janvier                        '   
        Label_TotalMinute1.Text = ObjTotal.StructureMinute_Janvier                      '
        Label_MinutesConverti1.Text = ObjTotal.StructureConversionMinute_Janvier        '
        Label_TotalHeure1.Text = ObjTotal.StructureHeure_Janvier                        '
        Label_TotalMinute1.Text = ObjTotal.StructureMinute_Janvier                      '
        Label_MinutesConverti2.Text = ObjTotal.StructureConversionMinute_Février        '
        Label_TotalHeure2.Text = ObjTotal.StructureHeure_Février                        '
        Label_TotalMinute2.Text = ObjTotal.StructureMinute_Février                      '
        Label_MinutesConverti3.Text = ObjTotal.StructureConversionMinute_Mars           '
        Label_TotalHeure3.Text = ObjTotal.StructureHeure_Mars                           '
        Label_TotalMinute3.Text = ObjTotal.StructureMinute_Mars                         '
        Label_MinutesConverti4.Text = ObjTotal.StructureConversionMinute_Avril          '
        Label_TotalHeure4.Text = ObjTotal.StructureHeure_Avril                          '
        Label_TotalMinute4.Text = ObjTotal.StructureMinute_Avril                        '
        Label_MinutesConverti5.Text = ObjTotal.StructureConversionMinute_Mai            '
        Label_TotalHeure5.Text = ObjTotal.StructureHeure_Mai                            ' Met à jour tous les labels
        Label_TotalMinute5.Text = ObjTotal.StructureMinute_Mai                          '
        Label_MinutesConverti6.Text = ObjTotal.StructureConversionMinute_Juin           '
        Label_TotalHeure6.Text = ObjTotal.StructureHeure_Juin                           '
        Label_TotalMinute6.Text = ObjTotal.StructureMinute_Juin                         '
        Label_MinutesConverti7.Text = ObjTotal.StructureConversionMinute_Juillet        '
        Label_TotalHeure7.Text = ObjTotal.StructureHeure_Juillet                        '
        Label_TotalMinute7.Text = ObjTotal.StructureMinute_Juillet                      '
        Label_MinutesConverti8.Text = ObjTotal.StructureConversionMinute_Août           '
        Label_TotalHeure8.Text = ObjTotal.StructureHeure_Août                           '
        Label_TotalMinute8.Text = ObjTotal.StructureMinute_Août                         '
        Label_MinutesConverti9.Text = ObjTotal.StructureConversionMinute_Septembre      '
        Label_TotalHeure9.Text = ObjTotal.StructureHeure_Septembre                      '
        Label_TotalMinute9.Text = ObjTotal.StructureMinute_Septembre                    '
        Label_MinutesConverti10.Text = ObjTotal.StructureConversionMinute_Octobre       '
        Label_TotalHeure10.Text = ObjTotal.StructureHeure_Octobre                       '
        Label_TotalMinute10.Text = ObjTotal.StructureMinute_Octobre                     '
        Label_MinutesConverti11.Text = ObjTotal.StructureConversionMinute_Novembre      '
        Label_TotalHeure11.Text = ObjTotal.StructureHeure_Novembre                      '
        Label_TotalMinute11.Text = ObjTotal.StructureMinute_Novembre                    '
        Label_MinutesConverti12.Text = ObjTotal.StructureConversionMinute_Décembre      '
        Label_TotalHeure12.Text = ObjTotal.StructureHeure_Décembre                      '
        Label_TotalMinute12.Text = ObjTotal.StructureMinute_Décembre ''''''''''''''''''''

        ' Une fois ke les labels sont à jour on s'occupe des ListView
        ' split
        ' Janvier
        Dim Fs_Janvier As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Janvier.hor1", FileMode.Open)
        Dim Str_Janvier As New IO.StreamReader(Fs_Janvier)
        Dim LVI_Janvier As ListViewItem
        Do Until Str_Janvier.Peek = -1
            Val = Str_Janvier.ReadLine.Split("|")
            LVI_Janvier = ListView1.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Janvier.SubItems.Add(Val(i))
            Next
        Loop
        Str_Janvier.Close()
        Fs_Janvier.Close()

        ' Février
        Dim Fs_Février As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Février.hor1", FileMode.Open)
        Dim Str_Février As New IO.StreamReader(Fs_Février)
        Dim LVI_Février As ListViewItem
        Do Until Str_Février.Peek = -1
            Val = Str_Février.ReadLine.Split("|")
            LVI_Février = ListView2.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Février.SubItems.Add(Val(i))
            Next
        Loop
        Str_Février.Close()
        Fs_Février.Close()

        ' Mars
        Dim Fs_Mars As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Mars.hor1", FileMode.Open)
        Dim Str_Mars As New IO.StreamReader(Fs_Mars)
        Dim LVI_Mars As ListViewItem
        Do Until Str_Mars.Peek = -1
            Val = Str_Mars.ReadLine.Split("|")
            LVI_Mars = ListView3.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Mars.SubItems.Add(Val(i))
            Next
        Loop
        Str_Mars.Close()
        Fs_Mars.Close()

        ' Avril
        Dim Fs_Avril As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Avril.hor1", FileMode.Open)
        Dim Str_Avril As New IO.StreamReader(Fs_Avril)
        Dim LVI_Avril As ListViewItem
        Do Until Str_Avril.Peek = -1
            Val = Str_Avril.ReadLine.Split("|")
            LVI_Avril = ListView4.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Avril.SubItems.Add(Val(i))
            Next
        Loop
        Str_Avril.Close()
        Fs_Avril.Close()

        ' Mai
        Dim Fs_Mai As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Mai.hor1", FileMode.Open)
        Dim Str_Mai As New IO.StreamReader(Fs_Mai)
        Dim LVI_Mai As ListViewItem
        Do Until Str_Mai.Peek = -1
            Val = Str_Mai.ReadLine.Split("|")
            LVI_Mai = ListView5.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Mai.SubItems.Add(Val(i))
            Next
        Loop
        Str_Mai.Close()
        Fs_Mai.Close()

        ' Juin
        Dim Fs_Juin As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Juin.hor1", FileMode.Open)
        Dim Str_Juin As New IO.StreamReader(Fs_Juin)
        Dim LVI_Juin As ListViewItem
        Do Until Str_Juin.Peek = -1
            Val = Str_Juin.ReadLine.Split("|")
            LVI_Juin = ListView6.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Juin.SubItems.Add(Val(i))
            Next
        Loop
        Str_Juin.Close()
        Fs_Juin.Close()

        ' Juillet
        Dim Fs_Juillet As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Juillet.hor1", FileMode.Open)
        Dim Str_Juillet As New IO.StreamReader(Fs_Juillet)
        Dim LVI_Juillet As ListViewItem
        Do Until Str_Juillet.Peek = -1
            Val = Str_Juillet.ReadLine.Split("|")
            LVI_Juillet = ListView7.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Juillet.SubItems.Add(Val(i))
            Next
        Loop
        Str_Juillet.Close()
        Fs_Juillet.Close()

        ' Août
        Dim Fs_Août As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Août.hor1", FileMode.Open)
        Dim Str_Août As New IO.StreamReader(Fs_Août)
        Dim LVI_Août As ListViewItem
        Do Until Str_Août.Peek = -1
            Val = Str_Août.ReadLine.Split("|")
            LVI_Août = ListView8.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Août.SubItems.Add(Val(i))
            Next
        Loop
        Str_Août.Close()
        Fs_Août.Close()

        ' Septembre
        Dim Fs_Septembre As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Septembre.hor1", FileMode.Open)
        Dim Str_Septembre As New IO.StreamReader(Fs_Septembre)
        Dim LVI_Septembre As ListViewItem
        Do Until Str_Septembre.Peek = -1
            Val = Str_Septembre.ReadLine.Split("|")
            LVI_Septembre = ListView9.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Septembre.SubItems.Add(Val(i))
            Next
        Loop
        Str_Septembre.Close()
        Fs_Septembre.Close()

        ' Octobre
        Dim Fs_Octobre As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Octobre.hor1", FileMode.Open)
        Dim Str_Octobre As New IO.StreamReader(Fs_Octobre)
        Dim LVI_Octobre As ListViewItem
        Do Until Str_Octobre.Peek = -1
            Val = Str_Octobre.ReadLine.Split("|")
            LVI_Octobre = ListView10.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Octobre.SubItems.Add(Val(i))
            Next
        Loop
        Str_Octobre.Close()
        Fs_Octobre.Close()

        ' Novembre
        Dim Fs_Novembre As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Novembre.hor1", FileMode.Open)
        Dim Str_Novembre As New IO.StreamReader(Fs_Novembre)
        Dim LVI_Novembre As ListViewItem
        Do Until Str_Novembre.Peek = -1
            Val = Str_Novembre.ReadLine.Split("|")
            LVI_Novembre = ListView11.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Novembre.SubItems.Add(Val(i))
            Next
        Loop
        Str_Novembre.Close()
        Fs_Novembre.Close()

        ' Décembre
        Dim Fs_Décembre As New IO.FileStream(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Décembre.hor1", FileMode.Open)
        Dim Str_Décembre As New IO.StreamReader(Fs_Décembre)
        Dim LVI_Décembre As ListViewItem
        Do Until Str_Décembre.Peek = -1
            Val = Str_Décembre.ReadLine.Split("|")
            LVI_Décembre = ListView12.Items.Add(Val(0))
            For i = 1 To Val.Length - 1
                LVI_Décembre.SubItems.Add(Val(i))
            Next
        Loop
        Str_Décembre.Close()
        Fs_Décembre.Close()

        ' Met à jour la barre de status et des titres
        StatusBar.Panels(0).Text = "Ce document à été ouvert à " & Date.Now.ToString("HH:mm:ss")
        Me.Text = "Horaire de travail v1.1fr - " & StatusBar.Panels(1).Text

        Coloration_Toutes_ListView()
    End Sub

    Private Sub MenuEnregistrer()
        With ObjTotal '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            .StructureHeure_Janvier = Label_TotalHeure1.Text                    '
            .StructureMinute_Janvier = Label_TotalMinute1.Text                  '
            .StructureConversionMinute_Janvier = Label_MinutesConverti1.Text    '
            .StructureHeure_Février = Label_TotalHeure2.Text                    '
            .StructureMinute_Février = Label_TotalMinute2.Text                  '
            .StructureConversionMinute_Février = Label_MinutesConverti2.Text    '
            .StructureHeure_Mars = Label_TotalHeure3.Text                       '
            .StructureMinute_Mars = Label_TotalMinute3.Text                     '
            .StructureConversionMinute_Mars = Label_MinutesConverti3.Text       '
            .StructureHeure_Avril = Label_TotalHeure4.Text                      '
            .StructureMinute_Avril = Label_TotalMinute4.Text                    '
            .StructureConversionMinute_Avril = Label_MinutesConverti4.Text      '
            .StructureHeure_Mai = Label_TotalHeure5.Text                        '
            .StructureMinute_Mai = Label_TotalMinute5.Text                      '
            .StructureConversionMinute_Mai = Label_MinutesConverti5.Text        '
            .StructureHeure_Juin = Label_TotalHeure6.Text                       '
            .StructureMinute_Juin = Label_TotalMinute6.Text                     ' Enregistre tou les labels ds la structure
            .StructureConversionMinute_Juin = Label_MinutesConverti6.Text       '
            .StructureHeure_Juillet = Label_TotalHeure7.Text                    '
            .StructureMinute_Juillet = Label_TotalMinute7.Text                  '
            .StructureConversionMinute_Juillet = Label_MinutesConverti7.Text    '
            .StructureHeure_Août = Label_TotalHeure8.Text                       '
            .StructureMinute_Août = Label_TotalMinute8.Text                     '
            .StructureConversionMinute_Août = Label_MinutesConverti8.Text       '
            .StructureHeure_Septembre = Label_TotalHeure9.Text                  '
            .StructureMinute_Septembre = Label_TotalMinute9.Text                '
            .StructureConversionMinute_Septembre = Label_MinutesConverti9.Text  '
            .StructureHeure_Octobre = Label_TotalHeure10.Text                   '
            .StructureMinute_Octobre = Label_TotalMinute10.Text                 '
            .StructureConversionMinute_Octobre = Label_MinutesConverti10.Text   '
            .StructureHeure_Novembre = Label_TotalHeure11.Text                  '
            .StructureMinute_Novembre = Label_TotalMinute11.Text                '
            .StructureConversionMinute_Novembre = Label_MinutesConverti11.Text  '
            .StructureHeure_Décembre = Label_TotalHeure12.Text                  '
            .StructureMinute_Décembre = Label_TotalMinute12.Text                '
            .StructureConversionMinute_Décembre = Label_MinutesConverti12.Text  '
        End With ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Horaire.hor1", OpenMode.Binary) ' Ouvre le fichier à sauvegarder
        FilePut(1, ObjTotal) ' Sauvegarde
        FileClose(1) ' Referme

        ' Une fois ke les labels sont à jour on s'occupe des ListView
        ' Sauvegarde les Listview ds les variable "Save_Listview"
        Save_Listview1 = "" ' On réinitialise la variable
        For i = 0 To ListView1.Items.Count - 1
            Save_Listview1 = Save_Listview1 & ListView1.Items(i).SubItems(0).Text & "|" & ListView1.Items(i).SubItems(1).Text & "|" & ListView1.Items(i).SubItems(2).Text & "|" & ListView1.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview2 = "" ' On réinitialise la variable
        For i = 0 To ListView2.Items.Count - 1
            Save_Listview2 = Save_Listview2 & ListView2.Items(i).SubItems(0).Text & "|" & ListView2.Items(i).SubItems(1).Text & "|" & ListView2.Items(i).SubItems(2).Text & "|" & ListView2.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview3 = "" ' On réinitialise la variable
        For i = 0 To ListView3.Items.Count - 1
            Save_Listview3 = Save_Listview3 & ListView3.Items(i).SubItems(0).Text & "|" & ListView3.Items(i).SubItems(1).Text & "|" & ListView3.Items(i).SubItems(2).Text & "|" & ListView3.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview4 = "" ' On réinitialise la variable
        For i = 0 To ListView4.Items.Count - 1
            Save_Listview4 = Save_Listview4 & ListView4.Items(i).SubItems(0).Text & "|" & ListView4.Items(i).SubItems(1).Text & "|" & ListView4.Items(i).SubItems(2).Text & "|" & ListView4.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview5 = "" ' On réinitialise la variable
        For i = 0 To ListView5.Items.Count - 1
            Save_Listview5 = Save_Listview5 & ListView5.Items(i).SubItems(0).Text & "|" & ListView5.Items(i).SubItems(1).Text & "|" & ListView5.Items(i).SubItems(2).Text & "|" & ListView5.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview6 = "" ' On réinitialise la variable
        For i = 0 To ListView6.Items.Count - 1
            Save_Listview6 = Save_Listview6 & ListView6.Items(i).SubItems(0).Text & "|" & ListView6.Items(i).SubItems(1).Text & "|" & ListView6.Items(i).SubItems(2).Text & "|" & ListView6.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview7 = "" ' On réinitialise la variable
        For i = 0 To ListView7.Items.Count - 1
            Save_Listview7 = Save_Listview7 & ListView7.Items(i).SubItems(0).Text & "|" & ListView7.Items(i).SubItems(1).Text & "|" & ListView7.Items(i).SubItems(2).Text & "|" & ListView7.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview8 = "" ' On réinitialise la variable
        For i = 0 To ListView8.Items.Count - 1
            Save_Listview8 = Save_Listview8 & ListView8.Items(i).SubItems(0).Text & "|" & ListView8.Items(i).SubItems(1).Text & "|" & ListView8.Items(i).SubItems(2).Text & "|" & ListView8.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview9 = "" ' On réinitialise la variable
        For i = 0 To ListView9.Items.Count - 1
            Save_Listview9 = Save_Listview9 & ListView9.Items(i).SubItems(0).Text & "|" & ListView9.Items(i).SubItems(1).Text & "|" & ListView9.Items(i).SubItems(2).Text & "|" & ListView9.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview10 = "" ' On réinitialise la variable
        For i = 0 To ListView10.Items.Count - 1
            Save_Listview10 = Save_Listview10 & ListView10.Items(i).SubItems(0).Text & "|" & ListView10.Items(i).SubItems(1).Text & "|" & ListView10.Items(i).SubItems(2).Text & "|" & ListView10.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview11 = "" ' On réinitialise la variable
        For i = 0 To ListView11.Items.Count - 1
            Save_Listview11 = Save_Listview11 & ListView11.Items(i).SubItems(0).Text & "|" & ListView11.Items(i).SubItems(1).Text & "|" & ListView11.Items(i).SubItems(2).Text & "|" & ListView11.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i
        Save_Listview12 = "" ' On réinitialise la variable
        For i = 0 To ListView12.Items.Count - 1
            Save_Listview12 = Save_Listview12 & ListView12.Items(i).SubItems(0).Text & "|" & ListView12.Items(i).SubItems(1).Text & "|" & ListView12.Items(i).SubItems(2).Text & "|" & ListView12.Items(i).SubItems(3).Text & "|" & vbCrLf
        Next i

        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Janvier.hor1") ''''''''
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Février.hor1")        '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Mars.hor1")           '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Avril.hor1")          '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Mai.hor1")            '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Juin.hor1")           '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Juillet.hor1")        ' Efface les fichiers
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Août.hor1")           '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Septembre.hor1")      '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Octobre.hor1")        '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Novembre.hor1")       '
        File.Delete(Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Décembre.hor1") '''''''

        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Janvier.hor1", OpenMode.Binary) '''''''
        FilePut(1, Save_Listview1)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Février.hor1", OpenMode.Binary)       '
        FilePut(1, Save_Listview2)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Mars.hor1", OpenMode.Binary)          '
        FilePut(1, Save_Listview3)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Avril.hor1", OpenMode.Binary)         '
        FilePut(1, Save_Listview4)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Mai.hor1", OpenMode.Binary)           '
        FilePut(1, Save_Listview5)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Juin.hor1", OpenMode.Binary)          ' Sauvegarde ds le fichier
        FilePut(1, Save_Listview6)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Juillet.hor1", OpenMode.Binary)       '
        FilePut(1, Save_Listview7)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Août.hor1", OpenMode.Binary)          '
        FilePut(1, Save_Listview8)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Septembre.hor1", OpenMode.Binary)     '
        FilePut(1, Save_Listview9)                                                                                          '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Octobre.hor1", OpenMode.Binary)       '
        FilePut(1, Save_Listview10)                                                                                         '
        FileClose(1)                                                                                                        '
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Novembre.hor1", OpenMode.Binary)      '
        FilePut(1, Save_Listview11)                                                                                         '
        FileClose(1)                                                                                                        '      
        FileOpen(1, Application.StartupPath & "\Save\" & StatusBar.Panels(1).Text & "\Décembre.hor1", OpenMode.Binary)      '
        FilePut(1, Save_Listview12)                                                                                         '
        FileClose(1) ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Met à jour la barre de status
        StatusBar.Panels(0).Text = "Le fichier de " & StatusBar.Panels(1).Text & " et à été sauvegarder à " + Date.Now.ToString("HH:mm:ss")

        'Met à jour la barre des titres
        Me.Text = "Horaire de travail v1.1fr - " & StatusBar.Panels(1).Text

        TBEnregistrer.Enabled = False
        MainMenu.MenuItems(0).MenuItems(1).Visible = False ''' Bouton Enregistrer
        MainMenu.MenuItems(0).MenuItems(1).Enabled = False '''
    End Sub

    Private Sub MenuImprimer()
        MessageBox.Show("ce bouton ne marche pô encore", "Horaire de travail v1.1fr", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        'Affiche la date et l'heure dans la barre de status
        StatusBar.Panels(2).Text = Date.Now.ToString("HH:mm:ss") ' Heure
        StatusBar.Panels(3).Text = Date.Now.ToString("dddd dd MMMM yyyy") ' Date
    End Sub

    Private Sub MenuOuvrir()
        If TBEnregistrer.Enabled = True Then
            Select Case MessageBox.Show("Veux tu sauvegarder ce document ?", "Sauvegarde", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    MenuEnregistrer()
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        Changement_De_Session()
    End Sub

    Private Sub Envoyer_Vers()
        Dim Form_EnvoyerVers As New Form_Envoyer(Me)
        Form_EnvoyerVers.Show()
    End Sub

    Private Sub MenuFichier_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, MenuItem).Index
            Case 0
                Confirmation_Avant_Ouverture()
            Case 1
                MenuEnregistrer() ' Enregistrer
            Case 2
                ' Séparateur1
            Case 3
                ' Envoyer vers
            Case 4
                MenuImprimer() ' Imprimer
            Case 5
                ' Séparateur3
            Case 6
                Me.Close() ' Quitter
        End Select
    End Sub

    Private Sub MenuEdition_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, MenuItem).Index
            Case 0
                MenuInsérer() ' Insérer
            Case 1
                MenuEffacer() ' Effacer
        End Select
    End Sub

    Private Sub MenuOptions_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, MenuItem).Index
            Case 0
                MessageBox.Show("ce bouton ne marche pô encore", "Horaire de travail v1.1fr", MessageBoxButtons.OK, MessageBoxIcon.None)
        End Select
    End Sub

    Private Sub MenuPoint_d_interrogation_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, MenuItem).Index
            Case 0
                Dim A_propos_deDialog As New Form_Aproposde
                A_propos_deDialog.ShowDialog()
        End Select
    End Sub

    Private Sub MenuEnvoyerVers_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, MenuItem).Index
            Case 0
                Envoyer_Vers()
        End Select
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case e.Button.Tag ''''''''''''''''
            Case "TBSession"                    '
                Confirmation_Avant_Ouverture()  '
            Case "TBEnregistrer"                '
                MenuEnregistrer() ' Enregistrer
            Case "TBImprimer"                   ' Barre d'icone
                MenuImprimer() ' Imprimer
            Case "TBInsérer"                    '
                MenuInsérer() ' Insérer
            Case "TBDelete"                     '
                MenuEffacer() ' Effacer
            Case "TBMail"                       '
                Envoyer_Vers()
            Case "TBInfo"                       '
                Dim A_propos_deDialog As New Form_Aproposde
                A_propos_deDialog.ShowDialog()
        End Select ''''''''''''''''''''''''''''''
    End Sub

    Private Sub Form_Index_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If TBEnregistrer.Enabled = True Then
            Select Case MessageBox.Show("Voulez vous enregistrer les modifications?", "Confirmation avant fermeture", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    MenuEnregistrer()
                Case DialogResult.Cancel ''''''''''''''''
                    Dim Cancel As Short = e.Cancel      ' Empêche la fermeture du document
                    Cancel = True                       '
                    e.Cancel = Cancel '''''''''''''''''''
            End Select
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        Try
            If TabControl.SelectedIndex = 0 Then ' Si le 1er élement de la TabControl est sélectionné
                If ListView1.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 1 Then ' Si le 2ème élement de la TabControl est sélectionné
                If ListView2.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 2 Then ' Si le 3ème élement de la TabControl est sélectionné
                If ListView3.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 3 Then ' Si le 4ème élement de la TabControl est sélectionné
                If ListView4.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 4 Then ' Si le 5ème élement de la TabControl est sélectionné
                If ListView5.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 5 Then ' Si le 6ème élement de la TabControl est sélectionné
                If ListView6.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 6 Then ' Si le 7ème élement de la TabControl est sélectionné
                If ListView7.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 7 Then ' Si le 8ème élement de la TabControl est sélectionné
                If ListView8.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 8 Then ' Si le 9ème élement de la TabControl est sélectionné
                If ListView9.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 9 Then ' Si le 10ème élement de la TabControl est sélectionné
                If ListView10.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 10 Then ' Si le 11ème élement de la TabControl est sélectionné
                If ListView11.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            ElseIf TabControl.SelectedIndex = 11 Then ' Si le 12ème élement de la TabControl est sélectionné
                If ListView12.Items.Count > 0 Then
                    MainMenu.MenuItems(0).MenuItems(3).Visible = True ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = True ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = True '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = True ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = True ''' Bouton Effacer
                    TBImprimer.Enabled = True ''''''''''' 
                    TBDelete.Enabled = True             ' ToolBar
                    TBMail.Enabled = True '''''''''''''''
                Else
                    MainMenu.MenuItems(0).MenuItems(3).Visible = False ''' Bouton Envoyer vers
                    MainMenu.MenuItems(0).MenuItems(3).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(4).Visible = False ''' Bouton Imprimer
                    MainMenu.MenuItems(0).MenuItems(4).Enabled = False '''
                    MainMenu.MenuItems(0).MenuItems(5).Visible = False ''' Bouton Séparateur
                    MainMenu.MenuItems(1).MenuItems(1).Visible = False ''' Bouton Effacer
                    TBImprimer.Enabled = False ''''''''''' 
                    TBDelete.Enabled = False             ' ToolBar
                    TBMail.Enabled = False '''''''''''''''
                End If
            End If
        Catch ex As Exception
            Exit Try ' en cas d'erreur
        End Try
    End Sub

    Private Sub Coloration_Toutes_ListView()
        Dim gr As Graphics = CreateGraphics()
        Dim MySortClass As New SortListView.SortClass

        MySortClass.DessinerArrièrePlanFaçonListing(ListView1, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView2, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView3, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView4, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView5, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView6, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView7, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView8, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView9, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView10, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView11, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
        MySortClass.DessinerArrièrePlanFaçonListing(ListView12, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))
    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView1.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView1.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView1, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView2_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView2.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView2.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView2.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView2, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView3_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView3.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView3.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView3.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView3, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView4_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView4.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView4.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView4.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView4, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView5_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView5.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView5.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView5.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView5, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView6_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView6.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView6.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView6.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView6, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView7_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView7.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView7.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView7.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView7, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView8_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView8.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView8.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView8.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView8, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView9_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView9.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView9.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView9.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView9, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView10_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView10.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView10.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView10.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView10, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView11_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView11.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView11.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView11.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView11, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub ListView12_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView12.ColumnClick
        Dim bAltSort As Boolean = False
        Dim MySortClass As New SortListView.SortClass
        Try
            MySortClass.column = e.Column
            'Vérifie que l'on a cliqué sur une zone numérique
            If IsNumeric(ListView12.Items(0).SubItems(e.Column).Text.ToUpper.Trim) Then
                MySortClass.Numeric = True
            Else
                MySortClass.Numeric = False
            End If

            'controle si l'utilisateur a cliqué sur la même colonne
            If mIntSelectedCol = e.Column Then
                MySortClass.AltSort = True
                mIntSelectedCol = -1
            Else
                mIntSelectedCol = e.Column
            End If
            ' lance le tri
            ListView12.ListViewItemSorter = MySortClass

            ' colore une ligne sur deux sinon suite au tri la coloration n'est plus une ligne sur 2
            MySortClass.DessinerArrièrePlanFaçonListing(ListView12, Color.FromArgb(190, 220, 201), Color.FromArgb(255, 255, 203))

        Catch
            Exit Try
        End Try
    End Sub
End Class