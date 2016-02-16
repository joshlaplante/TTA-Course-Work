def main():
    try:
        fh = open('xraven.txt')
    except IOError as e:
        print('could not open the file', e)
    else:
        for line in fh: print(line.strip())
    
    
if __name__ == "__main__": main()