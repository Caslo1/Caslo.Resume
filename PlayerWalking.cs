using System;

namespace Caslo.Interface
{
    class PlayerWalking : ICharacter
    {
        public int Speed { get => 2; set => Console.ReadLine(); }

        public int Move(int distance)
        {
            return distance / Speed;
        }
    }
}
