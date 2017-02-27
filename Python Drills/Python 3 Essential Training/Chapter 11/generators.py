def main():
    print("This is the functions.py file")
    for i in inclusive_range(5,25, 3):
        print (i, end = ' ')
    
    
def inclusive_range(*args):
    numargs = len(args)
    if numargs <1:
        raise TypeError('requires at least one argument')
    if numargs == 1:
        stop = args[0]
        start = 0
        step = 1
    elif numargs == 2:
        (start,stop) = args
        step = 1
    elif numargs == 3:
        (start,stop,step) = args
    else: 
        raise TypeError('inclusive_args expects at most 3 arguments')
    i = start
    while i <= stop:
        yield i
        i+=step
if __name__ == "__main__": main()