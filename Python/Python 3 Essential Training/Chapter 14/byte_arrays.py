def main():
    file = open('utf8.txt', 'r', encoding = 'utf_8')
    fileout = open('utf8.html', 'w')
    outbytes = bytearray()
    for line in file:
        for c in line:
            if ord(c) > 127:
                outbytes += bytes('&#{:04d};'.format(ord(c)), \
                                  encoding = 'utf_8')
            else: 
                outbytes.append(c)
    outstring = str(outbytes, encoding = 'utf_8')
    print(outstring, file = fileout)
    print(outstring)
    print('Done.')
if __name__ == "__main__": main()