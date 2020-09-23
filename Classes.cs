using System;

namespace Caslo.Classes
{

    class Classes
    {
        static void Main(string[] args)
        {
            Person character = new Person();

            Console.WriteLine("Введите расу персонажа");
            character.Race = Console.ReadLine();

            Console.WriteLine("Введите роль персонажа");
            character.Role = Console.ReadLine();

            Console.WriteLine("Введите цвет персонажа");
            character.Color = Console.ReadLine();

            Console.WriteLine("Введите рост персонажа от 150 до 210 см");
            character.Height = int.Parse(Console.ReadLine());

            if(character.Height < 150 && character.Height >210)
            {

            }
            else
            {
                Console.WriteLine("Повторите попытку");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(character.getChatacter);
            Console.ReadLine();
    }
    }
}
