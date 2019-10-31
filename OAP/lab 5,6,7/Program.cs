using System;

namespace ConsoleApp8
{
    class Program
    {
        static int GetRandInt(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
        static void FillArray(ref int[] array, bool isRandom = false, int min = -99, int max = 99)
        {
            if (isRandom)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = GetRandInt(min, max);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Введите " + i + " элемент: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void FillArray(ref double[] array, bool isRandom = false, int min = -99, int max = 99)
        {
            if (isRandom)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = GetRandInt(min, max);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Введите " + i + " элемент: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void ShowArray(int[] arr)
        {
            Console.Write("Элементы массива: ");
            foreach (int x in arr)
                Console.Write(x + " ");
        }
        static void ShowArray(double[] arr)
        {
            Console.Write("Элементы массива: ");
            foreach (int x in arr)
                Console.Write(x + " ");
        }

        // 5 практическая
        static void Print(string S)
        {
            Console.WriteLine(S);
        }
        static void Repead(string S, int K = 10)
        {
            for (int i = 0; i < K; i++)
                Console.WriteLine(S);
        }
        static int sum(int K = 10, int N = 100)
        {
            int g = 0;
            for (int i = K; i < N; i++)
                if (i % 2 == 0) g++;
            return g;
        }
        static string Word(int K = 10)
        {
            return ("Я учусь программировать " + K + " год!");
        }
        static void Error(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static double FindValue(double x)
        {
            if (x == 0)
                return 0;
            else
                return 1 / x;
        }
        static void Tasks5()
        {
            Print("1 task:\n");
            Print(Word(1));
            Print("\n2 task:\n");
            Repead("Жизнь хороша");
            Print("\n3 task:\n");
            Print(sum(200, 300).ToString() + " - количество четных чисел от 200 до 300");
        }

        // 6 практическая
        static void Task61()
        {

            while (true)
            {
                try
                {
                    Print("Введите значение X:");
                    double x = FindValue(double.Parse(Console.ReadLine()));
                    if (x == 0) Error("На ноль делить нельзя!");
                    else Console.WriteLine(x);
                }
                catch
                {
                    Error("Ошибка");
                }

            }
        }
        static void Task62(int A, int B, int C = 3)
        {
            Console.WriteLine($"Объем предмета равен = {A} * {B} * {C} = {A * B * C}");
        }
        static void Task63(int A, int B = 2)
        {
            Console.WriteLine("Результат: " + A * B);
        }
        static void Task64(int[] arr)
        {
            int sum = 0;
            Console.Write("Элементы массива: ");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
                sum += x;
            }
            Console.WriteLine(" | Сумма элементов массива = " + sum);
        }
        static void Task65(int[] arr)
        {
            int num = -1;
            Console.Write("Элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    num = i;
                    break;
                }
            }
            if (num == -1) Console.WriteLine(" | Нет ненулевых элементов");
            else Console.WriteLine(" | Номер первого ненулевого элемента - " + num);
        }
        
        // 7 практическая
        static double Task71(double A)
        {
            return A * 0.05;
        }
        static double Task72(double start, double end, int step)
        {
            double sum = 0;
            for (double i = start; i <= end; i += step)
                sum += i;
            return sum;
        }
        static string Task73(string date)
        {
            string[] arr = date.Split('.');
            int[] arr2 = new int[3];
            bool isExit = false;
            if(arr.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                    arr2[i] = int.Parse(arr[i]);

                if(arr2[1] == 2 && arr2[0] > 27)
                {
                    arr2[0] = 1;
                    arr2[1] += 1;
                    isExit = true;
                }

                if(!isExit)
                {
                    if (arr2[1] % 2 != 0 && arr2[0] < 31) arr2[0] += 1;
                    if (arr2[1] % 2 != 0 && arr2[0] > 30)
                    {
                        if (arr2[1] != 12)
                        {
                            arr2[0] = 1;
                            arr2[1] += 1;
                        }
                        else
                        {
                            arr2[0] = 1;
                            arr2[1] = 1;
                            arr2[2] += 1;
                        }
                    }

                    if (arr2[1] % 2 == 0 && arr2[0] < 30) arr2[0] += 1;
                    if (arr2[1] % 2 == 0 && arr2[0] > 29)
                    {
                        if (arr2[1] != 12)
                        {
                            arr2[0] = 1;
                            arr2[1] += 1;
                        }
                        else
                        {
                            arr2[0] = 1;
                            arr2[1] = 1;
                            arr2[2] += 1;
                        }
                    }
                }

                for (int i = 0; i < 3; i++)
                    if(arr2[i] < 10) arr[i] = "0" + arr2[i].ToString();
                    else arr[i] = arr2[i].ToString();


                return arr[0] + "." + arr[1] + "." + arr[2];
            }   else
            {
                return "Error";
            }
        }
        static int Task74(int[] arr)
        {
            int max = -99999;
            foreach (int x in arr)
                if (x > max) max = x;
            return max;
        }
        static double[][] Task75(int parametrsAmount)
        {
            double[][] result = new double[2][];
            result[1] = new double[1];

            double[] arr = new double[parametrsAmount];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(-10, 10);

            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            result[0] = arr;
            result[1][0] = sum % 9;

            return result;
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("\nВыберите номер работы (5all/61/62/63/64/65): ");
                switch (Console.ReadLine())
                {
                    case "5all":        // Все задания 5ой практической
                        Tasks5();
                        break;
                    case "61":      // 6 практическая 1 задание
                        Task61();
                        break;

                    case "62":      // 6 практическая 2 задание
                        Task62(1, 6, 2);
                        Task62(5, 2, 7);
                        Task62(9, 2);
                        break;

                    case "63":      // 6 практическая 3 задание
                        Print("Введите число A: ");
                        int A = int.Parse(Console.ReadLine());
                        Print("Введите число B: ");
                        int B = int.Parse(Console.ReadLine());
                        Task63(A, B);
                        break;

                    case "64":      // 6 практическая 4 задание
                        int[] arr = new int[] { 1, 5, 67, 2 };
                        int[] arr2 = new int[] { 8, 5, 2, 4, 7, 8, 3 };
                        int[] arr3 = new int[9];
                        Random r = new Random();
                        for (int i = 0; i < arr3.Length; i++)
                            arr3[i] = r.Next(-99, 99);
                        Task64(arr);
                        Task64(arr2);
                        Task64(arr3);
                        break;

                    case "65":      // 6 практическая 5 задание
                        int[] arr4 = new int[10];
                        int[] arr5 = new int[4];
                        int[] arr6 = new int[9];
                        FillArray(ref arr4, true, -100, 555);
                        FillArray(ref arr5, true, -55, 22);
                        FillArray(ref arr6, true, -1, 3);
                        Task65(arr4);
                        Task65(arr5);
                        Task65(arr6);
                        break;

                    case "71":      // 7 практическая 1 задание
                        Print("Введите число для расчета 5% от него: ");
                        double percent = Task71(double.Parse(Console.ReadLine()));
                        Print("5% = " + percent);
                        break;
                    case "72":      // 7 практическая 2 задание
                        Console.Write("Введите начальное значение: ");
                        double start = double.Parse(Console.ReadLine());
                        Console.Write("Введите конечное значение: ");
                        double end = double.Parse(Console.ReadLine());
                        Console.Write("Введите шаг: ");
                        int step = int.Parse(Console.ReadLine());

                        Print($"Сумма чисел от {start} до {end} с шагом {step} = " + Task72(start, end, step).ToString());
                        break;
                    case "73":      // 7 практическая 3 задание
                        Console.Write("Введите дату в формате ДД.ММ.ГГГГ: ");
                        Print(Task73(Console.ReadLine()));
                        break;
                    case "74":
                        int[] myArray = new int[15];
                        FillArray(ref myArray, true);
                        ShowArray(myArray);
                        Print("\nМаксимальное значание массива: " + Task74(myArray));
                        break;
                    case "75":
                        Console.Write("Введите количество параметров: ");
                        double[][] results = Task75(int.Parse(Console.ReadLine()));
                        ShowArray(results[0]);
                        Print("\nОстаток от деления их суммы на 9: " + results[1][0]);
                        break;

                    default:
                        Print("Нет такого номера");
                        break;

                }
            }

            Console.Read();
        }
    }
}
