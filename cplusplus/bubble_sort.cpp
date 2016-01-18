#include <iostream>
#include <vector>

using namespace std;

// function declaration
vector<int> bubble_sort(vector<int> int_list);
void display_list(vector<int> int_list);

// function implementation
vector<int> bubble_sort(vector<int> int_list)
{
    bool swapped = true;
    for(int i=int_list.size()-1;i>0 && swapped;i--)
    {
	swapped = false;
	for(int j=0;j<i;j++)
	{
	    // if the pair is out of order
	    if (int_list[j] > int_list[j+1])
	    {
		// swap the elements and remember change
		int temp = int_list[j];
		int_list[j] = int_list[j+1];
		int_list[j+1] = temp;
		swapped = true;
	    }
	}
    }

    return int_list;
}

void display_list(vector<int> the_list)
{
    for(int k=0;k<the_list.size();k++)
    {
	cout << the_list[k] << endl;
    }
}

int main()
{
    vector<int> sample_list;
    sample_list.push_back(5),sample_list.push_back(1);
    sample_list.push_back(4),sample_list.push_back(2);
    sample_list.push_back(8);
    display_list(bubble_sort(sample_list));
    return 0;
}
