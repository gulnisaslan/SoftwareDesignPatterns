using System;


namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.CrediCalculatorBase=new After2010CreditCalculate();
            customerManager.Save();
        }
    }

    abstract class  CrediCalculatorBase
    {
        public abstract void Calculate();
    }
     class Before2010CreditCalculate : CrediCalculatorBase
     {
          public override void Calculate()
          {
               Console.WriteLine("Credit calculated using before 2010");
          }


     }

        class After2010CreditCalculate : CrediCalculatorBase
     {
          public override void Calculate()
          {
               Console.WriteLine("Credit calculated using after 2010");
          }


     }
     class CustomerManager
     {
         public CrediCalculatorBase CrediCalculatorBase { get; set; }
         public void Save(){
            Console.WriteLine("Customer manager  businnes");
            CrediCalculatorBase.Calculate();
         }
     }
}


