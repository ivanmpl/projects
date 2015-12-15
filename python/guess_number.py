# sample program for use in unit testing

import random

def guessNumber():
	print ("Please Enter a number between 1-10:"),
	user_guess = raw_input()
	actual_num = random.randint(1, 10)
	print ("Your guess: %s")  % user_guess
	print ("actual number: %s") % actual_num
	if user_guess == actual_num:
		print ("You guessed correctly")
	else:
		print ("Sorry you guessed incorrectly")
		
print ("This program allows a user to guess a random number")
print ("Press any key and Enter to Continue: "),
raw_input()
guessNumber()

while True:
    print ("try again? y/n: "),
    answer = raw_input()
    if answer  == 'y':
	guessNumber()
    elif answer  == 'n':
	exit()
    else:
	print ("invalid response please try again")
	

