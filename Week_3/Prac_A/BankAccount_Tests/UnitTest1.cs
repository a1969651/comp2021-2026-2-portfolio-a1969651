using Xunit;

public class BankAccountTests
{
    [Fact]
    public void DepositDecimal()
    {
        BankAccount account = new BankAccount();

        account.Deposit(100m);

        Assert.Equal(100m, account.Balance);
    }

    [Fact]
    public void DepositInt()
    {
        BankAccount account = new BankAccount();

        account.Deposit(100);

        Assert.Equal(100m, account.Balance);
    }

    [Fact]
    public void DepositDouble()
    {
        BankAccount account = new BankAccount();

        account.Deposit(100.50);

        Assert.Equal(100.50m, account.Balance);
    }

    [Fact]
    public void Withdraw()
    {
        BankAccount account = new BankAccount();

        account.Deposit(100m);
        account.Withdraw(40m);

        Assert.Equal(60m, account.Balance);
    }

    [Fact]
    public void WithdrawWithoutFunds()
    {
        BankAccount account = new BankAccount();

        account.Deposit(100m);

        Assert.Throws<ArgumentException>(() =>
            account.Withdraw(150m)
        );
    }

    [Fact]
    public void ApplyInterest()
    {
        SavingsAccount account = new SavingsAccount();

        account.Deposit(100m);
        account.interestRate = 0.05m;

        account.ApplyInterest();

        Assert.Equal(105m, account.Balance);
    }

    [Fact]
    public void TransactionFee()
    {
        CheckingAccount account = new CheckingAccount();

        account.Deposit(100m);
        account.Withdraw(20m);

        Assert.Equal(75m, account.Balance);
    }

    [Fact]
    public void TransactionFeeWithoutFunds()
    {
        CheckingAccount account = new CheckingAccount();

        account.Deposit(20m);

        Assert.Throws<ArgumentException>(() => account.Withdraw(16m)
        );
    }
}