import wx, db_program

class Frame(wx.Frame):
    def __init__(self, title):
        wx.Frame.__init__(self,None, \
                          title = title, size = (800,600))
        panel = wx.Panel(self)

        #creating the menu bar
        menuBar = wx.MenuBar()
        fileMenu = wx.Menu()
        exitItem = fileMenu.Append(wx.NewId(), "Exit")
        menuBar.Append(fileMenu, "File")

        self.SetMenuBar(menuBar)
        self.Bind(wx.EVT_MENU, self.exitProgram, exitItem)

        self.CreateStatusBar()
        
        #setup add new character UI
        
        #create static box
        wx.StaticBox(panel, label = "Add a new character", pos=(20,40), \
                     size = (280,190))
        #text for name, gender, etc
        wx.StaticText(panel, label = "Name:", pos = (30,70))
        wx.StaticText(panel, label = "Gender:", pos = (30,110))
        wx.StaticText(panel, label = "Age:", pos = (30,150))
        wx.StaticText(panel, label = "Occupation:", pos = (30,190))
        #single line text boxes
        self.sName = wx.TextCtrl(panel, size = (150,-1), pos = (130,70))
        self.sGen = wx.TextCtrl(panel, size = (150,-1), pos = (130,110))
        self.sAge = wx.SpinCtrl(panel, value = '0', \
                                size = (70,25), pos = (130,150))
        self.sOcc = wx.TextCtrl(panel, size = (150,-1), pos = (130,190))
        #save button
        save = wx.Button(panel, label = "Add Character", \
                         pos = (100,230))
        save.Bind(wx.EVT_BUTTON, self.addCharacter)

        #setup the table UI

        #setup table as listCtrl
        self.listCtrl = wx.ListCtrl(panel, size = (400,400), pos = (350,40), \
                               style = wx.LC_REPORT |wx.BORDER_SUNKEN)
        #add columns to listCtrl
        self.listCtrl.InsertColumn(0, "ID")
        self.listCtrl.InsertColumn(1, "Name")
        self.listCtrl.InsertColumn(2, "Gender")
        self.listCtrl.InsertColumn(3, "Age")
        self.listCtrl.InsertColumn(4, "Occupation")
        #add data to the list control
        self.fillListCtrl()

        #setup a delete button
        deleteBtn = wx.Button(panel, label = 'Delete', pos = (640,450))
        #run onSelect function when item is selected
        self.listCtrl.Bind(wx.EVT_LIST_ITEM_SELECTED, self.onSelect)
        #bind delete button to onDelete function
        deleteBtn.Bind(wx.EVT_BUTTON, self.onDelete)
        

    #get data from the database
    def fillListCtrl(self):
        allData = db_program.viewAll()
        #delete old data before adding data
        self.listCtrl.DeleteAllItems()
        for row in allData:
            #loop through and append data
            self.listCtrl.Append(row)

    def onSelect(self, event):
        #get the id of the selected row
        self.selectedId = event.GetText()

    def onDelete(self, event):
        #delete the charcter
        db_program.deleteCharacter(self.selectedId)
        #refresh the table
        self.fillListCtrl()

    def addCharacter(self,event):
        name = self.sName.GetValue()
        gen = self.sGen.GetValue()
        age = self.sAge.GetValue()
        occ = self.sOcc.GetValue()
        #checking if variables have a value
        if (name == '') or (gen == '') or (age == '') or (occ == ''):
            #alert user that a variable is empty
            dlg = wx.MessageDialog(None, \
        'Some character values are missing. Enter values in each text box.', \
                                   'Missing Details', wx.OK)
            dlg.ShowModal()
            dlg.Destroy()
            return False
        #add character using function from db_program
        db_program.newCharacter(name, gen, age, occ)
        print db_program.viewAll()
        #empty text boxes when finished
        self.sName.Clear()
        self.sGen.Clear()
        self.sOcc.Clear()
        self.sAge.SetValue(0)
        #update list control
        self.fillListCtrl()
        
    def exitProgram(self, event):
        self.Destroy()

        
app = wx.App()
frame = Frame("Python GUI")
frame.Show()
app.MainLoop()
