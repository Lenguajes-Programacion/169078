using System;

namespace Practica1
{
    class Persona
    {
        static void Main()
        {
            string Nombre = "Maria";

            Console.WriteLine("Dime tu primer nombre");
            Nombre = Console.ReadLine();
            if (Nombre == "maria")
            {
                Console.WriteLine("Hola " + Nombre);

            }
            else
            {
                Console.WriteLine("no te conozco " + Nombre);

            }
            Console.ReadKey();
        }
    }
}