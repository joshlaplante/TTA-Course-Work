def addIfInt(obj1,obj2):
    if type(obj1) is int and type(obj2) is int:
        print(obj1+obj2)
    else:
        print("One or both are not integers")


addIfInt(2,1)
addIfInt(2,'one')