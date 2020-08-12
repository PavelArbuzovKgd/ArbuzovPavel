using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    class Task4
    {
        /// <summary>
        /// 4. Написать программу нахождения корней заданного квадратного уравнения.
        /// </summary>
        private double b;
        private double c;
        private double a;

        public void Race()
        {
            Console.WriteLine("a=");
             a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
             b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
             c = Convert.ToDouble(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0) Console.WriteLine("Корней нет.");
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                if (x1 == x2) Console.WriteLine("Один корень: x={0}", x1);
                else Console.WriteLine("Два корня: x1={0}; x2={1}", x1, x2);
            }
        }
    }
}
