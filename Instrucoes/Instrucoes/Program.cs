using System;

namespace Instrucoes
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Declaracoes()
            {
                int a;
                int b = 2, c = 3;
                const int d = 4;
                a = 1;

                Console.WriteLine(a + b + c + d);
            }

            static void InstrucaoIf(string[] args)
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Nenhum argumento");
                }
                else if (args.Length == 1)
                {
                    Console.WriteLine("Um argumento");
                }
                else
                {
                    Console.WriteLine($"{args.Length} argumentos");
                }
            }

            static void InstrucaoSwitch(string[] args)
            {
                int numeoDeArgumentos = args.Length;

                switch (numeoDeArgumentos)
                {
                    case 0:
                        Console.WriteLine("Nenhum argumento");
                        break;
                    case 1:
                        Console.WriteLine("Um argumento");
                        break;
                    default:
                        Console.WriteLine($"{numeoDeArgumentos} argumentos");
                        break;
                }
            }

            static void InstrucaoWhile(string[] args)
            {
                int i = 0;

                while (i < args.Length)
                {
                    Console.WriteLine(args[i]);
                    i++;
                }
            }

            static void InstrucaoDo(string[] args)
            {
                string texto;

                do
                {
                    texto = Console.ReadLine();
                    Console.WriteLine(texto);
                } while (!string.IsNullOrEmpty(texto));
            }

            static void InstrucaoFor(string[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }

            static void InstrucaoForeach(string[] args)
            {
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
