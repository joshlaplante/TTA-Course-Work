import datetime

class Times():
    
    def __init__(self):
        #set opening and closing hours
        self.openTime = datetime.time(9,0,0)
        self.closeTime = datetime.time(21,0,0)
        #get current time in Portland
        self.Pnow = datetime.datetime.now()
        self.Ptime = datetime.time(self.Pnow.hour, self.Pnow.minute, self.Pnow.second)
        #print current time in Portland
        print 'The time in Portland is ' +  str(self.Ptime)
        print ''
        #get NY time difference
        self.NYtimediff = datetime.timedelta(hours = 3)
        #get NY time
        self.NYnow = self.Pnow + self.NYtimediff
        self.NYtime = datetime.time(self.NYnow.hour, self.NYnow.minute, self.NYnow.second)
        #get London time difference
        self.Ltimediff = datetime.timedelta(hours = 8)
        #get London time
        self.Lnow = self.Pnow + self.Ltimediff
        self.Ltime = datetime.time(self.Lnow.hour, self.Lnow.minute, self.Lnow.second)

    #create method to check if NY is open
    def checkNY(self):
        print 'The time in New York is ' + str(self.NYtime)
        if self.openTime < self.NYtime < self.closeTime:
            print 'The New York branch is open.'
            print ''
        else:
            print 'The New York branch is closed.'
            print ''
            

    #create method to see if London is open
    def checkL(self):
        print 'The time in London is ' + str(self.Ltime)
        if self.openTime < self.Ltime < self.closeTime:
            print 'The London branch is open.'
        else:
            print 'The London branch is closed.'


def main():
    go = Times()
    go.checkNY()
    go.checkL()


if __name__ == "__main__": main()
