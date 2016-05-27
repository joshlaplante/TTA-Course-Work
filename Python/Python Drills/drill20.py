def stringLonger():
    inputString = input("Enter a string to copy: ")
    copyString = input("Enter how many times to copy that string: ")
    numCopies = int(copyString)
    returnString = inputString
    for i in range(numCopies):
        returnString += inputString
    print(returnString)

stringLonger()