import time
global gizmos
gizmos = 0
global gold
gold = 0

def start():
    print("Hello and welcome!")
    name = input("What's your name?: ")
    print("Welcome,", name,'!')
    print("The objective of this game is to make gizmos. \n \
          After making the gizmos you will sell them.")
    choice = input("Do you want to play? (yes/no): ")
    if choice == "yes":
        print("Let's get started!")
        main()
    if choice == "no":
        print("K, bye...")

def main():
    global gizmos
    global gold
    if gold > 999:
        print("You're so rich! You win!")
        again = input("Do you want to play again? (yes/no): ")
        if again == "yes":
            print("Let's go again!")
            gizmos = 0
            gold = 0
            main()
        if again == "no":
            print("Well okay, Mister Moneybags!")
            break
    pick = input("Do you want to make a gizmo? (yes/no): ")
    if pick == "yes":
        time.sleep(2)
        print("You make a gizmo.")
        gizmos += 1
        print("You currently have", gizmos, "gizmos.")
        main()
    if pick == "no":
        sell = input("Do you want to sell your gizmos? (yes/no): ")
        if sell == "yes":
            print("You sell", gizmos, "gizmos.")
            gold = gizmos*100
            gizmos = 0
            print("You now have", gold, "gold.")
            main()

start()
