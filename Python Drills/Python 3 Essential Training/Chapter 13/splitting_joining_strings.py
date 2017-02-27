s = "this is a string of words"
print(s.split())
print(s.split('i'))
words = s.split()
for w in words:
    print( w)
new = ":".join(words)
print(new)