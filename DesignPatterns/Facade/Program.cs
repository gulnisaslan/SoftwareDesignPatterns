using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Save();
        }
    }
    class Logging:ILogging
    {
        public void Log(){
            System.Console.WriteLine("Logged");
        }
    }
     class Caching:ICaching
    {
        public void Cache(){
            System.Console.WriteLine("Caching");
        }
    }
     class Autorize:IAutorize
    {
        public void CheckUser(){
            System.Console.WriteLine("User check");
        }
    }
      class Validation:IValidate
    {
        public void Validate(){
            System.Console.WriteLine( "Validated");
        }
    }


    class CustomerManager
    {
       private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns=new CrossCuttingConcernsFacade();
            
        }
        public void Save(){
           _concerns.Caching.Cache();
           _concerns.Autorize.CheckUser();
           _concerns.Logging.Log();
           _concerns.Validation.Validate();
            System.Console.WriteLine("Saved");
        }

    }
    class CrossCuttingConcernsFacade
    {
        public IAutorize Autorize;
        public ICaching Caching;
       public ILogging Logging;
       public IValidate Validation;

        public CrossCuttingConcernsFacade()
        {
            Autorize=new Autorize();
            Caching=new Caching();
            Logging=new Logging();
            Validation=new Validation();
        }
    }


    //interfaces
    interface IAutorize
    {
        void CheckUser();
    }
     
     interface ILogging
    {
        void Log();
    }
   
    interface ICaching
    {
        void Cache();
    }
    interface IValidate
    {
        void Validate();
    }
}
