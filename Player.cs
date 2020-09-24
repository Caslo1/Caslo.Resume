using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caslo.OperactionAbstract
{

    public abstract class Player
    {
        public string Race { get; }

        public string Gender { get; }

        public string Classes { get; }

        public int Level { get; set; }

        public Player(string race, string gender, string classes, int level)
        {
            if(string.IsNullOrWhiteSpace(race))
            {
                throw new ArgumentNullException(nameof(race));
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentNullException(nameof(gender));
            }

            if (string.IsNullOrWhiteSpace(classes))
            {
                throw new ArgumentNullException(nameof(classes));
            }

            if (level < 0)
            {
                throw new ArgumentNullException(nameof(level));
            }


            Race = race;
            Gender = gender;
            Classes = classes;
            Level = level;
        }

        public override string ToString()
        {
            return $"{Race}, {Gender}, {Classes}, lvl {Level} ";
        }
    }


}
