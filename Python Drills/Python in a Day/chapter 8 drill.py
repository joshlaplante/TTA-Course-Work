#Create list of epic programmers
epic_programmer_list = ["Tim Berners-Lee",
                        "Guido van Rossum",
                        "Linus Torvalds",
                        "Larry Page",
                        "Sergey Brin"]

#Add myself to the end of the list
epic_programmer_list.append("Me")

#Looping through each item in epic_programmer_list
for programmer in epic_programmer_list:
    #Print the programmer's name to console
    print "An epic programmer: " + programmer



#Create a list of numbers
number_list = [1,2,3,4,5]
empty_number_list = []
#Loop through each number in number_list
for x in number_list:
    #Append each number to the power of 2 to the empty_number_list
    empty_number_list.append(x**2)
print empty_number_list
