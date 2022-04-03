using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentsUI
{
    public  class Product
    {
        private Product()
        {

        }
        public static Product BuildFromCSVLine(string line)
        {
            Product product = new Product();
            string[] lines = line.Split(',');
          
            product.id = lines[0];
            product.price = int.Parse(lines[1]);
            product.quantity = int.Parse(lines[2]);
            product.tax = int.Parse(lines[3]);
            product.name = lines[4];
                
            return product; 
        }
        public string id;
        public int price;
        public int quantity;
        public int tax;
        public string name;
    }
}
