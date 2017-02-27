nice = 0
mean = 0

def main():
    start()

def start():
    print("Hey! Welcome to nice or mean.")
    name = input("What's your name? : ")
    print("Hi, " + name + "!")
    print("In this game you will be greeted by several different people. You can treat them nicely or you can be mean.")
    print("At the end of the game your fate will be determined by how you have acted.")

    choice = input("Do you want to play? (type 'y'/'n') : ")
    if choice == "y":
        print("Great, use 'm' for mean and 'n' for nice!")
        begin()
    if choice == "n":
        print("K, bye...")
    elif choice != "y" or "n":
        print("Please enter 'y' or 'n'")


def begin():
    global nice
    global mean

    if nice > 2 :
        print("Nice job - you win! Everyone loves you and you live in a palace!")
        choice = input("Do you want to play again? (type 'y'/'n') : ")
        if choice == "y":
            print("Okay, let's go!")
            nice = 0
            mean = 0
            begin()
        if choice == "n":
            print("Say no more...later!")
            exit()
        elif choice != "y" or "n":
            print("Please enter 'y' or 'n'")

    if mean > 2:
        print("Too bad - game over! You now live in a van down by the river with no friends.")
        choice = input("Do you want to play again? (type 'y'/'n') : ")
        if choice == "y":
            print("Okay, let's go!")
            nice = 0
            mean = 0
            begin()
        if choice == "n":
            print("Off you go!")
            exit()
        elif choice != "y" or "n":
            print("Please enter 'y' or 'n'")

    pick = input("Someone approaches you to talk. Will you be nice or mean? (type 'm'/'n'): ")
    if pick == "n":
        print("They smile, wave, and walk away.")
        nice += 1
        print("You currently have " + str(nice) + " nice.")
        begin()

    if pick == "m":
        print("They frown, glare at you, and storm off.")
        mean += 1
        print("You currently have " + str(mean) + " mean.")
        begin()




start()
