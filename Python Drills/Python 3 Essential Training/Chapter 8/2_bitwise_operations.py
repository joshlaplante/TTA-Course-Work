print(0b0101)

def b(n):
    print('{:08b}'.format(n))

b(5)

x, y = 0x55, 0xaa

b(x)
b(y)
b(x | y)
b(x & y)
b(x ^ y)
b(x ^ 0)
b(x ^ 0xff)
b(x << 4)
b(x >> 4)
b(~x)
