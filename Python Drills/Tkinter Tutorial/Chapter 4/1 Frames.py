from tkinter import *
from tkinter import ttk

root = Tk()
frame = ttk.Frame(root)
frame.pack()
frame.config(height = 100, width = 200)
frame.config(relief = RIDGE)
button = ttk.Button(frame, text = 'Click Me')
button.grid()
frame.config(padding = (30,15))
labelFrame = ttk.LabelFrame(root, height = 100, width = 200, text = 'My Frame')
labelFrame.pack()



root.mainloop()