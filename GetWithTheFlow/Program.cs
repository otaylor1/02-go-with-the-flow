using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Are You Happy?");
            Console.WriteLine("Yes or No");

            string firstAnswer = Console.ReadLine();
            if (firstAnswer.ToLower() == "yes")
            {
                Console.WriteLine("Keep doing what you are doing.");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Do you want to be happy?");
                Console.WriteLine("Yes or No");


                string finalAnswer = Console.ReadLine();
                if (finalAnswer.ToLower() == "yes")
                {
                    Console.WriteLine("Change something.");
                    Console.ReadLine();

                }

                else {
                    Console.WriteLine("Keep doing what you are doing.");
                    Console.ReadKey();

                }
            }

        }
    }
}






