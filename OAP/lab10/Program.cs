using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            tasks t = new tasks();
            t.task3();
        }
    }
}

class tasks
{
    public void task1()
    {
        while (true)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                int pozSum = 0, negSum = 0, pozCount = 0, negCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");
                    arr[i] = int.Parse(Console.ReadLine());
                    if (arr[i] > 0)
                    {
                        pozSum += arr[i];
                        pozCount++;
                    }
                    else
                    {
                        negSum += arr[i];
                        negCount++;
                    }
                }
                try
                {
                    Console.WriteLine($"Среднее положительных = {pozSum / pozCount}");
                }
                catch
                {
                    Console.WriteLine("Положительных нет");
                }
                try
                {
                    Console.WriteLine($"Среднее отрицательных = {negSum / negCount}\n");
                }
                catch
                {
                    Console.WriteLine("Отрицательных нет.");
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }

    public void task2()
    {
        while (true)
        {
            try
            {
                int n;
                while(true)
                {
                    Console.Write("Введите размер массива: ");
                    n = int.Parse(Console.ReadLine());
                    if (!(n == 0)) break;
                }
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                bool changed = false, isAllZero = true;
                int last;

                if (arr.Length > 1)
                {
                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (!(arr[i] == 0)) isAllZero = false;
                        if (arr[i - 1] > 0 && arr[i] < 0)
                        {
                            changed = true;
                            break;
                        }
                        if (arr.Length == 1 && arr[i] < 0)
                        {
                            changed = true;
                            break;
                        }
                    }

                    if (changed) Console.WriteLine("Положительное первее");
                    else Console.WriteLine("Негативное первее");
                }   else
                {
                    if (arr[0] > 0) Console.WriteLine("Первее положительное");
                    else Console.WriteLine("Первее отрицательное");
                }
                    

            }
            catch
            {
                Console.WriteLine("ошибка");
            }
        }
    }

    public void task3()
    {
        while(true)
        {
            try
            {
                Console.Write("Введите размер матрицы: ");
                int n = int.Parse(Console.ReadLine());
                int[,] matrix = new int[n, n];

                Random r = new Random();
                int temp;
                for (int i = 0; i < n; i++)
                {
                    for (int u = 0; u < n; u++)
                    {
                        temp = r.Next(0, 2);
                        matrix[i, u] = temp;
                        Console.Write(temp + " ");
                    }
                    Console.WriteLine();
                }

                int sum = 0, count = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int u = 0; u < n; u++)
                    {
                        temp = matrix[i, u];
                        if (u > i && temp > 0)
                        {
                            sum += temp;
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Кол-во положительных чисел: {count}\nИх сумма: {sum}");
            } catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        Console.Read();
    }
}