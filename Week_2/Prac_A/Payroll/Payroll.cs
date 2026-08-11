public class Payroll
{
    private double hours;
    private decimal rate;
    private decimal taxRate;

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
        if (hours < 0)
        {
            throw new ArgumentException("Hours must be positive.");
            break;
        }

        if (rate < 0)
        {
            throw new ArgumentException("Rate must be positive.");
            break;
        }

        if (taxRate < 0 || taxRate > 1)
        {
            throw new ArgumentException("Tax rate must be between 0 and 1.");
            break;
        }

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