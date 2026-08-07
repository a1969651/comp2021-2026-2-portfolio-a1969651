class Program
{
    static void Main()
    {
        Console.WriteLine("Enter employee name: ");
        string name = Console.ReadLine();

        try
        {
            Console.WriteLine("Enter hours worked: ");
            double hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate: ");
            double rate = double.Parse(Console.ReadLine());

            double net_pay = CalculatePay.calculate_pay(hours, rate);
            Console.WriteLine($"{name} earnt {net_pay}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}