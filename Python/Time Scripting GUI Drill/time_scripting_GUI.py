import os
import shutil
import datetime
import wx

class windowClass(wx.Frame):
    def __init__(self, parent, title):
        super(windowClass, self).__init__(parent, title = title, \
                                          size = (640,480))
        self.SetBackgroundColour('#ccffff')
        self.createUI()
        self.Show(True)


    def createUI(self):
        #artifically set source and destination
        self.source = os.getcwd()
        self.destination = os.getcwd()
        #setup grid bag sizer
        grid = wx.GridBagSizer(hgap = 20, vgap = 20)
        #create source text and current source
        self.source_path_text = wx.StaticText(self, \
                            label = "Current Source Path: ")
        self.source_path_current = wx.StaticText(self, \
                            label = self.source)
        #create destination text and current destination
        self.destination_path_text = wx.StaticText(self, \
                            label = "Current Destination Path: ")
        self.destination_path_current = wx.StaticText(self, \
                            label = self.destination)
        #add text to grid
        grid.Add(self.source_path_text, pos = (1,1), \
                 flag = wx.ALIGN_LEFT)
        grid.Add(self.source_path_current, pos = (1,2), span = (1,5), \
                 flag = wx.ALIGN_LEFT)
        grid.Add(self.destination_path_text, pos = (3,1), \
                 flag =wx.ALIGN_LEFT)
        grid.Add(self.destination_path_current, pos = (3,2), span = (1,5), \
                 flag = wx.ALIGN_LEFT)
        #create and add source button
        self.sourceButton = wx.Button(self, label = "Change Source")
        grid.Add(self.sourceButton, pos = (2,1), flag = wx.ALIGN_RIGHT)
        #create and add destination button
        self.destinationButton = wx.Button(self, label = "Change Destination")
        grid.Add(self.destinationButton, pos = (4,1), flag = wx.ALIGN_RIGHT)
        #set grid bag sizer
        self.SetSizer(grid)
        #create copy button
        self.copyButton = wx.Button(self, label = "Copy Files")
        grid.Add(self.copyButton, pos = (6,3), flag = wx.ALIGN_CENTER)
        #create button bindings
        self.Bind(wx.EVT_BUTTON, self.changeSource, self.sourceButton)
        self.Bind(wx.EVT_BUTTON, self.changeDestination, self.destinationButton)
        self.Bind(wx.EVT_BUTTON, self.setTimes, self.copyButton)

    #create change source method
    def changeSource(self, event):
        sourceChange = wx.DirDialog(self, message = "Choose a Source Folder", \
                                    defaultPath = os.getcwd(), style = wx.OPEN)
        if sourceChange.ShowModal() == wx.ID_OK:
            #update source to user selection
            self.source = sourceChange.GetPath()
            self.source_path_current.SetLabel(self.source)

    #create change destination method
    def changeDestination(self, event):
        destinationChange = wx.DirDialog(self, \
                                    message = "Choose a Destination Folder",\
                                    defaultPath = os.getcwd(), style = wx.OPEN)
        if destinationChange.ShowModal() == wx.ID_OK:
            #update destination to user selection
            self.destination = destinationChange.GetPath()
            self.destination_path_current.SetLabel(self.destination)
        
        


    def timedCopier(self, now, limit):
        for files in os.listdir(self.source):
            #set source file path
            source_file = os.path.join(self.source, files)
            #get last modified time of file
            mtimestamp = os.path.getmtime(source_file)
            mdatetime = datetime.datetime.fromtimestamp(mtimestamp)
            #check if modified time is within limit (last 24 hours)
            if limit < mdatetime < now:
                #set destination file path
                destination_file = os.path.join(self.destination, files)
                print 'Copying ' + str(source_file) + ' to...'
                print str(destination_file)
                #copy over file
                shutil.copy(source_file, destination_file)
        



    def setTimes(self, event):
        #get current time
        now = datetime.datetime.now()
        #get limit time (24 hours back)
        limitdiff = datetime.timedelta(hours = 24)
        limit = now - limitdiff
        #get source
        self.source = self.source
        #get destination
        self.destination = self.destination
        #run timeScript with current and limit times
        self.timeScript(now, limit)


def main():
    app = wx.App()
    window = windowClass(None, title = 'File Copier')
    app.MainLoop()
    

if __name__ == "__main__": main()
