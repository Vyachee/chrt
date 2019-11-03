using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Task1()
        {
            string text = "";
            for (int i = 1; i <= 1000; i++)
                text += i.ToString() + "\n";

            using (StreamWriter sw = new StreamWriter("test.txt"))
                sw.Write(text);

            Console.WriteLine("Файл создан.");
        }
        public static void Task2()
        {
            string path = "D:\\test\\task2\\";
            DirectoryInfo f = new DirectoryInfo("X");
            f.Create();
            f.CreateSubdirectory("Y");
            f.CreateSubdirectory("Z");

            Console.WriteLine("Каталоги созданы");
        }
        public static void Task3()
        {
            string line;
            int counter = 1;
            string[] yearAndName = new string[2];
            string[] date = new string[3];


            int year;
            bool endable = false;
            Console.Write("Сколько строк прочитать (0 - все): ");
            int amountToRead = int.Parse(Console.ReadLine());

            if (amountToRead != 0) endable = true;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            using (StreamReader file = new StreamReader("names.txt"))
            {
                while((line = file.ReadLine()) != null)
                {
                    yearAndName = line.Split('\t');

                    date = yearAndName[0].Split('.');
                    year = int.Parse(date[2]);

                    Console.WriteLine($"\nОбработка строки #{counter}");

                    if (dict.ContainsKey(year))
                        dict[year] += 1;
                    else dict.Add(year, 1);

                    if (endable && counter == amountToRead)
                        break;

                    counter++;
                }
            }

            Console.WriteLine($"Обработано {counter} строк");
            Console.WriteLine("Результат:\n[год / кол-во человек]");
            foreach (KeyValuePair<int, int> x in dict)
                Console.WriteLine(x.Key + " - " + x.Value);

        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Выберите задание: (1\\2\\3 (0 - выход)): ");
                switch(Console.ReadLine())
                {
                    case "1":
                        Task1(); Console.WriteLine("Error");
                        break;

                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Нет такого номера");
                        break;
                }
            }
        }
    }
}
