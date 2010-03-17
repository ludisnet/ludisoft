#! /usr/bin/env python
# -*- coding: Utf8 -*-

# Traitement et conversion de lignes dans un petit fichier texte

def traiteLigne(ligne):
    "convertit une ligne de 'Latin1' en 'Utf8', avec insertion de -*-"
    ligne = ligne.decode("Latin1")   # conversion 'string' => 'unicode'
    newLine = u""                    # nouvelle chaîne unicode à construire
    c, m = 0, 0                      # initialisations
    while c < len(ligne):            # lire tous les caractères de la ligne
        if ligne[c] == " ":          
            # Le caractère lu est un espace.
            # On ajoute une 'tranche' à la chaîne en cours de construction :
            newLine = newLine + ligne[m:c] + "-*-"
            # On mémorise dans m la position atteinte dans la ligne lue :
            m = c + 1                # ajouter 1 pour "oublier" l'espace
        c = c + 1
    # Ne pas oublier d'ajouter la 'tranche' suivant le dernier espace :
    newLine = newLine + ligne[m:]
    # Renvoyer la chaîne construite, reconcertie en 'string' Utf8 :
    return newLine.encode("Utf8")

# --- Programme principal : ---
nomFS = raw_input("Nom du fichier source (Latin-1) : ")
nomFD = raw_input("Nom du fichier destinataire (Utf-8) : ")
fs = open(nomFS, 'r')               # ouverture des 2 fichers
fd = open(nomFD, 'w')
while 1:                            # boucle de traitement
    li = fs.readline()              # lecture d'une ligne 'source'
    if li == "":
        break                       # détection de fin de fichier
    fd.write(traiteLigne(li))       # traitement + écriture   
fd.close()
fs.close()

