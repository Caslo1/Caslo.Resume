using System;

namespace Caslo.AndEventes
{
    class Person
    {
        public event Action CreateCharacter;
        public event EventHandler CreateLimit;

        public string Nickname { get; set; }

        public void Limit(int lim)
        {
            if(lim < 5)
            {
                CreateCharacter?.Invoke();
            }
            else
            {
                CreateLimit?.Invoke(this, null);
            }
        }
    }
}
