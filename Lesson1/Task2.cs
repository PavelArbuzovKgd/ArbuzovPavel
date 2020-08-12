using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    /// <summary>
/// 2. Найти максимальное из четырех чисел. Массивы не использовать.
/// </summary>
    class Task2
    {
        public void MaxInt()
        {
            int a, b, c, d;

            Console.WriteLine("Введите первое целое число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье целое число: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертое целое число: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine($"Максимальное из введенных чисел будет : {Max(a, b, c, d)}");            
        }

        static int Max(int a, int b, int c, int d)
        {
            if (a > b && a > c && a > d) return a;
            if (b > a && b > c && b > d) return b;
            if (c > a && c > b && c > d) return b;
            return d;
        }
    }
}
