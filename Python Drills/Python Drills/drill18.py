def weirdSum():
    numstring1 = input("Enter 1st number: ")
    numstring2 = input("Enter 2nd number: ")
    numstring3 = input("Enter 3rd number: ")
    num1 = int(numstring1)
    num2 = int(numstring2)
    num3 = int(numstring3)
    if num1 == num2 and num2 == num3:
        print(num1*9)
    else:
        print(num1+num2+num3)
weirdSum()