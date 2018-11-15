// semantic.cpp

#include "semantic.h"
#include <iostream>
#include <string>
#include <cmath>


using namespace std;

Semantic::Semantic(): x(0),y(0), z(0)
{ }

Semantic::Semantic(unsigned int x_par, unsigned int y_par, unsigned int z_par, std::string pre_par, std::string meta_par): x(x_par),y(y_par),z(z_par),preRelease(pre_par),metaData(meta_par)
{ }


std::string Semantic::toSemstring()
{
    return std::to_string(x) + "." + std::to_string(y) + "." + std::to_string(z) + preRelease + metaData;

}