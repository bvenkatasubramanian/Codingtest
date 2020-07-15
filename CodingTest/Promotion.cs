using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public static class Promotion
    {
       public static double ApplyPromotion(string SKUId, int quantity)
        {
            if (SKUId == "A")
            {
                if(quantity ==3)
                {
                    return 130;
                }
            }

            if (SKUId == "D" && SKUId=="C")
            {
                return 30;
            }
            

            if (SKUId == "B")
            {
               if(quantity == 2)
                {
                    return 45;
                }
            }
            return 0;
        }
    }
}
