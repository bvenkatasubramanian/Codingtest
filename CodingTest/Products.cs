using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    class Products : IProducts
    {
        public double getPrice(string SKUId, int quantity)
        {
            if(SKUId == "A" && quantity==1)
            {
                return 50;
            }
            else if (SKUId == "A" && quantity >= 3)
            {
                var quantsnumerator = (quantity/3);
                var quantsdenominator = quantity % 3;

                if (quantsnumerator >= 1)
                {
                    return ((quantsnumerator * 130) + (quantsdenominator * 50));
                }

                
            }

            if (SKUId == "B" && quantity==1)
            {
                return 30;
            }

            if (SKUId == "B" && quantity >= 2)
            {
                var quantsnumerator = (quantity / 2);
                var quantsdenominator = quantity % 2;

                if (quantsnumerator >= 1)
                {
                    return ((quantsnumerator * 45) + (quantsdenominator * 30));
                }
            }

            if (SKUId == "C" && quantity == 1)
            {
                return 20;
            }
            if (SKUId == "C" && quantity >= 1)
            {
                var quantsnumerator = (quantity / 1);
                var quantsdenominator = quantity % 1;

                if (quantsnumerator >= 1)
                {
                    return ((quantsdenominator * 20));
                }
            }


            if (SKUId == "D" && quantity == 1)
            {
                return 15;
            }

            if (SKUId == "D" && quantity >=1)
            {
                var quantsnumerator = (quantity / 1);
                var quantsdenominator = quantity % 1;

                if (quantsnumerator >= 1)
                {
                    return ((quantsdenominator * 15));
                }
            }

            if(SKUId == "E" && quantity == 1)
            {
                return 30;
            }

            return 0;
        }
    }
}
