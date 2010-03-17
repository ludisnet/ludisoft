Option Strict On 'pour un bon codage
Option Explicit On 'pour un bon codage

'Notions abordées dans ce tutos :
'- Utilisation de Threads
'- Utilisation de l'objet WebClient
'- Utilisation de Environment.TickCount pour le calcul du temps de téléchargement
'- Utilisation du WebProxy et du HwebRequest.

'Trois méthodes pour télécharger un fichier depuis le net :
'- Une seulement valable avec VB.NET 2005 ==> très simple à mettre en place
'- Une autre valable pour VB.NET 2003 et 2005 ==> plus difficile mais reste simple
'- La troisieme permet la gestion de la vitesse et du temps estimé du téléchargement (VB.NET 2003 et 2005) ==> difficile à implémenter

'Methode 1 :
'- Avantages : rapide - simple et efficace
'- Inconvenients : valable que avec framework 2.0 - pas de possibilité d'avoir la vitesse de dl
'- Conclusion : Ideal pour les débutants qui n'en demande pas trop :)

'Methode 2 :
'- Avantages : facile à mettre en place - valable avec vb 2003 et 2005
'- Inconvenients : pas de possibilité de voir la progression - permet pas de récupérer la vitesse de dl, ni le tps estimé
'- Conclusion : Inutile comme méthode autant utiliser la 1ere sauf si vous etes sous vb 2003

'Methode 3 :
'- Avantages : gestion de la vitesse et du tps estimé - affichage de la progression du dl - valable pour vb 2003 et 2005
'- Inconvenients : necessite une classe - code dur à mettre en place et code assez long
'- Conclusion : Idéal pour les initiés de vb.net qui en veulent bcp ^^

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False 'n'intercepte pas les erreur inter-thread
    End Sub

    Private Sub B_Parcourir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Parcourir.Click
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            T_Path.Text = FBD.SelectedPath 'affecte le path à la textbox
        End If
    End Sub

