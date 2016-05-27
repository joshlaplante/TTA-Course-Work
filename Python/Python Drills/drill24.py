def vowelCheck():
    letter = input("Enter one character: ")
    if letter in ['a','e','i','o','u']:
        print("Yup that's a vowel...")
    else:
        print("Nope, that's not a vowel...")

vowelCheck()