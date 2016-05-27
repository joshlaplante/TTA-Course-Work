def futureValue(initial,rate,time):
    import math
    print(initial * (math.e**(rate*time)))

futureValue(1,.05,10)

# problem doesn't even specify if interest is compounded on intervals or continuously...so i used continuously compounded rate