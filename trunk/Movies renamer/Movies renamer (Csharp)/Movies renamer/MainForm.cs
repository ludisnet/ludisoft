/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 17.02.2010
 * Time: 08:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.IO;

namespace Movies_renamer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string dirpath1 = "";
		string dirpath2 = "";
		
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
		
		
		
		void BrowsecoverClick(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description = "Select directory...";
    		if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
    			{
    				pathcover.Text = folderBrowserDialog1.SelectedPath;
    				dirpath1 = pathcover.Text;
    			}
		}
		
		void BrowsemovieClick(object sender, EventArgs e)
		{
			folderBrowserDialog2.Description = "Select directory...";
    		if (folderBrowserDialog2.ShowDialog(this) == DialogResult.OK)
    			{
    				pathmovie.Text = folderBrowserDialog2.SelectedPath;
    				dirpath2 = pathmovie.Text;
    			}
		}
		
		void LOADcoverClick(object sender, EventArgs e)
		{
			  listcover.Items.Clear();
			  dirpath1=pathcover.Text;
		//	 listBoxDossier.Items.Clear();
			
			
		//	 if (browsedialog1.ShowDialog()==DialogResult.OK)
		//	 {
		//	 nomfichier.Text=browsedialog.SelectedPath;
			
			 //without sub-folder
			 //String[] fichiers = Directory.GetFiles(dirpath1);
			 
			 //with sub-folder
			 String[] fichiers = Directory.GetFiles(@dirpath1, "*.*", SearchOption.AllDirectories);
			 
			 for (int i = 0 ; i < fichiers.Length ; i++)
			 {
			 	 listcover.Items.Add(fichiers[i]);
			 }
			
			 /*
			  
			 String[] reps = Directory.GetDirectories(dirpath1);
			
			 for (int i = 0 ; i < reps.Length ; i++)
			 {	
			 	 listcover.Items.Add(reps[i]);
			 }




			 */
		//	 }
			} 
		
	
		}
}
