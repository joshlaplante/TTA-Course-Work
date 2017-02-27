def getListAndTuple():
    numbers = input("Input comma-separated numbers here: ")
    numlist = numbers.split(",")
    numtuple = tuple(numlist)
    print("List:", numlist)
    print("Tuple:",numtuple)

getListAndTuple()