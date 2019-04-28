using System;

namespace Exercise5
{

    public class Box
    {
        public Box (double len, double wth, double hgt)
        {
            this.length  = len;
            this.width = wth;
            this.height = hgt;
        }
        
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        public double getVolume()
        {
            return (length * width * height);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Box bx1 = new Box(2,5,10);
            System.Console.WriteLine("Box 1 Volume: " + bx1.getVolume());
            
            Box bx2 = new Box(5,7,6);
            System.Console.WriteLine("Box 2 Volume: " + bx2.getVolume());

            Box bx3 = new Box(2,5,7);
            System.Console.WriteLine("Box 3 Volume: " + bx3.getVolume());

        }
    }
}
