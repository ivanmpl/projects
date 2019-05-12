using System;

namespace Acme.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManageCustomer manageCustomer = new ManageCustomer();
            //manageCustomer.Run();

            ManageDept manageDept = new ManageDept();
            manageDept.Run();
        }
    }
}
