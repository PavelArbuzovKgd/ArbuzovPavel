using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Lesson
{
    class Program
    {

        static void Main(string[] args)
        {
            Task1 Task1 = new Task1();
            Console.WriteLine("введите пример для проверки правильности расстановки скобок");
            Console.WriteLine(Task1.CheckStr(Console.ReadLine()) ? "Верное" : "НЕ Верное");

        }

    }

}   

