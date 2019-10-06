using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /*
         
             3 лаба вся
             4 лаба 1 задание
             
             */
        static void Main(string[] args)
        {
            Tasks t = new Tasks();
            t.Task4();
            //t.Task5();
            //t.Task6();
            //t.Task7();
            //t.Task8();

            //t.Task9();
            //t.Task10();
            Console.Read();
        }
    }
}

class Tasks
{
    public void Task4() // 3.3.1 (3 вариант, 3 лаба, 1 задание)
    {
        int x = 1000;
        for(int i = 0; i < 10; i++)
        {
            Console.Write($"{x} ");
            x -= 100;
        }
    }

    public void Task5() // 3.3.2
    {
        int x = 10;
        do
        {
            Console.WriteLine(x);
            x += 10;
        } while (x <= 150);
    }

    public void Task6() // 3.3.3
    {
        double n, sum = 0;
        while (true)
        {
            Console.Write("Введите число n: ");
            n = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                sum += Math.Pow(n, i);

            Console.WriteLine($"Sum: {sum}");
        }
    }

    public void Task7() // 3.3.4
    {
        double n, k, sum = 0;
        while(true)
        {
            Console.Write("Сколько денег взяли?: ");
            n = double.Parse(Console.ReadLine());

            Console.Write("На сколько дней взяли?: ");
            k = double.Parse(Console.ReadLine());

            sum = n;

            for (int i = 1; i <= k; i++)
                sum += n * 0.02;
            
            Console.WriteLine($"\nЧерез {k} дней они будут должны {sum} руб.\n");
        }
    }

    public void Task8() // 3.3.5
    {
        double n, a = 0;
        while (true)
        {
            Console.Write("Число n: ");
            n = double.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
                a += Math.Pow(-1, n) * ((n + 1) / Math.Pow(n, 3) + 2);
            Console.WriteLine("Result: " + a);
        }
    }

    public void Task9() // 3.4.1
    {
        int rows, columns;
        while(true)
        {
            try
            {
                Console.Write("Кол-во строк: ");
                rows = int.Parse(Console.ReadLine());

                Console.Write("Кол-во столбцов: ");
                columns = int.Parse(Console.ReadLine());

                Console.WriteLine();
                for (int i = 0; i < rows; i++)
                {
                    for (int u = 0; u < columns; u++)
                        Console.Write("A ");
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

        }
    }

    public void Task10() // 3.4.2
    {
        int size;
        try
        {
            Console.Write("Размер матрицы: ");
            size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int u = 0; u < size; u++)
                    Console.Write("0 ");
                Console.WriteLine();
            }
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
    }
}