using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args) // Lab number 2
        {
            Tasks t = new Tasks();
            t.Task1();
            //t.Task2();
            //t.Task3();
        }
    }
}

class Tasks
{
    public void Task1()
    {

        double potato, cucmbers, tomato;

       while(true)
        {
            try
            {
                Console.WriteLine("Введите массу картофеля (кг)");
                potato = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите массу огурцов (кг)");
                cucmbers = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите массу томатов (кг)");
                tomato = double.Parse(Console.ReadLine());

                double all = potato + cucmbers + tomato;
                if (all < 10)
                    Console.WriteLine("\nМожно");
                else Console.WriteLine($"\nНельзя ({all} кг > 10 кг)");
            }
            catch
            {
                Console.WriteLine("\nОшибка");
            }
        }

    }

    public void Task2()
    {
        int year;
        while(true)
        {
            Console.Write("Введи год: ");
            try
            {
                year = int.Parse(Console.ReadLine());
                if (year % 4 == 0)
                    if (year % 100 == 0)
                        if (year % 400 == 0)
                            Console.WriteLine("Високосный"); // Делится на 4 и 400 нацело и этот год - начало столетия
                        else Console.WriteLine("Обычный"); // Если делится на 4 и это начало столетия, но не делится на 400 нацело
                    else Console.WriteLine("Високосный"); // Если делится на 4 и это не начало столетия
                else Console.WriteLine("Обычный"); // Если не делится на 4 нацело
            }
            catch
            {
                Console.WriteLine("[!] Ошибка");
            }
        }
    }

    public void Task3()
    {
        while(true)
        {
            double x, y;

            try
            {
                Console.Write("Введите X: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("Введите Y: ");
                y = double.Parse(Console.ReadLine());

                if (((x < 0) && (y > 0) && (x * x + y * y <= 1)) || ((x > 0) && (y < 0) && (x * x + y * y <= 1)))
                    Console.WriteLine($"\n{x};{y} входит\n");
                else Console.WriteLine($"\n{x};{y} не входит\n"); 
            } catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
