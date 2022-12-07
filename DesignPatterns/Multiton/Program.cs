using System;
using System.Collections.Generic;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera = Camera.GetCamera("Nikon");
            Camera camera1 = Camera.GetCamera("Nikon");
            Camera camera2= Camera.GetCamera("Canon");
            Camera camera3 = Camera.GetCamera("Canon");
            Console.WriteLine(camera.Id);
            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera2.Id);
            Console.WriteLine(camera3.Id);

        }
 
   }
   class Camera{
       static Dictionary<string,Camera> _cameras =new Dictionary<string, Camera>();
       static object _lock =new object();
       
       public Guid Id{get;set;}

       private Camera(){
           Id =Guid.NewGuid();

       }
       public static Camera GetCamera(string brand){
           lock (_lock){
               if (!_cameras.ContainsKey(brand))
               {
                   _cameras.Add(brand,new Camera());
               }

           }
           return _cameras[brand];
       }
   }
}
