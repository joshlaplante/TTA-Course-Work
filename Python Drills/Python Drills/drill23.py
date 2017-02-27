def weirdCopier():
    inputString = input("Enter a string: ")
    copyString = input("Enter number of copies to make: ")
    numCopies = int(copyString)
    returnString = inputString[0:2]
    if len(inputString) >= 2:
        for i in range(numCopies):
            returnString += inputString[0:2]
    else:
        returnString += inputString
    print(returnString)
weirdCopier()