public class Program
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
            decimal rate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter tax rate: ");
            decimal taxRate = decimal.Parse(Console.ReadLine());

            Payroll employee = new Payroll(hours, rate, taxRate);

            decimal netPay = employee.CalculateNetPay();

            Console.WriteLine($"{name} earnt {netPay}");

            Console.WriteLine("Update tax rate: ");
            decimal newTax = decimal.Parse(Console.ReadLine());

            employee.ChangeTaxRate(newTax);

            decimal newNetPay = employee.CalculateNetPay();

            Console.WriteLine($"{name} earnt {newNetPay} with new tax rate");
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