using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
                string Num;
                Console.WriteLine("Enter a Hexadecimal Number :");
               Num = Console.ReadLine();
                int Output = int.Parse(Num, System.Globalization.NumberStyles.HexNumber);
                Console.WriteLine("The Decimal value is " + Output);
                Console.Read();
            }
        }
    }

   

