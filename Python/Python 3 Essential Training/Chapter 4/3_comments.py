def main():
    for n in primes(): # generate a list of prime numbers
        if n > 100: break
        print(n)
        
def isPrime(n):
    if n == 1: # 1 is never prime
        return False
    for x in range(2,n):
        if n % x == 0:
            return False # found a divisor, not prime
    else:
         return True

def primes(n = 1):
    while(True):
        if isPrime(n): yield n #yield makes this a generator
        n+= 1


if __name__ == "__main__": main()