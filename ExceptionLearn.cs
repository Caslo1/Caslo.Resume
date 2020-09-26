using System;
using System.Data;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace Caslo.Exceptions
{
    class ExceptionLearn
    {
        static void Main(string[] args)
        {
            int expChatacter = 0;
            int expUNIT = 42;
            int lvl = 1;
            int lvlup = 100;
            int Experience = 0;
            Console.WriteLine("Сколько врагов вы победили?");
            try
            {
                int amount = int.Parse(Console.ReadLine());
                Experience = expChatacter + expUNIT * amount;
                Console.WriteLine($"Ваш текущий полученный опыт = {Experience}");
                while (true)
                {
                    if (Experience >= 100)
                    {
                        Experience = Experience - lvlup;
                        lvl++;
                    }

                    else
                    {
                        throw new InvalidCastException();
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число повторите попытку");
            }
            catch (Exception) when (Experience == 0)
            {
                Console.WriteLine("У вас не получилось победить врага");
            }

            catch (InvalidCastException) when(Experience > 0 && Experience < 100)
            {
                Console.WriteLine("Вам не хватает");
                Console.WriteLine(100 - Experience);
            }
            finally
            {
                if(lvl > 1)
                {
                    Console.WriteLine(new MyOwnException());
                }

                Console.WriteLine($"Ваш текущий уровень {lvl}");
                Console.ReadLine();
            }
        }
    }
}
