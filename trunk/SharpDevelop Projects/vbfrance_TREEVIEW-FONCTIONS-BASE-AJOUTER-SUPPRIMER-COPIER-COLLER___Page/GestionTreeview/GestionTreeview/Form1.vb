Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TV_test.Nodes.Clear()
    End Sub

    Private Sub AjouterUneRacineTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUneRacineTSMI.Click
        ' ajouter au premier niveau
        Try
            Dim Racine As New TreeNode
            Racine.Text = "racine"
            Me.TV_test.Nodes.Add(Racine)
            Racine.BeginEdit()
        Catch erreur As Exception
            MessageBox.Show("Ajouter impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub AjouterSousTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterSousTSMI.Click
        ' ajouter sous le noeud actif
        Try
            Dim NoeudActif As TreeNode = Me.TV_test.SelectedNode
            Dim NouveauNoeud As TreeNode = NoeudActif.Nodes.Add("article sous")
            Me.TV_test.SelectedNode = NouveauNoeud
            NouveauNoeud.BeginEdit()
        Catch erreur As Exception
            MessageBox.Show("Ajouter impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub AjouterAvantTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterAvantTSMI.Click
        ' ajouter avant le noeud actif
        Try
            Dim NoeudActif As TreeNode = Me.TV_test.SelectedNode
            Dim NouveauNoeud As TreeNode = NoeudActif.Parent.Nodes.Insert(NoeudActif.Index, "article avant")
            Me.TV_test.SelectedNode = NouveauNoeud
            NouveauNoeud.BeginEdit()
        Catch erreur As Exception
            MessageBox.Show("Ajouter impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub AjouterAprèsTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterAprèsTSMI.Click
        ' ajouter apres le noeud actif
        Try
            Dim NoeudActif As TreeNode = Me.TV_test.SelectedNode
            Dim NouveauNoeud As TreeNode = NoeudActif.Parent.Nodes.Insert(NoeudActif.Index + 1, "article après")
            Me.TV_test.SelectedNode = NouveauNoeud
            NouveauNoeud.BeginEdit()
        Catch erreur As Exception
            MessageBox.Show("Ajouter impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub SupprimerTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerTSMI.Click
        ' supprimer le noeud actif
        Try
            Me.TV_test.SelectedNode.Remove()
        Catch erreur As Exception
            MessageBox.Show("Supprimer impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub RenommerTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenommerTSMI.Click
        ' renommer le noeud actif
        Try
            Me.TV_test.SelectedNode.BeginEdit()
        Catch erreur As Exception
            MessageBox.Show("Renommer impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub CopierTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopierTSMI.Click
        ' copier dans le clipboard
        Try
            Clipboard.Clear()
            Clipboard.SetData("System.Windows.Forms.TreeNode", Me.TV_test.SelectedNode)
        Catch erreur As Exception
            MessageBox.Show("Copier impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub CollerTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollerTSMI.Click
        ' coller dans le noeud actif
        Try
            Dim NoeudActif As TreeNode = Me.TV_test.SelectedNode
            Dim NoeudCopie As TreeNode = DirectCast(Clipboard.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            NoeudCopie.Text = NoeudCopie.Text & " (copie)"
            NoeudActif.Nodes.Add(NoeudCopie)
            NoeudActif.ExpandAll()
        Catch erreur As Exception
            MessageBox.Show("Coller impossible. " & erreur.GetBaseException.Message)
        End Try
    End Sub

    Private Sub TV_test_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TV_test.MouseClick
        ' selectionner le bon noeud après le clic droit
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim NoeudActif As TreeNode = Me.TV_test.GetNodeAt(New Point(e.X, e.Y))
            Me.TV_test.SelectedNode = NoeudActif
        End If
    End Sub
End Class
