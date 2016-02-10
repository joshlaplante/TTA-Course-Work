from math import sqrt, exp

print sqrt(16)
print exp(2)


#Import the function randint from the random module
from random import randint

def multiplyBy5(x):
    return 5*x

def add5(x):
    return x+5

def randomAdd(x):
    #get a random integer between 0 and 10
    y = randint(0,10)
    return x+y

print multiplyBy5(3)
print add5(9)
print randomAdd(8)
