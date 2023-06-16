using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
     public class Car
     {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        
        public void Start()
        {
            Console.WriteLine("The car is starting.");
        }

      
        public void Stop()
        {
            Console.WriteLine("The car is stopping.");
        }
     }
   
       
}
