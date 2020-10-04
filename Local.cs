using System;

namespace Caslo.AttributeAndReflection
{
    public class Local
    {
        [CharacterPosition(21, 4)]

        public string Town { get; set; }
        public string Location { get; set; }

        public Local(string name)
        {
            

            Town = name;
        }
    }
}
