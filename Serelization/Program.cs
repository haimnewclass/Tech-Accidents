using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using Item.BL;
using System.Text.Json;
namespace Serelization
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

     public Data data { get; set; }
    }
    public class Data
    {
        public int Lins { get; set; }
        public string Img { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample3();
            
        }

        static void Sample3()
        {
            ProductItem pi = new ProductItem()
            {
                imgUrl = "1111111",
                name = "ddddddd",
                price = 2.7f,
                details = new Details()
                {
                    HowToUse = "2222222222222",
                    years = 10
                }
            };

            string str = JsonSerializer.Serialize(pi);
            pi = JsonSerializer.Deserialize<ProductItem>(str);
        }
        static void Sample2()
        {
            // read json file
            string data = System.IO.File.ReadAllText(@"C:\Code\CSV\AccidentsReport\Serelization\Products.json");

            // deserializetion
            Product[] arr = JsonSerializer.Deserialize<Product[]>(data);
            float max = arr[0].price;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].price>max)
                {
                    max = arr[i].price;
                }
            }

        }
        static void Sample()
        {
            Item item = new Item();
            item.Id = 122;
            item.Name = "Cola";
            item.Price = 6;
            item.data = new Data()
            {
                Img = "wwwwwww",
                Lins = 456
            };

            string ser = System.Text.Json.JsonSerializer.Serialize(item);
            System.IO.File.WriteAllText("serializ.txt", ser);

            string loadedStr = System.IO.File.ReadAllText("serializ.txt");

            Item newItem = System.Text.Json.JsonSerializer.Deserialize<Item>(loadedStr);

            Item[] arr = new Item[10];
            arr[0] = newItem;
            arr[1] = newItem;
            arr[2] = newItem;
            arr[3] = newItem;
            ser = System.Text.Json.JsonSerializer.Serialize(arr);
            System.IO.File.WriteAllText("serializ_Arr.txt", ser);

            Item[] arr2 = System.Text.Json.JsonSerializer.Deserialize<Item[]>(ser);

        }
    }
}
