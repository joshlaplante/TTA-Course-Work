class Egg:
    def __init__(self,type = "fried"):
        self.type = type
        
    def whatType(self):
        return self.type
    
def main():
    fried = Egg()
    scrambled = Egg('scrambled')
    print(scrambled.whatType())

if __name__ == "__main__": main()