using System.Linq.Expressions;

public class Program
{
    static void Main()
    {
        try
        {

            Console.WriteLine("Checkings Account type 1, Savings Account type 2.");
            int accType = int.Parse(Console.ReadLine());

            if (accType == 1)
            {
                CheckingAccount account = new CheckingAccount();

                Console.WriteLine("Enter Owner: ");
                string owner = Console.ReadLine();

                Console.WriteLine("Enter deposit amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());

                account.Owner = owner;
                account.Deposit(amount);
                Console.WriteLine($"New Balance is {account.Balance}");

                Console.WriteLine("Enter Withdraw amount: ");
                decimal withamount = decimal.Parse(Console.ReadLine());
                account.Withdraw(withamount);
                Console.WriteLine($"You just withdrew {withamount} with a fee of {account.transactionFee}. New Balance is {account.Balance}");
            } else if (accType == 2)
            {
                SavingsAccount account = new SavingsAccount();

            Console.WriteLine("Enter Owner: ");
            string owner = Console.ReadLine();

            Console.WriteLine("Enter deposit amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.Owner = owner;
            account.Deposit(amount);
            Console.WriteLine($"New Balance is {account.Balance}");

            Console.WriteLine("Enter Withdraw amount: ");
            decimal withamount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withamount);
            Console.WriteLine($"You just withdrew {withamount}. New Balance is {account.Balance}");

            Console.WriteLine("Enter interest rate: ");               
            decimal interestRate = decimal.Parse(Console.ReadLine());

            account.interestRate = interestRate;

            Console.WriteLine($"Before Interest {account.Balance}");
            account.ApplyInterest();
            Console.WriteLine($"After Interest {account.Balance}");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}