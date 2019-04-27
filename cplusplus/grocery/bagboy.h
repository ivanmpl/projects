//File: bagboy.h
//class to implement the transaction of reading input and everything else

#ifndef bagboy_h
#define bagboy_h

#include "manager.h"

class bagboy : public manager
{
  public:
	void getInventory(char *pFilename);
	void printReceipt();
	void promptItems();
	void PriceCheck();
	friend class cashier; // set class cashier as friend--> access all data members/functions

  private:
	float price[100];
	std::string item[100];
	unsigned code[100];
	int counter;
	int pound[100];
	int x;
	int m;
};

#endif