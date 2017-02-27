text = ["This is a sentence.","So is this."]

try:
    for line in htext: #intentionally misspelled
        print(line)
except IOError as e:
    print("Something bad happened ({})".format(e))

print("after the error")
