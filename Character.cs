using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caslo.OperactionAbstract
{
    class Character : Player
    {
        public Character(string race, string gender, string classes, int level) : base(race, gender, classes, level)
        {

        }

        public static Character operator+ (Character gameOne, Character gamerThree)
        {
            int level = (int)Math.Round(gameOne.Level + gamerThree.Level / 4.0);
            var character = new Character("Орк", "Мужчина", "Воин", level);
            return character;
        }

        public static Character operator/ (Character gameFour, Character gamerTwo)
        {
            int level = (int)Math.Round(gameFour.Level + gamerTwo.Level / 4.0);
            var character = new Character("Гном", "Мужчина", "Разбойник", level);
            return character;
        }

    }
}
