using System;

namespace chrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task();
            //t.Ruble();
            //t.MaxOfThree();
            t.MaxOfThreeV2();
            Console.Read();
        }
    }
}

class Task
{
    public void Ruble() // То, что делали на паре
    {

        // Определение склонения по количеству деревяных

        string S = " рублей";   // Стандартное склонение

        Console.WriteLine("Сколько рублей?");
        int rub = int.Parse(Console.ReadLine());  // Спрашиваем, сколько рублей, чтобы произошло склонение

        double lastOne = rub % 10,  // Последняя цифра
               lastTwo = rub % 100; // Последние 2 цифры

        if (lastTwo == 11 || lastTwo == 12 || lastTwo == 13 || lastTwo == 14)   // Если последние 2 цифры
        {
            Console.WriteLine(rub + S); // То выводим стандартное склонение
            return; // И выходим
        }

        if (lastOne == 1) S = " рубль"; // Если последняя 1, то выводим склонение = рубль
        if (lastOne == 2 || lastOne == 3 || lastOne == 4) S = " рубля"; // Если 2, 3 или 4, то склонение = рубля

        Console.WriteLine(rub + S); // Выводим n рублей + склонение


    }

    public void MaxOfThree() // домашка.mp4
    {
        // Определение максимального значения из трёх чисел
        Random r = new Random();    // Создаем объект рандом (случайность)

        Console.Write("От скольки?: "); // Спрашиваем от скольки и записываем
        int from = int.Parse(Console.ReadLine());

        Console.Write("До скольки?: "); // Спрашиваем до скольки и записываем
        int to = int.Parse(Console.ReadLine());


        // Присваимваем рандомные значение от from до to трем переменным:
        int first = r.Next(from, to),
            second = r.Next(from, to),
            third = r.Next(from, to);

        int max = 0; // По дефлоту максимальное значение = 0

        Console.Write($"Значения: {first}, {second}, {third}"); // Выводим значения

        if (first > second && first > third) max = first; // Если первое значение больше всех, то максимальное = первое
        if (second > first && second > third) max = second; // Если второе, то максимальное = второе
        if (third > second && third > first) max = third; // Если третье, то максимальное = третье
        if (first == second && second == third) // Ну а если реально произошло чудо и всё совпало, то выводим ого и выходим
        {
            Console.WriteLine("\nОго! Все равны, вот это да, какое совпадение!");
            return;
        }

        Console.WriteLine("\nМаксимальное значение: " + max); // Если мы ещё не вышли, то выводим максимальное значение

    }

    public void MaxOfThreeV2() // ДомашкаV2.mp4
    {
        // Определение максимального значения из трёх чисел [v2]

        Random r = new Random();    // Создаем объект рандом (случайность)

        Console.Write("От скольки?: "); // Спрашиваем от скольки и записываем
        int from = int.Parse(Console.ReadLine());

        Console.Write("До скольки?: "); // Спрашиваем до скольки и записываем
        int to = int.Parse(Console.ReadLine());

        Console.Write("Сколько чисел?: "); // Спрашиваем сколько чисел надо
        int count = int.Parse(Console.ReadLine());

        int[] values = new int[count];  // Массив, размером count из int

        int max = 0; // По дефлоту максимальное значение = 0

        Console.Write("Значения: ");
        for (int i = 0; i < count; i++) // Заполнение массива рандомными числами,
        {                               // вывод значений и определение макс. значения
            values[i] = r.Next(from, to);
            Console.Write(" " + values[i]);
            if (values[i] >= max) max = values[i];
            
        }

        Console.WriteLine("\nМаксимальное значение: " + max); // Выводим максимальное значение
    }
}
