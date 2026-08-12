using System.Linq.Expressions;

public class Program
{
    static void Main()
    {
        try
        {
        Console.WriteLine("Enter Owner: ");
        string owner =Console.ReadLine();

        Console.WriteLine("Enter deposit amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        BankAccount account = new BankAccount();
        account.Owner = owner;
        account.Deposit(amount);
        Console.WriteLine($"New Balance is {account.Balance}");

        Console.WriteLine("Enter Withdraw amount: ");
        decimal withamount = decimal.Parse(Console.ReadLine());
        account.Withdraw(withamount);
        Console.WriteLine($"You just withdrew {withamount}. New Balance is {account.Balance}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
