#Our epic programmer dict from before
epic_programmer_dict = {'tim berners-lee': ['tbl@gmail.com',111],
                        'guido van rossum': ['gvr@gmail.com',222],
                        'linus torvalds': ['lt@gmail.com',333],
                        'larry page': ['lp@gmail.com',444],
                        'sergey brin': ['sb@gmail.com',555]}

def searchPeople(personsName):

    #looks up the persons name in the dictionary
    try:
        #Tries the following lines of text, if there are no errors then it runs
        personsInfo = epic_programmer_dict[personsName]
        print 'Name: ' + personsName.title()
        print 'Email: ' + personsInfo[0]
        print 'Number: ' + str(personsInfo[1])
    except:
        #If there are errors, then this runs instead
        print 'No information found for that name'

userWantsMore = True
while userWantsMore == True:
    #asks usre to input persons name
    personsName = raw_input('Please enter a name: ').lower()
    #run our new function searchPeople with what was typed in
    searchPeople(personsName)

    #see if user wants to search again
    searchAgain = raw_input('Search again? (y/n)')

    #look at what they reply and act accordingly
    if searchAgain == 'y':
        #userWantsMore stays True so loop repeats
        userWantsMore = True
    elif searchAgain == 'n':
        #userWantsMore turns to False, and stops loop
        userWantsMore = False
    else:
        #user inputs and invalid response, so we quit
        print "I don't understand what you mean, quitting search."
        userWantsMore = False
