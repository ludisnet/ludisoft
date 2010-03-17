/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 10.07.2009
 * Time: 14:10
 * 
 * V0.1 : 10.07.2009 : LuL :
 * 
 * TODO :
 * - auto. path labview local
 * - Progress bar + see copied files
 * 
 * 
 * ********************
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Labview_sync
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			string LVdirpath = "";
			string LVlocuserdirpath = "";
			string LVlocinstrdirpath = "";
			string LVlibdirpath = (@"\\Gva1\Labo\Laboratoire\LABVIEW\labview development LABO\LV_LABOLEM");
			string LVusersdirpath = (@"\\Gva1\Labo\Laboratoire\LABVIEW\labview development LABO\users dev");
			string LVinstrdirpath = (@"\\Gva1\Labo\Laboratoire\LABVIEW\drivers_instr.lib\LV_LABOLEM_INSTR_DRIVERS\instr.lib");
		string[] aVLVS = new string[0];
		string[] aVLVL = new string[0];
//			string [] aVLVS;
//			string [] aVLVL;
		
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			if( 8 == IntPtr.Size 
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                //return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
                LVdirpath = (Environment.GetEnvironmentVariable("ProgramFiles(x86)")+@"\National Instruments\LabVIEW 8.6");
            }

            //return Environment.GetEnvironmentVariable("ProgramFiles");
            LVdirpath = (Environment.GetEnvironmentVariable("ProgramFiles")+@"\National Instruments\LabVIEW 8.6");

			textBox1.Text = LVdirpath;
			textBox2.Text = LVlibdirpath;
			textBox3.Text = LVusersdirpath;
			textBox4.Text = LVinstrdirpath;	
			label5.Text = "";

			
			versionbox.Text = "Select version...";
			versionbox.Enabled = false;
//			versionbox.Enabled = true;
			
			string [] filesLVdirpath;
			filesLVdirpath = Directory.GetDirectories(LVdirpath);
			int filecount = filesLVdirpath.GetUpperBound(0) + 1;
		    for (int i = 0; i<filecount;  i++)
			    {
	    	    	versionbox.Items.Add(Path.GetFileName(filesLVdirpath[i]));
	    	    	//versionbox.Items.Add(Path.GetFullPath(filesLVdirpath[i]));
	    	    	//arrayVLV.Add(Path.GetFileName(filesLVdirpath[i]));
//	    	    	aVLVS[i] = Path.GetFileName(filesLVdirpath[i]) ;
////	    	    	aVLVS = new string [] {Path.GetFileName(filesLVdirpath[i])} ;
//	    	    	aVLVL[i] = Path.GetFullPath(filesLVdirpath[i]) ;
////	    	    	versionbox.Items([i]) = aVLVS[i];
	    	    	
			    }
