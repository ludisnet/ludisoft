//Copyright (C) Microsoft Corporation.  Tous droits réservés.

// DigitCounter.cs
// compiler avec : /target:library
using System; 

// Déclare le même espace de noms que celui de Factorial.cs. Cela permet
// simplement d'ajouter les types au même espace de noms.
namespace Functions 
{
    public class DigitCount 
    {
        // La méthode statique NumberOfDigits calcule le nombre de
        // caractères numériques dans la chaîne passée :
        public static int NumberOfDigits(string theString) 
        {
            int count = 0; 
            for ( int i = 0; i < theString.Length; i++ ) 
            {
                if ( Char.IsDigit(theString[i]) ) 
                {
                    count++; 
                }
            }
            return count;
        }
    }
}

