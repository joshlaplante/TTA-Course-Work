def numChecker(value, numList):
    if value in numList:
        print("Yup, that value is in the list...")
    else:
        print("Nope, that value isn't in the list...")

numChecker(1, [1,2,3])
numChecker(1, [4,5,6])