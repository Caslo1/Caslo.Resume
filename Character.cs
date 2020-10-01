namespace Caslo.LINQ
{
    class Character
    {
        public string nickname { get; set; }
        public int lvl { get; set; }
        public override string ToString()
        {
            return $"Name: {nickname}, lvl: {lvl} ";
        }
    }
}
