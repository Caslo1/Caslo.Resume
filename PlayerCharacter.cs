using System;

namespace Caslo.Encouragement
{
    public class PlayerCharacter<TStr, TInt>
    {
        public TStr Name { get; }
        public TStr Race { get; }

        public TInt Level { get; set; }

        public TInt Experience { get; set; }

        public PlayerCharacter(TStr name, TStr race, TInt level, TInt experience)
        {
            Name = name;
            Race = race;
            Level = level;
            Experience = experience;

        }



        public override string ToString()
        {
            return $"{Name}: {Race}, lvl {Level} Exp {Experience}"; ;
        }

    }
}
