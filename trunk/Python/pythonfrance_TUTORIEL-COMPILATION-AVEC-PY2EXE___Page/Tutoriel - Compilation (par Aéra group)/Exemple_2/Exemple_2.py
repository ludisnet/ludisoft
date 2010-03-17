from Tkinter import *

fen = Tk()
fen.iconbitmap("py.ico")

texte = Label(fen, text = "Bonjour tout le monde !!! ")
texte.pack(padx = 10, pady = 10)

boutton = Button(fen, text = "  Salut  ", command = fen.destroy)
boutton.pack(padx = 10, pady = 10)

fen.mainloop()
