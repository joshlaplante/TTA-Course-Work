def weirdAddition(n):
    num1 = n
    num2 = int("{0}{1}".format(n,n))
    num3 = int("{0}{1}{2}".format(n,n,n))
    addition = num1+num2+num3
    print(addition)

weirdAddition(5)