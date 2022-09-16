﻿using System;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //int BrutoSalary = 0;
            Console.WriteLine("Enter Bruto Salary:");
            int BrutoSalary =Convert.ToInt32( Console.ReadLine());

            if (BrutoSalary <= 1200 && BrutoSalary >= 500)
            {
                Calc1(BrutoSalary);
            }

            if (BrutoSalary <= 2099 && BrutoSalary >= 1201)
            {
                Calc2(BrutoSalary);
            }

            if (BrutoSalary >= 2100)
            {
                Calc3(BrutoSalary);
            }

        }

        static void Calc1(double BrutoSalary)
        {
            double pensionFond = BrutoSalary * 0.02;

            double Insurance = BrutoSalary * 0.016;

            double Tax = (BrutoSalary - 500 - pensionFond - Insurance) * 0.2;

            double Calc1 = BrutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your Neto Salary is = " + Calc1);
        }

        static void Calc2(double BrutoSalary)

        {
            double pensionFond = BrutoSalary * 0.02;

            double Insurance = BrutoSalary * 0.016;

            double TaxFreeInCome = 500 - 0.55556 * (BrutoSalary - 1200);

            double Tax = (BrutoSalary - pensionFond - Insurance - TaxFreeInCome) * 0.2;

            double Calc2 = BrutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your Neto Salary is = " + Calc2);
        }

        static void Calc3(double BrutoSalary)
        {

            double pensionFond = BrutoSalary * 0.02;

            double Insurance = BrutoSalary * 0.016;

            double Tax = BrutoSalary * 0.2;

            double Calc3 = BrutoSalary - pensionFond - Insurance - Tax;

            Console.WriteLine("Your Neto Salary is = " + Calc3);
        }
    }
}
