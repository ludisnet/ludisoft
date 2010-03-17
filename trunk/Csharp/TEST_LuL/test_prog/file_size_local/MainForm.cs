/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 02.07.2009
 * Time: 09:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace file_size_local
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
				
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string path = textBox1.Text;
			long sizelocalfile;
			try
	{
    System.IO.FileInfo monfichier = new System.IO.FileInfo(path);
    //Console.WriteLine("Taille du fichier : {0} octets", monfichier.Length);
    //MessageBox.Show("Taille du fichier : {0} octets", monfichier.Length.ToString("0"));
    sizelocalfile = monfichier.Length/1024;
    label1.Text = sizelocalfile.ToString("0.00");
	}
	catch (Exception exc)
{
    //Console.WriteLine("Un problème a été rencontré avec le fichier '{0}' !\nErreur: {1}", path, exc.Message);  
    MessageBox.Show ("erreur de fichier");
}		
		}
	}
}
