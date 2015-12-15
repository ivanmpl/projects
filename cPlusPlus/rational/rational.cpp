// rational.cpp

#include "rational.h"
#include <iostream>
#include <cmath>

rational::rational():num(1), den(1)
{ }

rational::rational(int x, int y):num(x), den(y)
{ 
    reduce();
}

int rational::get_num() const
{
    return num;
}

void rational::set_num(int x)
{
    num = x;
    reduce();
}

void rational::set_den(int x)
{
    den=x;
    reduce();
}

rational rational::operator * (const rational& r) const
{
    rational temp(this->num*r.num, this->den*r.den);
    return temp;
}

rational rational::operator / (const rational& r) const
{
    rational temp(this->num*r.den, this->den*r.num);
    return temp;
}

rational rational::operator - (const rational& r) const
{
    int new_num = num*r.den - den*r.num;
    int new_den = den * r.den;
    return rational(new_num, new_den);
}

rational rational::operator + (const rational& r) const
{
    int new_num = this->num*r.den + this->den*r.num;
    int new_den = this->den*r.den;
    return rational(new_num, new_den);
}

bool operator == (const rational& r1, const rational& r2)
{
    return (r1.num*r2.den)== (r1.den*r2.num);
}

void rational::display() const
{
    if((num<0 && den<0) || (num>=0 && den>0))
	std::cout << '(' << num << ',' << den << ')';
    else
	std::cout << "-(" << std::abs(num) << ',' << std::abs(den) << ')';
}

void rational::reduce()
{
    int common = gcd(num,den);
    num /= common;
    den /= common;
}

int rational::gcd(int a, int b)
{
    int temp;
    while(b!=0)
    {
	temp=b;
	b=a%b;
	a=temp;
    }
    return a;
}
	

    
