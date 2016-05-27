def simpleHistogram(numList):
    for num in numList:
        returnString = ''
        returnString += '#' * num
        print(returnString)

simpleHistogram([1,2,3])