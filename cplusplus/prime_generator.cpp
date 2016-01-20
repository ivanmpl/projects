// file: prime_generator.cpp
// author: ivan

#include <iostream>

void primeGenerator(int n);

void primeGenerator(int n)
{
    int i,j;
    bool prime;
    
    std::cout << "2 ";
    
    for(i=3;i<=n;i++)
    {
        prime = true;
        for(j=2; j<i; j++)
        {
            if(i%j == 0)
            {
                prime = false;
                break;
            }
        }
        if(prime)
            std::cout << i << " ";
    }
    
    std::cout << "\n";
}

int main()
{
    int num;
    std::cout << "Enter upper bound for primes: ";
    std::cin >> num;
    primeGenerator(num);
    return 0;
}
