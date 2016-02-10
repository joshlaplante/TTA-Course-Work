import wx


class Frame(wx.Frame):
    #add title variable
    def __init__(self, title):
        #title = title variable
        wx.Frame.__init__(self, None, \
                          title = title, size = (300,200))
        self.Center()
        panel = wx.Panel(self)
        button = wx.Button(panel,label = "Exit", \
                           size = (100,40),pos = (100,30))
        button.Bind(wx.EVT_BUTTON, self.exit)
        #create menu bar
        menuBar = wx.MenuBar()
        #create the menu items
        fileMenu = wx.Menu()
        editMenu = wx.Menu()
        self.SetMenuBar(menuBar)
        #add fileMenu and editMenu to menuBar
        menuBar.Append(fileMenu, "File")
        menuBar.Append(editMenu, "Edit")
        #add items to fileMenu
        fileMenu.Append(wx.NewId(), "New File", "Create a new file")
        fileMenu.Append(wx.NewId(), "Open")
        exitItem = fileMenu.Append(wx.NewId(), "Exit")
        #Bind exit menu item to exit function
        self.Bind(wx.EVT_MENU, self.exit, exitItem)
        #create status bar
        self.CreateStatusBar()
        #spin control idea
        self.spinner = wx.SpinCtrl(panel, value = "0", pos = (150,80), \
                         size = (70,25))
        self.valueText = wx.StaticText(panel, label = '', pos = (130,80))
        self.spinner.Bind(wx.EVT_SPINCTRL, self.spinControl)
    def exit(self, event):
        self.Destroy()
    def spinControl(self, event):
        #get spin control value
        value = self.spinner.GetValue()
        #Update static text
        self.valueText.SetLabel(str(value))
app = wx.App()
#Pass in the frame title
frame = Frame("Python GUI")
frame.Show()
app.MainLoop()

