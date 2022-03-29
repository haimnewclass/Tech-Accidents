using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentsUI
{
    public class ReadCSVFile
    {
        string fileName;
        public ReadCSVFile(string fname)
        {
            fileName = fname;
        }
        public string[] Read()
        {
            string[] ret;

            ret = System.IO.File.ReadAllLines(fileName);

            return ret;
        }
    }
}
