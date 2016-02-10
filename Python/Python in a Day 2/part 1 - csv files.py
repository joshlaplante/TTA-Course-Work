import os, csv

#path to the script
currentPath = os.path.dirname(os.path.abspath("__file__"))

#make spreadsheet path
outputCSV = currentPath + '/spreadsheet.csv'

#open the file
CSVFile = open(outputCSV, 'wb')

#create writer object
writer = csv.writer(CSVFile,delimiter = ',')

#data to go in csv
row_1 = [1, "Row 1", 123]
row_2 = [2, "Row 2", 456]
row_3 = [3, "Row 3", 789]

#combine rows
rows = [row_1,row_2,row_3]

#write rows to csv
for row in rows:
    writer.writerow(row)

CSVFile.close()



#path to the script
currentPath = os.path.dirname(os.path.abspath("__file__"))

#make spreadsheet path
inputCSV = currentPath + '/spreadsheet.csv'

#open the file in read mode
CSVFile = open(inputCSV, 'rb')

#create reader object
reader = csv.reader(CSVFile, delimiter = ',')

#add data to array
readerData = []
for row in reader:
    readerData.append(row)
print readerData
    
