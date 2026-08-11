public class Payroll
{
    private double hours;
    private decimal rate;
    private decimal taxRate;

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
        this.hours = hours;
        this.rate = rate;
        this.taxRate = taxRate;
    }

    public decimal CalculateNetPay()
    {
        decimal gross = (decimal)hours * rate;
        decimal tax = gross * taxRate;
        decimal netPay = gross - tax;

        return netPay;
    }

    public void ChangeTaxRate(decimal newTax)
    {
        if (newTax < 0 || newTax > 1)
        {
            throw new ArgumentException("Tax rate must be between 0 and 1.");
        }

        taxRate = newTax;
    }
}