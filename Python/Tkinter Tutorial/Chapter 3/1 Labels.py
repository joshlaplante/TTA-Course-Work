from tkinter import *
from tkinter import ttk

root = Tk()
label = ttk.Label(root, text = "Hello, Tkinter!")
label.pack()
label.config(text = "Howdy, Tkinter!")
label.config(text = "Howdy, Tkinter! It's been a while since we last met. Great to see you again!")
label.config(wraplength = 150)
label.config(justify = CENTER)
label.config(foreground = 'blue', background = 'yellow', font = ('Courier',18, 'bold'))
label.config(text = "Hello, Tkinter!")
picture = PhotoImage(file = 'Chapter 3\8bit shades.gif')
label.config(image = picture)
label.config(compound = 'center')
label.img = picture
label.config(image = label.img)

root.mainloop()