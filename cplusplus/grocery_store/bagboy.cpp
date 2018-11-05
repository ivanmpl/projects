//File: cashier.h
//class to implement the transaction of reading input

#include "bagboy.h"
#include <cstdlib>
#include <iostream>
#include <string>
#include <sstream>
#include <new>

void bagboy::promptItems()
{
	using std::cin;
	using std::cout;
	using std::endl;

L3:
	cout << "Enter the number of items you want to buy?: ";
	cin >> x;
	m = x;
	cout << endl;

	if ((x <= 10) && (x >= 5))
	{
		return;
	}

	if (x > 10)
	{
		cout << "Error value is too big please try again\n";
		goto L3;
	}

	if (x < 5)
	{
		cout << "Error value is too small please try again\n";
		goto L3;
	}

	else
	{
		cout << "Error not a valid entry try again\n";
		goto L3;
	}
}

void bagboy::printReceipt()
{
	using namespace std;
	int y = 0;
	cout << "------------------------------------\n";
	cout << "------- Thanks for Shopping --------\n";
	cout << "------- Club ID 001-235-813 --------\n";
	while (x > 0)
	{
		int RandIndex = (rand() % counter);
		cout << "Purchased: " << item[RandIndex] << endl;
		cout << "code: " << code[RandIndex] << endl;
		cout << "price: " << price[RandIndex] << endl;
		x--;
	}
	cout << "--------- You Saved $0.0  ----------\n";
	cout << "------------------------------------\n";
}

void bagboy::getInventory(char *pFilename)
{
	using namespace std;

	const int A = 100;
	ifstream inputstream(pFilename);
	string line;
	int i = 0;

	if (inputstream.fail())
	{
		cout << "We will be closed for inventory\n";
		inputstream.close();
		exit(1);
	}

	while (getline(inputstream, line) && i < A)
	{
		istringstream s(line);
		char d;
		s >> code[i] >> d;
		getline(s, item[i], '|');
		s >> price[i];
		counter = i;
		++i;
	}
	inputstream.close();
}

void bagboy::PriceCheck()
{
	using namespace std;
	int l, n;
	int *p;
	l = m;
	p = new (nothrow) int[l];
	if (p == 0)
	{
		cout << "Error: memory could not be allocated";
		exit(1);
	}
	else
	{
		for (n = 0; n < l; n++)
		{
			p[n] = 0;
		}
		cout << "-------Total Cost: $";
		cout << "34.50";
		cout << "-----------\n";
		delete[] p;
	}
}