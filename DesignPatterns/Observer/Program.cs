using System;
using System.Collections.Generic;

namespace Observer
{ 
        class Program
    {
        static void Main(string[] args)
        { 
            var customerObserver=new CustomerObserver();
            var employeeObserver= new EmployeeObserver();
            ProductManager productManager=new ProductManager();
            productManager.Attach(customerObserver);
            productManager.Attach(employeeObserver);
            productManager.Detach(customerObserver);
            productManager.Detach(employeeObserver);
            productManager.UpdatePrice();
        }
    }

    class ProductManager
    {
        List<Observer> _observers= new List<Observer>();
        public void UpdatePrice(){
            Console.WriteLine("Product price changed");
             Notify();
        }
         public void Attach(Observer observer){
              _observers.Add(observer);
          }
           public void Detach(Observer observer){
              _observers.Remove(observer);
          }
          private void Notify(){
              foreach (var observer in _observers)
              {
                  observer.Update();
              }
          }
    }
   abstract class Observer
    {
        public abstract void Update();
    }
     class CustomerObserver : Observer
     {
         

         public override void Update() 
          {
            Console.WriteLine("Message To Customer:Product price changed");
           
          }
     }
         
          
    

    class EmployeeObserver : Observer
     {
          public override void Update()
          {
                 Console.WriteLine("Message To employee :Product price changed");
        }
    }

}

