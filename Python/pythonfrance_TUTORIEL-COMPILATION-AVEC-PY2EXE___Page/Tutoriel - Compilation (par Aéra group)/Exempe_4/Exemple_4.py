import wx

class MyFrame(wx.Frame):
    def __init__(self, parent, title):
        wx.Frame.__init__(self, parent, -1, title)
        


        menuBar = wx.MenuBar()

         
        menu = wx.Menu()

        

        menuBar.Append(menu, "Fichier")
        self.SetMenuBar(menuBar)

        self.CreateStatusBar()


        
        panel = wx.Panel(self)

        t = wx.StaticText(panel, -1, "Bonjour tout le monde. Ceci est un test")
        t.SetSize(t.GetBestSize())
        b1 = wx.Button(panel, -1, "Quitter")
        b2 = wx.Button(panel, -1, "Test n°1")
        b3 = wx.Button(panel, -1, "Test n°2")


        sizer = wx.BoxSizer(wx.VERTICAL)
        sizer.Add(t, 0, wx.ALL, 10)
        sizer.Add(b1, 0, wx.ALL, 10)
        sizer.Add(b2, 0, wx.ALL, 10)
        sizer.Add(b3, 0, wx.ALL, 10)
        panel.SetSizer(sizer)
        panel.Layout()

        self.Centre()



class MyApp(wx.App):
    def OnInit(self):
        frame = MyFrame(None, "Test de Aéra group")
        self.SetTopWindow(frame)

        frame.Show(True)
        return True
    
        
app = MyApp(True)
app.MainLoop()
