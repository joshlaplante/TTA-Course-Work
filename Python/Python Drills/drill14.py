def printDaysBetweenDates():

    from datetime import date  
  
    firstdate = date(2014, 7, 2)  
    seconddate = date(2014, 7, 11)  
    diff = seconddate - firstdate
    print(diff.days)  
printDaysBetweenDates()