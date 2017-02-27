def colorComparison():
    colorList1 = ["White", "Black", "Red"]
    colorList2 = ["Red", "Green"]
    for item in colorList1:
        if item not in colorList2:
            print(item)

colorComparison()