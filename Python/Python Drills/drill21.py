def evenOrOdd():
    numString = input("Enter a number to see if it's even or odd: ")
    num = int(numString)
    if num % 2 == 0:
        print("That number is even.")
    else: 
        print("That number is odd.")

evenOrOdd()