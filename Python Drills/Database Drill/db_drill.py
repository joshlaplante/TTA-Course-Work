import sqlite3

RosterValues = (('Jean-Baptiste Zorg','Human',122), \
                ('Korben Dallas','Meat Popsicle', 100), \
                ("Ak'not", 'Mangalore', -5))

with sqlite3.connect(':memory:') as connection:

    cursor = connection.cursor()

    cursor.executescript("""
                    DROP TABLE IF EXISTS Roster;
                    CREATE TABLE Roster(Name TEXT, Species TEXT, IQ INT);""")
    cursor.executemany("INSERT INTO Roster VALUES(?,?,?)",RosterValues)

    
def updateSpecies():
    cursor.execute("UPDATE Roster SET Species = 'Human' \
                    WHERE Name = 'Korben Dallas'")

updateSpecies()

def getHumans():
    cursor.execute("SELECT Name,IQ FROM Roster WHERE Species = 'Human'")
    for row in cursor.fetchall():
        print(row)

getHumans()
