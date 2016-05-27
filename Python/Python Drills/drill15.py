def getVolumeOfSphere():
    import math
    radius = input("Enter a radius for a sphere to get its volume: ")
    volume = 4/3 * int(radius)**3
    print("The volume of the sphere is:", volume)

getVolumeOfSphere()