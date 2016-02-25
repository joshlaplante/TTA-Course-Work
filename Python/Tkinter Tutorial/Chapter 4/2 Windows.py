from tkinter import *

root = Tk()
window = Toplevel(root, )
window.title('New Window')
window.lower()
window.lift(root)
window.state('zoomed')
window.state('withdrawn')
window.state('iconic')
window.state('normal')
window.state('normal')
window.iconify()
window.deiconify()
window.geometry('640x480+50+100')
window.resizable(False, False)
window.maxsize(640,480)
window.minsize(200,200)
window.resizable(True,True)
root.destroy()



root.mainloop()