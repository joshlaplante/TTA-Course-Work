from tkinter import *

root = Tk()
text = Text(root, width = 40, height = 10)
text.pack()
text.insert('1.0', 'Inserted message')
text.tag_add('my_tag', '1.0', '1.0 wordend')
text.tag_configure('my_tag', background = 'yellow')
text.tag_remove('my_tag', '1.1', '1.3')
print(text.tag_ranges('my_tag'))
print(text.tag_names())
print(text.tag_names('1.0'))
text.replace('my_tag.first', 'my_tag.last', 'That')
text.tag_delete('my_tag')
print(text.mark_names())
text.insert('insert', '_')
text.mark_set('my_mark', 'end')
text.mark_gravity('my_mark', 'right')
text.mark_unset('my_mark')
picture = PhotoImage(file = 'Chapter 5\8bit shades.gif')
text.image_create('insert', image = picture)
button = Button(text, text = 'Click Me')
text.window_create('insert', window = button)




root.mainloop()