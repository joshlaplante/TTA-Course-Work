#!/usr/bin/python3
#PyDrill_db_34_vs
#This is a GUI with database usage to create HTML pages for The Tech Academy

from tkinter import *
from tkinter import ttk
import webbrowser
import sqlite3

class windowClass():
    def __init__(self, master):
        #title, size, color window
        master.title('HTML Creator')
        master.geometry('1080x720')
        master.configure(background = '#66ff99')
        self.dbCreate()
        self.createUI(master)

    def createUI(self, master):
        #create styling widget
        self.style = ttk.Style()
        #change color & font
        self.style.configure('TFrame', background = '#66ff99')
        self.style.configure('TButton', background = '#66ff99')
        self.style.configure('TLabel', background = '#66ff99', font = ('MS Sans Serif', 14, 'bold'))
        self.style.configure('content.TLabel', background = '#66ff99', font = ('MS Sans Serif', 11, 'bold'), borderwidth = 10, relief = GROOVE)
        self.style.configure('TRadiobutton', background = '#66ff99')

        #create and pack main frame
        self.frame = ttk.Frame(master)
        self.frame.pack()

        #create and grid header label to main frame
        self.headerLabelText = 'Enter your desired HTML body text:'
        self.headerLabel = ttk.Label(self.frame, text = self.headerLabelText)
        self.headerLabel.grid(row = 2, column = 2, pady = (20,0))

        #create and grid entry to main frame
        self.entry = ttk.Entry(self.frame, width = 100)
        self.entry.grid(row = 3, column = 2, pady = (20, 0))
        self.defaultEntryText = 'Stay tuned for our amazing summer sale!'
        self.entry.insert(0, self.defaultEntryText)

        #create and grid content add button to main frame
        self.addButtonText = 'Add content to database'
        self.addButton = ttk.Button(self.frame, text = self.addButtonText, command = self.getEntryText)
        self.addButton.grid(row = 4, column = 2, pady = (20,0))

        #create inner frame for success label for content addition
        self.addSuccessFrame = ttk.Frame(self.frame)
        self.addSuccessFrame.grid(row = 5, column = 2, pady = (20,0))

        #create and hide success label
        self.addSuccessText = "Content added successfully!"
        self.addSuccess = ttk.Label(self.addSuccessFrame, text = self.addSuccessText)
        self.addSuccess.pack()
        self.addSuccess.pack_forget()

        #create and grid content header label to main frame
        self.contentHeaderText = 'Choose desired content from the database:'
        self.contentHeader = ttk.Label(self.frame, text = self.contentHeaderText)
        self.contentHeader.grid(row = 6, column = 2, pady = (40,0))

        #create inner frame for content display
        self.contentFrame = ttk.Frame(self.frame)
        self.contentFrame.grid(row = 7, column = 2, pady = (20,0))

        #fill content frame with content
        self.showContent()

        #create and grid html creation button
        self.createButtonText = 'Create HTML page'
        self.createButton = ttk.Button(self.frame, text = self.createButtonText, command = self.createhtml)
        self.createButton.grid(row = 8, column = 2, pady = (20,0))

        #create inner frame for success label for html creation
        self.createSuccessFrame = ttk.Frame(self.frame)
        self.createSuccessFrame.grid(row = 9, column = 2, pady = (20,0))

        #create and hide success label
        self.createSuccessText = "Page created successfully!"
        self.createSuccess = ttk.Label(self.createSuccessFrame, text = self.createSuccessText)
        self.createSuccess.pack()
        self.createSuccess.pack_forget()

        #create and grid page open button to main frame
        self.openButtonText = 'Open your page!'
        self.openButton = ttk.Button(self.frame, text = self.openButtonText, command = self.openPage)
        self.openButton.grid(row = 10, column = 2, pady = (40,0))


    def dbCreate(self):
        #create database and table for content
        self.conn = sqlite3.connect('htmlContent.db')
        self.conn.execute('create table if not exists htmlContent ( \
        ID integer primary key autoincrement, \
        content text)')
        #readout what is currently in the database
        self.readout = self.conn.execute('select * from htmlContent')
        self.lines = self.readout.fetchall()


    def getEntryText(self):
        #grab text from entry
        self.entryText = self.entry.get()
        #use text from entry to create html page
        self.addContent()
        #show success text
        self.addSuccess.pack()


    def addContent(self):
        #inserts entry text content to the table
        self.conn.execute('insert into htmlContent (content) values ("{}")'.format(self.entryText))
        self.conn.commit()
        #readout what is currently in the database
        self.readout = self.conn.execute('select * from htmlContent')
        self.lines = self.readout.fetchall()
        #refresh the content space
        self.showContent()


    def showContent(self):
        #clear out old content before filling frame with new content
        for widget in self.contentFrame.winfo_children():
            widget.destroy()
        #create counters for row and column placement
        self.row = 1
        self.column = 0
        #create variable for radiobuttons
        self.contentSelection = StringVar()
        #iterate through database content to create a label and radiobutton for each table entry
        for line in self.lines:
            self.contentLabel = ttk.Label(self.contentFrame, text = line[1])
            self.contentLabel.config(style = 'content.TLabel')
            self.contentLabel.grid(row = self.row, column = self.column, padx = 10, pady= 10)
            self.contentButton = ttk.Radiobutton(self.contentFrame, variable = self.contentSelection, value = line[1])
            self.contentButton.grid(row = self.row+1, column = self.column)
            #increase column counter after each content item
            self.column += 1
            #after three columns are filled, bumps up row counter and resets column counter
            if self.column % 3 == 0:
                self.row += 2
                self.column = 0


    def createhtml(self):
        #grab content selection text
        self.contentSelectionText = self.contentSelection.get()
        if self.contentSelectionText == '':
            pass
        else:
            #open html file
            self.html = open('index.html', 'w')
            #write basic format plus the text from entry to the html file
            self.content = "<html> \n<body> \n" + self.contentSelectionText + "\n</body> \n</html>"
            self.html.write(self.content)
            #close html file
            self.html.close()
            self.createSuccess.pack()


    def openPage(self):
        #set open new tab to true if possible
        self.new = 2
        #set url path to new html file
        self.url = 'index.html'
        #open the new html file
        webbrowser.open(self.url, new = self.new)


def main():
    root = Tk()
    window = windowClass(root)
    root.mainloop()
    

if __name__ == "__main__": main()