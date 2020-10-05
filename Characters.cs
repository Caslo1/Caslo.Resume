using System;
using System.Runtime.Serialization;

namespace Caslo.Serializations
{
    [DataContract]
    public class Characters
    {
        [DataMember]
        public string Nickname { get; set; }
        [DataMember]
        public int Lvl { get; set; }

        public Person Person { get; set; }

        public Characters(string nickname, int lvl)
        {

            // TODO: Input validation

            Nickname = nickname;
            Lvl = lvl;
        }

        public override string ToString()
        {
            return Nickname;
        }
    }
}
