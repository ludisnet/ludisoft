/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 10.07.2009
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Labview_sync
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.select1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.select2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.select3 = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.synchro = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.select4 = new System.Windows.Forms.Button();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.versionbox = new System.Windows.Forms.ComboBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(299, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Directory Labview (local) :";
			// 
			// select1
			// 
			this.select1.Location = new System.Drawing.Point(317, 47);
			this.select1.Name = "select1";
			this.select1.Size = new System.Drawing.Size(75, 23);
			this.select1.TabIndex = 2;
			this.select1.Text = "Select...";
			this.select1.UseVisualStyleBackColor = true;
			this.select1.Click += new System.EventHandler(this.Select1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(38, 97);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(273, 20);
			this.textBox2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Directory library lab.:";
			// 
			// select2
			// 
			this.select2.Location = new System.Drawing.Point(317, 94);
			this.select2.Name = "select2";
			this.select2.Size = new System.Drawing.Size(75, 23);
			this.select2.TabIndex = 2;
			this.select2.Text = "Select...";
			this.select2.UseVisualStyleBackColor = true;
			this.select2.Click += new System.EventHandler(this.Select2Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(11, 95);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(21, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(38, 148);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(273, 20);
			this.textBox3.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(39, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Directory data users :";
			// 
			// select3
			// 
			this.select3.Location = new System.Drawing.Point(317, 145);
			this.select3.Name = "select3";
			this.select3.Size = new System.Drawing.Size(75, 23);
			this.select3.TabIndex = 2;
			this.select3.Text = "Select...";
			this.select3.UseVisualStyleBackColor = true;
			this.select3.Click += new System.EventHandler(this.Select3Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(11, 146);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(21, 24);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(11, 249);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(381, 23);
			this.progressBar1.TabIndex = 4;
			// 
			// synchro
			// 
			this.synchro.Location = new System.Drawing.Point(12, 305);
			this.synchro.Name = "synchro";
			this.synchro.Size = new System.Drawing.Size(111, 23);
			this.synchro.TabIndex = 5;
			this.synchro.Text = "Synchronization";
			this.synchro.UseVisualStyleBackColor = true;
			this.synchro.Click += new System.EventHandler(this.SynchroClick);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(316, 305);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 6;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(38, 203);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(273, 20);
			this.textBox4.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Directory instruments drivers:";
			// 
			// select4
			// 
			this.select4.Location = new System.Drawing.Point(317, 200);
			this.select4.Name = "select4";
			this.select4.Size = new System.Drawing.Size(75, 23);
			this.select4.TabIndex = 2;
			this.select4.Text = "Select...";
			this.select4.UseVisualStyleBackColor = true;
			this.select4.Click += new System.EventHandler(this.Select4Click);
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(11, 201);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(21, 24);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// versionbox
			// 
			this.versionbox.FormattingEnabled = true;
			this.versionbox.Location = new System.Drawing.Point(190, 22);
			this.versionbox.Name = "versionbox";
			this.versionbox.Size = new System.Drawing.Size(121, 21);
			this.versionbox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 279);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(379, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "label5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 338);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.versionbox);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.synchro);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.select4);
			this.Controls.Add(this.select3);
			this.Controls.Add(this.select2);
			this.Controls.Add(this.select1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Labview sync";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button synchro;
		private System.Windows.Forms.Button select1;
		private System.Windows.Forms.Button select2;
		private System.Windows.Forms.Button select3;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button select4;
		private System.Windows.Forms.ComboBox versionbox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
