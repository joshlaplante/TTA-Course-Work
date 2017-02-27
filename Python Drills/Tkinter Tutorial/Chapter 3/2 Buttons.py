from tkinter import *
from tkinter import ttk

def callback():
    print("Clicked!")

root = Tk()
button = ttk.Button(root, text = "Click Me")
button.pack()
button.config(command = callback)

button.invoke()
button.state(['disabled'])

print(button.instate(['disabled']))
button.state(['!disabled'])

print(button.instate(['!disabled']))

logo = PhotoImage(file = 'Chapter 3\8bit shades.gif')
button.config(image = logo, compound = LEFT)
small_logo = logo.subsample(10,10)
button.config(image = small_logo)

root.mainloop()