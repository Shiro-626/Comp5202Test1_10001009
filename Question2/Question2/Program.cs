using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 2

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--This program will compute the average of ten numbers--");
            Console.WriteLine("--------------------------------------------------------");

            float total = 0;

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"Please enter number {i}");
                total = total + float.Parse(Console.ReadLine());
            }
            float avg = total / 10;
            
            Console.WriteLine($"The average of those ten numbers is: {avg}");

            Console.ReadLine();
            

        }
    }
}
