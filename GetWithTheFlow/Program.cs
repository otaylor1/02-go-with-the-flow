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
            Console.WriteLine("Type: Yes or No");

            string firstAnswer = Console.ReadLine();

            //adding .ToLower() to string name makes all answers of yes lowercase
            

            if (firstAnswer.ToLower() == "yes")
            {
                Console.WriteLine("Keep doing what you are doing.");
                Console.ReadKey();
            }

            //put the rest of the code in else to keep afinal else from repeating if it has already been stated above

            else
            {
                Console.WriteLine("Do you want to be happy?");
                Console.WriteLine("Type: Yes or No");


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






