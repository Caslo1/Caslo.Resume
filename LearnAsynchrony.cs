using System;
using System.Threading.Tasks;

namespace Caslo.Asynchrony
{
    class LearnAsynchrony
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы начали уровень");

            lvlupAsync();

            for(int unit = 0; unit < 20; unit++)
            {
                Console.WriteLine($"Вы победили {unit}");
            }
            Console.WriteLine("Вы победили всех врагов");
            Console.ReadLine();
        }

        static async Task lvlupAsync()
        {
            Console.WriteLine("Вы начинаете получать опыт");
            await Task.Run(() => Experience());
            Console.WriteLine("Поздравляю вас с повышением уровня");
        }
        static void Experience()
        {
            for(int exp = 0; exp < 20; exp++ )
            {
                Console.WriteLine($"Ваш текущий опыт {exp}");
            }

        }
    }
}
