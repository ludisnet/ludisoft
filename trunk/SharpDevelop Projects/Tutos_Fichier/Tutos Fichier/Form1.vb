Option Strict On 'evite conversions implicites
Option Explicit On 'evite déclatations implicites

Imports System.IO 'pour travailler sur les fichiers


'********************************************
'Auteur : Aspic                             *
'Date : 6/10/2007                           *
'Téléchargé sur http://aspic.developpez.com *
'Mon site perso : http://zonegeeks.com      *
'********************************************

'Quatre notions abordées dans ce tutos :
' - Utilisation de la classe StreamReader pour la lecture des fichiers textes
' - Utilisation de la classe StreamWriter pour l'ecriture des données dans un fichier texte
' - Utilisation de la classe FileStream pour la lecture et l'ecriture dans n'importe quelle type de fichier
' - Convertir des bytes en ASCII (String)

Public Class Form1

    Private Sub B_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Save.Click
        Dim Flux As New StreamWriter(Application.StartupPath & "\test.txt", False) 'crée un fichier nommé test.txt
        Flux.Write(RTB.Text) 'écrit les données dans le fichier
        Flux.Close() 'ferme le fichier ===> important !!
    End Sub

    Private Sub B_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Load.Click
        Try
            RTBL.Clear() 'efface les données si il y en a
            Dim Flux As New StreamReader(Application.StartupPath & "\test.txt", False) 'ouvre le fichier test.txt
            Dim resultat As String = Flux.ReadToEnd 'lis tous les données
            RTBL.AppendText(resultat) 'affiche le resultat dans la RTB
            Flux.Close() 'ferme le fichier

            'il existe les methodes ReadBlock qui permet de lire un block d'octet et Readline
            'qui permet de lire une ligne entière.
            'la methode ReadToEnd lis tous le fichier en un coup.
            'Utiliser la methode Peek pour parcourir le fichier en le lisant par block et par ligne. Voir exemple :
            ''''
            ''''
            'While Flux.Peek <> -1 'tans que possible
            '  Dim result As String = Flux.ReadLine 'lis une ligne !
            'End While
        Catch ex As IOException 'en cas d'erreurs
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub B_Parcourir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Parcourir.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then 'si le mec a choisi un fichier
            Try
                RTBF.Clear() 'vide la rtb
                Dim Flux As New FileStream(OFD.FileName, FileMode.Open) 'ouvre le fichier selectionné
                Dim resultat(4096) As Byte 'crée un tableau de byte de 4096 octets
                Flux.Read(resultat, 0, resultat.Length) 'lis les données du fichier en byte (4096 byte seront lus)
                MsgBox("ce fichier comporte : " & Flux.Length & " octets")
                Dim resultatEnString As String = System.Text.Encoding.Default.GetString(resultat) 'converti les bytes en string
                RTBF.AppendText(resultatEnString) 'affiche le resultat
                Flux.Close() 'ferme le fichier

                'il existe aussi la méthode write qui écrit des bytes dans le fichier !
                'les methodes BeginRead/EndRead et BiginWrite/EndWrite sont pour l'utilisation asynchrome. Si vous
                'ne savez pas ce que cela signifie, laisser tomber et utiliser les méthodes Read et Write.
                'Position permet de récupérer la position du flux et Flush permet de vider la mémoire tampon.
                'Les autres methodes ne sont pas très utiles.
            Catch ex As IOException 'en cas d'erreurs
                MsgBox(ex.Message)
            End Try
        Else 'sinon
            MsgBox("veuillez choisir un fichier")
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
    End Sub
    

End Class
