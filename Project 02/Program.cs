/* Documentation:
 * Project 2
 * By Joshua Yang
 * Student id: 2355145
 * Date: 9/9/2019
 * Class: Visual Programming (CPSC 236)
 * Professor: Christopher Boyd
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Integers are declared 
             *  with default assignment
             *  based off of Rubric
             */
            int x = 7;
            int y = 5;

            Console.WriteLine("Sum: " + sum(x, y)); // Prints Addition Function with declared ints
            Console.WriteLine("Subtract: " + sub(x, y)); // Prints Subtraction Function with declared ints
            Console.WriteLine("Divide: " + divide(x, y)); // Prints Dvision Function with declared ints
            Console.WriteLine("Multiple: " + multiple(x, y)); // Prints Multiplication Functions with declared ints
            Console.WriteLine("Remainder: " + mod(x, y)); // Prints Remainder Function with declared ints
            Console.WriteLine("Please press ENTER to exit program!"); // A display message to direct user to next step
            Console.ReadLine(); // Pausing Console to allow user to read output screen before program exits
            
        }

        /*  Function "sum" will add 
            integer a and b and return the value back to 
            where it was called.
        */
        static int sum(int a, int b)
        {
            return a + b;
        }

        /*  Function "Sub" will Subtract 
            integer a and b and return the value back to 
            where it was called.
        */
        static int sub(int a, int b)
        {
            return a - b;
        }

        /*  Function "Divide" will divide 
            integer a and b and return the value back to 
            where it was called.
        */
        static int divide(int a, int b)
        {
            return a / b;
        }

        /*  Function "Multiple" will multiply 
            integer a and b and return the value back to 
            where it was called.
        */
        static int multiple(int a, int b)
        {
            return a * b;
        }

        /*  Function "Mod" will retrieve the remainder from 
            integer a and b and return the value back to 
            where it was called.
        */
        static int mod(int a, int b)
        {
            return a % b;
        }

    }
}
