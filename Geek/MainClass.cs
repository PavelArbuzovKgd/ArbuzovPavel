using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    class MainClass
    {
        
        static void Main()
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();
            Task6 task6 = new Task6();
            task1.IndexMass();
            task2.MaxInt();
            task3.Change();
            task4.Race();
            task5.Month();
            task6.Year();

            Console.ReadKey();
        }
    }
}
