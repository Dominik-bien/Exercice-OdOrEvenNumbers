using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdOrEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program ask user to enter number 
            Console.WriteLine("Enter a number: ");
            var number = GetInput();
            //if number mod 2 is equal to 0 the program displays that the number is even
            if (number % 2 == 0)
            {
                Console.WriteLine($"Even Number. Number: {number}");
            }
            else
            //else if number mod 2 is not equal to 0 the program displays that number is even
            {
                Console.WriteLine($"Odd number: Number: {number}");
            }
        }

        //private method to throw exception if user enter a wrong format for the number variable.
        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("The stated value is not correct");

            return input;
        }
    }
}
