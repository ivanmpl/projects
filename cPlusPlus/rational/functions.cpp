// File: functions.cpp

#include "functions.h"
#include <iostream>

namespace functions
{
    void greeting()
    {
	using std::cout;
	using std::cin;
	using std::endl;

	cout << "This program demonstrations various operations on\n";
	cout << "rational numbers, including +, -, * and /.\n";
	cout << "Press any key and ENTER to continue:  ";
	char c;
	cin >> c;
	cout << endl;
    }

    void get_rational_parts(int& n, int& d)
    {
	bool input_check;
	do
	{
	    std::cout << "Enter integers for a rational numerator: ";
	    std::cin >> n;
		std::cout << "Enter integers for a rational denominator: ";
		std::cin >> d;
	    if(!std::cin)
	    {
		std::cin.clear();
		while(std::cin.peek() != '\n')
		    std::cin.get();
		std::cin.get();
		input_check = false;
	    }
	    else input_check = true;
	}  while(input_check == false);
    }
}
