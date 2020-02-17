using System;
namespace calculadora1
{

    class calculadora
    {
        public float digito1, digito2, resultado, resultado2 = 0;  //declaracion de variables
        public bool op = false;

        //Funcion Principal

        static void Main()
        {
            calculadora opera = new calculadora();
            string operador;
            do
            {
                Console.WriteLine("Que operacion desea realizar?");
                Console.WriteLine("suma-------------- +");
                Console.WriteLine("resta------------- -");
                Console.WriteLine("multiplicacion---- *");
                Console.WriteLine("division---------- /");
                Console.WriteLine("salir------------- e");
                operador = (Console.ReadLine());
                switch (operador)
                {
                    case "+":
                        opera.Suma();//llamar las funciones
                        break;
                    case "-":
                        opera.Resta();
                        break;
                    case "*":
                        opera.Multi();
                        break;
                    case "/":
                        opera.Divi();
                        break;
                    case "e":
                        Console.Clear();
                        Console.WriteLine("adios:)", System.Environment.NewLine);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingresa un operador valido", System.Environment.NewLine);
                        break;
                }
            } while (operador != "e");


        }
        //Funcion para sumar----------------------------------------------------------------------------
        public float Suma()
        {
            if (op == true)
            {
                Console.WriteLine("Ingresa el nuevo digito: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado2 = resultado + digito2;
                resultado = resultado2;  //sustituir el valor de un valor en otro

            }
            else
            {
                Console.WriteLine("Primer Numero: ");
                digito1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Segundo Numero: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado = digito1 + digito2;
                op = true;

            }
            Console.WriteLine("Resultado = : " + resultado);

            return resultado;
        }

        //Funcion para restar--------------------------------------------------------------------------
        public float Resta()
        {
            if (op == true)
            {
                Console.WriteLine("Ingresa el nuevo digito: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado2 = resultado - digito2;
                resultado = resultado2;

            }
            else
            {
                Console.WriteLine("Digito 1: ");
                digito1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digito 2: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado = digito1 - digito2;
                op = true;

            }
            Console.WriteLine("Resultado = : " + resultado);

            return resultado;
        }
        //Funcion para multiplicar--------------------------------------------------------------------------
        public float Multi()
        {
            if (op == true)
            {
                Console.WriteLine("Ingresa el nuevo digito: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado2 = resultado * digito2;
                resultado = resultado2;

            }
            else
            {

                Console.WriteLine("Digito1 : ");
                digito1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digito 2: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado = digito1 * digito2;
                op = true;

            }
            Console.WriteLine("Resultado = : " + resultado);

            return resultado;
        }
        //Funcion para dividir--------------------------------------------------------------------------
        public float Divi()
        {
            if (op == true)
            {
                Console.WriteLine("Ingresa el nuevo digito: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado2 = resultado / digito2;
                resultado = resultado2;

            }
            else
            {

                Console.WriteLine("Digito 1: ");
                digito1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digito 2: ");
                digito2 = Int32.Parse(Console.ReadLine());
                resultado = digito1 / digito2;
                op = true;

            }
            Console.WriteLine("Resultado = : " + resultado);

            return resultado;
        }
    }
}