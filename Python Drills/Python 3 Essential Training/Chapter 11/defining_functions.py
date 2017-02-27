def main():
    testfunc(42, 12, 33)
    
def testfunc(number, another = 52, onemore = 32):
    print('This is a test function', number, another, onemore)
    
if __name__ == "__main__": main()