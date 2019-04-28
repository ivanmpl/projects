using System;

namespace Exercise1
{

    abstract class Shape
    {
        protected float R, L, B;

        public abstract float Area();
        public abstract float Circumference();
        public abstract void PromptValues();
    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            PromptValues();
        }

        public override void PromptValues()
        {
            System.Console.Write("Enter Width: ");
            float.TryParse(System.Console.ReadLine(), out this.R);

            System.Console.Write("Enter Length: ");
            float.TryParse(System.Console.ReadLine(), out this.L);

            System.Console.Write("Enter Height: ");
            float.TryParse(System.Console.ReadLine(), out this.B);
        }

        public override float Area()
        {
            return R * L * B;
        }

        public override float Circumference()
        {
            return 2 * (R + L);
        }
    }

    class Circle : Shape
    {
        public Circle() 
        {
            PromptValues();
        }

        public override void PromptValues()
        {
            System.Console.Write("Enter Radius: ");
            float.TryParse(System.Console.ReadLine(), out this.R);
        }

        public override float Area()
        {
            return (this.R * this.R * 3.14f);
        }

        public override float Circumference()
        {
            return (2* 3.14f * this.R);
        }
    }

}