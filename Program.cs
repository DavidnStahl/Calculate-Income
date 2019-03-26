using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your monthly salary?: ");
            double monthlySalary = double.Parse(Console.ReadLine());
            Console.Write("how much procent do you pay in taxes?, (example 0,3) ");
            double yourTaxes = double.Parse(Console.ReadLine());
            double yearSalary = YearSalary(monthlySalary);
            double yourTax = PaidTaxes(yearSalary, yourTaxes);
            double paidPublicPension = PaidPublicPension(yearSalary);
            double paidServicePension = PaidServicePension(yearSalary);
            Console.WriteLine("Salary per year: " + yearSalary);
            Console.WriteLine("You pay " + yourTax + " in taxes every year ");
            Console.WriteLine("Your company pays you " + paidPublicPension + " in public pension every year ");
            Console.WriteLine("Your company pays you " + paidServicePension + " in service pension every year ");
            Console.ReadLine();
        }
        public static double YearSalary(double monthlySalary)
        {
            double yearSalary = monthlySalary * 12;
            return yearSalary;
        }
        public static double PaidTaxes(double yearSalary, double yourTaxes)
        {
            double taxes = yearSalary * yourTaxes;
            return taxes;
        }
        public static double PaidPublicPension(double yearSalary)
        {
            double publicPensionProcent = 0.185;
            double maxPublicPension = 483000;
            if (yearSalary >= maxPublicPension)
            {
                return publicPensionProcent * maxPublicPension;
            }
            else
            {
                return publicPensionProcent * yearSalary;
            }
        }
        public static double PaidServicePension(double yearSalary)
        {
            double specialPublicPensionProcent = 0.3;
            double publicPensionProcent = 0.075;
            double maxPublicPension = 483000;
            if (yearSalary <= maxPublicPension)
            {
                return publicPensionProcent * yearSalary;
            }
            else
            {
                return (publicPensionProcent * maxPublicPension) + (specialPublicPensionProcent * (yearSalary - maxPublicPension));
            }
        }

    }
}
