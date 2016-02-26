import sqlite3
import time
import datetime
import numpy as np
import matplotlib.pyplot as plt
import matplotlib.dates as mdates

conn = sqlite3.connect('tutorial.db')
cursor = conn.cursor()

def tableCreate():
    cursor.execute("create table if not exists \
stuffToPlot(ID INT, unix REAl, datestamp TEXT, keyword TEXT, value REAL)")

tableCreate()

sql = "select * from stuffToPlot where keyword = ?"
wordUsed = 'Python Sentiment'

graphArray = []

for row in cursor.execute(sql,[(wordUsed)]):
        startingInfo = (str(row).replace("'","")).replace(")","").replace(")","")
        splitInfo = startingInfo.split(',')
        graphArrayAppend = splitInfo[2] + ',' + splitInfo[4]
        graphArray.append(graphArrayAppend)

datestamp, value = np.loadtxt(graphArray,delimiter = ',', unpack = True,
                converters = { 0: mdates.strpdate2num(' %Y-%m-%d %H:%M:%S')})

fig = plt.figure()

rect = fig.patch

ax1 = fig.add_subplot(1,1,1, axisbg = 'white')
plt.plot_date(x=datestamp, y = value, fmt = 'b-', label = 'value', linewidth = 2)
plt.show()

###this code doesn't seem to work in python 3, just python 2
