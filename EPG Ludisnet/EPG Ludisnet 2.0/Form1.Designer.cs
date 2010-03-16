namespace Telechargement
{
    partial class Telechargement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
        	this.labelFichier = new System.Windows.Forms.Label();
        	this.fileToDownload = new System.Windows.Forms.TextBox();
        	this.selectBouton = new System.Windows.Forms.Button();
        	this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        	this.saveTo = new System.Windows.Forms.TextBox();
        	this.labelSave = new System.Windows.Forms.Label();
        	this.downloadBouton = new System.Windows.Forms.Button();
        	this.cancelButton = new System.Windows.Forms.Button();
        	this.progressBar = new System.Windows.Forms.ProgressBar();
        	this.labelProgress = new System.Windows.Forms.Label();
        	this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        	this.SuspendLayout();
        	// 
        	// labelFichier
        	// 
        	this.labelFichier.AutoSize = true;
        	this.labelFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelFichier.Location = new System.Drawing.Point(9, 11);
        	this.labelFichier.Name = "labelFichier";
        	this.labelFichier.Size = new System.Drawing.Size(108, 13);
        	this.labelFichier.TabIndex = 0;
        	this.labelFichier.Text = "File to download :";
        	// 
        	// fileToDownload
        	// 
        	this.fileToDownload.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
        	this.fileToDownload.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
        	this.fileToDownload.Location = new System.Drawing.Point(12, 25);
        	this.fileToDownload.Name = "fileToDownload";
        	this.fileToDownload.Size = new System.Drawing.Size(392, 20);
        	this.fileToDownload.TabIndex = 1;
        	// 
        	// selectBouton
        	// 
        	this.selectBouton.Location = new System.Drawing.Point(366, 63);
        	this.selectBouton.Name = "selectBouton";
        	this.selectBouton.Size = new System.Drawing.Size(38, 23);
        	this.selectBouton.TabIndex = 2;
        	this.selectBouton.Text = "...";
        	this.selectBouton.UseVisualStyleBackColor = true;
        	this.selectBouton.Click += new System.EventHandler(this.selectBouton_Click);
        	// 
        	// saveFileDialog
        	// 
        	this.saveFileDialog.Filter = "Tous les fichiers|*.*";
        	// 
        	// saveTo
        	// 
        	this.saveTo.Location = new System.Drawing.Point(12, 65);
        	this.saveTo.Name = "saveTo";
        	this.saveTo.ReadOnly = true;
        	this.saveTo.Size = new System.Drawing.Size(348, 20);
        	this.saveTo.TabIndex = 4;
        	// 
        	// labelSave
        	// 
        	this.labelSave.AutoSize = true;
        	this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelSave.Location = new System.Drawing.Point(9, 51);
        	this.labelSave.Name = "labelSave";
        	this.labelSave.Size = new System.Drawing.Size(150, 13);
        	this.labelSave.TabIndex = 3;
        	this.labelSave.Text = "TVserver Directory path :";
        	// 
        	// downloadBouton
        	// 
        	this.downloadBouton.Location = new System.Drawing.Point(115, 143);
        	this.downloadBouton.Name = "downloadBouton";
        	this.downloadBouton.Size = new System.Drawing.Size(86, 23);
        	this.downloadBouton.TabIndex = 5;
        	this.downloadBouton.Text = "Import";
        	this.downloadBouton.UseVisualStyleBackColor = true;
        	this.downloadBouton.Click += new System.EventHandler(this.downloadBouton_Click);
        	// 
        	// cancelButton
        	// 
        	this.cancelButton.Enabled = false;
        	this.cancelButton.Location = new System.Drawing.Point(215, 143);
        	this.cancelButton.Name = "cancelButton";
        	this.cancelButton.Size = new System.Drawing.Size(86, 23);
        	this.cancelButton.TabIndex = 6;
        	this.cancelButton.Text = "Cancel";
        	this.cancelButton.UseVisualStyleBackColor = true;
        	this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
        	// 
        	// progressBar
        	// 
        	this.progressBar.Location = new System.Drawing.Point(12, 107);
        	this.progressBar.Name = "progressBar";
        	this.progressBar.Size = new System.Drawing.Size(392, 23);
        	this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        	this.progressBar.TabIndex = 7;
        	// 
        	// labelProgress
        	// 
        	this.labelProgress.AutoSize = true;
        	this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelProgress.Location = new System.Drawing.Point(9, 93);
        	this.labelProgress.Name = "labelProgress";
        	this.labelProgress.Size = new System.Drawing.Size(123, 13);
        	this.labelProgress.TabIndex = 8;
        	this.labelProgress.Text = "Download progress :";
        	// 
        	// Telechargement
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(416, 177);
        	this.Controls.Add(this.labelProgress);
        	this.Controls.Add(this.progressBar);
        	this.Controls.Add(this.cancelButton);
        	this.Controls.Add(this.downloadBouton);
        	this.Controls.Add(this.saveTo);
        	this.Controls.Add(this.labelSave);
        	this.Controls.Add(this.selectBouton);
        	this.Controls.Add(this.fileToDownload);
        	this.Controls.Add(this.labelFichier);
        	this.MaximizeBox = false;
        	this.Name = "Telechargement";
        	this.Text = "EPG Ludisnet";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        #endregion

        private System.Windows.Forms.Label labelFichier;
        private System.Windows.Forms.TextBox fileToDownload;
        private System.Windows.Forms.Button selectBouton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox saveTo;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Button downloadBouton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
    }
}

