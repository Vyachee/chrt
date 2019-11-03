using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void FillList(ref List<int> list)
        {
            Console.Write("Сколько элементов добваить в List?: ");

            Random r = new Random();
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
                list.Add(r.Next(-10, 99));
        }

        public static void ShowList(List<int> list)
        {
            Console.Write("Элементы листа: ");
            foreach (int x in list)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        public static void Task1()
        {
            List<int> l = new List<int>();
            FillList(ref l);
            ShowList(l);

            int sum = 0;
            foreach (int x in l)
                if (x >= 10) sum += x;

            Console.WriteLine("Сумма двузначных элементов листа: " + sum);
        }

        public static void Task2()
        {
            Console.Write("Введите какую-либо строку: ");

            string s = Console.ReadLine();
            Stack<string> st = new Stack<string>();

            char[] sArr = s.ToCharArray();

            foreach (char x in sArr)
                st.Push(x.ToString());

            foreach (string x in st)
                Console.Write(x);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Номер задания (1\\2):");
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
