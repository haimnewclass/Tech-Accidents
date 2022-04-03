using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentsUI
{
    public class ReadCSVFiles
    {
        
        public void ScanAndReadAllCSVFiles(string folder)
        {
            string[] list = System.IO.Directory.GetFiles(folder);

            for (int i = 0; i < list.Length; i++)
            {
                ReadCSVFile readCSVFile = new ReadCSVFile(list[i]);
                //string[] lines = readCSVFile.Read();
                Product[] products = readCSVFile.LoadProducts();

            }
        }
    }
}
