using System;
using System.Collections.Generic;
using System.Linq;

namespace Caslo.LINQ
{
    class LearnLINQ
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var player = new List<Character>();

            for(var i = 0; i < 10; i++)
            {
                var characters = new Character()
                {
                    nickname = (i + 1) + " Caslo",
                    lvl = rnd.Next(1, 100)
                };
                player.Add(characters);
            }

            var highlvl = player.Where(person => person.lvl > 70);

            foreach(var person in highlvl)
            {
                Console.WriteLine(person);
            }

            var characterlvl = player.Select(person => person.lvl);

            foreach(var person in characterlvl)
            {
                Console.WriteLine(person);
            }

            var listCharacters = player.OrderByDescending(person => person.lvl)
                                       .ThenBy(person => person.nickname);

            foreach (var person in listCharacters)
            {
                Console.WriteLine(person);
            }

            var party = player.GroupBy(person => person.lvl < 20);

            foreach (var group in party)
            {
                Console.WriteLine($"New players: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\t {person}");
                }
            }

            Console.WriteLine(player.All(person => person.lvl >= 21));
            Console.WriteLine(player.Any(person => person.lvl >= 90));

            Console.WriteLine(player.Contains(player[0]));

            var number = new int[] { 1, 2, 3, 4 };
            var number2 = new int[] { 2, 4, 6, 8 };

            foreach (var person in number)
            {
                Console.WriteLine(person);
            }

            var union = number.Union(number2);

            foreach (var person in union)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var intersect = number.Intersect(number2);

            foreach (var person in intersect)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var except = number.Except(number2);

            foreach (var person in except)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            var phantom = number2.Skip(1)
                                 .Take(2);

            foreach (var person in phantom)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            int first = 21;

            if(first == 21)
            {
                player.Single(person => person.lvl == 21);
                Console.WriteLine(first);
            }    

            Console.ReadLine();
        }
    }
}
