/*
 * Created by SharpDevelop.
 * User: lul
 * Date: 10.07.2009
 * Time: 09:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace test_console2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			/*
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			*/
			string [] array99 = new string[] {"toto1", "toto2","toto3"};
			
			for (int i=0; i<array99.Length; i++)
			{
				Console.WriteLine(array99[i]);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);

			
			
		}
	}
}