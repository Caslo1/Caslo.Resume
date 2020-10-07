using System;

namespace Caslo.TypeObject
{
    class Person
    {
        public string Person1 { get; set; }
        public int lvl { get; set; }
        public Person lvlup { get; set; }

        public Person Clone()
        {
            return MemberwiseClone() as Person;
        }

        public override string ToString()
        {
            return lvl.ToString();
        }
    }
}
