using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentsUI
{
    public static class DataBank
    {
        private static bool AlreadyInit = false;
        public  static void Init()
        {
            RandomNames = new string[4];

            RandomNames[0] = "Moshe";
            RandomNames[1] = "Avi";
            RandomNames[2] = "Yossi";
            RandomNames[3] = "Gil";

            AlreadyInit = true;
        }
        public static string[] RandomNames;
        public static string GetRandomName()
        {
            if (!AlreadyInit) Init();

            Random r = new Random();
            return RandomNames[r.Next(0,RandomNames.Length-1)];
        }
    }
}
