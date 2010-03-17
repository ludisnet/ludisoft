/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 23.06.2009
 * Time: 08:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lablabviewlibsync
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string pfpath = (Environment.GetEnvironmentVariable("ProgramFiles")+@"\National Instruments");
		string versionLV;
		string liblabLV = @"\\gva1\labo\Laboratoire\LABVIEW\labview development LABO\LV_LABOLEM";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			comboBox1.Text = "Select version...";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
					
		//string pfpath = (Environment.GetEnvironmentVariable("ProgramFiles")+@"\National Instruments");	
		 if (Directory.Exists(pfpath) == false)
		 	//MessageBox.Show("Le répertoire {0} existe !", pfpath);
    	//Console.WriteLine("Le répertoire ({0}) existe !", path);
		//else
    	//Console.WriteLine("Le répertoire ({0}) n'existe pas !", path);
		 	MessageBox.Show(@"/!\ Le répertoire `"+pfpath+"` n'existe pas !");
		 //break;
		//else
		//continue;
		
	
    string[] files;
    //string[] pathfiles;
    //string[] nono;

    // pour avoir les noms des fichiers et sous-répertoires
    //files = Directory.GetFileSystemEntries(pfpath);
    files = Directory.GetDirectories(pfpath);
    //string name = System.IO.Path.GetFileName(files);
    
    int filecount = files.GetUpperBound(0) + 1;
    for (int i = 0; i<filecount;  i++)
    {
        //Console.WriteLine(files[i]);
    	//MessageBox.Show(files[i]);
    	//nono[i] = System.IO.Path.GetFileName(files[i]);
    	//comboBox1.Items.Add(files[i]);
    	//pathfiles = files;
    	comboBox1.Items.Add(Path.GetFileName(files[i]));
		//string toto1 = Path.GetFileName(files[i]);
		//comboBox2.Items.Add(pathfiles[i]);
    }
      	    
		}
				
			
		/*
		public void AddToMyComboBox1()
		//ajour des différentes versions de Labview du repertoire NI
		*/
		//public static void Main() 
		//{
			
		//Environment.GetEnvironmentVariable("TEMP")
		
	
		//string [] versionlist =
		//}
		
		

		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			string versionLV = (pfpath +@"\"+ comboBox1.SelectedItem.ToString());
			textBox1.Text = versionLV;
		}			
	
		
		void Button1Click(object sender, EventArgs e)
		{
			//Chemin bibli. Labview local :
			textBox1.Text = versionLV;
			if(File.Exists(versionLV))
				MessageBox.Show("fichier existant");
			else
				MessageBox.Show("fichier inexistant");

			//versionLV
		}
	}
}


