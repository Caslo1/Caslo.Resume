using System;
using System.Runtime.InteropServices;

namespace Caslo.Unsafecode
{
    class LearnUnsafeCode
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Console.WriteLine("Выберете персонажа");

                string Character = Console.ReadLine();

                int num = 0;
                int* address = &num;
                int lvl = 0;
                int exp = 0;

                if (Character == "Caslo")
                {
                    num = 1;
                    Console.WriteLine($"Персонаж № {*address}");
                    lvlCaslo(&lvl, &exp);
                    Console.WriteLine($"{Character} {lvl} {exp}");
                }
                else
                {
                    if (Character == "Trall")
                    {
                        num = 2;
                        Console.WriteLine($"Персонаж № {*address}");
                        lvlTrall(&lvl, &exp);
                        Console.WriteLine($"{Character} {lvl} {exp}");
                    }
                    else
                    {
                        Console.WriteLine("У вас нет такого персонажа");
                    }
                }


                Console.ReadLine();
            }
        }

        static unsafe void lvlCaslo(int* lvl, int* exp)
        {
            *lvl = 21;
            *exp = 404;
        }
        static unsafe void lvlTrall(int* lvl, int* exp)
        {
            *lvl = 100;
            *exp = 0;
        }
    }
}
