using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serelization
{
    public class Details
    { 
        public string HowToUse { get; set; }
        public int years { get; set; }

    }

    public class ProductItem
    {
        public string imgUrl { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public Details details { get; set; }

    }

    public class Product
    {
        public string imgUrl { get; set; }
        public string name { get; set; }
        public float price { get; set; }

    }
}
