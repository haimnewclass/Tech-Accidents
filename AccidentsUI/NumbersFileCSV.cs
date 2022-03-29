using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AccidentsUI
{
    public class NumbersFileCSV
    {
        string fileName;
        public NumbersFileCSV(string fName)
        {
            fileName = fName;
        }

        //123,123,234
        public void Create(int linesCount)
        {
            string[] lines = new string[linesCount];
            Random r = new Random();

            for (int i = 0; i < lines.Length; i++)
            {                
                lines[i] = r.Next(1, 999).ToString();
            }

            File.WriteAllLines(fileName, lines);
        }
    }
}
