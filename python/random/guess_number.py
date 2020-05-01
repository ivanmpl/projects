# sample guess number program for use in unit testing
import random
import sys


# function that takes number guess from standard input
def guess_number():
    user_guess = input("Please Enter a number between 1-10: ")
    actual_num = random.randint(1, 10)
    print("Your guess:", user_guess)
    print("actual number:", actual_num)
    if user_guess == actual_num:
        print("You guessed correctly")
    else:
        print("Sorry you guessed incorrectly")


# main() function
def main():
    #  Command line args are in sys.argv[1], sys.argv[2] ...
    #  sys.argv[0] is the script name itself and can be ignored
    if len(sys.argv) > 1:
        print("Hello ", sys.argv[1])
    else:
        print("Hello")

    print("This program allows a user to guess a random number")
    input("Press any key and Enter to Continue: ")
    guess_number()

    while True:
        answer = input("try again? y/n: ")
        if answer == 'y':
            guess_number()
        elif answer == 'n':
            exit()
        else:
            print("invalid response please try again")


# Standard boilerplate to call the guess_number() function
if __name__ == '__main__':
    main()
