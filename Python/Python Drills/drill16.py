def differenceFinder():
    numstring = input("Enter a number: ")
    num = int(numstring)
    if num < 17:
        print(17-num)
    else:
        print((num-17)*2)

differenceFinder()