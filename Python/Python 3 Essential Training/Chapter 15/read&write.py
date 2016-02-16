def main():
    buffersize = 100
    inf = open('raven.txt', 'r')
    outf = open('big.txt', 'w')
    buffer = inf.read(buffersize)
    while len(buffer):
        outf.write(buffer)
        print('.', end = '')
        buffer = inf.read(buffersize)
    print('Done.')

if __name__ == "__main__": main()