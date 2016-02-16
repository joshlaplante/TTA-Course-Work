def main():
    testfunc(5,6,7,8,9,one = 1, two = 2, four = 42)
    
def testfunc(this, that, other, *args, **kwargs):
    print( this, that, other, args, \
           kwargs['one'], kwargs['two'], kwargs['four'])
    
if __name__ == "__main__": main()