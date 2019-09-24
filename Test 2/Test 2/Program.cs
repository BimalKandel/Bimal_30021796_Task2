using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class program
    {
        static void Main(string[] args)
        {
            salary s1 = new salary();
            s1.AnnualSalary = 80000;
            Console.WriteLine($"Your salary is se tat {s1.AnnualSalary}");
            Console.WriteLine($"your salary per weekis {s1.DispalySalary()}");
            Console.WriteLine("");
            Console.WriteLine("i will calculate your wages");
            Console.WriteLine("enter a number of hour work:");
            int hour = int.Parse(Console.ReadLine());
        }
        public class salary
        {
            double annualsalary;
            double weekelysalary;

            public double Annualsalary
            {
                get { return annualsalary; }
                set { annualsalary = value; }

                public double Weekelysalary
            {
                get { return weekelysalary; }
                set { Weekelysalary = value; }

            }

            public salary()
            {
                Weekelysalary = DisplaySalary();

            }
            public double DisplaySalary(); 
            {

            return (annualsalary* 7) / 365;
             }
    }
    public class wages
    {
        double numhours;
        double weekelywages;

    }

    public double NUmHours
    {
        get { return this.NumHour}
        set { this.NumHours = value}
    }

    public double Weekelywages
    {
        get { return this.weekelywage; }
        set { weekely wages = Value}

    }
    get { return this.NumHour}
    set { this.NumHours = value}


    public double DisplaySalary(); 
            {

            return (annualsalary* 7) / 365;












