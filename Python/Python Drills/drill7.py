def getExtension():
    filename = input("Enter a filename: ")
    file = filename.split(".")
    print(file[-1])
getExtension()
