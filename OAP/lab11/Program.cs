using System;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    class Program
    {

        public static string GetMonth(string date)
        {
            string[] arrDate = date.Split('.');
            string month = "";
            if(arrDate.Length == 3)
            {
                switch (int.Parse(arrDate[1]))
                {
                    case 1:
                        month = "Январь";
                        break;
                    case 2:
                        month = "Февраль";
                        break;
                    case 3:
                        month = "Март";
                        break;
                    case 4:
                        month = "Апрель";
                        break;
                    case 5:
                        month = "Май";
                        break;
                    case 6:
                        month = "Июнь";
                        break;
                    case 7:
                        month = "Июль";
                        break;
                    case 8:
                        month = "Август";
                        break;
                    case 9:
                        month = "Сентярь";
                        break;
                    case 10:
                        month = "Октябрь";
                        break;
                    case 11:
                        month = "Ноябрь";
                        break;
                    case 12:
                        month = "Декабрь";
                        break;
                    default:
                        month = "Неверный формат даты";
                        break;
                }
            }   else
            {
                month = "Неверный формат даты";
            }
            return month;
        }

        public static void Task1()
        {
            Console.Write("Введите строку для поиска или введите 7 для выбора случайной строки: ");
            string s = Console.ReadLine();
            string[] rs = {
                "Сегодня 5 августа",
                "У меня 3 ручки",
                "Я вешу 250 кг и мой рост 155 см",
                "У того человека IQ 300. Этим человеком был Альберт Эйнштейн",
                "Плотность населения города равна 45631"
            };


            if (s == "7")
            {
                Random rand = new Random();
                s = rs[rand.Next(0, rs.Length)];
            }

            Console.WriteLine($"\nПоиск чисел в строке \"{s}\"...\n");

            Regex r = new Regex(@"\d+");
            MatchCollection m = r.Matches(s);

            if (m.Count > 0)

                foreach (Match match in m)
                    Console.WriteLine($"Найдено число: {match.Value}");

            else Console.WriteLine("Чисел в строке нет");
            Console.WriteLine();

        }
        public static void Task2()
        {
            Console.Write("Введите дату в формате ДД.ММ.ГГГГ: ");
            Console.WriteLine(GetMonth(Console.ReadLine()));
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Введите номер задания (1\\2): ");
                switch(Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                }
            }
        }
    }
}
