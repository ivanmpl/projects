// File: rational.h

#ifndef _myrational
#define _myrational

class rational
{
public:
    // Constructors
    rational();
    rational(int, int);

    /********* Constant functions *************/
    // Pre:  None
    // Post: The rational numerator is returned
    int get_num() const;

    // Pre:  None
    // Post: The rational denominator is returned
    int get_den() const { return den; }

    // Pre:  None
    // Post: The rational is displayed on the standard output
    void display() const;

    /**********  Modifiers *******************/
    // Pre:  None
    // Post: The rational numerator has been set to 'n'
    void set_num(int n);

    // Pre:  None
    // Post: The rational denominator has been set to 'd'
    void set_den(int d);

    /********** Class operators *************/
    // Pre:  None
    // Post: A rational that is the sum of 'r' and the invoking object has been returned
    rational operator + (const rational& r) const;

    // Pre:  None
    // Post: A rational that is the difference of 'r' and the invoking object has been returned
    rational operator - (const rational& r) const;

    // Pre:  None
    // Post: A rational that is the product of 'r' and the invoking object has been returned
    rational operator * (const rational& r) const;

    // Pre:  None
    // Post: A rational that is the ratio of 'r' and the invoking object has been returned
    rational operator / (const rational& r)const;

    /***************** Friend *************/
    // Pre:  None
    // Post: Rationals 'r' and 's' are compared for equality. True is return is they are the
    // same, and false is returned otherwise
    friend bool operator == (const rational& r, const rational& s);

private:
    void reduce();
    int gcd(int,int);
    int num, den;
};

#endif
