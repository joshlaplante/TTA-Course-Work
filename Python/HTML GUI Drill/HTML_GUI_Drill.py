from tkinter import *
from tkinter import ttk
import webbrowser

class windowClass():
    def __init__(self, master):
        #title, size, color window
        master.title('HTML Creator')
        master.geometry('640x240')
        master.resizable(False,False)
        master.configure(background = '#66ff99')
        self.createUI(master)

    def createUI(self, master):
        #create styling widget
        self.style = ttk.Style()
        #change color & font
        self.style.configure('TFrame', background = '#66ff99')
        self.style.configure('TButton', background = '#66ff99')
        self.style.configure('TLabel', background = '#66ff99', font = ('MS Sans Serif', 14, 'bold'))
        #create and pack frame
        self.frame = ttk.Frame(master)
        self.frame.pack()
        #create and grid label to frame
        self.labelText = 'Enter your desired HTML body text'
        self.label = ttk.Label(self.frame, text = self.labelText)
        self.label.grid(row = 2, column = 2, pady = (20,0))
        #create and grid entry to frame
        self.entry = ttk.Entry(self.frame, width = 100)
        self.entry.grid(row = 3, column = 2, pady = (20, 0))
        self.defaultEntryText = 'Stay tuned for our amazing summer sale!'
        self.entry.insert(0, self.defaultEntryText)
        #create and grid buttons to frame
        self.createButtonText = 'Create HTML page'
        self.createButton = ttk.Button(self.frame, text = self.createButtonText, command = self.getEntryText)
        self.createButton.grid(row = 4, column = 2, pady = (20,0))
        self.openButtonText = 'Open your page!'
        self.openButton = ttk.Button(self.frame, text = self.openButtonText, command = self.openPage)
        self.openButton.grid(row = 6, column = 2, pady = (20,0))
        #create inner frame for success label
        self.successFrame = ttk.Frame(self.frame)
        self.successFrame.grid(row = 5, column = 2, pady = (20,0))
        #create and hide success label
        self.successText = "Page created successfully!"
        self.success = ttk.Label(self.successFrame, text = self.successText)
        self.success.pack()
        self.success.pack_forget()


    def getEntryText(self):
        #grab text from entry
        self.entryText = self.entry.get()
        #use text from entry to create html page
        self.createhtml()
        #show success text
        self.success.pack()


    def createhtml(self):
        #open html file
        self.html = open('index.html', 'w')
        #write basic format plus the text from entry to the html file
        self.content = "<html> \n<body> \n" + self.entryText + "\n</body> \n</html>"
        self.html.write(self.content)
        #close html file
        self.html.close()


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