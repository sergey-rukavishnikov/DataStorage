namespace DataStorage;

public class Message : Note
{
    private readonly string? _text;

    public Message(string? text)
    {
        _text = text;
    }

    public override void Print()
    {
        base.Print();
        Console.Write($" [Message] {_text}\n");
    }
}