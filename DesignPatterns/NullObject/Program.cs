using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager(new StubLogger());
        }
    }
    class CustomerManager
    {
        private ILogger _logger;
        public CustomerManager(ILogger logger ){
            _logger=logger;
        }
        public void Save(){
            Console.WriteLine("Saved");
            _logger.Log();
        }
    }
    interface ILogger
    {
        void Log();
    }
     class Log4NetLogger : ILogger
     {
      public void Log(){
          Console.WriteLine("Logged with Log4Net");
      }
     }
     class NLogLogger:ILogger
    {
          public void Log(){
          Console.WriteLine("Logged with NLog");

          
      }
    }
     class StubLogger : ILogger
     {
         private static StubLogger _stubLogger;
         private static object _lock=new object();
         public static StubLogger GetLogger(){
             lock(_lock){
                 if(_stubLogger==null){
                     _stubLogger=new StubLogger();
                 }
             }
             return _stubLogger;
         } 
          public void Log()
          {
               
          }

         
     }


     class CustomerManagerTests{
        public void SaveTest(){
            CustomerManager customerManager=new CustomerManager(new StubLogger());
            customerManager.Save();
        }
    }
}
