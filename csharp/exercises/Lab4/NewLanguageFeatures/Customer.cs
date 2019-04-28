using System.Collections.Generic;

namespace NewLanguageFeatures
{
    public static class Extensions
    {
        public static List<T> Append<T>(this List<T> a, List<T> b)
        {
            List<T> newList = new List<T>(a);
            newList.AddRange(b);
            return newList;
        }


        public static bool Compare(this Customer cust1, Customer cust2)
        {
            if (cust1.CustomerID == cust2.CustomerID &&
                cust1.City == cust2.City &&
                cust1.Name == cust2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int id)
        {
            CustomerID = id;
        }

        public override string ToString()
        {
            return Name + "\t" + City + "\t" + CustomerID;
        }
    }
}