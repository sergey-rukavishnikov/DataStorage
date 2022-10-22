namespace DataStorage
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<Note> notes = new List<Note>();
            if (notes == null) throw new ArgumentNullException(nameof(notes))
            {
                HelpLink = null,
                HResult = 0,
                Source = null
            };
            string? fName;
            string? lName;
            int age;
            string? brand;
            int year;
            int nNumber;
            bool cycle = true;
            while (cycle)
            {
                Console.WriteLine("1. Print data\n" +
                                  "2. Add data\n" +
                                  "3. Remove data\n" +
                                  "Q. Exit\n");
                ConsoleKeyInfo choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                 case ConsoleKey.D1:
                     if(notes.Count != 0)
                     {
                         foreach (var variable in notes) 
                         {
                             Console.Write($"{notes.IndexOf(variable)}. ");
                             variable.Print();
                         }
                     }
                     else
                     {
                         Console.WriteLine("The notebook is empty");
                     }
                     break;
                 case ConsoleKey.D2:
                 {
                     Console.WriteLine("Choose type of record:\n" +
                                       "1. Message\n" +
                                       "2. Person\n" +
                                       "3. Car \n");
                     ConsoleKeyInfo chosenType = Console.ReadKey(true);
                     switch (chosenType.Key)
                     {
                         case ConsoleKey.D1:
                             Console.WriteLine("Type your message.");
                             notes.Add(new Message(Console.ReadLine()));
                             break;
                         case ConsoleKey.D2:
                             Console.Write("First Name: ");
                             fName = Console.ReadLine();
                             Console.Write("Last Name: ");
                             lName = Console.ReadLine();
                             Console.Write("Age: ");
                             int.TryParse(Console.ReadLine(), out age);
                             if (fName != null)
                                 if (lName != null)
                                     notes.Add((new Person(fName, lName, age)));
                             break;
                         case ConsoleKey.D3:
                             Console.Write("Car brand: ");
                             brand = Console.ReadLine();
                             Console.Write("Year of manufacture of the car: ");
                             int.TryParse(Console.ReadLine(), out year);
                             if (brand != null) notes.Add(new Car(brand, year));
                             break;
                     }
                 }
                     break;
                 case ConsoleKey.D3:
                     if (notes.Count != 0)
                     {
                         Console.Write("Enter the note number: ");
                         int.TryParse(Console.ReadLine(), out nNumber);
                         if (notes.Count > nNumber)
                             notes.RemoveAt(nNumber);
                         else
                             Console.WriteLine("There is no note with this number!");
                     }
                     else
                     {
                         Console.WriteLine("The notebook is empty");
                     }
                     break;
                 case ConsoleKey.Q:
                     cycle = false;
                     break;
                 default:
                     Console.Error.WriteLine("Error: Incorrect number entered!");
                     break;
                }
            }
        }
    }
}