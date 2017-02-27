#!/usr/bin/python3
#PyDrill Database functionality for File Transfer - Python 3.4 - IDLE
#This is a GUI with database usage to transfer file paths for The Tech Academy


#import modules
import os
import shutil
import datetime
import sqlite3
from tkinter import *
from tkinter import ttk


class windowClass():
    
    def __init__(self, master):
        #title, size, color window
        master.title('Timed Copier GUI')
        master.geometry("640x480")
        master.resizable(False,False)
        master.configure(background = '#ccffff')
        #create database and user interface
        self.dbCreate()
        self.createUI(master)


    def createUI(self, master):
        self.frame = Frame(master, background = '#ccffff')
        self.frame.pack()
        #artifically set source and destination
        self.source = os.getcwd()
        self.destination = os.getcwd()
        #create source text and current source
        self.sourcePathText = Label(self.frame, background = '#ccffff', \
                            text = "Current Source Path: ")
        self.sourcePathCurrent = Label(self.frame, background = '#ccffff', \
                            text = self.source)
        #create destination text and current destination
        self.destinationPathText = Label(self.frame, background = '#ccffff', \
                            text = "Current Destination Path: ")
        self.destinationPathCurrent = Label(self.frame, background = '#ccffff', \
                            text = self.destination)
        #add text to grid
        self.sourcePathText.grid(row = 1, column = 1)
        self.sourcePathCurrent.grid(row = 1, column = 2, columnspan = 5)
        self.destinationPathText.grid(row = 3, column = 1)
        self.destinationPathCurrent.grid(row = 3, column = 2, columnspan = 5)
        #create and add source button
        self.sourceButton = Button(self.frame, text = "Change Source", \
                                   command = self.changeSource)
        self.sourceButton.grid(row = 2, column = 1, pady = (10,20))
        #create and add destination button
        self.destinationButton = Button(self.frame, text = "Change Destination", \
                                    command = self.changeDestination)
        self.destinationButton.grid(row = 4, column = 1, pady = (10,20))
        #create last copy time text
        self.lastCopyText = Label(self.frame, text = 'Time of Last Copy: ', \
                                  background = '#ccffff')
        self.lastCopyTimeText = Label(self.frame, text = self.lastCopyTime, \
                                      background = '#ccffff')
        self.lastCopyText.grid(row = 5, column = 2)
        self.lastCopyTimeText.grid(row = 5, column = 3)
        #create copy button
        self.copyButton = Button(self.frame, text = "Copy Files", \
                                 command = self.setTimes)
        self.copyButton.grid(row = 6, column = 3)
        


        
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
                        values ("{}")'.format(self.lastCopyString))
        self.conn.commit()
        self.lastCopyTimeText.config(text = self.lastCopyString)

    #create change source method
    def changeSource(self):
        sourceChange = filedialog.askdirectory( title = "Choose a Source Folder", \
                                    initialdir = os.getcwd())
        if sourceChange != '':
            #update source to user selection
            self.source = sourceChange
            self.sourcePathCurrent.config(text = self.source)

    #create change destination method
    def changeDestination(self):
        destinationChange = filedialog.askdirectory( \
                                    title = "Choose a Destination Folder",\
                                    initialdir = os.getcwd())
        if destinationChange != '':
            #update destination to user selection
            self.destination = destinationChange
            self.destinationPathCurrent.config(text = self.destination)
        
        


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
                print ('Copying ' + str(source_file) + ' to...')
                print (str(destination_file))
                #copy over file
                shutil.copy(source_file, destination_file)
        



    def setTimes(self):
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
    root = Tk()
    window = windowClass(root)
    root.mainloop()
    

if __name__ == "__main__": main()
