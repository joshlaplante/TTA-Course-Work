def GetArea():
    import math
    radius = input("Enter the radius of a circle press enter to get its area: ")
    area = int(radius)**2 * math.pi
    print("The area is: ", area)

GetArea()