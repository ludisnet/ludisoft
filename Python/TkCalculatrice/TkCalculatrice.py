## Auteur: Alain_72

from Tkinter import * 

class Calculette(Frame): 
  def __init__(self, parent): 
    Frame.__init__(self, parent) 
    self.nbre1 = "" 
    self.nbre2 = "" 
    self.action = "" 
    
    self.ecran = Label(self, bg = "black", anchor = E, fg = "white", text = "0", width = 16) 
    self.ecran.grid(row = 0, column = 0, columnspan = 4, ipadx = 2, ipady = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "C", 
                    command = self.Efface, 
                    width = 3) 
    bouton.grid(row = 1, column = 0) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "/", 
                    command = lambda arg = "/" : self.Operateur(arg), 
                    width = 3) 
    bouton.grid(row = 1, column = 1) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "*", 
                    command = lambda arg = "*" : self.Operateur(arg), 
                    width = 3) 
    bouton.grid(row = 1, column = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "-", 
                    command = lambda arg = "-" : self.Operateur(arg), 
                    width = 3) 
    bouton.grid(row = 1, column = 3) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "7", 
                    command = lambda arg = "7" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 2, column = 0) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "8", 
                    command = lambda arg = "8" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 2, column = 1) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "9", 
                    command = lambda arg = "9" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 2, column = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "+", 
                    command = lambda arg = "+" : self.Operateur(arg), 
                    width = 3, 
                    height = 3) 
    bouton.grid(row = 2, column = 3, rowspan = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "4", 
                    command = lambda arg = "4" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 3, column = 0) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "5", 
                    command = lambda arg = "5" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 3, column = 1) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "6", 
                    command = lambda arg = "6" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 3, column = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "1", 
                    command = lambda arg = "1" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 4, column = 0) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "2", 
                    command = lambda arg = "2" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 4, column = 1) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "3", 
                    command = lambda arg = "3" : self.SaisieNombre(arg), 
                    width = 3) 
    bouton.grid(row = 4, column = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "=", 
                    command = self.Calculer, 
                    width = 3, 
                    height = 3) 
    bouton.grid(row = 4, column = 3, rowspan = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = "0", 
                    command = lambda arg = "0" : self.SaisieNombre(arg), 
                    width = 7) 
    bouton.grid(row = 5, column = 0, columnspan = 2) 
    
    bouton = Button(self, 
                    anchor = CENTER, 
                    text = ".", 
                    command = self.SaisiePoint, 
                    width = 3) 
    bouton.grid(row = 5, column = 2) 
        
  def SaisiePoint(self): 
    if self.nbre1 == "": 
      self.nbre1 = "0." 
      self.ecran.configure(text = self.nbre1) 
    elif self.action == "": 
      self.nbre1 = self.nbre1 + "." 
      self.ecran.configure(text = self.nbre1) 
    elif self.nbre2 == "": 
      self.nbre2 = "0." 
      self.ecran.configure(text = self.nbre2) 
    else: 
      self.nbre2 = self.nbre2 + "." 
      self.ecran.configure(text = self.nbre1) 
    
  def Calculer(self): 
    try: 
      res = str(eval(str(float(self.nbre1)) + self.action + str(float(self.nbre2)))) 
      self.nbre1 = res 
      self.nbre2 = "" 
      self.action = "" 
      self.ecran.configure(text = res) 
      return res 
    except: 
      res = "erreur" 
      self.nbre1 = "" 
      self.nbre2 = "" 
      self.action = "" 
      self.ecran.configure(text = res) 
      return res 
      
    
  def Operateur(self, Ope): 
    if self.nbre1 == "": 
      if Ope == "-": 
        self.nbre1 = "-" 
    elif self.nbre2 == "": 
      if self.action == "": 
        self.action = Ope 
      else: 
        if Ope == "-": 
          self.nbre2 = "-" 
    else: 
      resultat = self.Calculer() 
      if resultat != "erreur": 
        self.action = Ope 
    
  def Efface(self): 
    self.ecran.configure(text = "0") 
    self.nbre1 = "" 
    self.nbre2 = "" 
    self.action = "" 
    
  def SaisieNombre(self, nbre): 
    if self.nbre1 == "": 
      self.nbre1 = nbre 
      self.ecran.configure(text = self.nbre1) 
    elif self.action == "": 
      self.nbre1 = self.nbre1 + nbre 
      self.ecran.configure(text = self.nbre1) 
    elif self.nbre2 == "": 
      self.nbre2 = nbre 
      self.ecran.configure(text = self.nbre2) 
    else: 
      self.nbre2 = self.nbre2 + nbre 
      self.ecran.configure(text = self.nbre1) 

root = Tk() 
calc = Calculette(root) 
calc.pack() 
root.mainloop()
