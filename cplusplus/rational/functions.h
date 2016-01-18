// File: functions.h

namespace functions
{
  // Pre:  None
  // Post: A greeting specifying the nature of the program printed to standard output
  void greeting();

  // Pre:  None
  // Post: The numerator and denominator values for a rational have been extracted from the input and stored in 'n' and 'd'
  void get_rational_parts(int& n, int& d);
}
