using Xunit;

public class PayrollTests
{
    [Fact]
    public void Constructor_WithValidData_CreatesPayroll()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(960m, result);
    }

    [Fact]
    public void Constructor_WithNegativeHours_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(-1, 30m, 0.2m));
    }

    [Fact]
    public void Constructor_WithNegativeRate_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(40, -30m, 0.2m));
    }

    [Fact]
    public void Constructor_WithInvalidTaxRate_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
            new Payroll(40, 30m, 1.5m));
    }

    [Fact]
    public void CalculateNetPay_CalculatesCorrectly()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(960m, result);
    }

    [Fact]
    public void ChangeTaxRate_UpdatesNetPay()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        payroll.ChangeTaxRate(0.3m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(840m, result);
    }

    [Fact]
    public void ChangeTaxRate_WithInvalidRate_ThrowsException()
    {
        Payroll payroll = new Payroll(40, 30m, 0.2m);

        Assert.Throws<ArgumentException>(() =>
            payroll.ChangeTaxRate(1.5m));
    }
}
