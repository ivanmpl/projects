// rational_test.cpp
// This program tests a rational abstract data type which is the ratio of two integers.
// rationals numbers are inputted from keyboard tested with operators addition, subtraction, multiplication and division.

#include "functions.h"
#include "rational.h"
#include <cstdlib>
#include <iostream>

int main()
{
    // Greet user
    functions::greeting();

    // Get values to create two rationals
    int n=0, d=0;
    functions::get_rational_parts(n,d);
    rational r1(n,d);
    functions::get_rational_parts(n,d);
    rational r2(n,d);

    // Display the rationals
    std::cout << "r1 = ";
    r1.display();
    std::cout << "\nr2 = ";
    r2.display();

    // Compute rational +, -, *, and / on the two rationals and display results
    std::cout << "\nr1 + r2 = ";
    (r1+r2).display();
    std::cout << "\nr1 - r2 = ";
    (r1-r2).display();
    std::cout << "\nr1 * r2 = ";
    (r1*r2).display();
    std::cout << "\nr1 / r2 = ";
    (r1/r2).display();
    std::cout << '\n';

    return EXIT_SUCCESS;
}
