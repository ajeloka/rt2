using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// loop 100 - 
        /// print fizz if divisible by 3
        /// print buzz if divisible by 5
        /// </summary>
        static void divisor_result(int max)
        {
            try
            {
                if (max > 0)
                {
                    for (int i = 1; i <= max; i++)
                    {
                        bool found = false;
                        if ((i) % 3 == 0)
                        {
                            Console.WriteLine("Fizz ");
                            found = true;
                        }

                        if (i % 5 == 0)
                        {
                            Console.WriteLine("Buzz ");
                            found = true;
                        }

                        if (!found)
                        {
                            Console.WriteLine(i.ToString());
                        }
                    }
                }
            }
            catch
            {

            }          

        }
        static void Main(string[] args)
        {
            int max = 0;
            string input = Console.ReadLine();
            if (int.TryParse(input, out max))
            {
                divisor_result(max);
            }
            else
                Console.WriteLine("Please enter a valid number > 100");
           
            Console.ReadKey();
        }
    }
}
