def stringFromList(list):
    returnString = ''
    for item in list:
        returnString += str(item)
    print(returnString)

stringFromList([1,'string', 2.0])