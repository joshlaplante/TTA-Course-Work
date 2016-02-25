from tkinter import *
from tkinter import ttk

root = Tk()
month = StringVar()
combobox = ttk.Combobox(root, textvariable = month)
combobox.config(values = ("Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"))
combobox.pack()

year = StringVar()
spinbox = Spinbox(root, from_ = 1990, to_ = 2014, textvariable = year)
spinbox.pack()



root.mainloop()