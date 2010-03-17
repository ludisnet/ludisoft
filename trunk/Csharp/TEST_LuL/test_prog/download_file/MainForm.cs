/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 02.07.2009
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace download_file
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
			
			
			//My.Computer.Network.DownloadFile(url, fichier_complet, "", "",
			//True, 100000, True)
				My.Computer.Network.DownloadFile("http://ludisnet.free.fr/test.zip", "tmp.zip";
				
			
				
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
