using System;

namespace Caslo.AnonymMethodAndLambdaExpressions
{
    class LearnAnonymMethodandLymbda
    {
        delegate int lvlup(int shortage);
        static void Main(string[] args)
        {
            var exp = 1000;
            var unit = 250;

            lvlup lvlup1 = delegate (int shortage)
            {
                shortage = exp - unit;
                Console.WriteLine($"Вам не хватает {shortage} до поднятия уровня");
                return shortage;
            };

            lvlup1(750);

            lvlup lvlup2 = (shortage) =>
            {
                shortage = exp - unit * 2;
                Console.WriteLine($"Вам не хватает {shortage} до поднятия уровня");
                return shortage;
            };
            lvlup2(500);

            Console.ReadLine();
        }
    }
}
