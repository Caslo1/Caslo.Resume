namespace Caslo.Classes
{
    class Person
    {
        public string Race { get; set; }
        public string Role { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }

        public Person()
        {

        }

        public string getChatacter
        {
            get
            {
                return $"Раса: {Race}, Роль: {Role}, Цвет: {Color}, Рост: {Height}.";
            }
        }
    }
}
