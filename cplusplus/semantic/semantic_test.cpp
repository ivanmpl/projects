// semantic_test.cpp
// This program test semantic string validity and api rules

#include "functions.h"
//#include "semantic.h"
#include <cstdlib>
#include <iostream>
#include <string>

using namespace std;

int main()
{
    // Greet user
    functions::greeting();

    // Get semantic string
    std::string input_string = functions::get_semantic_string();

    // Validation message
    std::string vmsg = "Error";

    // Validate string
    bool is_valid = false;

    // Semantic string sections to parse
    unsigned int x, y, z = 0;
    std::string meta, alpha = "";

    is_valid = functions::check_semantic_string(input_string,vmsg, x, y, z, meta, alpha);

    // Determine if semantic string is valid
    //input_string, vmessage, x, y, z, meta, alpha
    //if (valid)
    //{
    //   std::cout << "good" << endl;
    //Semantic s(x, y, z, meta, alpha);
    //cout << s.toSemstring() << endl;
    //}
    //else
    //{
    //   std::cout << vmessage << endl;
    //}

    return EXIT_SUCCESS;
}
