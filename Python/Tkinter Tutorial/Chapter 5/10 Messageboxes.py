from tkinter import messagebox

messagebox.showinfo(title = 'Some Sort of Message', message = 'Blah blah blah')
messagebox.askyesno(title = 'Hungry?', message = 'Do you want pizza?')

from tkinter import filedialog

filename = filedialog.askopenfile()

from tkinter import colorchooser

colorchooser.askcolor(initialcolor = '#FFFFFF')