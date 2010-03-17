Public Class DisableCroix
    Public Declare Function GetMenuItemCount Lib "user32" (ByVal hMenu As Long) As Integer
    Public Declare Function RemoveMenu Lib "user32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    Public Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Boolean) As Integer
    Public Const MF_BYPOSITION = &H400&
    Public Const MF_REMOVE = &H1000&
    Public hSysMenu As Integer
    Public nCount As Integer
    Public hwndb As Integer
    Public Boutappuyé As Single
    Public Declare Function DrawMenuBar Lib "user32" (ByVal hwnd As Integer) As Integer

    Public Sub New(ByVal hwnd As Integer, ByVal sText As String, ByVal IDMenu As Short)
        hSysMenu = GetSystemMenu(hwnd, False)
        nCount = GetMenuItemCount(hSysMenu)
        RemoveMenu(hSysMenu, nCount - 1, MF_REMOVE Or MF_BYPOSITION)
        RemoveMenu(hSysMenu, nCount - 3, MF_REMOVE Or MF_BYPOSITION)
        hwndb = hwnd
    End Sub
    Public Sub DisEnable()
        If Boutappuyé = 1 Or Boutappuyé = 11 Then
            hSysMenu = GetSystemMenu(hwndb, False)
        Else
            hSysMenu = GetSystemMenu(hwndb, True)
        End If
        nCount = GetMenuItemCount(hSysMenu)
        RemoveMenu(hSysMenu, nCount - 1, MF_REMOVE Or MF_BYPOSITION)
        RemoveMenu(hSysMenu, nCount - 3, MF_REMOVE Or MF_BYPOSITION)
        DrawMenuBar(hwndb)
    End Sub
End Class
