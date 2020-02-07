using System;

namespace Practica2
{
    class Program
    {
        //Proyecto calculadora
        //Se espera recibir los argumentos valor1 (int) valor2 (string)
        //valor3 (int)
        //responder resultado en (int)
        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "+":
                    Console.WriteLine("Es una suma");
                    break;

                case "-":
                    Console.WriteLine("Es una resta");
                    break;

                case "*":
                    Console.WriteLine("Es una multiplicacion");
                    break;

                case "/":
                    Console.WriteLine("Es una divicion");
                    break;

                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido" + args[1]);
                    break;
            }
        }
    }
}
