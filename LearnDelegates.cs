using System;

namespace Caslo.DelegateAndEvent
{
    class LearnDelegates
    {
        public delegate void Player();
        public delegate int Expirience(int exp);
        static void Main(string[] args)
        {
            Player second = character;
            second += lvl;
            second();

            Player first = new Player(character);
            first += lvl;
            first += characterExp;
            first.Invoke();

            Player coop = first + second;
            coop.Invoke();

            var expirience = new Expirience(ExpUp);
            expirience += ExpUp;

            expirience((new Random()).Next(1, 50));

            Action third = lvlup;
            third();

            Predicate<int> fourth = delegate (int date) {return date > 10; };
            Console.WriteLine(fourth(21));

            Func<int, int> fifth = ExpUp;
            fifth?.Invoke(1);

            Console.ReadLine();
        }

        public static int ExpUp(int exp)
        {
            Console.WriteLine(exp);
            return exp;
        }
        
        public static void characterExp()
        {
            Console.WriteLine("Вы почти получили новый уровень");
        }

        public static void lvl()
        {
            Console.WriteLine("У вас 21 уровень");
        }

        public static void lvlup()
        {
            Console.WriteLine("Вам не хватает не много до следующего уровня");
        }

        public static void character()
        {
            Console.WriteLine("Орк");
        }
    }
}
