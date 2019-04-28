namespace Exercise4
{
    class Person
    {
        protected int age;

        public void SetAge(int n)
        {
            age = n;
        }

        public void Hello()
        {
            System.Console.WriteLine("Hello");
        }

    }

    class Student : Person
    {
        public void GoToClasses()
        {
            System.Console.WriteLine("I'm going to classes");
        }

        public void ShowAge()
        {
            System.Console.WriteLine("My age is: {0} years old", age);
        }



    }

    class Teacher : Person
    {
        private string subject = "English";
        public void Explain()
        {
            System.Console.WriteLine("Explanation begins");
        }

        public void ShowSubject()
        {
            System.Console.WriteLine("My subject is " + subject);
        }

    }
}