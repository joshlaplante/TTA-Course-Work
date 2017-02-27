
def main():
    text = ["this is a line of text 01", \
            "this is a line of text 02", \
            "this is a line of text 03", \
            "this is a line of text 04", \
            "this is a line of text 05"]
    
    for index, line in enumerate(text):
        print(index, line)
        
    string = "This is a string"
    for i, ch in enumerate(string):
        if ch == 's':
            print('index {} is an s'.format(i))
        
if __name__ == "__main__": main()