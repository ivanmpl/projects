// file: prime_test.cpp
// program: primality test of user inputed integer
// author: ivan

#include <iostream>

// Prototype for IsPrime function.
bool IsPrime(int);

// PRE: takes integer as argument for primality test
// POST: returns true if integer is prime otherwise false
bool IsPrime(int number)
{
    // If number is less than 2 it's not prime i.e.{-Z},0,1
    if (number < 2)
        return false;
    // if number equals 2 than it is prime
    if (number == 2)
        return true;
    // if number is divisible by two with 0 remainder then not prime
    if(number % 2 == 0)
    	return false;
    // check if number is divisible by or odd; previous flow of control removed remaining sets 
    for(int i=3; (i*i) <= number; i+=2)
    {
        if(number % i == 0)
        	return false;
    }
	return true;
}

int main()
{
	using std::cout;
	using std::cin;
	using std::endl;

	int number;
	cout << "Enter an integer: ";
	cin >> number;
	if (IsPrime(number))
	{
		cout << number << " is prime." << endl;
	}
	else
	{
		cout << number << " is not prime." << endl;
	}

	return 0;
}
