using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double E, s1=0, s2=0;
            int i=1;
            Console.WriteLine("Введите точность Е");
            while (!double.TryParse(Console.ReadLine(), out E)||(E<=0))
                Console.WriteLine("Введите рациональное число больше 0");
            
            do
            {
                s1 = s2; 
                s2= s1+ 1d / (i * (i + 1));
                i++;
            } while (s2 - s1 >= E);
            Console.WriteLine("Сумма ряда с точностью " + E + " равна " + s2);
            Console.ReadLine();
        
        }
    }
}
