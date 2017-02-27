class Duck:
    def __init__(self, **kwargs):
        self.variables = kwargs
        
    def quack(self):
        print('Quaacccck!')
    
    def walk(self):
        print('Walks like a duck')

    def get_variable(self, k):
        return self.variables.get(k,None)
    
    def set_variable(self, k, v):
        self.variables[k] = v
        
def main():
    donald = Duck()
    donald.quack()
    donald.walk()
   
if __name__ == "__main__": main()