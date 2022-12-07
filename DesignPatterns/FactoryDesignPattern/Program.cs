using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager = new CustomerManager();
           customerManager.Save(new LoggerFactory());
        }
    }

    public class LoggerFactory:ILoggerFactory{
        public ILogger CreateLogger(){
            //Business to decide
            return new EDLogger();
        }
    }
    public class LoggerFactory2:ILoggerFactory{
        public ILogger CreateLogger(){
            //Business to decide
            return new EDLogger();
        }
    }

    public interface ILogger{
        void log();
    }

    //çıplak class kalmasın.:)
    public interface ILoggerFactory{
         ILogger CreateLogger();
    }
    public class EDLogger:ILogger{
        public void log(){
            System.Console.WriteLine("ED loglandı");
        }
    }

    public class CustomerManager{
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory =loggerFactory;
        }
        public void Save(){
            System.Console.WriteLine("Saved");
            //ILogger logger = new LoggerFactory().CreateLogger();
           ILogger logger=_loggerFactory.CreateLogger();
            logger.log();
        }
    }
s
   
}
