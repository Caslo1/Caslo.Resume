using System;

namespace Caslo.AnonymTypeAndTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCharacter = new
            {
                Name = "Caslo",
                Classes = "Shaman",
                lvl = 21
            };

            var secondCharacter = new
            {
                Name = "Feral",
                Classes = "Druid",
                lvl = 70
            };

            Tuple<string, string, byte> thirdCharacter = new Tuple<string, string, byte>("ButmanIV", "Monk", 100);


            Console.WriteLine($"{firstCharacter.Name}  {firstCharacter.Classes}  {firstCharacter.lvl}");
            Console.WriteLine($"{secondCharacter.Name}  {secondCharacter.Classes}  {secondCharacter.lvl}");
            Console.WriteLine($"{thirdCharacter.Item1}  {thirdCharacter.Item2}  {thirdCharacter.Item3}");
            Console.ReadLine();
        }
    }
}
