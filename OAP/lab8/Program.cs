using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Для продолжения работы нажмите [ENTER]...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Read();
            Console.Clear();
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.Write("Выберите операцию, которую хотите выполнить: \n" +
                "Установить длины сторон (1) \n" +
                "Вывод информации(2) \n" +
                "Показать площадь (3) \n" +
                "Показать периметр (4) \n" +
                "Закончить работу (0): ");
        }
        static void Main(string[] args)
        {
            Triangle t = new Triangle(0, 0, 0);
            while(true)
            {
                try
                {
                    ShowMenu();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            double a, b, c;
                            Console.Write("Введите сторону А: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Введите сторону B: ");
                            b = double.Parse(Console.ReadLine());
                            Console.Write("Введите сторону C: ");
                            c = double.Parse(Console.ReadLine());

                            t = new Triangle(a, b, c);
                            Pause();
                            break;

                        case "2":
                            t.InfoDisplay();
                            Pause();
                            break;

                        case "3":
                            Console.WriteLine($"Площадь треугольника = {t.GetArea()}");
                            Pause();
                            break;

                        case "4":
                            Console.WriteLine($"Периметр треугольника = {t.GetPerimetr()}");
                            Pause();
                            break;

                        case "0":
                            return;
                    }
                }   catch
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }
    }
}
class Triangle
{
    private double A, B, C;
    public Triangle(double A, double B, double C)
    {
        this.A = A;
        this.B = B;
        this.C = C;

        Console.WriteLine($"Установлены стороны: {A}, {B}, {C}");
    }

    public void InfoDisplay()
    {
        Console.WriteLine($"Сторона А: {A}\nСторона B: {B}\nСторона C: {C}");
    }

    public double GetPerimetr()
    {
        return (A + B + C);
    }

    public double GetArea()
    {
        double p = GetPerimetr() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}