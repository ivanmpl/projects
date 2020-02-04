using System;

public class TextInput
{
    protected string value;

    public virtual void Add(char c)
    {
        value = value + c;
    }

    public string GetValue()
    {
        return value;
    }

}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if (Char.IsNumber(c))
        {
            value += c;
        }

    }

}


public abstract class MotorVehicle
{

    int fuel = 0;

    // They ALL have fuel, so lets implement this for everybody.
    public int getFuel()
    {
        return this.fuel;
    }

    // That can be very different, force them to provide their
    // own implementation.
    public abstract void run();
}

// My teammate complies and writes vehicle looking that way
public class Car : MotorVehicle
{
    public override void run()
    {
        System.Console.WriteLine("Wrroooooooom");
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        string d = "tes";
        d.Equals("tsest", StringComparison.InvariantCultureIgnoreCase);

        NumericInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());

        Car car = new Car();
        car.run();
    }
}