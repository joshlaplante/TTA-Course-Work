from tkinter import *
from tkinter import ttk

root = Tk()
entry = ttk.Entry(root, width = 30)
entry.pack()
entry.insert(0,"Enter your password")
entry.config(show = '*')
entry.state(['readonly'])

root.mainloop()