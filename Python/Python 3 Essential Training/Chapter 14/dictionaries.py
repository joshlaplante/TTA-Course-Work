d = {'one':1, 'two':2, 'three':3}
x = dict(one = 1, two = 2, three = 3)

y = dict(four = 4, five = 5, six = 6, **x)
print (d,x,y)

for k in d:
    print(k)
    
for k,v in d.items():
    print(k,v)
    
print(d['three'])
print(d.get('three'))

del y['six']
print(y)
print(y.pop('five'))