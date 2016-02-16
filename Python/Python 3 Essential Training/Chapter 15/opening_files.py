def main():
    f = open('raven.txt', 'r')
    for line in f:
        print(line, end = '')

if __name__ == "__main__": main()