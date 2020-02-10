using System;
namespace calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operadorES;
            int Suma, Resta, Multiplicacion, Variable1, Variable2;
            Console.WriteLine("Realiza una operacion");
            Console.WriteLine("Escribe el primer digito");
            Variable1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un operador");
            operadorES = Console.ReadLine();
            Console.WriteLine("Escribe el segundo digito");
            Variable2 = Int32.Parse(Console.ReadLine());

            Suma = Variable1 + Variable2;
            Resta = Variable1 - Variable2;
            Multiplicacion = Variable1 * Variable2;
            double Division = (Variable1 / Variable2);


            switch (operadorES)
            {
                case "+" :
                    Console.WriteLine("El resultado de tu suma es: " + Suma);
                    break;

                case "-":
                    Console.WriteLine("El resultado de tu resta es: " + Resta);
                    break;

                case "*":
                    Console.WriteLine("El resultado de tu multiplicacion es: " + Multiplicacion);
                    break;

                case "/":
                    Console.WriteLine("El resultado de tu division es: " + Division);
                    break;

                default:
                    Console.WriteLine("Intentalo de nuevo " + operadorES);
                    break;


            }
            Console.ReadLine();
        }
    }
}