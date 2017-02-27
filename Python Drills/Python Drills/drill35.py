def weirdCheck():
    numstring1 = input("Enter 1st number: ")
    numstring2 = input("Enter 2nd number: ")
    num1 = int(numstring1)
    num2 = int(numstring2)
    if num1 == num2 or num1 + num2 == 5 or num1 - num2 == 5 or num2 - num1 == 5:
        print(True)
    else:
        print(False)

weirdCheck()