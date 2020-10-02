using System;
using System.Collections;
using System.Linq;

namespace Caslo.ExtensionMethod
{
    public static class Helper
    {
        public static bool HighLvl(this int i)
        {
            return i >= 80; 
        }

        public static string listCharacters(this IEnumerable collection)
        {
            var result = "";

            foreach(var character in collection)
            {
                result += character.ToString() + " , \r\n";
            }

            return result;
        }

        public static Character CreateRandomLvl(this Character character, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(value => value));
            character.Number = "Character № " + rnd.Next(min, max);
            character.lvl = rnd.Next(1, 100);

            return character;
        }
    }
}
