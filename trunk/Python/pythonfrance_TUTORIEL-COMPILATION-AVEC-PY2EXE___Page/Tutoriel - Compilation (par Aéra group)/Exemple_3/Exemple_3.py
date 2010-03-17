from Tkinter import *
import Pmw

fen = Tk()

g=Pmw.Group(fen, tag_text="Titre du group")
g.pack(padx = 10, pady = 10)

texte = Label(g.interior(), text = "Bonjour tout le monde !!!")
texte.pack(padx = 10, pady = 10)

boutton = Button(g.interior(), text = "  Salut  ", command = fen.destroy)
boutton.pack(padx = 10, pady = 10)

fen.mainloop()
