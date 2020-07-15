using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    interface IProducts
    {
        double getPrice(string SKUId, int quantity);
    }
}
