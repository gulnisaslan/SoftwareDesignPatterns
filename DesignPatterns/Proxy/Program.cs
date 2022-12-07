using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CrediManagerProxy crediManager= new CrediManagerProxy();
            Console.WriteLine(crediManager.Calculate());
            Console.WriteLine(crediManager.Calculate());
            
        }
    }
    // Abstract Class
    abstract class CreditBase
    {
        public abstract int Calculate();
    }
     //class
     class CrediManager:CreditBase
     {
        
         public override int Calculate()
          {
               int result = 1;
                for (int i = 1; i < 5; i++)
                {
                    result *= i;
                    Thread.Sleep(1000);
                } 
                return result;
          }
     }

     class CrediManagerProxy : CreditBase
     {
         private CrediManager _creditManager;
         private int _cacheValue;
          public override int Calculate()
          {
            if(_creditManager==null){
                _creditManager=new CrediManager();
                _cacheValue=_creditManager.Calculate();
            }
            return _cacheValue;
          }
     }
}




