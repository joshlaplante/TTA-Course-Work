x = 42
print(id(x))
print(id(42))
print(x is 42)
x = dict(a = 42)
y = dict(a = 42)
print(id(x))
print(id(y))
print(x is y)