//		    versionbox.Items.AddRange (aVLVS);

		    

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
//		void seelct1Click(object sender, EventArgs e)
//		{
//    		if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
//    		{
//    			LVdirpath = folderBrowserDialog1.SelectedPath;
//    			textBox1.Text = LVdirpath;
//    		}
//		}
		
		void Select1Click(object sender, EventArgs e)
		
		{
    		if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
    		{
    			LVdirpath = folderBrowserDialog1.SelectedPath;
    			textBox1.Text = LVdirpath;
    		}
		}
		
		void Select2Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog2.ShowDialog(this) == DialogResult.OK)
    		{
    			LVlibdirpath = folderBrowserDialog2.SelectedPath;
    			textBox2.Text = LVlibdirpath;
    		}
		}
		
		void Select3Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog3.ShowDialog(this) == DialogResult.OK)
    		{
    			LVusersdirpath = folderBrowserDialog3.SelectedPath;
    			textBox3.Text = LVusersdirpath;
    		}
	
		}
		
		void Select4Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog4.ShowDialog(this) == DialogResult.OK)
    		{
    			LVinstrdirpath = folderBrowserDialog4.SelectedPath;
    			textBox4.Text = LVinstrdirpath;
    		}
		}
		
		void versionboxSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			
		}
		
		void SynchroClick(object sender, EventArgs e)
		{
			//LVdirpath = (textBox1.Text+@"\user.lib");
			LVdirpath = textBox1.Text;
			LVlibdirpath = textBox2.Text;
			LVusersdirpath = textBox3.Text;
			LVinstrdirpath = textBox4.Text;	
			synchro.Enabled = false;

			if (Directory.Exists(LVdirpath))
			{
				if (checkBox1.Checked == true)
				{
				//MessageBox.Show(checkBox1.Checked.ToString());
					if (Directory.Exists(LVlibdirpath))
					{
						LVlocuserdirpath = (LVdirpath+@"\user.lib");
						//DirectoryInfo sourceDir = new DirectoryInfo(LVlibdirpath);
						//DirectoryInfo destinationDir = new DirectoryInfo(LVdirpath);
        				//DirectoryInfo destDir = new DirectoryInfo(LVdirpath);
        				//CopyDirectory(sourceDir, destinationDir);

        				CopyDir(LVlibdirpath, LVlocuserdirpath);
					}
					else
					{
						MessageBox.Show (@"Invalid library lab. directory","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}
				}
				
				if (checkBox2.Checked == true)
				{
					if (Directory.Exists(LVusersdirpath))
					{
						LVlocuserdirpath = (LVdirpath+@"\user.lib");
        				CopyDir(LVusersdirpath, LVlocuserdirpath);
					}
					else
					{
							MessageBox.Show (@"Invalid library users lab. directory","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}

				}
				
				if (checkBox3.Checked == true)
				{
					if (Directory.Exists(LVinstrdirpath))
					{
						LVlocinstrdirpath = (LVdirpath);
						//LVlocinstrdirpath = (LVdirpath+@"\instr.lib");
        				//label5.Text = 
        				CopyDir(LVinstrdirpath, LVlocinstrdirpath);
					}
					else
					{
							MessageBox.Show (@"Invalid library instruments lab. directory","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}
				}
				
				if (checkBox1.Checked==false&&checkBox2.Checked==false&&checkBox3.Checked==false)
				{
				MessageBox.Show (@"No valid checkbox","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
				else
				{
				successync ();
				}
//				MessageBox.Show ("Labview library synchro. done !","Process done",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show (@"Invalid Labview local directory","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
			
			reinitialisation();

			
			}
		 
		    
		public static void CopyDir(string sourceDir, string destDir) 
			{
			    DirectoryInfo dir = new DirectoryInfo(sourceDir);
			    if (!dir.Exists)
			    {
					dir.Create();
			    }
			        string realDestDir;
			        if (dir.Root.Name != dir.Name) 
			       {
			           realDestDir = Path.Combine(destDir, dir.Name); 
			           if (!Directory.Exists(realDestDir))
			               Directory.CreateDirectory(realDestDir); 
			       }
			       else realDestDir = destDir;       
			       foreach (string d in Directory.GetDirectories(sourceDir)) 
			           CopyDir(d, realDestDir);
			       foreach (string file in Directory.GetFiles(sourceDir)) 
			       {
			//       		label5.text = sourceDir;
			
			            string fileNameDest = Path.Combine(realDestDir, Path.GetFileName(file)); 
			            //if (!File.Exists(fileNameDest))
//			            label5.text = file.ToString();
			
			            File.Copy(file, fileNameDest, true); 
			
			       }

			}
		
		
        private void successync ()
	        {
			MessageBox.Show ("Labview library synchro. done !","Process done !",MessageBoxButtons.OK,MessageBoxIcon.Information);
	        }
		        
	
        private void reinitialisation()
		    {
		
		        //Rend accessible le bouton Synchro
		        synchro.Enabled = true;
		        //downloadBouton.Text = "Télécharger";
		
		        //Rend inaccessible le bouton Annuler
		        cancel.Enabled = false;
		
		        //Réinitialisation de la barre de progression
		        progressBar1.Value = 0;
		        
		        label5.Text = "";
		    }


		
		
		}
	}
