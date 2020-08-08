using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    /// <summary>
    /// 1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
    /// </summary>
    class Task1
    {
        public void IndexMass()
        {
            Console.WriteLine("Введите ваш вес:");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост:");
            double h = double.Parse(Console.ReadLine());
            double i = m / (h * h);
            Console.WriteLine("Индекс массы тела = " + i);            
        }
    }
}
