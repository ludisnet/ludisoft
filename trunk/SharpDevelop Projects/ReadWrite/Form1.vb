'------------------------------------------------------------------------------
'---
'--- Comparaison du contenu de deux répertoires
'--- 
'--- Module d'acquisition de répertoire
'---
'------------------------------------------------------------------------------

'--- Appel des espaces de noms nécessairesImports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Namespace ReadWrite

    Public Class FrmReadWrite
        Inherits System.Windows.Forms.Form
        Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private WithEvents txtChemin As System.Windows.Forms.TextBox
        Private WithEvents btnParcourir As System.Windows.Forms.Button
        Private WithEvents btnLire As System.Windows.Forms.Button
        Private WithEvents btnEcrire As System.Windows.Forms.Button
        Private WithEvents TxtFichier As System.Windows.Forms.RichTextBox
        Private WithEvents chEcrire As System.Windows.Forms.CheckBox

        Private Sub InitializeComponent()
        	Me.txtChemin = New System.Windows.Forms.TextBox
        	Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        	Me.btnParcourir = New System.Windows.Forms.Button
        	Me.btnLire = New System.Windows.Forms.Button
        	Me.btnEcrire = New System.Windows.Forms.Button
        	Me.TxtFichier = New System.Windows.Forms.RichTextBox
        	Me.chEcrire = New System.Windows.Forms.CheckBox
        	Me.SuspendLayout
        	'
        	'txtChemin
        	'
        	Me.txtChemin.Location = New System.Drawing.Point(8, 16)
        	Me.txtChemin.Name = "txtChemin"
        	Me.txtChemin.Size = New System.Drawing.Size(336, 20)
        	Me.txtChemin.TabIndex = 0
        	'
        	'openFileDialog1
        	'
        	Me.openFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt"
        	'
        	'btnParcourir
        	'
        	Me.btnParcourir.Location = New System.Drawing.Point(24, 48)
        	Me.btnParcourir.Name = "btnParcourir"
        	Me.btnParcourir.Size = New System.Drawing.Size(75, 23)
        	Me.btnParcourir.TabIndex = 1
        	Me.btnParcourir.Text = "Parcourir"
        	AddHandler Me.btnParcourir.Click, AddressOf Me.BtnParcourirClick
        	'
        	'btnLire
        	'
        	Me.btnLire.Location = New System.Drawing.Point(248, 48)
        	Me.btnLire.Name = "btnLire"
        	Me.btnLire.Size = New System.Drawing.Size(80, 23)
        	Me.btnLire.TabIndex = 2
        	Me.btnLire.Text = "Lire le fichier"
        	'
        	'btnEcrire
        	'
        	Me.btnEcrire.Location = New System.Drawing.Point(32, 264)
        	Me.btnEcrire.Name = "btnEcrire"
        	Me.btnEcrire.Size = New System.Drawing.Size(120, 23)
        	Me.btnEcrire.TabIndex = 3
        	Me.btnEcrire.Text = "Ecrire dans le fichier"
        	'
        	'TxtFichier
        	'
        	Me.TxtFichier.Location = New System.Drawing.Point(8, 88)
        	Me.TxtFichier.Name = "TxtFichier"
        	Me.TxtFichier.Size = New System.Drawing.Size(336, 160)
        	Me.TxtFichier.TabIndex = 4
        	Me.TxtFichier.Text = ""
        	'
        	'chEcrire
        	'
        	Me.chEcrire.Location = New System.Drawing.Point(192, 264)
        	Me.chEcrire.Name = "chEcrire"
        	Me.chEcrire.Size = New System.Drawing.Size(112, 24)
        	Me.chEcrire.TabIndex = 5
        	Me.chEcrire.Text = "Ecrire à la suite ?"
        	'
        	'FrmReadWrite
        	'
        	Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        	Me.ClientSize = New System.Drawing.Size(352, 302)
        	Me.Controls.Add(Me.chEcrire)
        	Me.Controls.Add(Me.TxtFichier)
        	Me.Controls.Add(Me.btnEcrire)
        	Me.Controls.Add(Me.btnLire)
        	Me.Controls.Add(Me.btnParcourir)
        	Me.Controls.Add(Me.txtChemin)
        	Me.Name = "FrmReadWrite"
        	Me.Text = "Lire et écrire dans un fichier texte"
        	Me.ResumeLayout(false)
        	Me.PerformLayout
        End Sub

        <STAThread()> _
        Shared Sub Main()
            Application.Run(New FrmReadWrite)
        End Sub

        Private Sub btnParcourir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParcourir.Click
            '--- ouverture de la boîte à dialogue de Windows
            If openFileDialog1.ShowDialog = DialogResult.Cancel Then
                Return
            Else
                '--- capture le nom et chemin du fichier texte
                txtChemin.Text = openFileDialog1.FileName
            End If
        End Sub

        '--------------------
        '--- Bouton : Ecrire
        '--------------------
        Private Sub btnLire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLire.Click
            If txtChemin.Text.Length = 0 Then
                MessageBox.Show("Erreur, vous devez choisir un fichier", "Erreur")
            Else
                '--- Implémente TextReader qui lit les caractères à partir d'un flux d'octets 
                '--- dans un codage particulier.
                Dim sr As StreamReader = New StreamReader(txtChemin.Text, System.Text.Encoding.Default)
                '--- installe le contenu dans le richtextbox
                TxtFichier.Text = sr.ReadToEnd
                '--- referme le fichier texte
                sr.Close()
            End If
        End Sub

        '--------------------
        '--- Bouton : Ecrire
        '--------------------
        Private Sub btnEcrire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEcrire.Click
            If txtChemin.Text.Length = 0 OrElse txtChemin.Text.Length = 0 Then
                MessageBox.Show("Erreur, vous devez choisir un fichier/Ecrire du texte à insérer", "Erreur")
            Else
                Dim bAjouter As Boolean = False
                If chEcrire.Checked Then
                    bAjouter = True
                End If
                '--- Implémente TextWriter pour écrire les caractères dans un flux 
                '--- selon un codage particulier.
                Dim sw As StreamWriter = New StreamWriter(txtChemin.Text, bAjouter, System.Text.Encoding.Default)
                '--- installe le contenu dans le fichier
                sw.Write(TxtFichier.Text)
                '--- referme le fichier texte
                sw.Close()

                MessageBox.Show("Fichier écrit avec succès", "Succès")
            End If
        End Sub
        
    End Class
End Namespace
