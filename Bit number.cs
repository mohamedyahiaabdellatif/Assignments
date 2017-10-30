
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,n;
            string p;

            Console.WriteLine("Enter a number :");
            number = int.Parse(Console.ReadLine());

           p = Convert.ToString(number, 2);
            Console.WriteLine("The Number in Binary :\n" + p);

            Console.WriteLine("Enter a specific Position n :");
          n= int.Parse(Console.ReadLine());
            Console.WriteLine("The value of Bit at Position  " + p + " is:\n" + p[n - 1]);
            Console.ReadLine();
        }
    }
}
