using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    class Engine
    {
        public List<Product> AddProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product() { Unit = "A", Price = 50, promounit = 3 });
            list.Add(new Product() { Unit = "B", Price = 30, promounit = 2 });
            list.Add(new Product() { Unit = "C", Price = 20, promounit = 1 });
            list.Add(new Product() { Unit = "D", Price = 15, promounit = 1 });
            return list;
        }

        public void OrderProducts()
        {
            List<Order> orders = new List<Order>();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Enter the product type you wish to order");
                var a = Console.ReadLine();
                
                Console.WriteLine("Enter the quantity");
                var b = Console.ReadLine();

                Products prods = new Products();

                try
                {
                    int value;
                    if (int.TryParse(b, out value))
                    {
                        orders.Add(new Order() { Unit = a, Quantity = Convert.ToInt32(b) });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter an integer value");
                }

                var specialofferC = false;
                var specialofferD = false;

                foreach(var ij in orders)
                {
                    if(ij.Unit=="C" && ij.Quantity == 1)
                    {
                        specialofferC = true;
                       
                    }
                    if(ij.Unit =="D" && ij.Quantity == 1)
                    {
                        specialofferD = true;
                    }
                }

                double total = 0;
                
                foreach (var im in orders)
                {
                    
                    total += prods.getPrice(im.Unit.ToString(), Convert.ToInt32(im.Quantity));
                }
               
                Console.WriteLine("Total" + total);
                //Console.ReadLine();
            }



        }
    }
}
