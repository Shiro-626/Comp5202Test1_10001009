using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("This program can tell you if your number is odd or even");
            Console.WriteLine("-------------------------------------------------------");

            int userNum = 0; 

            do
            {
                Console.WriteLine("Enter a whole number between 1 and 1000:");
                userNum = Int32.Parse(Console.ReadLine());

                if (userNum > 1000 || userNum < 1)
                {
                    Console.WriteLine("That number is not between 1 and 1000, please enter another number");
                    userNum = Int32.Parse(Console.ReadLine());
                }
            } while (userNum > 1000 || userNum < 1);

            userNum = userNum % 2;

                if (userNum == 0)
                {
                    Console.WriteLine("That number is even");
                }
                else
                {
                    Console.WriteLine("That number is odd");
                }

            Console.ReadLine();

        

        }
    }
}
