using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Caslo.Serializations
{
    class LearnSerialization
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            var characters = new List<Characters>();

            for(int i = 1; i < 10; i++)
            {
                persons.Add(new Person("ID: " + i, i));
            }

            for(int i = 1; i < 10; i++)
            {
                var character = new Characters(Guid.NewGuid().ToString().Substring(0, 5), i % 10)
                {
                    Person = persons[i % 9]
                };

                characters.Add(character);
            }

            var binFormatter = new BinaryFormatter();

            using(var personList = new FileStream("Save.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(personList, persons);
            }

            using (var personList = new FileStream("Save.bin", FileMode.OpenOrCreate))
            {
                var newPerson = binFormatter.Deserialize(personList) as List<Person>;
                if(newPerson != null)
                {
                    foreach(var num in newPerson)
                    {
                        Console.WriteLine(persons);
                    }
                }
            }

            Console.ReadLine();

            var soapFormatter = new SoapFormatter();

            using (var personList = new FileStream("Save.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(personList, persons.ToArray());
            }

            using (var personList = new FileStream("Save.soap", FileMode.OpenOrCreate))
            {
                var newPerson = soapFormatter.Deserialize(personList) as Person[];
                if (newPerson != null)
                {
                    foreach (var num in newPerson)
                    {
                        Console.WriteLine(persons);
                    }
                }
            }

            Console.ReadLine();

            var xmlForamtter = new XmlSerializer(typeof(List<Person>));

            using (var personList = new FileStream("Save.xml", FileMode.OpenOrCreate))
            {
                xmlForamtter.Serialize(personList, persons);
            }

            using (var personList = new FileStream("Save.xml", FileMode.OpenOrCreate))
            {
                var newPerson = xmlForamtter.Deserialize(personList) as List<Person>;
                if (newPerson != null)
                {
                    foreach (var num in newPerson)
                    {
                        Console.WriteLine(persons);
                    }
                }
            }

            Console.ReadLine();

            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Characters>));

            using (var characterList = new FileStream("Save.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(characterList, characters);
            }

            using (var characterList = new FileStream("Save.json", FileMode.OpenOrCreate))
            {
                var newCharacters = jsonFormatter.ReadObject(characterList) as List<Characters>;
                if (newCharacters != null)
                {
                    foreach (var num in newCharacters)
                    {
                        Console.WriteLine(characters);
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
