/*  sample project displaying simple arithmetic operations */

using System;

namespace Exercise2
{

    public class Arithmetic
    {
        int a, b;

        public void GetA()
        {

            System.Console.Write("Enter integer a: ");
            this.a = Convert.ToInt32(Console.ReadLine());
        }

        public void GetB()
        {
            System.Console.Write("Enter integer b: ");
            this.b = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayOptions()
        {
            System.Console.WriteLine("Below are the available Arithmetic Operations:");
            System.Console.WriteLine("1. Addition");
            System.Console.WriteLine("2. Subtraction");
            System.Console.WriteLine("3. Multiplication");
            System.Console.WriteLine("4. Division");
        }

        public int Addition()
        {
            return a + b;
        }

        public int Subtraction()
        {
            return a - b;
        }

        public int Multiplication()
        {
            return a * b;
        }

        public int Division()
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int option;

            Arithmetic a1 = new Arithmetic();
            a1.GetA();
            a1.GetB();
            a1.DisplayOptions();

            System.Console.Write("Enter the Arithmetic Operation number: ");
            option = Convert.ToInt32(System.Console.ReadLine());

            switch (option)
            {
                case 1:
                    System.Console.WriteLine($"Result: {a1.Addition()}");
                    break;
                case 2:
                    System.Console.WriteLine($"Result: {a1.Subtraction()}");
                    break;
                case 3:
                    System.Console.WriteLine($"Result: {a1.Multiplication()}");
                    break;
                case 4:
                    System.Console.WriteLine($"Result: {a1.Division()}");
                    break;
                default:
                    Console.WriteLine($"An unexpected option selected: ({option})");
                    break;
            }

        }
    }
}
