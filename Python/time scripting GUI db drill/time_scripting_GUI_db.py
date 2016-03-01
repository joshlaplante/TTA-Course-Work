import os
import shutil
import datetime
import wx
import sqlite3


class windowClass(wx.Frame):
    def __init__(self, parent, title):
        super(windowClass, self).__init__(parent, title = title, \
                                          size = (640,480))
        self.SetBackgroundColour('#ccffff')
        self.dbCreate()
        self.createUI()
        self.Show(True)


    def createUI(self):
        #artifically set source and destination
        self.source = os.getcwd()
        self.destination = os.getcwd()
        #setup grid bag sizer
        grid = wx.GridBagSizer(hgap = 20, vgap = 20)
        #create source text and current source
        self.sourcePathText = wx.StaticText(self, \
                            label = "Current Source Path: ")
        self.sourcePathCurrent = wx.StaticText(self, \
                            label = self.source)
        #create destination text and current destination
        self.destinationPathText = wx.StaticText(self, \
                            label = "Current Destination Path: ")
        self.destinationPathCurrent = wx.StaticText(self, \
                            label = self.destination)
        #add text to grid
        grid.Add(self.sourcePathText, pos = (1,1), \
                 flag = wx.ALIGN_LEFT)
        grid.Add(self.sourcePathCurrent, pos = (1,2), span = (1,5), \
                 flag = wx.ALIGN_LEFT)
        grid.Add(self.destinationPathText, pos = (3,1), \
                 flag =wx.ALIGN_LEFT)
        grid.Add(self.destinationPathCurrent, pos = (3,2), span = (1,5), \
                 flag = wx.ALIGN_LEFT)
        #create and add source button
        self.sourceButton = wx.Button(self, label = "Change Source")
        grid.Add(self.sourceButton, pos = (2,1), flag = wx.ALIGN_RIGHT)
        #create and add destination button
        self.destinationButton = wx.Button(self, label = "Change Destination")
        grid.Add(self.destinationButton, pos = (4,1), flag = wx.ALIGN_RIGHT)
        #create last copy time text
        self.lastCopyText = wx.StaticText(self, label = 'Time of Last Copy: ')
        self.lastCopyTimeText = wx.StaticText(self, label = self.lastCopyTime)
        grid.Add(self.lastCopyText, pos = (5,2))
        grid.Add(self.lastCopyTimeText, pos = (5,3))
        #create copy button
        self.copyButton = wx.Button(self, label = "Copy Files")
        grid.Add(self.copyButton, pos = (6,3), flag = wx.ALIGN_CENTER)
        #create button bindings
        self.Bind(wx.EVT_BUTTON, self.changeSource, self.sourceButton)
        self.Bind(wx.EVT_BUTTON, self.changeDestination, self.destinationButton)
        self.Bind(wx.EVT_BUTTON, self.setTimes, self.copyButton)
        #set grid bag sizer
        self.SetSizer(grid)


        
    def dbCreate(self):
        self.conn = sqlite3.connect('copyTimes.db')
        self.conn.execute('create table if not exists copyTimes( \
                    ID integer primary key autoincrement, \
                    copyTime text)')
        readout = self.conn.execute("select * from copyTimes")
        lines = readout.fetchall()
        for line in lines:
            self.lastCopyTimeRaw = line[1]
            self.lastCopyTime = self.lastCopyTimeRaw.replace('u','')
        if lines == []:
            self.lastCopyTime = 'No Copies Made Yet'

    def dbUpdate(self):
        self.lastCopyString = str(self.lastCopyTime)
        self.conn.execute('insert into copyTimes(copyTime) \
                        values ("%s")' % (self.lastCopyString))
        self.conn.commit()
        self.lastCopyTimeText.SetLabel(self.lastCopyString)

    #create change source method
    def changeSource(self, event):
        sourceChange = wx.DirDialog(self, message = "Choose a Source Folder", \
                                    defaultPath = os.getcwd(), style = wx.OPEN)
        if sourceChange.ShowModal() == wx.ID_OK:
            #update source to user selection
            self.source = sourceChange.GetPath()
            self.sourcePathCurrent.SetLabel(self.source)

    #create change destination method
    def changeDestination(self, event):
        destinationChange = wx.DirDialog(self, \
                                    message = "Choose a Destination Folder",\
                                    defaultPath = os.getcwd(), style = wx.OPEN)
        if destinationChange.ShowModal() == wx.ID_OK:
            #update destination to user selection
            self.destination = destinationChange.GetPath()
            self.destinationPathCurrent.SetLabel(self.destination)
        
        


    def timedCopier(self, now, limit):
        for files in os.listdir(self.source):
            #set source file path
            source_file = os.path.join(self.source, files)
            #get last modified time of file
            mtimestamp = os.path.getmtime(source_file)
            mdatetime = datetime.datetime.fromtimestamp(mtimestamp)
            #check if modified time is within limit
            if limit < mdatetime < now:
                #set destination file path
                destination_file = os.path.join(self.destination, files)
                print 'Copying ' + str(source_file) + ' to...'
                print str(destination_file)
                #copy over file
                shutil.copy(source_file, destination_file)
        



    def setTimes(self, event):
        #get current time
        self.now = datetime.datetime.now()
        #get limit time (lastCopyTime)
        if self.lastCopyTime == 'No Copies Made Yet':
            self.lastCopyTime = self.now
            limitdiff = datetime.timedelta(hours = 24)
            limit = self.now - limitdiff
            #get source
            self.source = self.source
            #get destination
            self.destination = self.destination
            #run timeScript with current and limit times
            self.timedCopier(self.now, limit)
            self.dbUpdate()
        else:
            limit = datetime.datetime.strptime(self.lastCopyTime, \
                                                '%Y-%m-%d %H:%M:%S.%f')
            self.lastCopyTime = self.now
            #get source
            self.source = self.source
            #get destination
            self.destination = self.destination
            #run timeScript with current and limit times
            self.timedCopier(self.now, limit)
            self.dbUpdate()
            


def main():
    app = wx.App()
    window = windowClass(None, title = 'File Copier')
    app.MainLoop()
    

if __name__ == "__main__": main()

