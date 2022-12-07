using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager=new CustomerManager();= Bu şekilde newleyemeyiz
            var customerManager =CustomerManager.CreateAsSingleton();// Bu şekilde uretebiliriz
            customerManager.Save();
        }
    }
    
    //S.D.P.(Singleton Design Pattern) class'ın
    //private Cunstructor'ın olustururuz.
    //Buradaki amacımız burayı dış erişime kapatmaktır.
    //CustomerManager dönen public ve static bir  metod yazarız.
    class CustomerManager{
        static CustomerManager _customerManager;
        static object _lockObject =new object();
        private CustomerManager(){
           
        }

        public static CustomerManager CreateAsSingleton(){
            //if(_customerManager==null){
               // _customerManager=new CustomerManager();
           // }
            //return _customerManager; //or
           // return _customerManager ?? ((lock(_lockObject)
            //_customerManager=new CustomerManager()));(bu kod, bu şekil de refactor edilmez.)
            lock(_lockObject){
                if(_customerManager==null){
                   _customerManager=new CustomerManager();
                }
            }
            return _customerManager;
        }

        public  void Save(){
            Console.WriteLine("kaydet");
        }
    }
}
