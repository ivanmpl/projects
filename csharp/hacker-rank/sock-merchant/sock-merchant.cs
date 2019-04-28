using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int num_socks = Int32.Parse(Console.ReadLine());
        string[] sock_c = Console.ReadLine().Split(' ');

        List<int> sock_color = new List<int>();
        for (int i = 0; i < num_socks; i++)
        {
            sock_color.Add(Int32.Parse(sock_c[i]));
        }
        colors.Sort();

        int curr_color = colors[0];
        int count = 0;
        for (int i = 1; i < num_socks; i++)
        {
            if (colors[i] == curr_color)
            {
                count++;
                i++;
                if (i < num_socks)
                    curr_color = colors[i];
            }
            else
            {
                curr_color = colors[i];
            }
        }
        Console.WriteLine(count);
    }
}