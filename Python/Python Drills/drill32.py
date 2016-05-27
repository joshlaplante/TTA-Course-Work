def LCMFinder():
    import fractions
    num1 = int(input("Enter 1st number: "))
    num2 = int(input("Enter 2nd number: "))
    print(int(abs(num1*num2) / fractions.gcd(num1,num2)))

LCMFinder()