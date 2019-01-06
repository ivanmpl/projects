using System;

namespace refresh
{

    public class Fruit
    {
        public Fruit(string name) => Name = name;
        public string Name { get; }

        public override string ToString() => Name;
    }

    public enum Unit { item, kilogram, gram, dozen };

    class Program
    {
        static void Main(string[] args)
        {
            int a = 24;
            int b = 6;
            int c = a + b;
            int d = 5;
            int e = (c) / d;
            int f = (c) % d;
            Console.WriteLine($"({c}) / {d}");
            Console.WriteLine($"qoutient: {e}");
            Console.WriteLine($"remainder: {f}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The Max range for integers is {max}");
            Console.WriteLine($"The Min range for integers is {min}");

            int over = max + b;
            Console.WriteLine($"Overflow: {over} sum of {max} and {b}");
            Console.WriteLine($"Equals: Min + {b - 1} or {min + (b - 1)}");

            double g = 4;
            double h = 3;
            double i = (g + h) / 2;
            Console.WriteLine($"Double Precision: {i}");

            g = 18;
            h = 22;
            i = (g + h) / 7;
            Console.WriteLine($"Double Precision: {i}");
            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine($"The Max range for double is {maxd}");
            Console.WriteLine($"The Min range for double is {mind}");

            double improper = 2.0 / 3.0;
            Console.WriteLine($"Rounding: {improper}");

            double anon = 1.0;
            double bnon = 3.0;
            Console.WriteLine(anon / bnon);

            // the M suffic used to indicate constant to use decimal type
            decimal cexp = 1.0M;
            decimal dexp = 3.0M;
            Console.WriteLine(cexp / dexp);

            // Challenge #1
            // Circle Area = Pi * r * r
            double r = 2.50;
            double CircleArea = Math.PI * r * r;
            Console.WriteLine(CircleArea);

            a = 6;
            b = 7;
            if (a + b > 12)
                Console.WriteLine("a + b is greater than 12");

            /* 
            int counter = 0;
                        while (counter < 10)
                        {
                            Console.WriteLine($"The counter is {counter}");
                            counter++;
                        }*/

            // Challenge # 2
            // Sum of all integers 1 through 20 that are divisible by 3
            int sum = 0;
            for (int l = 0; l < 20; l++)
            {
                if (l % 3 == 0)
                {
                    sum += l;
                }
            }

            Console.WriteLine($"The sum of integers equals {sum}");

            // referencing Fruit class
            var item = new Fruit("orange");
            var date = DateTime.Now;
            var price = 1.22m;
            var unit = Unit.item;
            //Console.WriteLine($"{item} was ${price} per {unit} On {date}.");
            Console.WriteLine($"On {date:d}, the price of {item} was {price:F3} per {unit}.");


        }

    }



}
