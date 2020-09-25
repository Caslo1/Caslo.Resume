using System;
using System.Collections.Generic;

namespace Caslo.Encouragement
{
    class Program 
    {
        static void Main(string[] args)
        {

            var lvlup = new PlayerCharacter<string, int>("Caslo", "Orc", 20, 42);

            Console.WriteLine(lvlup);
            Console.ReadLine();
        }
    }
}
