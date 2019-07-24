using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_16
{
    class Class1
    {
        public void Bigger() #method to see if the number is even odd and sums up two numbers

        {
         //   int z;
            int x; #initializes the x int
            Console.Write("Enter a number: "); #prompts the user
            x = Convert.ToInt32(Console.ReadLine()); #converts the x variable

           if (x % 2 == 0) #if the x % 2 is equal to 0 then it is even
            {
                Console.WriteLine("The number is even ");
            }

            if (x % 2 != 0) if x % 0 doesnt equal 0 then the it is odd
            {
                Console.WriteLine("The number is odd ");
            }

            int y; # initializes the y int 
            Console.Write("Enter a number: "); #prompts the user 
            y = Convert.ToInt32(Console.ReadLine()); #converts the y variable 

            int z = y + x; #sums up the x and y variable 
            
            Console.WriteLine($"The answer is {z}"); #writes out the message and the sum to the console
        }
    }
}


