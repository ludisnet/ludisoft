/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 01.07.2009
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test_form
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
			if (textBox1.Text == "")
{
    MessageBox.Show("You have not typed the URL", "URL Error", 
			MessageBoxButtons.OK, MessageBoxIcon.Error);
}
else              
{                
    string URL = textBox1.Text;
    string filetype = URL.Substring(URL.LastIndexOf(".") + 1, 
			(URL.Length - URL.LastIndexOf(".") - 1));
    filetypevalue.Text = filetype.ToUpper();
    string filename = URL.Substring(URL.LastIndexOf("/") + 1, 
			(URL.Length - URL.LastIndexOf("/") - 1));
    namelabel.Text = filename;
     System.Net.WebRequest req = System.Net.HttpWebRequest.Create(textBox1.Text);
    req.Method = "HEAD";
    System.Net.WebResponse resp = req.GetResponse();
    long ContentLength = 0;
    long result;
    if (long.TryParse(resp.Headers.Get("Content-Length"), out ContentLength))
    {
        string File_Size;                   
        
        /*
        if (ContentLength >= 1073741824)
        {
            result = ContentLength / 1073741824;
            kbmbgb.Text = "GB";
        }
        else if (ContentLength >= 1048576)
        {
            result = ContentLength / 1048576;
            kbmbgb.Text = "MB";
        }
        else
        {
            result = ContentLength / 1024;
            kbmbgb.Text = "KB";                        
        }
        */
       	result = ContentLength / 1024;
        File_Size = result.ToString("0.00");
        sizevaluelabel.Text = File_Size;
        
    }
} 
		}
		
		
	}
}
