import urllib2
from bs4 import BeautifulSoup

def extractMData(webpage):
    soup = BeautifulSoup(webpage)
    #get contents of the container div
    divContainer = soup.find("div", {"id":"container"})
    #Find all the divs with the class block
    divBlock = divContainer.findAll("div", {"class":"block"})
    info = divBlock[3]
    #Extract info_left and info_right divs
    getLeft = info.findAll("div", {"class":'info_left'})
    getRight = info.findAll("div", {"class":'info_right'})
    for i in range(0,len(getLeft)):
        textLeft = getLeft[i].get_text()
        textRight = getRight[i].get_text()
        print textLeft + ": " + textRight
    print ""
        
#open webpage
webpage = urllib2.urlopen("http://inadaybooks.com/justiceleague")

#convert to BeautifulSoup
soup = BeautifulSoup(webpage)

#get contents of the container div
divContainer = soup.find("div", {"id":"container"})
#get the contents of the fourth block class div
divBlock = divContainer.findAll("div", {"class":"block"})
#get the contents of the fourth separator class div
divSep = divBlock[3].findAll('div', {"class":"separator"})
#get all 'a' tag elements from the fourth separator class div
members = divSep[3].findAll("a")
#loop through members to open each page
for member in members:
    #grab the url
    href = member.get('href')
    #create url to open
    url = "http://inadaybooks.com/justiceleague/"+href
    #open url
    mPage = urllib2.urlopen(url)
    extractMData(mPage)


