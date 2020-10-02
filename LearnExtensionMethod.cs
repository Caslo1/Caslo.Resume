using System;
using System.Collections.Generic;

namespace Caslo.ExtensionMethod
{
    class LearnExtensionMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя аккаунта ");
            var Name = Console.ReadLine();
            Console.WriteLine("Введите максимальный уровень из своих персонажей");
            var input = Console.ReadLine();
            if(int.TryParse(input, out int result))
            {
                if(result.HighLvl())
                {
                    Console.WriteLine($"Name: {Name}  lvl: {result}");
                }
                else
                {
                    Console.WriteLine("У вас низкий уровень");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не правильно");
            }

            Console.WriteLine();

            var listChar = new List<Character>();

            for(var i = 0; i < 10; i++)
            {
                var character = new Character();
                character.CreateRandomLvl(1, 20);
                listChar.Add(character);
            }

            var characterName = listChar.listCharacters();
            Console.WriteLine(characterName);

            Console.ReadLine();
        }
    }
}
