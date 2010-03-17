using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Telechargement
{
    public partial class Telechargement : Form
    {
        WebClient client = null;

        public Telechargement()
        {
            InitializeComponent();
        }

        private void selectBouton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveTo.Text = saveFileDialog.FileName;
            }
        }

        private void downloadBouton_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(fileToDownload.Text.Trim(), UriKind.Absolute))
            {
                //Création d'une nouvelle instance de WebClient
                client = new WebClient();

                //On abonne notre instance client à l'évènement de progression du téléchargement
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

                //On abonne notre instance client à l'évènement de fin du téléchargement
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

                //On lance le téléchargement avec les paramètres saisies.
                //Le premier correspond à l'adresse du fichier à télécharger et le second à l'emplacement de sauvegarde
                Uri url = new Uri(fileToDownload.Text.Trim());
                client.DownloadFileAsync(url, saveTo.Text);

                downloadBouton.Enabled = false;      // Rend inaccessible le bouton Télécharger
                downloadBouton.Text = "En cours..."; // Modifie le texte de ce même bouton 

                //Rend accessible le bouton Annuler afin de pouvoir arrêter le téléchargement
                cancelButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vous devez saisir une adresse correcte");
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Met à jour la position de la barre de progression à partir
            // de l'état d'avancement contenu dans l'attribut ProgressPercentage
            progressBar.Value = e.ProgressPercentage;
        }

        private void reinitialisation()
        {
            //Réinitialisation des champs texte
            fileToDownload.ResetText();
            saveTo.ResetText();

            //Réinitialisation de la boîte de dialogue et de ses données
            saveFileDialog.Reset();

            //Rend accessible le bouton Télécharger
            downloadBouton.Enabled = true;
            downloadBouton.Text = "Télécharger";

            //Rend inaccessible le bouton Annuler
            cancelButton.Enabled = false;

            //Réinitialisation de la barre de progression
            progressBar.Value = 0;
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                //Affichage du message de confirmation
                MessageBox.Show("Téléchargement terminé.");
            }
            else
            {
                //Affichage du message d'annulation
                MessageBox.Show("Téléchargement annulé.");
            }
            
            reinitialisation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }
    }
}
