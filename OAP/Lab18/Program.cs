using System;
using System.Diagnostics;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Process.Start("WINWORD.exe");

            Console.WriteLine("Произошло 1 задание, нажми ентер");
            Console.Read();

            // Task 2
            foreach(Process process in Process.GetProcesses())
                Console.WriteLine(process.ProcessName + " | id: " + process.Id);

            // Task 3
            Process.Start("mailto:igoreshapl@gmail.com?subject=Топ колледжов&body=ЧРТ вошел в ТОП-3 колледжов мира");


            Console.WriteLine("Произошло ещё два задания, можешь ничо не нажимать");
            Console.Read();
        }
    }
}
