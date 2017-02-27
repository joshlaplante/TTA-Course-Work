def printCalendar():
    import calendar  
    year = int(input("Enter the year : "))  
    month = int(input("Enter the month (Numeric) : "))  
    print(calendar.month(year, month))  

printCalendar()