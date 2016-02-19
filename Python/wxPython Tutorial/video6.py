import wx

class windowClass(wx.Frame):

    def __init__(self, *args, **kwargs):
        super(windowClass, self).__init__(*args, **kwargs)
        self.basicGUI()

    def basicGUI(self):
        panel = wx.Panel(self)
        
        menuBar = wx.MenuBar()
        fileButton = wx.Menu()
        editButton = wx.Menu()
        exitItem = fileButton.Append(wx.ID_EXIT, 'Exit', 'Exit the Program')
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
        

        wx.TextCtrl(panel, pos = (10,10), size = (250,150))

        if yesNoAnswer == wx.ID_NO:
            userName = "Liar"

        chooseOneBox = wx.SingleChoiceDialog(None, \
                "What's your favorite topping?", 'Choose wisely...', \
                ['Pepperoni', 'Sausage', 'Mushrooms', 'Peppers'])
        if chooseOneBox.ShowModal() == wx.ID_OK:
            favTopping = chooseOneBox.GetStringSelection()
        
        self.SetTitle('Epic Window for ' + userName)
        self.Show(True)


    def Quit(self, e):
        self.Close()

def main():
    app = wx.App()
    windowClass(None)
    app.MainLoop()

main()
