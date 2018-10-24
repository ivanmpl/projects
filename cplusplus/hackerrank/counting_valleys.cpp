#include <iostream>

using namespace std;

int countingValleys(int n, string s)
{
    int levelCounter = 0;
    int valleyCounter = 0;

    for (int i = 0; i < n; i++)
    {
        //TODO: Update function to show visual representation of path

        if (s[i] == 'U')
            valleyCounter++;
        else
            valleyCounter--;

        cout << i << ' ' << s[i] << ' ' <<  valleyCounter << ' ';
        if (valleyCounter ==  -1 && s[i] == 'D')
        {
            levelCounter++;
        }

        cout << levelCounter << endl;
    }

    return levelCounter;
}

int main()
{
    int NumberOfValleys = countingValleys(12, "DDUUDDUDUUUD");
    return 0;
}
