using System;

namespace SalaryCalculator
{
    internal class Program
    {
         static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter Bruto Salary:");
            double brutoSalary =Convert.ToDouble( Console.ReadLine());

            if (brutoSalary <= 1200 && brutoSalary >= 500)
            {
                Calc1(brutoSalary);
            }

            if (brutoSalary <= 2099 && brutoSalary >= 1201)
            {
                Calc2(brutoSalary);
            }

            if (brutoSalary >= 2100)
            {
                Calc3(brutoSalary);
            }

        }

        public static void Calc1(double brutoSalary)
        {
            double pensionFond = brutoSalary * 0.02;

            double uneploymentTax = brutoSalary * 0.016;

            double Tax = (brutoSalary - 500 - pensionFond - uneploymentTax) * 0.2;

            double Calc1 = brutoSalary - pensionFond - uneploymentTax - Tax;

            Console.WriteLine($"Your Neto Salary is: {Calc1}");
        }

        public static void Calc2(double brutoSalary)

        {
            double pensionFond = brutoSalary * 0.02;

            double uneploymentTax = brutoSalary * 0.016;

            double TaxFreeInCome = 500 - 0.55556 * (brutoSalary - 1200);

            double Tax = (brutoSalary - pensionFond - uneploymentTax - TaxFreeInCome) * 0.2;

            double Calc2 = brutoSalary - pensionFond - uneploymentTax - Tax;

            Console.WriteLine($"Your Neto Salary is: {Calc2}");
        }

        public static void Calc3(double brutoSalary)
        {

            double pensionFond = brutoSalary * 0.02;

            double uneploymentTax = brutoSalary * 0.016;

            double Tax = (brutoSalary - pensionFond -uneploymentTax  )* 0.2;

            double Calc3 = brutoSalary - pensionFond - uneploymentTax - Tax;

            Console.WriteLine($"Your Neto Salary is: {Calc3}");
        }
    }
}
