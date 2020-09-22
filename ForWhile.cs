using System;
using System.Collections.Generic;

namespace Caslo.CDDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var firstValue = 0;
            var secondValue = 0;

            while (list.Count < 4)
            {
                list.Add(firstValue = int.Parse(Console.ReadLine()));
                list.Add(secondValue = int.Parse(Console.ReadLine()));
            }

            var result = 0;
            var numberList = 0;
            do
            {
                result = firstValue - secondValue;
                Console.WriteLine(result);
                numberList++;
            }
            while (numberList < list.Count);

            Console.ReadLine();
        }
    }
}
