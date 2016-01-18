// file: check_palindrome.cpp
// program: check if string is palindrome
// author: ivan

#include <iostream>  // std::cout
#include <string>    // std::string
#include <algorithm> // std::equal

// function prototype for palindrome test
bool isPalindrome(const std::string str);
bool anotherIsPalindrome(const std::string str);

bool isPalindrome(const std::string str)
{
    if(std::equal(str.begin(),str.begin() + str.size()/2,str.rbegin()))
        return true;
    else
        return false;
}

bool anotherIsPalindrome(const std::string str)
{
    if(str.empty())
        return false;
    int left = 0;
    int right = str.length() -1;
    while (left < right)
    {
     if(str[left] != str[right])
         return false;
     left++;
     right--;
    }

    return true;
}

int main()
{
    std::string str;
    std::cout << "Enter String: ";
    std::cin >> str;
    if (anotherIsPalindrome(str))
        std::cout << str << " is a palindrome\n";
    else
        std::cout << str << " is not a palindrome\n";

    return 0;
}
