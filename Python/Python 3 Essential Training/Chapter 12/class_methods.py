class Duck:
    def __init__(self, value):
        self._v = value
        
    def quack(self):
        print('Quaacccck!', self._v)
    
    def walk(self):
        print('Walks like a duck', self._v)

def main():
    donald = Duck(42)
    frank = Duck(1)
    donald.quack()
    donald.walk()
    frank.quack()
    frank.walk()
    
if __name__ == "__main__": main()