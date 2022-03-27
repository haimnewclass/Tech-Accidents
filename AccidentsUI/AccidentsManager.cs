using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentsUI
{
    public class AccidentsManager
    {
        public Accidents Accidents;
        public AccidentsManager()
        {
            string fname = @"C:\Users\ASI\source\repos\AccidentsReport\AccidentsUI\Data\2019.csv";
            Accidents = new Accidents(fname);
        }

    }
}
