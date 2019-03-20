// sample program showcasing inheritance and more

using System;

namespace inheritance
{
    // Base class
    public class A
    {
        private string value = "A value";

        public virtual string GetStringValue()
        {
            return this.value;
        }
    }

    // Child class derived from A
    public class B : A
    {
        private string value = "B value";

        public override string GetStringValue()
        {
            return this.value;
        }
    }

    // child class derived from B
    public class C : B
    {
        public string value = "C value";

         public override string GetStringValue()
        {
            return base.GetStringValue();
        }
    }

    class Program
    {
        static public string ReverseString(string str)
        {

            char[] arr = str.ToCharArray();
            char[] rev_arr = new char[str.Length];

            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                rev_arr[i] = arr[j];
            }

            return new string(rev_arr);
        }

        static public string ReverseString2(string str)
        {

            char[] arr = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = arr[i];
                arr[i] = arr[j];
                arr[j] = c;

            }

            return new string(arr);
        }

        /*     char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray ); */

        static void Main(string[] args)
        {
            // create class objects and print values
            A a = new A();
            // A
            Console.WriteLine(a.GetStringValue());
            B b = new B();
            // B
            Console.WriteLine(b.GetStringValue());
            C c = new C();
            // B
            Console.WriteLine(c.GetStringValue());
            // C
            Console.WriteLine(c.value);

            // Reverse String 
            string str = "foo bar";
            Console.WriteLine(ReverseString(str));
        }
    }
}
