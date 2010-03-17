'==============================================='
' JM de la Boutresse
' Avril 2004
' tri et ajustement des colonnes avec couleurs
'==============================================='
Option Strict On
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class SortClass
    Implements IComparer
    ' sendmessage a été adaptée à Vb.Net pas d'any ni de long et un Intptr pour le handle
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
    (ByVal hwnd As IntPtr, _
    ByVal wMsg As Integer, _
    ByVal wParam As Integer, _
    ByVal lParam As Integer) As Integer
    Private mColumn As Integer
    Private mNumeric As Boolean
    Private m_bAltSort As Boolean
    Private mIntSelectedCol As Integer
    Private Const LVM_FIRST As Integer = &H1000
    Private Const LVM_SETCOLUMNWIDTH As Integer = (LVM_FIRST + 30)
    Private Const LVSCW_AUTOSIZE As Integer = -1
    Private Const LVSCW_AUTOSIZE_USEHEADER As Integer = -2

    Public Property column() As Integer
        Get
            Return mColumn
        End Get
        Set(ByVal Value As Integer)
            mColumn = Value
        End Set
    End Property
    Public Property Numeric() As Boolean
        Get
            Return mNumeric
        End Get
        Set(ByVal Value As Boolean)
            mNumeric = Value
        End Set
    End Property
    Public Property AltSort() As Boolean
        Get
            Return m_bAltSort
        End Get
        Set(ByVal Value As Boolean)
            m_bAltSort = Value
        End Set
    End Property
    Public Function Compare(ByVal x As Object, ByVal y As Object) _
  As Integer Implements System.Collections.IComparer.Compare
        Dim lv1 As ListViewItem = CType(x, ListViewItem)
        Dim lv2 As ListViewItem = CType(y, ListViewItem)
        ' m_bAltSort est le sens une fois sur 2 asc/desc
        If mNumeric Then
            If m_bAltSort = True Then
                If CInt(lv1.SubItems(mColumn).Text) > 0 Then
                    Return CInt(lv1.SubItems(mColumn).Text) + CInt(lv2.SubItems(mColumn).Text)
                Else
                    ' attention pour les nombres de type 0,?? il faut ceci sinon pas de tri 2 fois
                    Return CInt((CDbl(lv1.SubItems(mColumn).Text) + CDbl(lv2.SubItems(mColumn).Text)) * 100)
                End If
            Else
                If CInt(lv1.SubItems(mColumn).Text) > 0 Then
                    Return CInt(lv1.SubItems(mColumn).Text) - CInt(lv2.SubItems(mColumn).Text)
                Else
                    ' attention pour les nombres de type 0,?? il faut ceci sinon pas de tri 2 fois
                    Return CInt((CDbl(lv1.SubItems(mColumn).Text) - CDbl(lv2.SubItems(mColumn).Text)) * 100)
                End If
            End If

        Else
            If m_bAltSort = True Then
                Return String.Compare(lv2.SubItems(mColumn).Text, lv1.SubItems(mColumn).Text)
            Else
                Return String.Compare(lv1.SubItems(mColumn).Text, lv2.SubItems(mColumn).Text)
            End If
        End If


    End Function
    Public Sub AjusterLargeurDesColonnes(ByVal m_listview As ListView, ByVal mode As Integer) ', ByVal Mode As Integer)
        Dim col2adjust As Integer

        If Not m_listview Is Nothing Then
            ' LVSCW_AUTOSIZE_USEHEADER ajuste en fonction du plus large

            For col2adjust = 1 To m_listview.Columns.Count - 1
                If mode = 0 Then
                    ' en fonction du plus large contenu ou entete
                    Call SendMessage(m_listview.Handle, _
                            LVM_SETCOLUMNWIDTH, _
                            col2adjust, LVSCW_AUTOSIZE_USEHEADER) ' LVSCW_AUTOSIZE)
                Else
                    ' en fonction du contenu seulement
                    Call SendMessage(m_listview.Handle, _
                                                LVM_SETCOLUMNWIDTH, _
                                                col2adjust, LVSCW_AUTOSIZE)
                End If
            Next col2adjust
        End If

    End Sub
    Public Sub DessinerArrièrePlanFaçonListing(ByVal m_listview As ListView, ByVal BarColor1 As Color, _
     ByVal BarColor2 As Color)
        Dim i As Integer
        ' si pair une couleur sinon l'autre
        For i = 0 To m_listview.Items.Count - 1
            If i / 2 = Int(i / 2) Then
                m_listview.Items(i).BackColor = BarColor1
            Else
                m_listview.Items(i).BackColor = BarColor2
            End If
        Next

    End Sub
    'Private Sub ShowHeaderIcon(ByVal m_listview As ListView, ByVal ColNo As Integer, _
    '                      ByVal imgIconNo As Integer, _
    '                      ByVal showImage As Boolean)
    '    ' ne marche pas manque le handle du header
    '    Dim hHeader As Integer
    '    Dim HD As HD_ITEM
    '    Dim m_imagelist As New ImageList
    '    m_imagelist.Images.Add(Image.FromFile(Application.StartupPath & "\sortascending.ico"))
    '    m_imagelist.Images.Add(Image.FromFile(Application.StartupPath & "\sortdescending.ico"))

    '    If Not (m_imagelist Is Nothing) Then
    '        On Error Resume Next

    '        'get a handle to the listview header component
    '        hHeader = SendMessage1(m_listview.Handle, LVM_GETHEADER, 0, 0)

    '        'set up the required structure members
    '        With HD
    '            .mask = HDI_IMAGE Or HDI_FORMAT

    '            .pszText = m_listview.Columns(ColNo).Text
    '            If showImage Then
    '                'icone alignée à droite
    '                .fmt = HDF_STRING Or HDF_IMAGE Or HDF_BITMAP_ON_RIGHT
    '                .iImage = imgIconNo
    '            Else
    '                'uniquement du text
    '                .fmt = HDF_STRING
    '            End If
    '        End With

    '        'modify the header
    '        Call SendMessage2(hHeader, HDM_SETITEM, ColNo, HD)
    '    End If
    'End Sub

End Class
