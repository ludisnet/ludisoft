/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 01.07.2009
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test_form
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.sizevaluelabel = new System.Windows.Forms.Label();
			this.namelabel = new System.Windows.Forms.Label();
			this.filetypevalue = new System.Windows.Forms.Label();
			this.kbmbgb = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(230, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(167, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Taille";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Type";
			// 
			// sizevaluelabel
			// 
			this.sizevaluelabel.Location = new System.Drawing.Point(119, 104);
			this.sizevaluelabel.Name = "sizevaluelabel";
			this.sizevaluelabel.Size = new System.Drawing.Size(81, 23);
			this.sizevaluelabel.TabIndex = 2;
			this.sizevaluelabel.Text = "label1";
			// 
			// namelabel
			// 
			this.namelabel.Location = new System.Drawing.Point(119, 127);
			this.namelabel.Name = "namelabel";
			this.namelabel.Size = new System.Drawing.Size(100, 23);
			this.namelabel.TabIndex = 2;
			this.namelabel.Text = "label1";
			// 
			// filetypevalue
			// 
			this.filetypevalue.Location = new System.Drawing.Point(119, 150);
			this.filetypevalue.Name = "filetypevalue";
			this.filetypevalue.Size = new System.Drawing.Size(100, 23);
			this.filetypevalue.TabIndex = 2;
			this.filetypevalue.Text = "label1";
			// 
			// kbmbgb
			// 
			this.kbmbgb.Location = new System.Drawing.Point(206, 104);
			this.kbmbgb.Name = "kbmbgb";
			this.kbmbgb.Size = new System.Drawing.Size(61, 23);
			this.kbmbgb.TabIndex = 2;
			this.kbmbgb.Text = "KB";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kbmbgb);
			this.Controls.Add(this.filetypevalue);
			this.Controls.Add(this.namelabel);
			this.Controls.Add(this.sizevaluelabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "test_form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label kbmbgb;
		private System.Windows.Forms.Label filetypevalue;
		private System.Windows.Forms.Label namelabel;
		private System.Windows.Forms.Label sizevaluelabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
