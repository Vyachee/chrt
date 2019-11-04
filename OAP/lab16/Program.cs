using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static void Task1()
        {

            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(-99, 99);

            double sum = 0;
            var items = from x in arr
                        where x > 0
                        select x;
            Console.Write("Исходные данные: ");
            foreach (int x in arr)
                Console.Write(x + " ");
            Console.Write("\nЧисла больше 0: ");
            foreach (int x in items)
            {
                sum += x;
                Console.Write(x + " ");
            }

            Console.WriteLine("\nСумма: " + sum);
        }

        class Country
        {
            public string name;
            public double c;
            public string continent;
            public Country(string name, double c, string continent)
            {
                this.name = name;
                this.c = c;
                this.continent = continent;
            }
        }

        public static void Task2()
        {
            Random r = new Random();

            List<Country> cs = new List<Country>();
            string[] conts =
            {
                "Азия", "Африка", "Северная Америка", "Южная Америка", "Антарктида", "Европа", "Австралия"
            };

            for (int i = 0; i < 25; i++) 
                cs.Add(new Country("С" + i.ToString(), r.Next(0, 200), conts[r.Next(0, conts.Length)]));

            Console.WriteLine("Все элементы: ");
            foreach (Country x in cs)
                Console.WriteLine(x.name + " " + x.c + " " + x.continent);

            var needle = from x in cs
                         where (x.c > 130 && x.continent == "Африка")
                         select x;

            Console.WriteLine("Население в Африке > 130: ");
            foreach (Country x in needle)
                Console.WriteLine(x.name + " " + x.c + " " + x.continent);

        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Выберите задание (1/2): ");
                switch(Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    default:
                        Console.WriteLine("Нет такого");
                        break;
                }
            }
        }   
    }
}
