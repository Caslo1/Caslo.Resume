using System;

namespace Caslo.Interface
{
    public class PlayerMove : ICharacter, IHorse
    {
        public int Speed { get => 4; set => Console.ReadLine(); }

        int ICharacter.Move(int distance)
        {
            return distance / Speed;
        }

        int IHorse.Move(int distance)
        {
            return distance / 20;
        }
    }
}
