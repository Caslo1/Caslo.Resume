using System;
using System.Collections.Generic;

namespace Caslo.MassiveAndOther
{
    class Program
    {

        enum Weekday
        {
            Mon = 0,
            Tue = 2,
            Wec = 4,
            Tro = 6,
            Sun = 8
        }

        static void Main(string[] args)
        {
            int[] Massive = new int[5];
            Massive[0] = 4;
            Massive[1] = 21;
            Massive[2] = 42;
            Massive[3] = 44;
            Massive[4] = 50;


            List<int> Jurnal = new List<int>()
            {
                0, 2, 4, 6, 8
            };

            Weekday day1;
            day1 = Weekday.Mon;

            foreach(int data in Jurnal)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine(Massive[0] + Massive[1] + Massive[2] + Massive[3] + Massive[4]);
            Console.WriteLine(day1);
            Console.ReadLine();
        }

    }
}
