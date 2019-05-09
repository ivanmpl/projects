using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace linq_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // data source samples
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            List<string> dinosaurs = new List<string>();
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");

            // data source from an XML document.
            XElement contries = XElement.Load(@"sample.xml");

            // anonymous types
            var anon = new { Age = 21, Name = "john" };

            // query creation
            IEnumerable<int> evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // force immediate execution
            List<int> evenNumList =
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToList();

            IEnumerable<string> longDinoName =
                from dino in dinosaurs
                where dino.Length > 11
                select dino;

            IEnumerable<XElement> elements =
                from el in contries.Elements("country")
                where (int)el.Element("year") > 2010
                select el;

            var els =
                from country in contries.Elements("country")
                select new {country.Element("rank").Value};


            // query execution
            int evenNumCount = evenNumQuery.Count();

            foreach (int num in evenNumQuery)
            {
                System.Console.Write(num + " ");
            }
            System.Console.WriteLine();

            foreach (string dino in longDinoName)
            {
                System.Console.Write(dino + " ");
            }
            System.Console.WriteLine();

            foreach (XElement item in elements)
            {
                System.Console.WriteLine(item.Element("rank").Value);
            }

            System.Console.WriteLine(anon.Age + " " + anon.Name);

            foreach (var el in els)
            {
                System.Console.WriteLine(el.Value);
            }



        }
    }
}
