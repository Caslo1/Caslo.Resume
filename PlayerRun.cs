using System;

namespace Caslo.Interface
{
    class PlayerRun : ICharacter
    {
        public int Speed { get => 4; set => Console.ReadLine(); }

        public int Move(int distance)
        {
            return distance / Speed;
        }
    }
}
