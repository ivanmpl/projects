//File: functions.h
//interface file: contains function prototypes for greeting ,display and repeat functions

#ifndef functions_h
#define functions_h

namespace functions
{
void greeting();	 // Pre:None Post: A greeting specifying the nature of the program
void menu();		 // Pre:None Post: continues through program if user wishes
void again(bool &d); // Pre:The User already shopped once Post:user wants to shop again if true loop
} // namespace functions

#endif // !functions_h
