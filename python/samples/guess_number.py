# sample guess number program for use in unit testing
import random
import sys

# sample function that takes number guess from standard input
def guessNumber():
    print("Please Enter a number between 1-10:")
    user_guess = input()
    actual_num = random.randint(1, 10)
    print("Your guess: ", user_guess)
    print("actual number: ", actual_num)
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
	print("Press any key and Enter to Continue: ")
	input()
	guessNumber()

	while True:
		print("try again? y/n: "),
		answer = input()
		if answer == 'y':
			guessNumber()
		elif answer == 'n':
			exit()
		else:
			print("invalid response please try again")

# Standard boilerplate to call the guessNumber() function
if __name__ == '__main__':
	main()
