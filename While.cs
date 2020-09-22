using System;

namespace Caslo.ForWhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for(int Value = 0; Value <= 15; Value++)
            {
                Console.WriteLine(Value);
                result = Value - (Value-1);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
