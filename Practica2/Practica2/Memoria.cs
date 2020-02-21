using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace calculadora1
{
    public class Memoria
    {

        public void LeerMemoria()
        {
            string arcivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(arcivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //Prueba de lectura de archivo db.json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //Lectura de json iterable 
            foreach ( var item in dbObject)
            {
                // Iteracion individual de casa grupo de datos del objeto json.
                Console.WriteLine("Dato en memoria:");
                Console.WriteLine(item.ToString());
            }
           
        }
    }
}

