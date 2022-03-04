using System;
using System.Configuration;

namespace DesignPatterns.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to Point Of Sales - XYZ Shopping Center");
            BillingSystem billingSystem = new BillingSystem();
            billingSystem.GenerateBill();
            Console.ReadLine();



        }
    }

    class TaxCalcFactory
    {
        private TaxCalcFactory()
        {

        }

        public static readonly TaxCalcFactory Instance = new TaxCalcFactory();
        public TaxCalculatorStrategy CreateTaxCalculator()
        {
            // read the config file for selecting which calc should create
            // will create a suitable tax calculator and returns
            string taxCalcName = ConfigurationManager.AppSettings["TAX"];
            Type theType = Type.GetType(taxCalcName);
            return (TaxCalculatorStrategy)Activator.CreateInstance(theType);
        }
    }

    class BillingSystem
    {

        TaxCalculatorStrategy taxCalc = null;
        //public BillingSystem(TaxCalculatorStrategy taxCalc)
        //{
        //    this.taxCalc = taxCalc;
        //}
        public void GenerateBill()
        {
            //
            // scan all items
            // create order
            // calculate order amount
            double orderAmt = 6700;
            // calculate disc
            // calculate tax
            //TaxCalculator ka = new TaxCalculator();
            //TaxCalcFactory factory = new TaxCalcFactory();
            taxCalc = TaxCalcFactory.Instance.CreateTaxCalculator();
            double tax = taxCalc.CalculateTax(orderAmt);
            // calculate bill amt
            // generate and print bill
            Console.WriteLine($"The Order Amount :{orderAmt}");
            Console.WriteLine($"The Total Tax : {tax}");
            Console.WriteLine($"The Total Bill Amount : {orderAmt + tax}");
        }
    }


    abstract class TaxCalculatorStrategy
    {
        public abstract double CalculateTax(double amount);
    }

    class KATaxCalculator : TaxCalculatorStrategy
    {
        public override double CalculateTax(double amount)
        {
            // KA state tax calculation
            Console.WriteLine("Using KA Tax Calculator");
            int st = 100;
            int cst = 60;
            int sbt = 15;
            int kkt = 10;
            return st + cst + sbt + kkt;
        }
    }

    class APTaxCalculator : TaxCalculatorStrategy
    {
        public override double CalculateTax(double amount)
        {
            Console.WriteLine("Using AP Tax Calculator");
            int st1 = 100;
            int cst1 = 60;
            int abc = 15;
            int xyz = 10;
            return st1 + cst1 + abc + xyz;
        }
    }

    class TSTaxCalculator : TaxCalculatorStrategy
    {
        public override double CalculateTax(double amount)
        {
            Console.WriteLine("Using TS Tax Calculator");
            int st2 = 100;
            int cst2 = 60;
            int abc1 = 15;
            int aaa = 10;
            return st2 + cst2 + abc1 + aaa;
        }
    }

    // add few more tax calculators and config
    // note: only add a new code for new feature. never modify existing code


    // Note: Plugin ustaxcalculator without modifying any existing code including ustaxcalculator. you can add new code

    class USTaxCalculator
    {
        public float ComputeTax(float amount)
        {
            Console.WriteLine("Using US Tax Calculator");
            return 422.89f;
        }
    }

    class USTaxCaculatorAdaptor : TaxCalculatorStrategy
    {
        public override double CalculateTax(double amount)
        {
            USTaxCalculator usTax = new USTaxCalculator();
            return (double)usTax.ComputeTax((float)amount);
        }
    }
}
