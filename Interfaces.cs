using System;
using System.Collections.Generic;

namespace Caslo.Interface
{
    class Interfaces
    {
        static void Main(string[] args)
        {
            var movement = new List<ICharacter>();
            movement.Add(new PlayerRun());
            movement.Add(new PlayerWalking());

            foreach(var player in movement)
            {
                Console.WriteLine(player.Move(100));
            }

            PlayerMove playerMove = new PlayerMove();
            Console.WriteLine(((ICharacter)playerMove).Move(100));
            Console.WriteLine(((IHorse)playerMove).Move(100));

            Console.ReadLine();
        }
    }
}
