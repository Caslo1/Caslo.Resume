using System;

namespace Caslo.AndEventes
{
    class LearnEvent
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Nickname = "Caslo"
            };
            person.CreateCharacter += Person_CreateCharacter;
            person.CreateLimit += Person_CreateLimit;
            person.Limit(5);
            person.Limit(4);
        }

        private static void Person_CreateLimit(object sender, EventArgs e)
        {
            if(sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Nickname} У вас предел создания персонажей");
            }    
        }

        private static void Person_CreateCharacter()
        {
            Console.WriteLine("Вы можете создать создать персонажа");
            Console.ReadLine();
        }
    }
}
