using System;
using Acme.Data.Entity;
using Acme.Service;

namespace Acme.Console
{
    class ManageDept
    {
        DepartmentService deptService;
        public ManageDept()
        {
            deptService = new DepartmentService();
        }

        void AddDept()
        {
            Department d = new Department();
            System.Console.Write("Enter name => ");
            d.Name = System.Console.ReadLine();

            System.Console.Write("Enter Location => ");
            d.Location = System.Console.ReadLine();

            if (deptService.Insert(d) > 0)
                System.Console.WriteLine("Deptartment added successfully");
            else
                System.Console.WriteLine("Some error has occured");
        }

        public void Run()
        {
            AddDept();
        }
    }
}
