class Program
{
    static void Main()
    {
        try
        {
            Person p = new Person ("Nic", "Averay", 19);
            Console.WriteLine($"Added person: {p.FirstName} {p.LastName} who is {p.Age} years old");
            Console.WriteLine($"Is Adult: {p.IsAdult()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid person: {ex.Message}");
        }
    }
}





