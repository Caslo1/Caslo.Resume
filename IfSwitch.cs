using System;

namespace Caslo.IfSwitch
{
    class Program
    {


        static void Main(string[] args)
        {
            int First = int.Parse(Console.ReadLine());
            int Second = int.Parse(Console.ReadLine());
            int Third = int.Parse(Console.ReadLine());
            int resault;

            if (First > Second && First > Third)
            {
                resault = First;
                Console.WriteLine(resault);
            }
            else
            {
                if(Second > Third)
                {
                    resault = Second;
                    Console.WriteLine(resault);
                }
                else
                {
                    resault = Third;
                    Console.WriteLine(resault);
                }
                

            }

            int block = int.Parse(Console.ReadLine());

            switch (block)
            {
                case 1:
                    Console.WriteLine("Нечётное");
                    break;
                case 2:
                    Console.WriteLine("Чётное");
                    break;
                case 3:
                    Console.WriteLine("Нечётное");
                    break;
                case 4:
                    Console.WriteLine("Чётное");
                    break;
                default:
                    break;
            }
            Console.ReadLine();

            int Input = int.Parse(Console.ReadLine());
            Console.WriteLine(Input == 4 ? "Отлично ты угадал" : "Не повезло бывает");
            
        }
    }
}
