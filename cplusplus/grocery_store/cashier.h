//File: cashier.h
//class to implement the transaction of reading input

#include "manager.h"

#ifndef cashier_h
#define cashier_h

class cashier : public manager
{
  public:
	cashier(); //defualt constructor
	void totalprice();

  private:
	float CreditCard;
};

#endif // !cashier_h
