using System;

namespace Caslo.AttributeAndReflection
{
    class CharacterPosition : Attribute
    {
        public float X { get; set; }
        public float Z { get; set; }

        public CharacterPosition() { }

        public CharacterPosition(float x, float z)
        {


            X = x;
            Z = z;
        }

        public override string ToString()
        {
            return $"\nLocation {X}, {Z}\n";
        }
    }
}
