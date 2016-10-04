using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameTheNumber
{
    class Program
    {
        /*
         * Нам нужно определить окончание для слова "гриб" в зависимости от заданного числа.
         * 
         * Идея: если последняя цифра в числе 1 - окончание отсутсвует. если 2, 3, 4 - окончание "a", в остальных случаях окончание "ов".
         * Исключения: числа вида 1х имеют окончание "ов".
         * */

        static void Main(string[] args)
        {
            string[] possibleEndings = { "", "а", "ов" };

            int k = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Я собрал " + k + " гриб" + possibleEndings[Ending(k)]);

            Console.ReadLine();
        }

        public static int Ending(int number)
        {
            if (number / 10 == 1)
            {
                return 2;
            }
            else
            {
                int remains = number % 10;

                if (remains == 1)
                {
                    return 0;
                }
                else if (remains >= 2 && remains <= 4)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
