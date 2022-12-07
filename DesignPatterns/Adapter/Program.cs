using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager =new ProductManager(new Log4NetAdapter());
            productManager.Save();
        }
    }

    class ProductManager
    {  
        private ILogger _logger;
            public ProductManager(ILogger logger)
            {
                _logger=logger;
            }
        public void Save(){
            _logger.Log("User Data");
            System.Console.WriteLine("Saved");
        }
    }

    class EdLogger:ILogger
    {
        public  void Log(string message){
            System.Console.WriteLine("Logged, {0} ",message);
        }
    }

    
   

    //nuget indirdik
    class Log4Net
    {
        public void LogMessage(string message){
            System.Console.WriteLine("Logged with Log4net, {0} ",message);
        }
    }
    //interfaces
    interface ILogger
    {
        void Log(string message);
    }
    
   class Log4NetAdapter:ILogger
   {
         
        public void Log(string message){
            Log4Net log4Net=new Log4Net();
            log4Net.LogMessage(message);
        }
   }
 

 }  