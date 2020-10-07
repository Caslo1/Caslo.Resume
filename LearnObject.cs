using System;

namespace Caslo.TypeObject
{
    class LearnObject
    {
        static void Main(string[] args)
        {
            var firstCharacter = "Caslo";
            var secondCharacter = "Caslo";

            var first = (object)firstCharacter;
            object second = secondCharacter;

            Console.WriteLine(first.Equals(second));

            var lvl_1 = new Person();
            var lvl_2 = new Person();

            var exp = new Person();

            var lvl1 = 21;
            var lvl2 = 21;


            Console.WriteLine(first.ToString());
            Console.WriteLine(lvl_2.ToString());
            Console.WriteLine();

            Console.WriteLine(lvl_1.GetHashCode());
            Console.WriteLine();

            Console.WriteLine(lvl_2.GetType());
            Console.WriteLine(first.GetType());
            Console.WriteLine();

            Console.WriteLine(typeof(Person) == second.GetType());
            Console.WriteLine();

            Console.WriteLine(Object.Equals(lvl1, lvl2));
            Console.WriteLine();

            Console.WriteLine(Object.ReferenceEquals(lvl1, lvl2));
            Console.WriteLine();

            var expChar = new Person() { lvl = 21, lvlup = new Person() };
            var expChar2 = expChar;
            expChar2.lvl = 100;
            expChar2.lvlup = new Person() { lvl = 21 };
            Console.WriteLine(expChar);

            Console.WriteLine();

            var expChar3 = expChar.Clone();
            expChar3.lvl = 80;
            expChar3.lvlup.lvl = 1000;

            Console.WriteLine(expChar);
            Console.WriteLine(expChar.lvlup);



            Console.ReadLine();
        }
    }
}
