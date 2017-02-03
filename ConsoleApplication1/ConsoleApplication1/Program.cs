using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to add 
            int number2; // declare second number to add 
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first integer: "); // prompt user 15 // read first number from user 16 17 18 
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second integer: "); // prompt user
                number2 = Convert.ToInt32(Console.ReadLine());
                sum = number1 + number2; // add numbers
                Console.WriteLine("Sum is {0}", sum); // display sum
            } catch
            {
                Console.Write("foutje");
            }
          
            Console.ReadLine();
        }
    }
}
