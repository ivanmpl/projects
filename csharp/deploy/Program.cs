using System;
using System.Text.RegularExpressions;
using Figgle;

namespace Applications.ConsoleApps
{
    public class ConsoleParser
    {
        public static void Main()
        {
            Console.WriteLine("Enter any text, followed by <Enter>:\n");
            String text = Console.ReadLine();
            ShowWords(text);
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();
        }

        private static void ShowWords(String s)
        {
            String pattern = @"\w+";
            var matches = Regex.Matches(s, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("\nNo words were identified in your input.");
            }
            else
            {
                Console.WriteLine($"\nThere are {matches.Count} words in your string:");
                for (int ctr = 0; ctr < matches.Count; ctr++)
                {
                    //$"   #{ctr,2}: '{matches[ctr].Value}' at position {matches[ctr].Index}";
                    string word = $"{matches[ctr].Value}";
                    Console.WriteLine(FiggleFonts.Standard.Render(word));
                }
            }
        }
    }
}