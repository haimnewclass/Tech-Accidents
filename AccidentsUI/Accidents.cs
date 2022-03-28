using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AccidentsUI
{
    public class Accidents
    {
        //public Accident[] arr2 = new Accident[2019099997];

        public System.Collections.Hashtable hash = new System.Collections.Hashtable();
        public Accident[] arr;
        public string fileName;
        public string[] fieldNames;

        public Accidents(string aFileName)        
        {
            fileName = aFileName;
            Load(fileName);
        }


        public string GetSugDerechByAccidentId(long id)
        {
           

            Accident acc = (Accident) hash[id];
            
            return acc.SugDerech;
        }
        public byte GetTkinutByAccidentId(long id)
        {
            

            byte ret = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i].id==id)
                {
                    ret =  arr[i].Tkinut;
                }
            }

            return ret;
            
        }

        public void Load(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            arr = new Accident[lines.Length];
            fieldNames = lines[0].Split(',');
            for (int i = 1; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');

                Accident accident = new Accident()
                {
                    id = int.Parse(line[FieldNameToNumber("pk_teuna_fikt")]),
                    SugDerech = line[FieldNameToNumber("SUG_DEREH")],
                    SugTeuna = line[FieldNameToNumber("SUG_TEUNA")],                    
                    Tkinut = byte.Parse(line[FieldNameToNumber("TKINUT")]) 
                };

                arr[i - 1] = accident;
                hash.Add(accident.id, accident);
                
            }
        }


        public int FieldNameToNumber(string name)
        {
            string upper = name.ToUpper();
            for (int i = 0; i < fieldNames.Length; i++)
            {
                if (upper.Equals(fieldNames[i].ToUpper()))
                    return i;
            }
            return -1;  // case field not found
        }

    }
}
