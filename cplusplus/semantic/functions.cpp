// File: functions.cpp

#include "functions.h"
#include <iostream>
#include <string>
#include <locale>

namespace functions
{

void greeting()
{
	using std::cin;
	using std::cout;
	using std::endl;

	cout << "This program demonstrations various operations on\n";
	cout << "semantic versioning, including type conversion, parsing, comparison.\n";
	cout << "Press any key and ENTER to continue:  ";
	char c;
	cin >> c;
	cout << endl;
	cin.ignore();
}

std::string get_semantic_string()
{
	std::string line;
	std::cout << "Enter valid semantic version string: ";
	std::getline(std::cin, line);
	return line;
}

bool check_semantic_string(std::string semstring, unsigned int &x, unsigned int &y, unsigned int &z, std::string meta, std::string alpha)
{
	x = 1;
	y = 2;
	z = 3;
	// string is empty; ignore
	if (semstring.empty())
	{
		//vmessage = "";
		return false;
	}

	std::size_t in_str = semstring.find(".");
	if (in_str != std::string::npos)
	{
		//vmessage = "found ";
		return false;
	}
	else
	{
		//vmessage = "invalid";
		return false;
	}

	return false;
}

} // namespace functions
