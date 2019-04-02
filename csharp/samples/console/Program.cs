using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IOManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sampleQuotes.txt";
            // simple file read and display by line
            //ReadFileDisplayLine(fileName);
            // more complex function with diverse methods
            IEnumerable<string> lines = ReadFromFile(fileName);
            // iterate through strings 
            foreach( var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        /// Read and Echo file
        static IEnumerable<string> ReadFromFile(string fileName)
        {
            string line;
            using (System.IO.StreamReader reader = File.OpenText(fileName))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    yield return line;
                }
            }
        }



        /// Read file and display it line by line
        static void ReadFileDisplayLine(string fileName)
        {
            // line counter
            int count = 0;
            // initial line
            string line;
            // bytestream for file 
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);

            // read line until end of input stream via iterator method
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                count++;
            }

            file.Close();
            Console.WriteLine($"{fileName} contains {count} lines");
        }

    }
}

