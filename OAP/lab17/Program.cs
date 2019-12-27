using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Lab17
{

    class Program
    {
        static string pathToXml = @"file.xml"; // Путь к скачанному XML
        static string pathToSave = @"myXml.xml";  // Путь, куда сохранять созданный XML файл
        static string pathToNames = @"names.txt";  // Путь к файлу names.txt

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Select number of the task (1/2): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        XmlDocument xDoc = new XmlDocument();   // Создать XML документ
                        string path = pathToXml;  // Указать путь до XML файла

                        xDoc.Load(path);    // Загрузить XML файл

                        XmlNodeList products = xDoc.GetElementsByTagName("Product");    // Получить все Product

                        int sum = 0;    // Изначальная сумма

                        foreach (XmlNode node in products)   // Для каждого Product
                        {
                            int price = int.Parse(node["price"].InnerText); // Получить цену
                            int count = int.Parse(node["count"].InnerText); // Получить кол-во
                            sum += price * count;   // Добавить к изначальной сумме цена * кол-во
                        }

                        Console.WriteLine("Total sum is " + sum);   // Вывести общую сумму покупок

                        break;

                    case "2":

                        Dictionary<int, int> dict = GetInfoAboutNames();    // Получить данные про года из names.txt

                        XmlDocument doc = new XmlDocument();    // Создать XML документ
                            
                        XmlElement root = doc.CreateElement("Years");   // Создать контейнер для всех годов
                        doc.AppendChild(root);                          // Поместить его в документ

                        foreach(KeyValuePair<int, int> item in dict)
                        {
                            XmlElement Year = doc.CreateElement("Year");    // Создать контейнер для элемента

                            XmlElement inYear = doc.CreateElement("InYear", string.Empty);  // Создать элемент inYear
                            inYear.InnerText = item.Key.ToString();                         // Поместить туда год
                            XmlElement count = doc.CreateElement("Count", string.Empty);    // Создать элемент count
                            count.InnerText = item.Value.ToString();                        // Поместить туда кол-во чубриков

                            Year.AppendChild(inYear);   // дальше без комментариев
                            Year.AppendChild(count);
                            root.AppendChild(Year);
                        }

                        doc.Save(pathToSave);

                        Console.Read();
                        break;
                }
            }
        }

        public static Dictionary<int, int> GetInfoAboutNames()
        {
            string line;
            int counter = 1;
            string[] yearAndName = new string[2];
            string[] date = new string[3];


            int year;
            bool endable = false;
            Console.Write("Сколько строк прочитать (0 - все): ");
            int amountToRead = int.Parse(Console.ReadLine());

            if (amountToRead != 0) endable = true;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            using (StreamReader file = new StreamReader(pathToNames))
            {
                while ((line = file.ReadLine()) != null)
                {
                    yearAndName = line.Split('\t');

                    date = yearAndName[0].Split('.');
                    year = int.Parse(date[2]);

                    Console.WriteLine($"\nОбработка строки #{counter}");

                    if (dict.ContainsKey(year))
                        dict[year] += 1;
                    else dict.Add(year, 1);

                    if (endable && counter == amountToRead)
                        break;

                    counter++;
                }
            }
            return dict;
        }
    }
}
