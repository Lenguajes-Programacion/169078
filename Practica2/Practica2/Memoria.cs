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
        public void arreglo()
        {
            string [] colores = {"rojo", "blanco", "morado"};
                Array.Reverse(colores);
                Array.ForEach(colores, (item)=> {
                    Console.WriteLine(item);
                    });
            String color = Array.Find(colores, (item) => {
                return item.Length > 4;
                    });
            Console.WriteLine(color);
            Console.WriteLine("accede a tus colores y separalaos con comas(,)");
            string coloruser = Console.ReadLine();
            string[] newColors = coloruser.Split(',');
            Console.WriteLine(newColors);
        }
        public void multidimensional()
        {
            int [,] array =  new int [4,2];
            Console.WriteLine(array);
        }
    
    }
}

