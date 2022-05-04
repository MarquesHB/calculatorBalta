using System;

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
            Console.WriteLine("O que desejar calcular?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------------");

            Console.WriteLine("Digite a opção desejada: ");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Console.ReadKey();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1+v2;
            Console.WriteLine($"O Resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1-v2;
            Console.WriteLine($"O Resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Divisao()
        {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1/v2;
            Console.WriteLine($"O Resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao()
        {
            
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1*v2;
            Console.WriteLine($"O Resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
