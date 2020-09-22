using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caslo.Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            var random = new Random();

            for(var value = 0; value < 10; value++)
            {
                list.Add(random.Next(0, 100).ToString());
            }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
