using System;

namespace Caslo.CDDZ2
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int parity = 0; parity < 4; parity++ )
            {
                Console.WriteLine("Введите чётное число");
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber%2 ==0)
                {
                    Console.WriteLine(userNumber);
                    Console.WriteLine("Верно");
                }
                else
                {
                    Console.WriteLine("Введите повторно");
                }

            }

            Console.ReadLine();
        }
    }
}
