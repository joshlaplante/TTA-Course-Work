def main():
    testfunc(1,2,3, 1, 1, 1)
    
def testfunc(this, that, other, *args):
    print(this, that, other)
    for n in args: print(n, end = ' ')
    
if __name__ == "__main__": main()