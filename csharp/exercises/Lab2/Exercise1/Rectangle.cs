using System;

namespace Exercise1
{
    class Rectangle
    {
        private double length = 1, width = 1;

        public double GetArea() => length * width;
        public double GetPerimeter() => 2 * (length + width);

        public void Display()
        {
            System.Console.WriteLine("Length:" + length);
            System.Console.WriteLine("Width:" + width);
            System.Console.WriteLine("Area:" + GetArea());
            System.Console.WriteLine("Perimeter:" + GetPerimeter());
        }

        public void GetData()
        {
            do
            {
                System.Console.Write("Enter length between 0-20: ");
                length = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Enter Width between 0-20: ");
                width = Convert.ToInt32(System.Console.ReadLine());

            } while (length < 0 || length > 20 || width < 0 || width > 20);
        }

    }

}
