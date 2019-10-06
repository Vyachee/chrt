using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program   // Lab 4
    {
        static void Main(string[] args)
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
        while(true)
        {
            try
            {
                Console.Write("Введите кол-во строк таблицы: ");
                int count = int.Parse(Console.ReadLine());
                for(int i = 0; i < count; i++)
                {
                    for (int u = 0; u < 3; u++) Console.Write("A ");
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }

    public void Task2()
    {
        while (true)
        {
            int size;
            try
            {
                Console.Write("Введите размер матрицы: ");
                size = int.Parse(Console.ReadLine());
                int[,] matrix = new int[size, size];
                for (int i = 0; i < size; i++)
                    for (int u = 0; u < size; u++)
                        if (i == u) matrix[i, u] = 1;
                        else matrix[i, u] = 0;

                for (int i = 0; i < size; i++)
                    for (int u = 0; u < size; u++)
                        if (i != 0) if (matrix[i - 1, u] == 1) matrix[i, u] = 1;

                for (int i = 0; i < size; i++)
                {
                    for (int u = 0; u < size; u++)
                        Console.Write(matrix[i, u] + " ");
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }

    public void Task3()
    {

        /*

        0 - (void)
        1 - "*"
        2 - "│"
        3 - "—"
        4 - "┼"

        */
        int[,] matrix =
        {
                { 1, 0, 0, 2, 0, 0, 0 },
                { 0, 1, 0, 2, 0, 0, 0 },
                { 0, 0, 1, 2, 0, 0, 0 },
                { 3, 3, 3, 4, 3, 3, 3 },
                { 0, 0, 0, 2, 1, 0, 0 },
                { 0, 0, 0, 2, 0, 1, 0 },
                { 0, 0, 0, 2, 0, 0, 1 },
            };

        int symbol = 0;
        for (int i = 0; i < 7; i++)
        {
            for (int u = 0; u < 7; u++)
            {
                symbol = matrix[i, u];

                if (symbol == 0) Console.Write(" ");
                if (symbol == 1) Console.Write("*");
                if (symbol == 2) Console.Write("│");
                if (symbol == 3) Console.Write("─");
                if (symbol == 4) Console.Write("┼");
            }
            Console.Write("\n");
        }
        Console.Read();
    }
}