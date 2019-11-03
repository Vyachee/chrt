using System;

namespace ConsoleApp4
{
    class Program
    {
        delegate string AddPrefix(string text); // Первый вариант реализации

        delegate string AddPrefixV2(string text); // Второй вариант реализации
        static void Main(string[] args)
        { 
            // Первый вариант реализации
            AddPrefix ap = delegate (string text)
            {
                return "ПР " + text;
            };

            // Второй вариант реализации (лямбда-выажение)
            AddPrefixV2 ap2 = x => "ПР " + x;

            Console.Write("Введите что-то: ");
            Console.WriteLine(ap(Console.ReadLine()));

            Console.Write("Введите что-то (второй вариант): ");
            Console.WriteLine(ap2(Console.ReadLine()));

            Console.Read();
        }
    }
}
