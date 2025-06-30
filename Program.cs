using System;
using System.Dynamic;
using System.Numerics;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma();
        }

        static void CalculaValor(string operador)
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            //Validar a Entrada do Primeiro Valor (Verificar se não esta vazia)
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            //Validar a Entrada do Segundo Valor (Verificar se não esta vazia)
            float v2 = float.Parse(Console.ReadLine());

            float resultado;
            switch (operador)
            {
                case "+":
                    resultado = v1 + v2;
                    break;
                case "-":
                    resultado = v1 - v2;
                    break;
                case "*":
                    resultado = v1 * v2;
                    break;
                case "/":
                    resultado = v1 / v2;
                    break;
                default:
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {v1 / v2}");
            Console.ReadKey();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            //Validar a Entrada do Primeiro Valor (Verificar se não esta vazia)
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            //Validar a Entrada do Segundo Valor (Verificar se não esta vazia)
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            //Validar a Entrada do Primeiro Valor (Verificar se não esta vazia)
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            //Validar a Entrada do Segundo Valor (Verificar se não esta vazia)
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {v1 - v2}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            //Validar a Entrada do Primeiro Valor (Verificar se não esta vazia)
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            //Validar a Entrada do Segundo Valor (Verificar se não esta vazia)
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {v1 / v2}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            //Validar a Entrada do Primeiro Valor (Verificar se não esta vazia)
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            //Validar a Entrada do Segundo Valor (Verificar se não esta vazia)
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {v1 * v2}");
            Console.ReadKey();
        }        
    }
}

