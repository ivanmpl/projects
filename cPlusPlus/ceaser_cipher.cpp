// file: ceaser_cipher.cpp
// purpose: simple ceaser cipher shift
// author: ivan

#include <iostream>
#include <string>

using namespace std;

int main()
{
    using std::cout;
    using std::cin;
    using std::endl;

    cout << "This program takes in user string\n";
    cout << "and applys a ceaser shift of arbitrary chars/.\n";
    cout << "Press any key and ENTER to continue:  ";
    char c;
    cin >> c;
    cout << endl;
    cin.ignore();

    std::string text, original;
    cout << "Please enter a string of characters: ";
    getline (cin,text);
    original = text;

    int len = text.length();
    int i  = 0,j = 0;

    // replace with for
    while(j < len)
    {
        if(text[j] == 32)
        {
            text[j] == text[j];
        }

        j++;
    }

    int shift;
    bool input_check = true;
    do
    {
        cout << "Please enter shift number(shift > 0 and shift < 26): ";
        cin >> shift;
	if(shift < 26 && shift > 0)
	    input_check = false;

    } while(input_check);


    while (i < len)
    {

        text[i] = toupper(text[i]);
        text[i] = text[i] + shift;

        if (text[i] - shift == 32)
        {
            text[i] = text[i] - shift;
        }

        else if(
                ((text[i] - shift > 31) && (text[i] - shift < 65)
                || ((text[i] - shift > 90) && (text[i] - shift < 97))
                || ((text[i] - shift > 122) && (text[i] - shift < 128)))
                )
                {
                    text[i] = text[i] - shift;
                }

        else if (text[i] > 90)
        {
            if (text[i] == 32 + shift)
            {
                text[i] = text[i] - shift;
            }
            else
            {
                text[i] = (text[i] - 26);
            }
        }

        i++;
    }

    cout << "original string: " << original << endl;
    cout << "ciphered string: " << text << endl;

    return 0;
}
