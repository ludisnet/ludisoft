Option Strict On 'soyons strict
Option Explicit On 'et explicit !

Imports System.Net

'********************************************
'Auteur : Aspic                             *
'Date : 6/10/2007                           *
'T�l�charg� sur http://aspic.developpez.com *
'Mon site perso : http://zonegeeks.com      *
'********************************************

'Ceci n'est pas ma classe je l'ai prise sur VBfrance
'Auteur : Hbv
'J'ai rajout� des commentaires car il n'y en avait aucun !
'J'ai modifi� la classe pour l'int�grer dans mon tutos

Public Class Download_File

    '3 events :
    '- Pour le d�but du t�lechargement (debut_dl)
    ' pour la progression du t�l�chargement (progression_dl)
    ' pour la fin du t�l�chargement (fin_dl)

    Public Event Debut_Dl(ByVal Taille_Fichier As Long, ByVal resumepos As Long, ByVal Temps_Depart As Long)
    Public Event Progression_Dl(ByVal actual_pos As Long)
    Public Event Fin_Dl(ByVal actual_pos As Long)

    Dim b As Boolean 'indique si l'utiliateur veut annul� son dl
    Dim bresume As Boolean
    Dim readstr As IO.Stream
    Dim lenfile As Long
    Dim bytesarr(102400) As Byte
    Dim timestart As Long
    Dim tmppos As Long
    Dim posresume As Long
    Dim pathname As String
    Dim urlz As String

    Public Sub Donwload_File_3(ByVal Source As String, ByVal Path As String, ByVal IsResume As Boolean)
        b = True
        bresume = IsResume
        timestart = 0
        pathname = Path
        urlz = Source
        Dim threadz As New System.Threading.Thread(AddressOf thread_launch)
        threadz.Start()
    End Sub

    Private Sub thread_launch() 'thread pour lancer le t�l�chargement
        Get_file(urlz, pathname) 'appel de la proc�dure de dl
    End Sub

    Public Sub Cancel_Dl() 'pour annuler le t�l�chargement
        b = False
    End Sub

    Private Sub Get_file(ByVal fileurl As String, ByVal filepath As String, Optional ByVal proxy As String = Nothing, Optional ByVal proxyport As Integer = Nothing)
        Try
            If proxy <> Nothing And proxyport <> Nothing Then
                Dim hproxy As New WebProxy(proxy, proxyport)
                GlobalProxySelection.Select = hproxy
            End If

            Dim hwebrequest As System.Net.HttpWebRequest = CType(System.Net.WebRequest.Create(fileurl), HttpWebRequest)
            If bresume = True Then
                posresume = CInt(FileLen(filepath))
                tmppos = posresume
                hwebrequest.AddRange(CInt(tmppos))
            End If

            Dim hwebresponse As System.Net.HttpWebResponse = CType(hwebrequest.GetResponse, HttpWebResponse)
            readstr = hwebresponse.GetResponseStream
            lenfile = hwebresponse.ContentLength + tmppos
            timestart = Environment.TickCount 'temps de depart du t�l�chargement
            Dim tmplen As Long 'indique la position du flux
            tmplen = 2
            b = True
            RaiseEvent Debut_Dl(lenfile, CInt(posresume), CInt(timestart)) 'debut du t�l�chargement
            Do While tmplen > 0
                If b = False Then Exit Do 'en cas d'annulation, on quitte la boucle
                tmplen = readstr.Read(bytesarr, 0, 102400) 'lis les donn�es
                tmppos += tmplen 'position du stream
                Dim filesave As New IO.FileStream(filepath, IO.FileMode.Append, IO.FileAccess.Write)
                filesave.Write(bytesarr, 0, CInt(tmplen)) 'ecrit les donn�es dans le fichier au bon entroit
                filesave.Close() 'ferme le fichier
                RaiseEvent Progression_Dl(tmppos) 'd�clanche l'event progression
                ' System.Threading.Thread.Sleep(100) 'ca sert � rien mais c'est pour ralentir le code je suppose !
            Loop
            RaiseEvent Fin_Dl(tmppos) 'le telechargement est termin� !
            readstr.Close() 'on ferme tout
            readstr = Nothing
        Catch ex As Exception
            MsgBox("Erreur " & ex.Message)
        End Try
    End Sub
End Class