#Region "Methode 1"
    Private Sub B_Dl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Dl1.Click
        MsgBox("Cette methode est valable avec VB.NET 2003 et 2005. Elle ne permet pas d'afficher la progression du téléchargement donc ni la vitesse et le temps estimé." & vbCrLf & vbCrLf & "Simple à mettre en place.")
        Dim thread1 As New Threading.Thread(AddressOf Start1) 'declare le thread
        thread1.Start() 'demarre le thread
    End Sub
    Private Sub Start1() '1ere procédure de dl
        Dim succes As String = Download_File_1(T_Source.Text, T_Path.Text) 'appelle la 1ere procédure de download
        MsgBox(succes) 'affiche le resultat
    End Sub
    Private Function Download_File_1(ByVal Source As String, ByVal Path As String) As String
        Dim Download As New System.Net.WebClient() 'on crée un objet webclient
        Dim TimeDownload As Long = Environment.TickCount 'pour calculer le temps du téléchargement, si on le veut
        Dim NomFichier As String() = Split(T_Source.Text, "/")
        Try
            Download.DownloadFile(Source, Path & "\" & NomFichier(UBound(NomFichier))) 'on télécharge le fichier avec la methode DonwloadFile
            Download.Dispose() 'on libere l'objet
            Return "Success Donwload : " & ((Environment.TickCount - TimeDownload) / 1000) & " secondes" 'retourne le temps du téléchargement
        Catch ex As Exception 'en cas d'erreur
            Return ex.Message 'on en renvoie l'erreur
        End Try
    End Function
#End Region

#Region "Methode 2" '
    Private Sub B_dl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_dl2.Click
        MsgBox("Cette methode est valable uniquement avec VB.NET 2005. Permet seulement d'afficher la progression du dl mais pas le temps estimé et ni la vitesse." & vbCrLf & vbCrLf & "Simple à mettre en place.")
        Dim thread2 As New Threading.Thread(AddressOf Start2) 'declare le thread
        thread2.Start() 'demarre le thread
    End Sub
    Private Sub Start2() '2eme procédure de dl
        Dim succes As Boolean = Download_File_2(T_Source.Text, T_Path.Text) 'appelle la 1ere procédure de download
        If succes = True Then
            MsgBox("Fichier téléchargé") 'affiche le resultat
        Else
            MsgBox("Erreur lors du téléchargement du fichier") 'affiche le resultat
        End If
    End Sub
    Private Function Download_File_2(ByVal Source As String, ByVal Path As String, Optional ByVal User As String = "", Optional ByVal Pass As String = "") As Boolean
        Try 'test
            My.Computer.Network.DownloadFile(Source, Path & "\test." & Microsoft.VisualBasic.Right(T_Source.Text, 3), User, Pass, True, 100, True)
            Return True
        Catch ex As Exception 'en cas d'erreur
            Return False
        End Try
    End Function
#End Region

#Region "Methode 3"

    Private WithEvents Dl As New Download_File
    Private SizeFile As Long 'variable pour la taille du fichier
    Private StartTime As Long 'variable pour le temps du dl

    Private Sub B_dl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_dl3.Click
        MsgBox("Cette methode permet de gérer l'avancement du dl ainsi que la vitesse et le temps estimé du téléchargement. Valable pour VB.NET 2003 et 2005." & vbCrLf & vbCrLf & "Difficile à implémenter")
        If T_Source.Text = "" Or T_Path.Text = "" Then
            MsgBox("Veuillez remplir tous les champs")
        Else
            Dl.Donwload_File_3(T_Source.Text, T_Path.Text & "\test." & Microsoft.VisualBasic.Right(T_Source.Text, 3), False) 'lance la 3eme methode
        End If
    End Sub

    Private Sub Dl_Debut_Dl(ByVal Taille_Fichier As Long, ByVal resumepos As Long, ByVal Temps_Depart As Long) Handles Dl.Debut_Dl
        SizeFile = Taille_Fichier 'stocke la taille du fichier
        L_Info.Text = "Debut du dl : Taille du fichier : " & Taille_Fichier.ToString
        StartTime = Date.Now.Ticks 'stocke le temps de départ
    End Sub

    Private Sub Dl_Fin_Dl(ByVal actual_pos As Long) Handles Dl.Fin_Dl
        pb.Value = 0 'reinitialise la progressbar
        SizeFile = 0 'idem
        StartTime = 0 'idem
        L_Info.Text = "Telechargement terminé."
    End Sub

    Private Sub Dl_Progression_Dl(ByVal actual_pos As Long) Handles Dl.Progression_Dl
        Try
            pb.Value = CInt((actual_pos / SizeFile) * 100) 'etat de la progression du dl
            Dim speed As Long = CLng((actual_pos * 10000000) / (DateTime.Now.Ticks - StartTime)) 'calcule de la vitesse
            If speed <> 0 Then
                Dim TpsEstime As Date
                L_Info.Text = "Vitesse : " & ConvertLen(speed) & " Tps estimé : " & CStr(DateAdd(DateInterval.Second, Math.Round((SizeFile - actual_pos) / speed), TpsEstime))
            End If
        Catch ex As OverflowException
            Exit Sub
        Catch e As Exception
            MsgBox("Erreur fatale : " & e.Message)
        End Try
    End Sub
    Private Function ConvertLen(ByRef fileLen As Long) As String 'fonction pour convertir la vitesse
        Dim Resultat As String = ""

        If fileLen < 1024 Then Resultat = fileLen & " octets"
        If fileLen > 1024 Then Resultat = Math.Round(fileLen / 1024) & " Ko"
        If fileLen > 1024000 Then Resultat = Math.Round(fileLen / (1024000), 2) & " Mo"
        If fileLen > 1024000000 Then Resultat = Math.Round(fileLen / (1024000000), 2) & " Go"

        Return Resultat
    End Function
#End Region

End Class
