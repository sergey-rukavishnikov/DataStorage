namespace DataStorage;

public class Car : Note
{
    private readonly string _brand;
    private readonly int _yr;

    public Car(string brand, int yr)
    {
        _brand = brand;
        _yr = yr;
    }

    public override void Print()
    {
        base.Print();
        Console.Write($" [Car] {_brand} {_yr}\n");
    }
}