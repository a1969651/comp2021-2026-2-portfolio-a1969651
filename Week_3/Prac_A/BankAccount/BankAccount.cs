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

    public virtual void Withdraw(decimal withamount)
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

public class SavingsAccount : BankAccount 
{
    public decimal interestRate {get; set;}

    public void ApplyInterest(){
        Balance = Balance + (Balance * interestRate);
    }
}

public class CheckingAccount : BankAccount
{
    public decimal transactionFee {get; set;} = 5m;

    public override void Withdraw(decimal withamount)
    {
        if (Balance - withamount - transactionFee >= 0)
        {
            Balance = Balance - withamount - transactionFee;
        }
        else
        {
            throw new ArgumentException("Insufficient funds");
        }
    }
}