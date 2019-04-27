//File: functions.cpp
//implementation file: implement functions to display greeting and display menu

#include "functions.h"
#include <iostream>
#include <fstream>
#include <cstdlib>

namespace functions
{
void greeting()
{
	using std::cin;
	using std::cout;
	using std::endl;

	cout << "This Program simulates a shopping excursion at a supermarket.\n"; // add more details
	cout << "Press any key and ENTER to continue: ";
	char c;
	cin >> c;
	cout << endl;
}

void menu()
{

	using std::cin;
	using std::cout;
	using std::endl;
	char x;

L1:
	cout << "Welcome to the Supermarket!\n"; //if false exit program if true continue
	cout << "Do u want to go shopping? (y/n): ";
	cin >> x;

	if (x == 'y') // if response is y continue
	{
		return;
	}
	else if (x == 'n') // if x exit
	{
		cout << "GoodBye... \n";
		exit(1);
	}
	else // if other reloop response
	{
		cout << "Error not a valid input try again\n";
		goto L1;
	}
}

void again(bool &d)
{
L2:
	char c;
	std::cout << "Do u want to go shopping Again(y/n): ";
	std::cin >> c;

	if (c == 'y')
	{
		d = true;
		return;
	}
	else if (c == 'n')
	{
		std::cout << "Have a Good Day!" << std::endl;
		d = false;
		return;
	}
	else
	{
		std::cout << "Error not a valid input try again\n";
		goto L2;
	}
}
} // namespace functions
