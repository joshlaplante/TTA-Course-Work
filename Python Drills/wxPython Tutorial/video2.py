import wx

class windowClass(wx.Frame):

    def __init__(self, parent, title):
        super(windowClass, self).__init__(parent, title = title, \
                                          size = (800,600))
        self.Centre()
        self.Show()

app = wx.App()
windowClass(None, title = "Epic Window")
app.MainLoop()
