namespace DataStorage;

public class Person : Note
{
    private readonly string _firstName;
    private readonly string _lastName;
    private readonly int _age;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public override void Print()
    {
        base.Print();
        Console.Write($" [Person] {_firstName} {_lastName} {_age}\n");
    }
}