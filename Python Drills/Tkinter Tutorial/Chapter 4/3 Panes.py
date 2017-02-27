from tkinter import *
from tkinter import ttk

root = Tk()
panedwindow = ttk.Panedwindow(root, orient = HORIZONTAL)
panedwindow.pack(fill = BOTH, expand = True)
frame1 = ttk.Frame(panedwindow, width = 100, height = 300, relief = SUNKEN)
frame2 = ttk.Frame(panedwindow, width = 400, height = 400, relief = SUNKEN)
panedwindow.add(frame1, weight = 1)
panedwindow.add(frame2, weight = 4)
frame3 = ttk.Frame(panedwindow, width = 50, height = 400, relief = SUNKEN)
panedwindow.insert(1, frame3)
panedwindow.forget(1)



root.mainloop()