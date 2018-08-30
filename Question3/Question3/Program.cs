using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 3

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-- This program will expand a basic quadratic equation --");
            Console.WriteLine("------------------- (x + n) (x + m) ---------------------");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Looking at the above brackets...");
            Console.WriteLine("\nEnter a +ve or -ve value for n:");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a +ve or -ve value for m:");
            float n = float.Parse(Console.ReadLine());

            int x = 1;
            float b = x*m + x*n;
            float c = m * n ;

            Console.WriteLine($"That in standard form is: x^2 + {b}x {c}");

            Console.ReadLine();

        }
    }
}
