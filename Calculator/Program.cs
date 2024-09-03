using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result;
            string operation;

            Console.WriteLine("Hello, Welcome to my Calculator!");
            Console.WriteLine("Please enter your first number: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Your Numbers are: ");
            Console.WriteLine(num1 + "," + num2);

            Console.WriteLine("a - addition\ns - substraction\nm - multiplication\nd - division\nSelect Your opeation(a/s/m/d): ");
            operation = Console.ReadLine();
            
            if ((operation == "a") || (operation == "A"))
            {
                Console.WriteLine("You have chosen: " + " Addition");
                result = num1 + num2;
            }
            else if ((operation == "s") || (operation == "S"))
            {
                Console.WriteLine("You have chosen: " + " Substraction");
                result = num1 - num2;
            }
            else if ((operation == "m") || (operation == "M"))
            {
                Console.WriteLine("You have chosen: " + " Multiplication");
                result = num1 * num2;

            }
            else if ((operation == "d") || (operation == "D"))
            {
                Console.WriteLine("You have chosen: " + " Division");
                result = num1 / num2;

            }
            else
            {
                Console.WriteLine("Incorrect choice.");
                result = 0;
            }

            Console.Write("Answer: ");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
        
}

