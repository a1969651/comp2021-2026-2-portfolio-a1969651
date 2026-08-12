public class BankAccount
{
    public string Owner {get; set;}
    public decimal Balance {get; set;}

    public void Deposit(decimal amount)
    {
        Balance = Balance + amount;
    }

    public void Deposit(int amount)
    {
        Balance = Balance + amount;
    }

    public void Deposit(double amount)
    {
        Balance = Balance + (decimal)amount;
    }

    public void Withdraw(decimal withamount)
    {
        if (Balance - withamount >= 0)
        {
            Balance = Balance - withamount;
        }
        else
        {
            throw new ArgumentException("Insufficient funds");
        }
    }
}