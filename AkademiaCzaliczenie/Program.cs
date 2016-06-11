using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCzaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int programStep = 0;
            float A, B;
            float result;
            while (true)
            {
                switch (programStep)
                {
                    case 0:
                        Console.Clear();
                        string[] mainMenu = { "Witam, elo, cześć, siemanko w bezużytecznym kalkulatorze :) \n\n",
                                  "MENU GŁÓWNE:\n", "[1] Dodawanie A+B", "[2] Odejmowanie A-B", "[3] Mnożenie A*B",
                                  "[4] Dzielenie A/B", "[5] Historia operacji", "[6] Wyjście\n\n" };
                        foreach (string text in mainMenu)
                        {
                            Console.WriteLine(text);
                        }
                        programStep = int.Parse(Console.ReadLine());
                        break;

                    case 1:
                        AdditionAB ADD = new AdditionAB();
                        EnterData(out A, out B);
                        ADD.a = A;
                        ADD.b = B;
                        result = ADD.AdditionABResult();
                        PrintResult(programStep, result);
                        programStep = 0;
                        break;
                    case 2:
                        SubstractAB SUB = new SubstractAB();
                        EnterData(out A, out B);
                        SUB.a = A;
                        SUB.b = B;
                        result = SUB.SubstractABResult();
                        PrintResult(programStep, result);
                        programStep = 0;
                        break;
                    case 3:
                        MultiplyAB MUL = new MultiplyAB();
                        EnterData(out A, out B);
                        MUL.a = A;
                        MUL.b = B;
                        result = MUL.MultiplyABResult();
                        PrintResult(programStep, result);
                        programStep = 0;
                        break;
                    case 4:
                        DivideAB DIV = new DivideAB();
                        EnterData(out A, out B);
                        DIV.a = A;
                        DIV.b = B;
                        result = DIV.DivideABResult();
                        PrintResult(programStep, result);
                        programStep = 0;
                        break;
                    case 5:
                        Console.ReadKey();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static void EnterData(out float A, out float B)
        {
            Console.Clear();
            Console.WriteLine("\n Podaj liczby A i B. \n");
            Console.WriteLine("A: ");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("\nB: ");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Dzięki :) \n\n\n");
        }

        public static void PrintResult(int programStep, float result)
        {
            if (programStep == 1)
            {
                Console.WriteLine("Wynik operacji A + B = " + result + ".\n");
            }
            else if (programStep == 2)
            {
                Console.WriteLine("Wynik operacji A - B = " + result + ".\n");
            }
            else if (programStep == 3)
            {
                Console.WriteLine("Wynik operacji A * B = " + result + ".\n");
            }
            else if (programStep == 4)
            {
                Console.WriteLine("Wynik operacji A / B = " + result + ".\n");
            }
            Console.WriteLine("Wciśnij dowolny klawisz...");
            Console.ReadKey();
        }

    }

}
