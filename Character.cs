using System;

namespace Caslo.ExtensionMethod
{
    public sealed class Character
    {
        public string Number { get; set; }
        public int lvl { get; set; }
        public override string ToString()
        {
            return $"Nickname: {Number}  lvl: {lvl}";
        }
    }
}
