using System;
using System.Linq;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Decorator
{
     class Program
    {
        static void Main(string[] args)
        {
            var personalCar=new PersonalCar{Make="bmw",Model="3.20",HirePrice=2500};
            SpecialOffer specialOffer =new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage=10;
            System.Console.WriteLine("Concrete : {0}",personalCar.HirePrice);
            System.Console.WriteLine("SpecialOffer : {0}",specialOffer.HirePrice);
        }
            
    }

    //abstract classes
    abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
        
    }

     //classes
     class PersonalCar : CarBase
     {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
     }


     class CommericalCar : CarBase
     {
         public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }

         
     }

     class CarDecoratorBase: CarBase
     {
         private CarBase _carBase;
          public CarDecoratorBase(CarBase carBase)
        {
            _carBase=carBase;
        }

           public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
         
     }

     class SpecialOffer : CarDecoratorBase
     {
         public int DiscountPercentage { get; set; }
         private readonly CarBase _carBase;
          public SpecialOffer(CarBase carBase) : base(carBase)
          {
              _carBase=carBase;
          }

          public override string Make { get => base.Make; set => base.Make = value; }
          public override string Model { get => base.Model; set => base.Model = value; }
          public override decimal HirePrice { get{return _carBase.HirePrice-_carBase.HirePrice*DiscountPercentage/100;} set => base.HirePrice = value; }

          
     }

}
