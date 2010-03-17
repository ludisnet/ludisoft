#Region " Imports "
' Quelques importations pour simplifier la syntaxe

Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Reflection
Imports System.Resources
Imports System.Windows.Forms
#End Region

Public Class MyMenu : Inherits MenuItem
    Private m_Icon As Icon

    ' Par défaut ce sont les couleurs définies
    ' ces couleurs peuvent être modifiées lors de l'appel
    Private m_Font As New Font("Comic Sans Ms", 10)
    Private m_Gradient_Color1 As Color = Color.RoyalBlue
    Private m_Gradient_Color2 As Color = Color.OrangeRed

    Public Sub New()
        MyClass.New("", Nothing, Nothing, Nothing, System.Windows.Forms.Shortcut.None)
    End Sub

    Public Sub New(ByVal text As String, ByVal icon As Icon, ByVal font As Font, ByVal onClick As EventHandler, ByVal shortcut As Shortcut)
        MyBase.New(text, onClick, shortcut)
        ' Owner Draw Property permet dfe modifier menu item par handling
        ' OnMeasureItem et OnDrawItem
        OwnerDraw = True
        m_Font = font
        m_Icon = icon
    End Sub

    ' Permet une couleur différente pour chaque élément du menu
    ' couleur dégradée.
    Public Sub New(ByVal text As String, ByVal GradientColor1 As System.Drawing.Color, ByVal GradientColor2 As System.Drawing.Color, ByVal icon As Icon, ByVal font As Font, ByVal onClick As EventHandler, ByVal shortcut As Shortcut)
        MyBase.New(text, onClick, shortcut)
        ' Propriété Key 
        OwnerDraw = True
        m_Font = font
        m_Gradient_Color1 = GradientColor1
        m_Gradient_Color2 = GradientColor2
        m_Icon = icon
    End Sub

    Private Function GetRealText() As String
        Dim s As String = Text
        ' Ajoute shortcut 
        If ShowShortcut And Shortcut <> Shortcut.None Then
            Dim k As Keys = CType(Shortcut, Keys)
            s = s & Convert.ToChar(9) & "           " & TypeDescriptor.GetConverter(GetType(Keys)).ConvertToString(k)
        End If

        Return s
    End Function


    Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)

        Dim br As Brush

        If Not m_Icon Is Nothing Then
            e.Graphics.DrawIcon(m_Icon, e.Bounds.Left + 2, e.Bounds.Top + 2)
        End If

        Dim rcBk As Rectangle = e.Bounds
        rcBk.X += 22

        ' Dessine un fond au menuavec des couleur dégradée
        ' Utilise les couleurs par défaut sauf si vous avez paszé des couleurs
        ' dans l'appel
        ' passe l'instantiation au menu item 
        If CBool(e.State And DrawItemState.Selected) Then
            br = New LinearGradientBrush(rcBk, m_Gradient_Color1, m_Gradient_Color2, 0)
        Else
            'Couleur d'arrière plan
            br = SystemBrushes.Menu
        End If

        ' Dessine le rectangle principal
        e.Graphics.FillRectangle(br, rcBk)

        ' Laisse la place pour l'accelerator key
        Dim sf As StringFormat = New StringFormat
        sf.HotkeyPrefix = HotkeyPrefix.Show

        ' Dessine le menu text
        br = New SolidBrush(e.ForeColor)
        e.Graphics.DrawString(GetRealText(), m_Font, br, e.Bounds.Left + 25, e.Bounds.Top + 2, sf)

    End Sub

    Protected Overrides Sub OnMeasureItem(ByVal e As MeasureItemEventArgs)
        ' Permet d'adapter la largeur au menu le plus large
        Dim sf As New StringFormat
        sf.HotkeyPrefix = HotkeyPrefix.Show
        MyBase.OnMeasureItem(e)
        e.ItemHeight = CInt(e.Graphics.MeasureString(GetRealText(), m_Font, 10000, sf).Height) '22
        e.ItemWidth = CInt(e.Graphics.MeasureString(GetRealText(), m_Font, 10000, sf).Width) + 10
    End Sub
End Class
