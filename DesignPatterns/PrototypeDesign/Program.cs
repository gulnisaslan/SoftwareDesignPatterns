using System;

namespace PrototypeDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer =new Customer{FirstName="Gülnisa ",LastName="Aslan",City="Gaziantep",Id=1};
            Customer customer2=(Customer)customer.Clone();
            customer2.FirstName="Ercan";
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }

    public abstract class Person{

        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer:Person{
        public string City { get; set; }

          public override Person Clone()
          {
              return (Person) MemberwiseClone();
          }

        
          
     }

      public class Employee:Person{
        public decimal Salary { get; set; }

          public override Person Clone()
          {
              return (Person) MemberwiseClone();
          }

        
          
     }
}
