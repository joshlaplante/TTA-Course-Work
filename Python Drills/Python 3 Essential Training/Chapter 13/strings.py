a, b = 5, 42
print(a,b)
print('this is {}, that is {}'.format(a,b))
s = 'this is {}, that is {}'
print(id(s))
new = s.format(a,b)
print(id(new))
print('this is {1}, that is {0}'.format(a,b))
d = dict(bob = a , fred = b)

string = 'this is {bob} and that is {fred}'.format(**d)
print(string)