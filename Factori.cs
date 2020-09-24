using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caslo.Factori
{
    class Program
    {
        static void Main(string[] args)
        {
            int factor = int.Parse(Console.ReadLine());
            int result = 0;

            if(factor == 0)
            {

                Console.WriteLine("Повторите попытку");
                Console.ReadLine();
                return;

            }

            if (factor == 1 || factor == 2)
            {
                result = 1;
            }
            else
            {
                result = (factor - 1) + (factor - 2);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
