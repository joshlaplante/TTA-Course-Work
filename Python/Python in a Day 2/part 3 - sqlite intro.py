import sqlite3

#connect to database 'simpsons.db'
conn = sqlite3.connect('simpsons.db')

##Create table named simpson_info (commented out because table already created)
#conn.execute("CREATE TABLE SIMPSON_INFO( \
#    ID INTEGER PRIMARY KEY AUTOINCREMENT, \
#    NAME TEXT, \
#    GENDER TEXT, \
#    AGE INT, \
#    OCCUPATION TEXT \
#    );")

##Add bart simpson to table (commented out because already added)
#conn.execute("INSERT INTO SIMPSON_INFO \
#    (NAME, GENDER, AGE, OCCUPATION) VALUES \
#   ('Bart Simpson', 'Male', 10, 'Student')");

##Add homer simpson to table (commented out because already added)
#conn.execute("INSERT INTO SIMPSON_INFO \
#    (NAME, GENDER, AGE, OCCUPATION) VALUES \
#   ('Homer Simpson', 'Male', 40, 'Nuclear Plant')");

##Add lisa simpson to table (commented out because already added)
#conn.execute("INSERT INTO SIMPSON_INFO \
#    (NAME, GENDER, AGE, OCCUPATION) VALUES \
#   ('Lisa Simpson', 'Female', 8, 'Student')");

##Delete rows with ID=2 to remove duplicate bart simpson
##(commented out because already removed)
#conn.execute("DELETE from SIMPSON_INFO where ID=2")

#Make homer simpson age 41
conn.execute("UPDATE SIMPSON_INFO \
    set AGE = 41 where NAME = 'Homer Simpson'")

#Save changes
conn.commit()

#Print number of changes to database
changes = conn.total_changes
print "Number of changes:", changes

#Get data from database (commented out because data already viewed)
cursor = conn.execute("SELECT * from SIMPSON_INFO")
#Get data from cursor
rows = cursor.fetchall()
print rows

##Delete the table (commented out to save table)
#conn.execute("DROP TABLE SIMPSON_INFO")


