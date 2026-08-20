using System.Runtime.CompilerServices;

public abstract class Employee {
    public const decimal TaxRate = 0.2m;

    public abstract string Name {get; set;}

    public abstract decimal CalculatePay();
}

public interface IReportable
{
    string GenerateReport();
}

public class FullTimeEmployee : Employee, IReportable
{
    public decimal AnnualSalary {get; set;}
    public override string Name {get; set;}

    public override decimal CalculatePay()
    {
        return AnnualSalary - (AnnualSalary * TaxRate);
    }

    public string GenerateReport()
    {
        return $"{Name}, {AnnualSalary}, {CalculatePay()}";
    }
}

public class Contractor : Employee, IReportable
{
    public decimal Rate {get; set;}
    public decimal Hours {get; set;}
    public override string Name {get; set;}

    public override decimal CalculatePay()
    {
        return (Rate * Hours) - TaxRate;
    }

    public string GenerateReport()
    {
        return $"{Name}, {Rate}, {Hours}, {CalculatePay()}";
    }
}


public class Run
{
    static void Main()
    {
        FullTimeEmployee Greg = new FullTimeEmployee();
        Greg.Name = "Greg";
        Greg.AnnualSalary = 80000m;
        Console.WriteLine(Greg.GenerateReport());
    }
}
