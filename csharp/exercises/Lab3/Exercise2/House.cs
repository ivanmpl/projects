namespace Exercise2
{

    class House
    {
        protected int area;
        protected Door door;

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public Door Door
        {
            get { return door; }
            set { door = value; }
        }

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        public virtual void ShowData()
        {
            System.Console.WriteLine("I am a house my area is {0} m2", area);
        }
    }

    class Door
    {
        protected string color;

        public Door()
        {
            color = "Brown";
        }

        public Door(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            System.Console.WriteLine("I am a door, my color is {0}", this.color);
        }
    }

    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {

        }

        public override void ShowData()
        {
            System.Console.WriteLine("I am a small apartment my area is {0} m2", area);
        }
    }

    class Person
    {
        protected string name;
        protected House house;

        public Person()
        {
            name = "Jake";
            house = new House(200);           
        }

        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            System.Console.WriteLine("I am a person my name is " + name);
            house.ShowData();
            house.Door.ShowData();
        }

    }


}