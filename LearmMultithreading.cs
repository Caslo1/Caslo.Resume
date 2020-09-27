using System;
using System.Threading;

namespace Caslo.Multithreading
{
    class LearmMultithreading
    {
        static void Main(string[] args)
        {
            Thread firstCharacter = new Thread(new ThreadStart(lvlFirst));
            firstCharacter.Start();

            Thread secondCharacter = new Thread(new ParameterizedThreadStart(lvlSecond));
            secondCharacter.Start(1000);

            Console.ReadLine();
        }

        static void lvlFirst()
        {
            int expCharacter = 0;
            for (int exp = 0; exp < 1000; exp++)
            {
                expCharacter++;
                if(expCharacter % 10 == 0)
                {
                    Console.WriteLine("Первый игрок получил опыт");
                }
            }
        }

        static void lvlSecond(object numeral)
        {
            int expCharacter = 0;
            for (int exp = 0; exp < (int)numeral; exp++)
            {
                expCharacter++;
                if (expCharacter % 10 == 0)
                {
                    Console.WriteLine("Второй игрок получил опыт");
                }
            }
        }
    }
}
