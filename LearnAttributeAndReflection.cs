using System;

namespace Caslo.AttributeAndReflection
{
    class LearnAttributeAndReflection
    {
        static void Main(string[] args)
        {
            var positionCharacter = new Local("Hesfion")
            {
                Location = "Town Hesfion"
            };

            var type = typeof(Local);
            var attributes = type.GetCustomAttributes(false);

            Console.WriteLine("Town Hesfion\n");

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }


            var properties = type.GetProperties();
            foreach(var prop in properties)
            {
                Console.WriteLine(prop.PropertyType + " " + prop.Name);

                var attributes2 = prop.GetCustomAttributes(false);

                foreach(var attribute in attributes2)
                {
                    Console.WriteLine(attribute);
                }
            }

            Console.ReadLine();
        }
    }
}
