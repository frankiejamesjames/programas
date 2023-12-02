using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_Juan_Antonio_Ripoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce número:");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(number));

        }

        public static int Factorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
            
        }
    }
}
