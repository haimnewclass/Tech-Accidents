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

        public void CreateBulkFiles(int filesCount,string folderName)
        {
            Random r = new Random();
            for (int i = 0; i < filesCount; i++)
            {
                string filename = $"{folderName}{Guid.NewGuid()}.csv";
                Run(r.Next(100, 1000), filename);
            }
        }
    }
}
