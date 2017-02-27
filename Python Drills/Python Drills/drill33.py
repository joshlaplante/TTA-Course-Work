def stupidSum():
    numstring1 = input("Enter 1st number: ")
    numstring2 = input("Enter 2nd number: ")
    numstring3 = input("Enter 3rd number: ")
    num1 = int(numstring1)
    num2 = int(numstring2)
    num3 = int(numstring3)
    if num1 == num2 or num2 == num3 or num1 == num3:
        print(0)
    else:
        print(num1+num2+num3)
stupidSum()