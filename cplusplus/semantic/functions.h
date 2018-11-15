// File: functions.h

#include <string>

namespace functions
{
// Pre:  None
// Post: A greeting specifying the nature of the program printed to standard output
void greeting();

// Pre:  None
// Post: Get semantic string from standard input
std::string get_semantic_string();

// Pre:  String to evaluate
// Post: Check if semantic string is valid (optional error message)
bool check_semantic_string(std::string semstring, unsigned int &x, unsigned int &y, unsigned int &z, std::string meta, std::string alpha);

} // namespace functions
