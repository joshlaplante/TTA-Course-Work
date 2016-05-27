def IsStringThing():
    stringToCheck = input("Enter a string: ")
    if len(stringToCheck) >= 2 and stringToCheck[0:2] == 'Is':
        print(stringToCheck)
    else:
        print("Is" + stringToCheck)

IsStringThing()