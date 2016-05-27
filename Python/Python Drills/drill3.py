def getDateTime():
    import datetime  
    now = datetime.datetime.now()  
    print ("Current date and time : ")  
    print (now.strftime("%m/%d/%Y %H:%M:%S"))  

getDateTime()
