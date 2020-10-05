using System;

namespace Caslo.Serializations
{
    [Serializable]
    public class Person
    {
        [NonSerialized]
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);
        public string Name { get; set; }
        public int Id { get; set; }

        public Person()
        {
            Id = rnd.Next(254, 500);
            Name = "Pablo " + rnd;
        }

        public Person(string name, int id)
        {
            // TODO: Input validation

            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
