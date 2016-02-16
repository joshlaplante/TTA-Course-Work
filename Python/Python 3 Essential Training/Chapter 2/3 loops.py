#while loops

a, b = 0, 1

while b < 50:
    print(b)
    a, b = b, a + b
print('Done')

#for loops

textArray = ["This is a line of text 01", \
             "This is a line of text 02", \
             "This is a line of text 03", \
             "This is a line of text 04", \
             "This is a line of text 05",]

for line in textArray:
    print(line)
