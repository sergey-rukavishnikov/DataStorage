using System.Data;

namespace DataStorage;

public abstract class Note
{
     private readonly DateTime _dateTime;

     protected Note()
     {
          _dateTime = DateTime.Now;
     }

     public virtual void Print()
     {
          Console.Write($"[{_dateTime}]");
     }
}