/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 17.06.2009
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
//using System.Drawing;
//using System.Windows.Forms;

//using System;
//using System.Drawing;
//using System.Collections;
using System.ComponentModel;
//using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;


namespace test_prog
{
	class EPG
	{
		//private string pathdest;
		
		
		public static void Main(string[] args)
		{
		/*
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		*/	
						
			// URL to download : "http://xmltv.myftp.org/download/tnt.zip"
				
				/*
				// On isole le nom du fichier
				int i = textBox1.Text.LastIndexOf("/");
				fichier = textBox1.Text.Substring(i+1, textBox1.Text.Length - i -1);
				*/
				// declaration de la destination
				
				//pathdest = "c:\\test.zip";
				
				// On télécharge le fichier et on le stocke surle disque dur
				// sous la forme c:\nom_fichier
				 WebClient client = new WebClient();
				//client.DownloadFile(textBox1.Text.Trim(), "C:\\" + fichier);
//				client.DownloadFile("http://ludisnet.free.fr/test.zip", "c:\\tmp.zip");
				client.DownloadFile("http://ludisnet.free.fr/test.zip", "tmp.zip");

				//Samples
				//WebClient Client = new WebClient ();
				//Client.DownloadFile("http://www.csharpfriends.com/Members/index.aspx", " index.aspx");	
							
				
				FastZip fz = new FastZip();       
				//fz.ExtractZip(zipFile, targetDirectory,"");
				fz.ExtractZip("tmp.zip", "C:\\tmp","");
				
			
			/*
				ZipFile zip = ZipFile.Read("MyZip.zip");
		        foreach (ZipEntry e in zip)
        {
            e.Extract("NewDirectory");
        }
			
			
		        ZipFile zip = ZipFile.Read("c:\\test1.zip");
		        foreach (ZipEntry e in zip)
        {
            e.Extract("C:\tmp");   
		        
		}
		*/	
	}
}
	}