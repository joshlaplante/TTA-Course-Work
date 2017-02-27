import wx

class windowClass(wx.Frame):

    def __init__(self, *args, **kwargs):
        super(windowClass, self).__init__(size = (800,600),*args, **kwargs)
        self.basicGUI()

    def basicGUI(self):
        panel = wx.Panel(self)
        
        menuBar = wx.MenuBar()
        fileButton = wx.Menu()
        editButton = wx.Menu()

        importItem = wx.Menu()
        importItem.Append(wx.ID_ANY, 'Import Pepperoni Pizza')
        importItem.Append(wx.ID_ANY, 'Import Sausage Pizza')
        importItem.Append(wx.ID_ANY, 'Import Mushroom Pizza')
        importItem.Append(wx.ID_ANY, 'Import Pepper Pizza')

        fileButton.AppendMenu(wx.ID_ANY, 'Import', importItem)

        toolBar = self.CreateToolBar()
        quitToolButton = toolBar.AddLabelTool(wx.ID_ANY, 'Quit', \
                                              wx.Bitmap('8bit.jpg'))
        importToolButton = toolBar.AddLabelTool(wx.ID_ANY, 'Import', \
                                                wx.Bitmap('8bit2.jpg'))
        toolBar.Realize()
        self.Bind(wx.EVT_TOOL, self.Quit, quitToolButton)
        
        exitItem = wx.MenuItem(fileButton, wx.ID_EXIT, 'Quit\tCtrl+Q')
        exitItem.SetBitmap(wx.Bitmap('card_red.png'))
        fileButton.AppendItem(exitItem)



        menuBar.Append(fileButton, 'File')
        menuBar.Append(editButton, 'Edit')
        self.SetMenuBar(menuBar)
        self.Bind(wx.EVT_MENU, self.Quit, exitItem)

        userName = "Nameless"
        nameBox = wx.TextEntryDialog(None, 'What is your name?', 'Welcome!', \
                                     'name')
        if nameBox.ShowModal() == wx.ID_OK:
            userName = nameBox.GetValue()

        yesNoBox = wx.MessageDialog(None, 'Do you enjoy pizza?', \
                                    'Ultimate Question', wx.YES_NO)
        yesNoAnswer = yesNoBox.ShowModal()
        yesNoBox.Destroy()
        


        if yesNoAnswer == wx.ID_NO:
            userName = "Liar"

        chooseOneBox = wx.SingleChoiceDialog(None, \
                "What's your favorite topping?", 'Choose wisely...', \
                ['Pepperoni', 'Sausage', 'Mushrooms', 'Peppers'])
        if chooseOneBox.ShowModal() == wx.ID_OK:
            favTopping = chooseOneBox.GetStringSelection()
            if favTopping == "Pepperoni":
                color = "red"
            elif favTopping == "Sausage":
                color = "brown"
            elif favTopping == "Mushrooms":
                color = 'white'
            elif favTopping == "Peppers":
                color = "green"

        wx.TextCtrl(panel, pos = (3,100), size = (150,50))

        awesomeText = wx.StaticText(panel, -1, "Awesome Text", pos = (3,3))
        awesomeText.SetForegroundColour('#67cddc')
        awesomeText.SetBackgroundColour('black')

        rlyAwesomeText = wx.StaticText(panel, -1, "Customized Awesomeness", \
                                       pos = (3,30))
        rlyAwesomeText.SetForegroundColour(color)
        rlyAwesomeText.SetBackgroundColour('black')
        
        self.SetTitle('Epic Window for ' + userName)
        self.Show(True)


    def Quit(self, e):
        self.Close()

def main():
    app = wx.App()
    windowClass(None)
    app.MainLoop()

main()
