//Copyright (C) Microsoft Corporation.  Tous droits réservés.

// FunctionClient.cs
// compiler avec : /reference:DigitCounter.dll;Factorial.dll
// arguments : 3 5 10
using System; 
//La directive using suivante rend disponibles les types définis dans l'espace de noms Functions
// pour cette unité de compilation :
using Functions;
class FunctionClient 
{ 
    public static void Main(string[] args) 
    { 
        Console.WriteLine("Function Client"); 

        if ( args.Length == 0 ) 
        {
            Console.WriteLine("Usage: FunctionTest ... "); 
            return; 
        } 

        for ( int i = 0; i < args.Length; i++ ) 
        { 
            int num = Int32.Parse(args[i]); 
            Console.WriteLine(
               "The Digit Count for String [{0}] is [{1}]", 
               args[i], 
               // Appelle la méthode statique NumberOfDigits dans la
               // classe DigitCount :
               DigitCount.NumberOfDigits(args[i])); 
            Console.WriteLine(
               "The Factorial for [{0}] is [{1}]", 
                num,
               // Appelle la méthode statique Calc dans la classe Factorial :
                Factorial.Calc(num) ); 
        } 
    } 
}

