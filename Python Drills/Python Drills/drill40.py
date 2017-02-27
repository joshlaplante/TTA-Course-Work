def distanceFormula(coordList1, coordList2):
    import math
    x = coordList1[0] - coordList2[0]
    y = coordList1[1] - coordList2[1]
    print(math.sqrt(x**2 + y**2))

distanceFormula([0,0],[3,4])