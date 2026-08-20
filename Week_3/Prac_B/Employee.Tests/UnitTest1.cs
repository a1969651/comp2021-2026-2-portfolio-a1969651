using Xunit;

namespace Employee.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void FullTimeEmployee_CalculatePay()
        {
            FullTimeEmployee emp = new FullTimeEmployee();
            emp.Name = "Greg";
            emp.AnnualSalary = 80000.0m;

            decimal result = emp.CalculatePay();

            Assert.Equal(64000.0m, result);
        }

        [Fact]
        public void FullTimeEmployee_GenerateReport()
        {
            FullTimeEmployee emp = new FullTimeEmployee();
            emp.Name = "Greg";
            emp.AnnualSalary = 80000.0m;

            string report = emp.GenerateReport();

            Assert.Contains("Greg", report);
        }

        [Fact]
        public void Contractor_GenerateReport()
        {
            Contractor emp = new Contractor();
            emp.Name = "Sarah";
            emp.Rate = 55.0m;
            emp.Hours = 120.0m;

            Assert.Contains("Sarah", emp.GenerateReport());
        }
    }
}