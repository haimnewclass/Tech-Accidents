using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentsUI
{
    public class CreateRandomFiles
    {
        public void Run(int linesCount,string fName)
        {
            NumbersFileCSV numbersFileCSV = new NumbersFileCSV(fName);
            numbersFileCSV.Create(linesCount);
        }
    }
}
