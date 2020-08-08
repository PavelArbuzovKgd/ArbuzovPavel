using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek
{
    /// <summary>
    /// 6. Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».
    /// </summary>
    class Task6
    {
        public void Year()
        {
            Console.WriteLine("Введите возраст!");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y == 1)
            {
                Console.WriteLine($"{y} год!");
            }
            else if (y > 1 && y < 5)
            {
                Console.WriteLine($"{y} года!");
            }
            else if (y > 4)
            {
                Console.WriteLine($"{y} лет!");
            }
            else Console.WriteLine("нет лет атлет!");
        }
    }
}
