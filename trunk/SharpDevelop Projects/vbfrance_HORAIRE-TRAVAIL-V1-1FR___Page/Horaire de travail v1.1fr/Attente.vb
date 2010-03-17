Public Class Form_Attente
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
    Friend WithEvents ComboBoxDésignation As System.Windows.Forms.ComboBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer_Progressbar As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Timer_Progressbar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 10
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(152, 144)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Veuillez patienter pendant la création d'un nouvel utilisateur..."
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(24, 40)
        Me.ProgressBar.Maximum = 40
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(456, 23)
        Me.ProgressBar.TabIndex = 2
        '
        'Timer_Progressbar
        '
        Me.Timer_Progressbar.Enabled = True
        '
        'Form_Attente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(498, 72)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Attente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merci de bien vouloir patienter"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private DisCroix As DisableCroix ' Désactive la croix système
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        NumericUpDown1.Value = NumericUpDown1.Value + 0.01
        If NumericUpDown1.Value = 3 Then
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub Form_Attente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(504, 96)
        DisCroix = New DisableCroix(Me.Handle.ToInt32, "", 0) '''''' Désactive la croix système
        DisCroix.Boutappuyé = 10 '''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub Timer_Progressbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Progressbar.Tick
        ProgressBar.Increment(1)
    End Sub
End Class
