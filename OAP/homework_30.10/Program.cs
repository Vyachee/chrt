using System;

namespace ConsoleApp8
{
    class Program
    {

        static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нажмите [ENTER] для продолжения");
            Console.Read();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
        }

        static void PrintStars(int amount)
        {
            Console.WriteLine($"Печатаю звездочки {amount} раз...");
            for(int i = 1; i <= amount; i++)
            {
                for (int u = 1; u <= amount; u++)
                    if (u <= i) Console.Write("* ");
                Console.WriteLine();
            }
        }

        static double PowerNumber(string strNumber)
        {
            string[] arr = strNumber.Split(' ');
            int number = int.Parse(arr[0]);
            int power = int.Parse(arr[1]);
            double num = 1;
            for(int i = 0; i < power; i++)
                num *= number;
            return num;
        }

        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.Write("Введите номер задания (1\\2): ");
                switch(Console.ReadLine())
                {
                    case "1":
                        try
                        {
                            Console.Write("Введите количество звездочек: ");
                            PrintStars(int.Parse(Console.ReadLine()));
                            Pause();
                        }   catch
                        {
                            Console.WriteLine("Неверные данные");
                        }

                        break;

                    case "2":
                        Console.Write("Введите число и степень, в которую нужно возвести это число через пробел (например \"2 10\"): ");
                        try
                        {
                            Console.WriteLine("Результат: " + PowerNumber(Console.ReadLine()));
                            Pause();
                        }
                        catch
                        {
                            Console.WriteLine("Неверные данные");
                        }
                    break;
                }
                
            }
        }
    }
}
