def stupiderSum():
    numstring1 = input("Enter 1st number: ")
    numstring2 = input("Enter 2nd number: ")
    num1 = int(numstring1)
    num2 = int(numstring2)
    if 15 < num1 + num2 < 20:
        print(20)
    else:
        print(num1+num2)

stupiderSum()