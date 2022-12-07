using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager =new Manager();
            VicePresident vicePresident=new VicePresident();
            President president =new President();
            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);
            Expense expense=new Expense{Detail="Training",Amount=1200};
            manager.HandleExpense(expense);

        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }

    abstract class ExpenseHandlerBase 
    {
        protected ExpenseHandlerBase _successor;
        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase successor){
            _successor=successor;
        }
    }

     class Manager : ExpenseHandlerBase
     {
          public override void HandleExpense(Expense expense)
          {
               if (expense.Amount<=100)
               {
                  Console.WriteLine("Manager handled the expense");
               }
               else if(_successor!=null)
               {
                   _successor.HandleExpense(expense);
               }
          }
     }

     class VicePresident : ExpenseHandlerBase
     {
          public override void HandleExpense(Expense expense)
          {
              if (expense.Amount>100 && expense.Amount<=1000)
               {
                  Console.WriteLine("Vice President handled the expense");
               }
               else if(_successor!=null)
               {
                   _successor.HandleExpense(expense);
               }
          }
     }
     class President : ExpenseHandlerBase
     {
          public override void HandleExpense(Expense expense)
          {
              if (expense.Amount>1000)
               {
                  Console.WriteLine("President handled the expense");
               }
               else if(_successor!=null)
               {
                   _successor.HandleExpense(expense);
               }
          }
     }

}
