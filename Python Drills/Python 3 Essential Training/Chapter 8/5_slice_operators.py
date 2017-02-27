list = [1,2,3,4,5,6,7,8,9,10]
print(list[0])
print(list[0:5])
for i in range(0,10):
    print(i)
    
print(list[0:10])

list[:] = range(100)
print(list)

print(list[27:42])
print(list[27:42:3])
for i in list[27:43:3]:
    print (i)
    
list[27:43:3] = (99,99,99,99,99,99)
print(list)