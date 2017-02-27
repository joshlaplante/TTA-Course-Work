def easyNumberSorter():
    unsortedList = [67, 45, 2, 13, 1, 998]
    sortedList = sorted(unsortedList)
    print("before: \n",unsortedList)
    print("after: \n",sortedList)


def myNumberSorter():
    unsortedList = [67, 45, 2, 13, 1, 998]
    workingList = [67, 45, 2, 13, 1, 998]
    sortedList = []
    while len(workingList) >0:
        num = min(workingList)
        sortedList.append(num)
        workingList.remove(num)
    print("before: \n",unsortedList)
    print("after: \n",sortedList)


myNumberSorter()
