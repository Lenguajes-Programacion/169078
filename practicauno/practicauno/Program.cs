using System;
// importamos la libreria pricipal

namespace practica_1
{
    class Program
    {
        //variable de la clase
         static string nombre = "Fernanda";

        static void Main(string[] args)
        {
            //Respondemos con el primer argumento 
            // Condicion se debe de cumplir todas las sentencias si utilizamos &&
            // Condicion se debe de cumplir cualquier de las sentencias si utilizamos ||
            // Tipos de comparaciones > < == >= <= !=
            // false is true
            if (args[0].Length > 0 && args[0] == nombre) // true o false
            {
                Console.WriteLine($"Hola {args[0]}");
            }
            else
            {
                Console.WriteLine("usuario no permitido");
            }
        }
    }
}