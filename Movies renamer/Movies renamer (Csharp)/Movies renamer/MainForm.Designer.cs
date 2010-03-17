/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 17.02.2010
 * Time: 08:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Movies_renamer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.listcover = new System.Windows.Forms.ListBox();
			this.listmovie = new System.Windows.Forms.ListBox();
			this.copytomovie = new System.Windows.Forms.Button();
			this.copytocover = new System.Windows.Forms.Button();
			this.LOADcover = new System.Windows.Forms.Button();
			this.LOADmovie = new System.Windows.Forms.Button();
			this.filtercover = new System.Windows.Forms.TextBox();
			this.filtermovie = new System.Windows.Forms.TextBox();
			this.pathcover = new System.Windows.Forms.TextBox();
			this.pathmovie = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.browsecover = new System.Windows.Forms.Button();
			this.browsemovie = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// listcover
			// 
			this.listcover.FormattingEnabled = true;
			this.listcover.Location = new System.Drawing.Point(12, 156);
			this.listcover.Name = "listcover";
			this.listcover.Size = new System.Drawing.Size(241, 355);
			this.listcover.TabIndex = 0;
			// 
			// listmovie
			// 
			this.listmovie.FormattingEnabled = true;
			this.listmovie.Location = new System.Drawing.Point(300, 156);
			this.listmovie.Name = "listmovie";
			this.listmovie.Size = new System.Drawing.Size(241, 355);
			this.listmovie.TabIndex = 0;
			// 
			// copytomovie
			// 
			this.copytomovie.Location = new System.Drawing.Point(261, 240);
			this.copytomovie.Name = "copytomovie";
			this.copytomovie.Size = new System.Drawing.Size(33, 23);
			this.copytomovie.TabIndex = 2;
			this.copytomovie.Text = ">>";
			this.copytomovie.UseVisualStyleBackColor = true;
			// 
			// copytocover
			// 
			this.copytocover.Location = new System.Drawing.Point(261, 270);
			this.copytocover.Name = "copytocover";
			this.copytocover.Size = new System.Drawing.Size(33, 23);
			this.copytocover.TabIndex = 2;
			this.copytocover.Text = "<<";
			this.copytocover.UseVisualStyleBackColor = true;
			// 
			// LOADcover
			// 
			this.LOADcover.Location = new System.Drawing.Point(117, 127);
			this.LOADcover.Name = "LOADcover";
			this.LOADcover.Size = new System.Drawing.Size(135, 23);
			this.LOADcover.TabIndex = 3;
			this.LOADcover.Text = "LOAD";
			this.LOADcover.UseVisualStyleBackColor = true;
			this.LOADcover.Click += new System.EventHandler(this.LOADcoverClick);
			// 
			// LOADmovie
			// 
			this.LOADmovie.Location = new System.Drawing.Point(405, 127);
			this.LOADmovie.Name = "LOADmovie";
			this.LOADmovie.Size = new System.Drawing.Size(135, 23);
			this.LOADmovie.TabIndex = 3;
			this.LOADmovie.Text = "LOAD";
			this.LOADmovie.UseVisualStyleBackColor = true;
			// 
			// filtercover
			// 
			this.filtercover.Location = new System.Drawing.Point(74, 68);
			this.filtercover.Name = "filtercover";
			this.filtercover.Size = new System.Drawing.Size(178, 20);
			this.filtercover.TabIndex = 4;
			this.filtercover.Text = "*.jpg";
			// 
			// filtermovie
			// 
			this.filtermovie.Location = new System.Drawing.Point(362, 68);
			this.filtermovie.Name = "filtermovie";
			this.filtermovie.Size = new System.Drawing.Size(178, 20);
			this.filtermovie.TabIndex = 4;
			this.filtermovie.Text = "*.avi";
			// 
			// pathcover
			// 
			this.pathcover.Location = new System.Drawing.Point(12, 13);
			this.pathcover.Name = "pathcover";
			this.pathcover.Size = new System.Drawing.Size(241, 20);
			this.pathcover.TabIndex = 4;
			this.pathcover.Text = "C:\\Program Files\\National Instruments\\LabVIEW 2009\\user.lib\\LV_users_dev\\LuL_dev\\" +
			"renamer\\test";
			// 
			// pathmovie
			// 
			this.pathmovie.Location = new System.Drawing.Point(297, 13);
			this.pathmovie.Name = "pathmovie";
			this.pathmovie.Size = new System.Drawing.Size(241, 20);
			this.pathmovie.TabIndex = 4;
			this.pathmovie.Text = "C:\\Program Files\\National Instruments\\LabVIEW 2009\\user.lib\\LV_users_dev\\LuL_dev\\" +
			"renamer\\test";
			// 
			// label1
			// 
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(14, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "filter :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(300, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "filter";
			// 
			// browsecover
			// 
			this.browsecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browsecover.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.browsecover.Location = new System.Drawing.Point(219, 39);
			this.browsecover.Name = "browsecover";
			this.browsecover.Size = new System.Drawing.Size(33, 16);
			this.browsecover.TabIndex = 6;
			this.browsecover.Text = "...";
			this.browsecover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.browsecover.UseVisualStyleBackColor = true;
			this.browsecover.Click += new System.EventHandler(this.BrowsecoverClick);
			// 
			// browsemovie
			// 
			this.browsemovie.Location = new System.Drawing.Point(507, 39);
			this.browsemovie.Name = "browsemovie";
			this.browsemovie.Size = new System.Drawing.Size(33, 16);
			this.browsemovie.TabIndex = 6;
			this.browsemovie.Text = "...";
			this.browsemovie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.browsemovie.UseVisualStyleBackColor = true;
			this.browsemovie.Click += new System.EventHandler(this.BrowsemovieClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(12, 38);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(177, 24);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "include sub-folder";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 520);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.browsemovie);
			this.Controls.Add(this.browsecover);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.filtermovie);
			this.Controls.Add(this.pathmovie);
			this.Controls.Add(this.pathcover);
			this.Controls.Add(this.filtercover);
			this.Controls.Add(this.LOADmovie);
			this.Controls.Add(this.LOADcover);
			this.Controls.Add(this.copytocover);
			this.Controls.Add(this.copytomovie);
			this.Controls.Add(this.listmovie);
			this.Controls.Add(this.listcover);
			this.Name = "MainForm";
			this.Text = "Movies renamer";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button browsemovie;
		private System.Windows.Forms.Button browsecover;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox pathmovie;
		private System.Windows.Forms.TextBox pathcover;
		private System.Windows.Forms.TextBox filtermovie;
		private System.Windows.Forms.TextBox filtercover;
		private System.Windows.Forms.ListBox listcover;
		private System.Windows.Forms.ListBox listmovie;
		private System.Windows.Forms.Button LOADcover;
		private System.Windows.Forms.Button LOADmovie;
		private System.Windows.Forms.Button copytomovie;
		private System.Windows.Forms.Button copytocover;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}
