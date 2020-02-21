using System;
using System.Collections.Generic;
using System.Ling;
using Sistem.IO;
using System.Threading.Tasks;
using Text;
using Newtonssoft.Json.Linq;

namespace PracticaDos
{ 
    class Memoria
    {
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObjct = JObject.Parse(dbJSON);
            var result = dbObjct.ToString();
            Console.WriteLine(result);
        }
    }

}
