#include <iostream>

using namespace std;
int main()
{
	bool prime;

	// If number is less than 2 it's not prime ex.{-Z},0,1
	if (number < 2) 
		prime = false;
	// if number equals 2 than it is prime
	if (number == 2)
		prime = true;
	// if number is divisible by two with 0 remainder then not prime
    if(number % 2 == 0) 
    	prime = false;

    for(int i=3; (i*i) <= number; i+=2)
    {
        if(number % i == 0 ) 
        	prime = false;
    }

    prime = true;

}

/


// Contains prototypes for cout & cin
#include <iostream>

// Prototype for IsPrime function.
bool IsPrime(int);

// main function is always run first in a
// C++ program.

int main()
{	//Given:   nothing.
	//Results: Accepts a number and
	//		  indicates if it is prime.

	int number;
	
	cout << "Enter an integer (>1): ";
	cin >> number;
	
	if (IsPrime(number))
	{
		cout << number << " is prime." << endl;
	}
	else
	{
		cout << number << " is not prime." << endl;
	}

	// This is more convention than anything.
	return 0;
}

bool IsPrime(int number)
{	// Given:   num an integer > 1
	// Returns: true if num is prime
	// 			false otherwise.
	
	int i;
	
	for (i=2; i<number; i++)
	{
		if (number % i == 0)
		{
			return false;
		}
	}
	
	return true;	
}

*/