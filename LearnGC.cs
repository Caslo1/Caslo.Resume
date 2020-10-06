using System;

namespace Caslo.GCs
{
    class LearnGC
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));

            var value = GC.GetTotalMemory(true);

            for (var i = 0; i < 10000; i++)
            {
                var Character = (object)i;
                int list = (int)Character;
            }

            var quantity = 0;
            Console.WriteLine(GC.CollectionCount(quantity));

            Console.WriteLine(GC.GetTotalMemory(false));

            GC.Collect();

            Console.WriteLine(GC.GetTotalMemory(false));

            Console.ReadLine();

        }
    }
}
