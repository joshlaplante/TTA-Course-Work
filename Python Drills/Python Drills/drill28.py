def evenNumberFinder(numList):
    for num in numList:
        if num == 237:
            break
        elif num % 2 == 0:
            print(num)

evenNumberFinder([1,2,3,4,5,237,6,7,8])