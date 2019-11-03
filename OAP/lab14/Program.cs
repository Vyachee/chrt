using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IComparable
    {
        double GetArea();
        double GetLength();
        double GetWidth();
        string GetName();

        void SetLength(double value);
        void SetWidth(double value);
        void SetName(string value);

    }
    class Room : IComparable
    {

        private double s1;
        private double s2;
        private string name;

        public Room(double length, double width, string title)
        {
            s1 = length;
            s2 = width;
            name = title;
        }
        public double GetArea()
        {
            return s1 * s2;
        }

        public double GetLength()
        {
            return s1;
        }

        public double GetWidth()
        {
            return s2;
        }

        public string GetName()
        {
            return name;
        }

        public void SetLength(double value)
        {
            s1 = value;
        }

        public void SetWidth(double value)
        {
            s2 = value;
        }

        public void SetName(string value)
        {
            name = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room(10, 15, "Комната 1");
            Room r2 = new Room(20, 28, "Комната 2");

            Console.WriteLine($"Площадь {r1.GetName()}: {r1.GetArea()} кв. м.");
            Console.WriteLine($"Площадь {r2.GetName()}: {r2.GetArea()} кв. м.");

            Console.Read();
        }
    }
}
