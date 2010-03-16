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
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;

namespace Telechargement
{
    public partial class Telechargement : Form
    {
        WebClient client = null;
        string dirpath = "";
        int varerror = 0;

        public Telechargement()
        {
            InitializeComponent();
            fileToDownload.Text = "http://xmltv.myftp.org/download/complet.zip";
            
        if( 8 == IntPtr.Size 
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                //return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
                dirpath = (Environment.GetEnvironmentVariable("ProgramFiles(x86)")+@"\Team MediaPortal\MediaPortal TV Server");
            }

            //return Environment.GetEnvironmentVariable("ProgramFiles");
            dirpath = (Environment.GetEnvironmentVariable("ProgramFiles")+@"\Team MediaPortal\MediaPortal TV Server");

        //string dirpath = (Environment.GetEnvironmentVariable("ProgramFiles")+@"\Team MediaPortal\MediaPortal TV Server");
            
            
			saveTo.Text = dirpath;
        }

        private void selectBouton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select directory...";
    		if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
    			{
    				saveTo.Text = folderBrowserDialog1.SelectedPath;
    				dirpath = saveTo.Text;

    			}
        	/*
        	 if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveTo.Text = saveFileDialog.FileName;
            }
            */
        }

        private void downloadBouton_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(fileToDownload.Text.Trim(), UriKind.Absolute))
            {
            	dirpath = saveTo.Text;
                //Création d'une nouvelle instance de WebClient
                client = new WebClient();

                //On abonne notre instance client à l'évènement de progression du téléchargement
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

                //On abonne notre instance client à l'évènement de fin du téléchargement
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

                //On lance le téléchargement avec les paramètres saisies.
                //Le premier correspond à l'adresse du fichier à télécharger et le second à l'emplacement de sauvegarde
                Uri url = new Uri(fileToDownload.Text.Trim());
                client.DownloadFileAsync(url, "tmp.zip");

                downloadBouton.Enabled = false;      // Rend inaccessible le bouton Télécharger
                downloadBouton.Text = "In progress..."; // Modifie le texte de ce même bouton 

                //Rend accessible le bouton Annuler afin de pouvoir arrêter le téléchargement
                cancelButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid URL");
                varerror = 1;
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
            //fileToDownload.ResetText();
            //saveTo.ResetText();

            //Réinitialisation de la boîte de dialogue et de ses données
            saveFileDialog.Reset();

            //Rend accessible le bouton Télécharger
            downloadBouton.Enabled = true;
            downloadBouton.Text = "Import";

            //Rend inaccessible le bouton Annuler
            cancelButton.Enabled = false;

            //Réinitialisation de la barre de progression
            progressBar.Value = 0;
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
            	FileInfo f=new FileInfo("tmp.zip");
            	//if (File.Exists("tmp.zip"))
            	if (f.Length != 0)
            	{
	            	FastZip fz = new FastZip();
	            	fz.ExtractZip("tmp.zip", dirpath,"");
	            		if (File.Exists(dirpath+@"\tvguide.xml"))
	            		{
							File.Delete(dirpath+@"\tvguide.xml");
							File.Move((dirpath+@"\complet.xml"), dirpath+@"\tvguide.xml");
							File.Delete("tmp.zip");
	            		}
	            		else
	            		{
	            			MessageBox.Show("Unzip or copy error.");
	            			varerror = 1;
	            		}
            	}
            	else
            	{
            		MessageBox.Show("Unavailable URL.");
            		varerror = 1;
            	}
				
                //Affichage du message de confirmation
                if (varerror == 0)
                MessageBox.Show("Import done.");
            }
            else
            {
                //Affichage du message d'annulation
                MessageBox.Show("Import cancel.");
            }
            
            reinitialisation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }
    }
}
