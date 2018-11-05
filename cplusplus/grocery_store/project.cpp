// File: project.cpp
// Driver file implements the flow of control and calls functions in or out classes

#include <cstdlib>
#include <fstream>
#include <string>
#include "functions.h"
#include "manager.h"
#include "cashier.h"
#include "bagboy.h"

int main(int argc, char *argv[])
{

	if (argc <= 1) // check argument from command line if <=1 exit
	{
		std::cout << "Usage: " << argv[0] << " <Filename>" << std::endl;
		exit(1);
	}

	char *pFilename = argv[1]; // pass command line argument as reference
	functions::greeting();	 // greet user
	bool cart = true;		   // set defualt true
	while (cart)			   // if true:continue shopping else:end loop
	{
		functions::menu(); // display menu
		bagboy paper;	  // create class bagboy object
		manager pen;
		cashier cash;
		paper.getInventory(pFilename); // read input from file
		paper.promptItems();		   // ask user for amount of items
		paper.printReceipt();		   // display receipt
		paper.PriceCheck();			   // calculate the total price of all items
		cash.totalprice();			   // display a message in receipt
		functions::again(cart);		   // if true recycle menu else end
	}
	return 0;
}