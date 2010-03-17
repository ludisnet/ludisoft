/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 18.06.2009
 * Time: 09:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections;

namespace testconsole
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
		//IDictionary env = Environment.GetEnvironmentVariables();
		// Pour afficher une variable dont on connait le nom
		//Console.WriteLine("USERNAME = {0}", env("USERNAME"));
		// Pour lister toutes les variables
		//IEnumerator en = env.Keys.GetEnumerator();
		//while (en.MoveNext())
    	//Console.WriteLine("{0} = {1}", en.Current, env(en.Current()));
    	//string toto = 	(Environment.GetEnvironmentVariable("ProgramFiles")+"\\National Instruments");
    	//Console.WriteLine("le repertoire temp est :{0} ", Environment.GetEnvironmentVariable("ProgramFiles"));
    	//Console.WriteLine("le repertoire temp est :{0} ", Environment.GetEnvironmentVariable("program file"));
    	//Console.WriteLine ((toto+"\\National Instruments"));
    	//Console.WriteLine (toto);
		
    	//String[] fichiers = Directory.GetFiles("c:\\");
		//String[] fichiers = Directory.GetFileSystemEntries("c:\\");
    	  
 /*   	  
 for (int i = 0 ; i < fichiers.Length ; i++)
 {
 Console.Out.WriteLine(fichiers[i]);
 } 


	Console.WriteLine("Répertoire système = {0}", Environment.SystemDirectory);
	Console.WriteLine("Répertoire système = {0}", Environment.GetEnvironmentVariable("ProgramFiles"));
    	
*/	

    String str;
    String nl = Environment.NewLine;
//
    Console.WriteLine();
    Console.WriteLine("-- Environment members --");

//  Invoke this sample with an arbitrary set of command line arguments.
    Console.WriteLine("CommandLine: {0}", Environment.CommandLine);

    String[] arguments = Environment.GetCommandLineArgs();
    Console.WriteLine("GetCommandLineArgs: {0}", String.Join(", ", arguments));

//  <-- Keep this information secure! -->
    Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);

    Console.WriteLine("ExitCode: {0}", Environment.ExitCode);

    Console.WriteLine("HasShutdownStarted: {0}", Environment.HasShutdownStarted);

//  <-- Keep this information secure! -->
    Console.WriteLine("MachineName: {0}", Environment.MachineName);

    Console.WriteLine("NewLine: {0}  first line{0}  second line{0}  third line",
                          Environment.NewLine);

    Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());

    Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);

//  <-- Keep this information secure! -->
    Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);

    Console.WriteLine("TickCount: {0}", Environment.TickCount);

//  <-- Keep this information secure! -->
    Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);

    Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);

//  <-- Keep this information secure! -->
    Console.WriteLine("UserName: {0}", Environment.UserName);

    Console.WriteLine("Version: {0}", Environment.Version.ToString());

    Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);

//  No example for Exit(exitCode) because doing so would terminate this example.

//  <-- Keep this information secure! -->
    String query = "My system drive is %SystemDrive% and my system root is %SystemRoot%";
    str = Environment.ExpandEnvironmentVariables(query);
    Console.WriteLine("ExpandEnvironmentVariables: {0}  {1}", nl, str);

    Console.WriteLine("GetEnvironmentVariable: {0}  My temporary directory is {1}.", nl,
                           Environment.GetEnvironmentVariable("TEMP"));

    Console.WriteLine("GetEnvironmentVariables: ");
    IDictionary    environmentVariables = Environment.GetEnvironmentVariables();
    foreach (DictionaryEntry de in environmentVariables)
        {
        Console.WriteLine("  {0} = {1}", de.Key, de.Value);
        }

    Console.WriteLine("GetFolderPath: {0}", 
                 Environment.GetFolderPath(Environment.SpecialFolder.System));

    String[] drives = Environment.GetLogicalDrives();
    Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", drives));
    
    if( 8 == IntPtr.Size 
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
    	Console.WriteLine("Répertoire système = {0}",  Environment.GetEnvironmentVariable("ProgramFiles(x86)"));
            }

    Console.WriteLine("Répertoire système = {0}",   Environment.GetEnvironmentVariable("ProgramFiles"));


			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}