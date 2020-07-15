using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

                List<Order> details = new List<Order>();

                var detailsA = (from c in orders
                              where c.Unit == "A"
                              select c.Quantity).Sum();

                details.Add(new Order() { Unit = "A", Quantity = detailsA });

                var detailsB = (from c in orders
                                where c.Unit == "B"
                                select c.Quantity).Sum();
                details.Add(new Order() { Unit = "B", Quantity = detailsB });

                var detailsC = (from c in orders
                                where c.Unit == "C"
                                select c.Quantity).Sum();

                details.Add(new Order() { Unit = "C", Quantity = detailsC });

                var detailsD = (from c in orders
                                where c.Unit == "D"
                                select c.Quantity).Sum();

                details.Add(new Order() {  Unit="D", Quantity= detailsD});


                var specialofferC = false;
                var specialofferD = false;
                var cunit = false;
                var dunit = false;
                var counter = 0;
                var cquants = 0;
                var dquants = 0;
                double total = 0;
                
                foreach (var ij in details)
                {
                    if(ij.Unit=="C" && ij.Quantity > 0)
                    {
                        specialofferC = true;
                        cquants = ij.Quantity;
                    }

                    if(ij.Unit =="D" && ij.Quantity > 0)
                    {
                        specialofferD = true;
                        dquants = ij.Quantity;
                    }

                    if(specialofferC && specialofferD)
                    {
                        details[2].Quantity = cquants - 1;
                        details[3].Quantity = dquants - 1;
                        total +=30;
                        
                    }

                    counter++;
                }
                

                
                
                foreach (var im in details)
                {
                    //if(specialofferC && specialofferD && (im.Unit=="C" || im.Unit =="D"))
                    //{
                    //    total -= 2.5;
                    //}
                    
                    total += prods.getPrice(im.Unit.ToString(), Convert.ToInt32(im.Quantity));
                }
               
                Console.WriteLine("Total" + total);
                //Console.ReadLine();
            }



        }
    }
}
