using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    class Task5
    {
        /// <summary>
        /// 5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
        /// </summary>
        public void Month()
        {
            Console.WriteLine("Введите номер месяца (число от 1 до 12)");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {

                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");                    
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Month();
                    break;
            }           
        }
    }
}
