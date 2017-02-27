t = tuple(range(10))
print(5 in t)
print(50 in t)
for i in t:
    print(i)
    
x = list(range(10))

print(5 in x)
print(50 in x)
for i in x:
    print(i)

print (t.count(5))
print(t.index(5))

x.append(100)
x.extend(range(5))

x.insert(3,12345)

x.remove(12345)
del x[3]

print(x)

print(x.pop(0))