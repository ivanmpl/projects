using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            System.Console.WriteLine("Area: " + rec.Area());
            System.Console.WriteLine("Circumference: " + rec.Circumference());

            Circle cir = new Circle();
            System.Console.WriteLine("Area: " + cir.Area());
            System.Console.WriteLine("Circumference: " + cir.Circumference());
        }
    }
}
