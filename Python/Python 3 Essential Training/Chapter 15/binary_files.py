def main():
    buffersize = 1000
    inf = open('8bit.jpg', 'rb')
    outf = open('new8bit.jpg', 'wb')
    buffer = inf.read(buffersize)
    while len(buffer):
        outf.write(buffer)
        print('.', end = '')
        buffer = inf.read(buffersize)
    print()
    print('Done.')

if __name__ == "__main__": main()