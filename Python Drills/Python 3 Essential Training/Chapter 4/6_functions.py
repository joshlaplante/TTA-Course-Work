def main():
    func(1)
    func()
    func(3)
    
def func(a=7):
    for i in range(a, 10):
        print(i, end = ' ')
    print()
    
if __name__ == "__main__": main()