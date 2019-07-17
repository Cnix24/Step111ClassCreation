using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreateStep111
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputValue;
            string userInput;

            Console.WriteLine("Please provide a number for math results: ");
            userInput = Console.ReadLine();
            inputValue = Convert.ToInt32(userInput);

            Mathing multiply = new Mathing(inputValue);
            

            Console.WriteLine("Your number " + inputValue + " times 10 is " + multiply.Multiplier);
            Console.WriteLine("Your number " + inputValue + " plus 23 is " + multiply.Adder);
            Console.WriteLine("Your number " + inputValue + " minus 9 is " + multiply.Subtractor);
        }
    }
}
