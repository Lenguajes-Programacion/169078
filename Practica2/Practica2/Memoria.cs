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

       static void Main(String[] args)
        {
            bool salir = false;
            while (!salir)
            {
                //Arreglo unidimensional
                Console.WriteLine("Arreglo Sencillo");
                string[] sencillo = { "Rojo", "Blanco", "Morado" };
                Console.WriteLine("[{0}]", string.Join(", ", sencillo));
                Console.WriteLine("Arreglo Dos Dimensiones");
                int[,] dosDimensiones = new int[5, 5];
                
                for (int i = 0; i < dosDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < dosDimensiones.GetLength(1);j++)
                    {
                        dosDimensiones[i, j] = i+j;
                        Console.WriteLine("{0},{1}={2}", i,j,dosDimensiones[i,j]);
                    }
                }
                Console.WriteLine("Arreglo Tres Dimensiones");
                int[,,] tresDimensiones = new int[5, 5, 5];
                for (int i = 0; i < tresDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < tresDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < tresDimensiones.GetLength(2); k++)
                        {
                            tresDimensiones[i, j, k] = i + j + k;
                            Console.WriteLine("{0},{1},{2}={3}", i, j,k, tresDimensiones[i, j,k]);
                        }
                    }
                }
                Console.WriteLine("Arreglo 4 Dimensiones");
                int[,,,] cuatroDimensiones = new int[5, 5, 5,5];
                for (int i = 0; i < cuatroDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < cuatroDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < cuatroDimensiones.GetLength(2); k++)
                        {
                            for (int l = 0; l < cuatroDimensiones.GetLength(3); l++)
                            {
                                cuatroDimensiones[i, j, k,l] = i + j + k+l;
                                Console.WriteLine("{0},{1},{2},{3}={4}", i, j, k,l, cuatroDimensiones[i, j, k,l]);
                            }
                        }
                    }
                }
                string exit = Console.ReadLine();
                if(exit == "y")
                {
                    salir = true;
                }
            }
        }
    }
    
    
}

