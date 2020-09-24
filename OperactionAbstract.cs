using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caslo.OperactionAbstract
{
    class OperactionAbstract
    {

        static void Main(string[] args)
        {
            Character gamerOne = new Character("Орк", "Мужчина", "Воин", 21);
            Character gamerTwo = new Character("Орк", "Женщина", "Охотница", 13);
            Character gamerThree = new Character("Человек", "Мужчина", "Волшебник", 10);
            Character gamerFour = new Character("Гном", "Мужчина", "Разбойник", 4);

            var lvlup = gamerOne + gamerThree;
            var lvlup2 = gamerFour + gamerTwo;

            Console.WriteLine(gamerOne);
            Console.WriteLine(gamerThree);
            Console.WriteLine(lvlup);

            Console.WriteLine(gamerFour);
            Console.WriteLine(gamerTwo);
            Console.WriteLine(lvlup2);

            Console.ReadLine();
        }
    }
}
