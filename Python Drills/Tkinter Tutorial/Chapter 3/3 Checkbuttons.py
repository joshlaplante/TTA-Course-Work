from tkinter import *
from tkinter import ttk

root = Tk()
checkButton = ttk.Checkbutton(root, text = 'Spam?')
checkButton.pack()
spam = StringVar()
spam.set('SPAM!')
checkButton.config(variable = spam, onvalue = 'Spam, please!', offvalue = 'No spam')
print(spam.get())
checkButton.invoke()
print(spam.get())

breakfast = StringVar()
radioButton = ttk.Radiobutton(root, text = 'Spam', variable = breakfast, value = 'Spam')
radioButton.pack()
radioButton = ttk.Radiobutton(root, text = 'Eggs', variable = breakfast, value = 'Eggs')
radioButton.pack()
radioButton = ttk.Radiobutton(root, text = 'Waffles', variable = breakfast, value = 'Waffles')
radioButton.pack()


root.mainloop()