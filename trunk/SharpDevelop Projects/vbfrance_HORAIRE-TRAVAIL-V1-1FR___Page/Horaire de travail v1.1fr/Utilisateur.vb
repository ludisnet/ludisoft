Imports System.IO

Public Class Form_Utilisateur
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
    Friend WithEvents Button_Ok As System.Windows.Forms.Button
    Friend WithEvents TextBox_Utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents ListBox_Utilisateur As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button_Effacer As System.Windows.Forms.Button
    Friend WithEvents Button_Quitter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_Utilisateur))
        Me.Button_Ok = New System.Windows.Forms.Button
        Me.TextBox_Utilisateur = New System.Windows.Forms.TextBox
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.ListBox_Utilisateur = New System.Windows.Forms.ListBox
        Me.Button_Effacer = New System.Windows.Forms.Button
        Me.Button_Quitter = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.Button_Ok.Enabled = False
        Me.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Ok.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ok.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Ok.Location = New System.Drawing.Point(144, 64)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(75, 40)
        Me.Button_Ok.TabIndex = 3
        Me.Button_Ok.Text = "&Ok"
        '
        'TextBox_Utilisateur
        '
        Me.TextBox_Utilisateur.Location = New System.Drawing.Point(8, 24)
        Me.TextBox_Utilisateur.Name = "TextBox_Utilisateur"
        Me.TextBox_Utilisateur.Size = New System.Drawing.Size(208, 24)
        Me.TextBox_Utilisateur.TabIndex = 4
        Me.TextBox_Utilisateur.Text = ""
        '
        'ListBox_Utilisateur
        '
        Me.ListBox_Utilisateur.ItemHeight = 17
        Me.ListBox_Utilisateur.Location = New System.Drawing.Point(8, 56)
        Me.ListBox_Utilisateur.Name = "ListBox_Utilisateur"
        Me.ListBox_Utilisateur.Size = New System.Drawing.Size(128, 89)
        Me.ListBox_Utilisateur.Sorted = True
        Me.ListBox_Utilisateur.TabIndex = 5
        '
        'Button_Effacer
        '
        Me.Button_Effacer.BackColor = System.Drawing.Color.Red
        Me.Button_Effacer.Enabled = False
        Me.Button_Effacer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Effacer.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Effacer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Effacer.Location = New System.Drawing.Point(144, 104)
        Me.Button_Effacer.Name = "Button_Effacer"
        Me.Button_Effacer.Size = New System.Drawing.Size(75, 40)
        Me.Button_Effacer.TabIndex = 7
        Me.Button_Effacer.Text = "&Effacer"
        '
        'Button_Quitter
        '
        Me.Button_Quitter.BackColor = System.Drawing.Color.Magenta
        Me.Button_Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Quitter.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Quitter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Quitter.Location = New System.Drawing.Point(8, 160)
        Me.Button_Quitter.Name = "Button_Quitter"
        Me.Button_Quitter.Size = New System.Drawing.Size(208, 23)
        Me.Button_Quitter.TabIndex = 8
        Me.Button_Quitter.Text = "&Quitter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Effacer)
        Me.GroupBox1.Controls.Add(Me.Button_Quitter)
        Me.GroupBox1.Controls.Add(Me.Button_Ok)
        Me.GroupBox1.Controls.Add(Me.TextBox_Utilisateur)
        Me.GroupBox1.Controls.Add(Me.ListBox_Utilisateur)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 192)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez indiquez le nom de l'utilisateur:"
        '
        'Form_Utilisateur
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(258, 208)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Utilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nom d'utilisateur"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private DisCroix As DisableCroix ' Désactive la croix système
    Dim Total_ListBox As String '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim List As Object
    Private Sub Form_Utilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisCroix = New DisableCroix(Me.Handle.ToInt32, "", 0) '''''' Désactive la croix système
        DisCroix.Boutappuyé = 10 '''''''''''''''''''''''''''''''''''

        Dim Val() As String '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i As Integer                                                                                    '
        Dim Temp As New FileStream(Application.StartupPath & "\Save\Nom d'utilisateur.txt", FileMode.Open)  '
        Dim Temp_Stream As New StreamReader(Temp)                                                           '
        Do Until Temp_Stream.Peek = -1                                                                      '  
            Val = Temp_Stream.ReadLine.Split("|")                                                           '
            ListBox_Utilisateur.Items.Add(Val(0))                                                           ' Split
            For i = 1 To Val.Length - 1                                                                     '
                ListBox_Utilisateur.Items.Add(Val(i))                                                       '
            Next                                                                                            '
        Loop                                                                                                '
        Temp_Stream.Close()                                                                                 '
        Temp.Close() ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If ListBox_Utilisateur.Items.Count = 0 Then ' Si la liste est vide 
            Exit Sub ' On se barre
        Else ' Sinon
            ListBox_Utilisateur.Items.RemoveAt(0) ' On supprime le premier élement car c'est un espace blanc
        End If
    End Sub

    Private Sub TextBox_Utilisateur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Utilisateur.TextChanged
        If TextBox_Utilisateur.Text = "" Then '''''''
            Button_Ok.Enabled = False               '
        Else                                        ' Propieté Enabled
            Button_Ok.Enabled = True                '
        End If ''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Button_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ok.Click
        ' Véifie si le nom d'utilisateur ki est ds la TextBox a deja ete saisi ds la ListBox
        Dim i As Integer
        For i = 0 To ListBox_Utilisateur.Items.Count - 1
            Dim Temp As String
            Temp = ""
            Temp = ListBox_Utilisateur.Items(i)
            If TextBox_Utilisateur.Text = Temp Then
                MessageBox.Show("Ce nom d'utilisateur à déjà été saisi", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next i

        If TextBox_Utilisateur.Text <> "" Then '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ListBox_Utilisateur.Items.Add(TextBox_Utilisateur.Text)                                  ' Ajoute à la ListBox
            ListBox_Utilisateur.SelectedItem = TextBox_Utilisateur.Text                              '
            Directory.CreateDirectory(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text) ' Créer le dossier spécifique
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Janvier.hor1") ''''''''
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Février.hor1")        '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Mars.hor1")           '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Avril.hor1")          '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Mai.hor1")            '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Juin.hor1")           '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Juillet.hor1")        ' Et les fichiers
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Août.hor1")           '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Septembre.hor1")      '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Octobre.hor1")        '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Novembre.hor1")       '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Décembre.hor1")       '
            File.Create(Application.StartupPath & "\Save\" & TextBox_Utilisateur.Text & "\Horaire.hor1") ''''''''
        End If
        Sauvegarde_De_La_ListBox()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Sauvegarde_De_La_ListBox()
        If ListBox_Utilisateur.Items.Count = 0 Then
            File.Delete(Application.StartupPath & "\Save\Nom d'utilisateur.txt")
            ListBox_Utilisateur.Items.Clear()
            TextBox_Utilisateur.Text = ""
        End If
        For Each List In ListBox_Utilisateur.Items ''''''''''''''''''''''''''''''''''''''''''''''
            Total_ListBox = Total_ListBox & List & "|"                                          ' Sauvegarde la ListBox
        Next                                                                                    '
        FileOpen(1, Application.StartupPath & "\Save\Nom d'utilisateur.txt", OpenMode.Binary)   '
        FilePut(1, Total_ListBox)                                                               '
        FileClose(1) ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub ListBox_Utilisateur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_Utilisateur.SelectedIndexChanged
        If ListBox_Utilisateur.SelectedIndex <> -1 Then '''''
            Button_Ok.Enabled = True                        '
            Button_Effacer.Enabled = True                   '
        Else                                                ' Propiété Enabled
            Button_Ok.Enabled = False                       '
            Button_Effacer.Enabled = False                  '
        End If ''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Button_Effacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Effacer.Click
        Select Case MessageBox.Show("Etes vous sûr de vouloir supprimer cet utilisateur définitivement", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            Case DialogResult.Yes
                ' Ne pô oublié de mettre le kill pour les sous dossiers
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Janvier.hor1") ''''''''
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Février.hor1")        '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Mars.hor1")           '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Avril.hor1")          '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Mai.hor1")            '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Juin.hor1")           '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Juillet.hor1")        ' Et les fichiers
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Août.hor1")           '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Septembre.hor1")      '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Octobre.hor1")        '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Novembre.hor1")       '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Décembre.hor1")       '
                File.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem & "\Horaire.hor1")        '
                File.Delete(Application.StartupPath & "\Save\" & "\Nom d'utilisateur.txt") ''''''''''''''''''''''''''''''''''
                Directory.Delete(Application.StartupPath & "\Save\" & ListBox_Utilisateur.SelectedItem) ' Supprime le dossier spécifié
                ListBox_Utilisateur.Items.RemoveAt(ListBox_Utilisateur.SelectedIndex) ' Efface l'élement sélectionné
            Case DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub LisBox_Utilisateur_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox_Utilisateur.DoubleClick
        If ListBox_Utilisateur.SelectedItem = "" Then
            Exit Sub
        Else
            DialogResult = DialogResult.OK ' En cas de double clique
        End If
    End Sub

    Private Sub Button_Quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Quitter.Click
        Sauvegarde_De_La_ListBox()
        End ' Quitte
    End Sub
End Class
