// File: semantic.h

#include <string>
using namespace std;

#ifndef _mysemantic
#define _mysemantic

class Semantic
{
public:
    // Default Constructor
    Semantic();
    // Overloaded Constructor
    Semantic(unsigned int x_par, unsigned int y_par, unsigned int z_par, std::string pre_par = " ", std::string meta_par = " ");

    /********** Class functions *************/
    // Pre:  Class initialized
    // Post: String of semantic lass type versioning members string
    string toSemstring();

    /// Overloaded '==' operator for Semantic data type
    Semantic operator == (const Semantic& r) const;

private:
    // immutable static to data type
    const unsigned int x;  // major version
    const unsigned int y;  // minor version
    const unsigned int z;  // patch version
    const std::string preRelease;
    const std::string metaData;
};

#endif 
