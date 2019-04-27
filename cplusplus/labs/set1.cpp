#include <iostream>

int main()
{

    // Write a program to print HELLO WORLD on screen.
    std::cout << "HELLO WORLD" << std::endl;

    // Write a program to display the following output using a single cout statement.
    /**
         Subject            Marks
        Mathematics     90 
        Computer         77 
        Chemistry        69 **/

    std::cout << "Subject"
              << "\tMarks"
              << "\nMathematics"
              << "\t90"
              << "\nComputer"
              << "\t77"
              << "\nChemistry"
              << "\t69" << std::endl;

    // Write a program which accept two numbers and print their sum.
    int a1, a2, a3 = 0;
    std::cout << "Enter a number: ";
    std::cin >> a1;
    std::cout << "Enter a second number: ";
    std::cin >> a2;
    a3 = a1 + a2;
    std::cout << "The sum of both numbers is: " << a3 << std::endl;

    // Write a program which accept temperature in Farenheit and print it in Celsius
    float f, c = 0;
    std::cout << "Enter a temperature in Farenheit: ";
    std::cin >> f;
    c = 5 * (f - 32) / 9;
    std::cout << "The temperature in Celsius is: " << c << std::endl;

    return 0;
}
