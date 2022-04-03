using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using System.Text.Json;
namespace Serelization
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

     
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Item item = new Item();
            item.Id = 122;
            item.Name = "Cola";
            item.Price = 6;

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
