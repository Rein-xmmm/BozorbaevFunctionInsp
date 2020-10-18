using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;
using System.Threading;

namespace FunctionInsp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine($"Пожождите идет загрузка данных");
                Console.Write($"{x}%");
                Thread.Sleep(3);
                Console.Clear();
            }
            FunctionInsp funk = new FunctionInsp();
            FunctionInsp.GetInspector();
            FunctionInsp.GetСarInspection();
            FunctionInsp.SetInspector();
            Console.WriteLine($"{funk.GenerateNumber("028", "s".ToUpper(), "75")}");
            FunctionInsp.GetWorker();
            Console.WriteLine($"{funk.AddWdorker()}");

            Console.ReadLine();  
        }
    }
}
