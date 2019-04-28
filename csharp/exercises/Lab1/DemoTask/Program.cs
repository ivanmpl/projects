/* sample getting started sample project */

using System;

namespace DemoTask
{
    public class Student 
    {
        string name, address;
        int mobile;

        public void GetData()
        {
            System.Console.Write("Enter you Name: ");
            name = Console.ReadLine();
            System.Console.Write("Enter your Address: ");
            address = Console.ReadLine();
            System.Console.Write("Enter your Mobile Number: ");
            mobile = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData() 
        {
            System.Console.WriteLine("Student Name: " + name);
            System.Console.WriteLine("Student Address: " + address);
            System.Console.WriteLine("Student Mobile: " + mobile);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetData();
            s1.DisplayData();
        }
    }
}
