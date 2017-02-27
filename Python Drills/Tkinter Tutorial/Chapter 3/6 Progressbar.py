from tkinter import *
from tkinter import ttk

root = Tk()
progressbar = ttk.Progressbar(root, orient = HORIZONTAL, length = 200)
progressbar.pack()
progressbar.config(mode = 'indeterminate')
progressbar.start()
progressbar.stop()
progressbar.config(mode = "determinate", maximum = 100.0, value = 25.0)
progressbar.config(value = 50.0)
progressValue = DoubleVar()
progressbar.config(variable = progressValue)
scale = ttk.Scale(root, orient = HORIZONTAL, length = 400, variable = progressValue, from_ = 0.0, to_ = 100.0)
scale.pack()

root.mainloop()