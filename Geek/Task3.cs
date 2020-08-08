using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    class Task3
    {
        /// <summary>
        /// 3. Написать программу обмена значениями двух целочисленных переменных:
        ///a.с использованием третьей переменной;
       /// b. * без использования третьей переменной.
        /// </summary>
        public void Change( )
        {
            int a = 6;
            int b = 10;
            int c;
            Console.WriteLine($"a = {a} b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} b = {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a} b = {b}");           
        }
    }
}
