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
        Me.components = New System.ComponentModel.Container
        Me.TV_test = New System.Windows.Forms.TreeView
        Me.CMS_test = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AjouterUneRacineTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.AjouterSousTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.AjouterAvantTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.AjouterAprèsTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.SupprimerTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.RenommerTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.CopierTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.CollerTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.CMS_test.SuspendLayout()
        Me.SuspendLayout()
        '
        'TV_test
        '
        Me.TV_test.AllowDrop = True
        Me.TV_test.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV_test.ContextMenuStrip = Me.CMS_test
        Me.TV_test.LabelEdit = True
        Me.TV_test.Location = New System.Drawing.Point(12, 39)
        Me.TV_test.Name = "TV_test"
        Me.TV_test.Size = New System.Drawing.Size(251, 192)
        Me.TV_test.TabIndex = 0
        '
        'CMS_test
        '
        Me.CMS_test.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUneRacineTSMI, Me.AjouterSousTSMI, Me.AjouterAvantTSMI, Me.AjouterAprèsTSMI, Me.CopierTSMI, Me.CollerTSMI, Me.RenommerTSMI, Me.SupprimerTSMI})
        Me.CMS_test.Name = "CMS_test"
        Me.CMS_test.Size = New System.Drawing.Size(175, 180)
        '
        'AjouterUneRacineTSMI
        '
        Me.AjouterUneRacineTSMI.Name = "AjouterUneRacineTSMI"
        Me.AjouterUneRacineTSMI.Size = New System.Drawing.Size(174, 22)
        Me.AjouterUneRacineTSMI.Text = "Ajouter une racine"
        '
        'AjouterSousTSMI
        '
        Me.AjouterSousTSMI.Name = "AjouterSousTSMI"
        Me.AjouterSousTSMI.Size = New System.Drawing.Size(174, 22)
        Me.AjouterSousTSMI.Text = "Ajouter sous"
        '
        'AjouterAvantTSMI
        '
        Me.AjouterAvantTSMI.Name = "AjouterAvantTSMI"
        Me.AjouterAvantTSMI.Size = New System.Drawing.Size(174, 22)
        Me.AjouterAvantTSMI.Text = "Ajouter avant"
        '
        'AjouterAprèsTSMI
        '
        Me.AjouterAprèsTSMI.Name = "AjouterAprèsTSMI"
        Me.AjouterAprèsTSMI.Size = New System.Drawing.Size(174, 22)
        Me.AjouterAprèsTSMI.Text = "Ajouter après"
        '
        'SupprimerTSMI
        '
        Me.SupprimerTSMI.Name = "SupprimerTSMI"
        Me.SupprimerTSMI.Size = New System.Drawing.Size(174, 22)
        Me.SupprimerTSMI.Text = "Supprimer"
        '
        'RenommerTSMI
        '
        Me.RenommerTSMI.Name = "RenommerTSMI"
        Me.RenommerTSMI.Size = New System.Drawing.Size(174, 22)
        Me.RenommerTSMI.Text = "Renommer"
        '
        'CopierTSMI
        '
        Me.CopierTSMI.Name = "CopierTSMI"
        Me.CopierTSMI.Size = New System.Drawing.Size(174, 22)
        Me.CopierTSMI.Text = "Copier"
        '
        'CollerTSMI
        '
        Me.CollerTSMI.BackColor = System.Drawing.SystemColors.Control
        Me.CollerTSMI.Name = "CollerTSMI"
        Me.CollerTSMI.Size = New System.Drawing.Size(174, 22)
        Me.CollerTSMI.Text = "Coller"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clic-droit sur le Treeview pour tester"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 243)
        Me.Controls.Add(Me.TV_test)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.CMS_test.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TV_test As System.Windows.Forms.TreeView
    Friend WithEvents CMS_test As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AjouterSousTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterAvantTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterAprèsTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUneRacineTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenommerTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
