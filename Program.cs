using System;
using System.Dynamic;
using System.Numerics;
using System.Reflection;
using Calculator.Enum;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção:");
            
            string? inputMenu = Console.ReadLine();
            while (String.IsNullOrEmpty(inputMenu))
            {
                Console.WriteLine("É obrigatorio selecionar uma opção:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("--------------------");
                Console.WriteLine("Selecione uma opção:");
                inputMenu = Console.ReadLine();
            }

            int operador = int.Parse(inputMenu);
            CalculaValor((EOperadorMatematico)operador);
        }

        static void CalculaValor(EOperadorMatematico operacao)
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor:");

            string? inputV1 = Console.ReadLine();
            while (String.IsNullOrEmpty(inputV1))
            {
                Console.WriteLine("É obrigatorio informar o primeiro valor:");
                inputV1 = Console.ReadLine();
            }

            Console.WriteLine("Informe o segundo valor:");
            string? inputV2 = Console.ReadLine();
            while (String.IsNullOrEmpty(inputV2))
            {
                Console.WriteLine("É obrigatorio informar o segundo valor:");
                inputV2 = Console.ReadLine();
            }
            
            float v1 = float.Parse(inputV1);
            float v2 = float.Parse(inputV2);
            float resultado;

            switch (operacao)
            {
                case EOperadorMatematico.adicao:
                    resultado = v1 + v2;
                    break;
                case EOperadorMatematico.subtracao:
                    resultado = v1 - v2;
                    break;
                case EOperadorMatematico.multiplicacao:
                    resultado = v1 * v2;
                    break;
                case EOperadorMatematico.divisao:
                    resultado = v1 / v2;
                    break;
                default:
                    resultado = 0f;
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine($"O resultado da {operacao} é {resultado}");
            Console.ReadKey();
        }      
    }
}

