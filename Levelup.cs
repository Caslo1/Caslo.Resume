using System;

namespace Caslo.Encouragement
{
    class Levelup<TStr, TInt> : PlayerCharacter<TStr, TInt>
    {
        public Levelup(TStr name, TStr race, TInt level, TInt experience) : base(name, race, level, experience)
        {
            
        }

    }
}
