using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // default person and house type
            Person defaultPerson = new Person();
            defaultPerson.ShowData();

            // small person with small apartment
            SmallApartment smallApt = new SmallApartment();
            Person smallPerson = new Person("Jackie", smallApt);
            smallPerson.ShowData();

            // person with house with blue door
            House house = new House(500);
            house.Door.Color = "Blue";
            Person person = new Person("John", house);

            // another person with house
            Person person2 = new Person();
            person2.House.Area = 1000;
            person2.House.Door.Color = "red";
            person2.Name = "Joe";
            person2.ShowData();
        }
    }
}
