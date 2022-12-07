using System;

namespace AbstractFactory
{
     class Program
     {
          static void Main(string[] args)
          {
             // ProductManager productManager =new ProductManager(new Factory1());
          }
     }
     public abstract class Logging
     {
          public abstract void Log(string message);
     }

     public class Log4NetLogger : Logging
     {
          public override void Log(string message)
          {
               Console.WriteLine("Logged with Log4net");
          }
    }
      public class NLogger : Logging
     {
          public override void Log(string message)
          {
               Console.WriteLine("Logged with Log4net");
          }
     }
     public abstract class Caching{
         public abstract void Cache(string data);

     }


     public class MemCahce : Caching
     {
          public override void Cache(string data)
          {
               System.Console.WriteLine("Cahcing with Memcache");
          }
     }

       public class RedisCahce : Caching
     {
          public override void Cache(string data)
          {
               System.Console.WriteLine("Caching with RedisCahce");
          }
     }

     public abstract class CrossCuttingConcernsFactory1{
         public  abstract Logging CreateLogger();
         public abstract Caching CreateCaching();
     }
     public class Factory1 : CrossCuttingConcernsFactory1
     {
       public  override Logging CreateLogger(){
            return new Log4NetLogger();
       }
         public override Caching CreateCaching(){
              return new RedisCahce();
         }
     }
       public class Factory2 : CrossCuttingConcernsFactory1
     {
       public  override Logging CreateLogger(){
            return new NLogger();
       }
         public override Caching CreateCaching(){
              return new RedisCahce();
         }
     }
     public class ProductManager{
         private CrossCuttingConcernsFactory1 _crossCuttingConcerns1;
        private Logging _logging;
        private Caching _caching;
        

        

          public ProductManager(CrossCuttingConcernsFactory1 crossCuttingConcerns1,
           Logging logging, Caching caching)
          {
               _crossCuttingConcerns1 = crossCuttingConcerns1;
                _caching= caching;
                _logging=logging;
         }

          

          public void GetAll(){
             _logging.Log("string");
             _caching.Cache("data");
             System.Console.WriteLine("Products listed");
         }
     }
}
