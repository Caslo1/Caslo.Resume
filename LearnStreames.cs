using System;
using System.IO;
using System.Text;


namespace Caslo.FileStream
{
    class LearnStreames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя персонажа");
            var character = Console.ReadLine();

            using (var filewrite = new StreamWriter("LearnStream.txt", true, Encoding.UTF8))
            {
                filewrite.Write($"Hello {character}");
                filewrite.WriteLine(" Это ваш первый персонаж");
            }

            using (var fileread = new StreamReader("LearnStream.txt", Encoding.UTF8))
            {
                var frRead = fileread.ReadToEnd();
                Console.Write(frRead);
            }

            Console.ReadLine();
        }
    }
}
