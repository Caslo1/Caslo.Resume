using System;

namespace Caslo.Interface
{
    internal interface ICharacter
    {
        int Move(int distance);

        int Speed { get; set; }
    }
}
