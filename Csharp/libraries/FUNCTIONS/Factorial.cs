//Copyright (C) Microsoft Corporation.  Tous droits réservés.

// Factorial.cs
// compiler avec : /target:library
using System; 

// Déclare un espace de noms. Vous devez organiser vos bibliothèques sous forme de packages,
// d'après leur espace de noms. Ainsi, le runtime .NET peut charger correctement les classes.
namespace Functions 
{ 
    public class Factorial 
    { 
// La méthode statique "Calc" calcule la valeur vectorielle de
// l'entier passé :
        public static int Calc(int i) 
        { 
            return((i <= 1) ? 1 : (i * Calc(i-1))); 
        } 
    }
}

