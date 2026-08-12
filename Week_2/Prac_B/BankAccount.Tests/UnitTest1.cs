using System.Reflection;

public class UnitTest1
{
    [Fact]
    public void Deposit()
    {
        BankAccount account = new BankAccount();
        account.Deposit(50);
        Assert.Equal(50, account.Balance);     
    }

    [Fact]
    public void Withdraw()
    {
        BankAccount account = new BankAccount();
        account.Deposit(50);
        account.Withdraw(50);
        Assert.Equal(0, account.Balance);
    }

    [Fact]
    public void InsufficientFunds()
    {
        BankAccount account = new BankAccount();
        account.Deposit(50);
        Assert.Throws<ArgumentException>(() => account.Withdraw(100));

    }
}
