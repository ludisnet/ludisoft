/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 09.07.2009
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test_console2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			string [] array2;
			
			//string [] array1 = new string[] {"test0" , "test1" , "test2" , "test3"};
			
			
			
			string [,] array1 = new string[,]
			{
				{"test0" , "test1" , "test2" , "test3"},
				{"url0", "url1" , "url2" , "url3"}
			};
			

			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
					
			/*
			string [] array2;
				for (int i=0; i<array1.Length(0) ; i++)
			{
				array1[i] = array2(0)[i];
			}
			*/
			
			//array2 = array1.CopyTo(0);
			comboBox1.Items.AddRange (array2);
			//comboBox1.Items.RemoveAt(0);
			comboBox1.SelectedIndex =(0);
			
			//comboBox1.Items.Add ("test");
			//comboBox1.Items.Add ("test1");
			//comboBox1.Select (1);
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
					
			
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			//textBox1.Text = comboBox1.SelectedItem.ToString();
			textBox1.Text = comboBox1.SelectedIndex.ToString();
					
					
	
		}
	}
}

