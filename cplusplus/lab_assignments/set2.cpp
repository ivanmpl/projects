#include <iostream>

int main()
{
    // Write a program which input three numbers and
    // display the largest number using ternary operator.
    int a, b, c;
    std::cout << "Enter 3 integers: ";
    std::cin >> a >> b >> c;

    std::cout << "The largest of the 3 integers is: ";

    // original implementation
    /*
    if (a > b && a > c)
    {
        std::cout << a;
    }
    elseif (b > a && b > c)
    {
        std::cout << b;
    }
    else
    {
        std::cout << c;
    }*/

    // conditional (ternary) operator implementation

    int largest = (a > b && a > c) ? a : (b > c) ? b : c;
    std::cout << largest;
    std::cout << std::endl;

    return 0;
}