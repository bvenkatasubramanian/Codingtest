using System;
using System.Collections.Generic;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Engine engine = new Engine();
            var list = engine.AddProducts();
            

            Console.WriteLine("List SKUID and Price");

            foreach(var i in list)
            {
                Console.WriteLine(i.Unit.ToString() + " - " + i.Price.ToString() + "Promo: Buy"+ i.promounit);
            }

            engine.OrderProducts();
            
        }

       
    }
}
