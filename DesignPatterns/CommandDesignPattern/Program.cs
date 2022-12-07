using System;
using System.Collections.Generic;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock =new SellStock(stockManager);
            StockController stockController =new StockController();
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(buyStock);
            stockController.PlaceOrders();

            
        }
    }
    class StockManager
    {
        private string _name="Laptop";
        private int _quantity=10;

        public void Buy(){
            Console.WriteLine($"Stock {_name} , {_quantity} bougth!");
        }

        public void Sell(){
            Console.WriteLine($"Stock {_name} , {_quantity} sold!");

        }
    }
    interface IOrder
    {
        void Execute();
    }
     class BuyStock : IOrder
     {
         StockManager _stockManager;

          public BuyStock(StockManager stockManager)
          {
              _stockManager=stockManager;
          }

          public void Execute()
          {
              _stockManager.Buy();
          }
     }
      class SellStock : IOrder
     {
          StockManager _stockManager;

          public SellStock(StockManager stockManager)
          {
              _stockManager=stockManager;
          }
          public void Execute()
          {
               _stockManager.Sell();
          }
     }
     class StockController
     {
         List<IOrder> _orders = new List<IOrder>();

         public void TakeOrder(IOrder order){
             _orders.Add(order);
         } 
         public void PlaceOrders(){
             foreach (var order in _orders)
             {
                 order.Execute();
             }
             _orders.Clear();
         }
     }
}

