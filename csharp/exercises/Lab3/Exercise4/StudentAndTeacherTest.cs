using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person ps = new Person();
            ps.Hello();
            Student st = new Student();
            st.Hello();
            st.SetAge(21);
            st.ShowAge();
            Teacher tc = new Teacher();
            tc.Hello();
            tc.SetAge(30);
            tc.Explain();
        }
    }
}

