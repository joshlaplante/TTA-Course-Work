def absFinder():
    numstring = input("Enter a number: ")
    num = int(numstring)
    if abs(1000-num) <= 100:
        print("This number is within 100 of 1000")
    elif abs(2000-num) <= 100:
        print("This number is within 100 of 2000")
    else:
        print("This number isn't special.")
absFinder()