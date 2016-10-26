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
            Mushroom mush = new Mushroom();

            int k;

            do
            {
                k = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Я собрал " + k + " гриб" + mush.Message(k));
            } while (k != -1);
            
            Console.ReadLine();
        }

        
    }
}
