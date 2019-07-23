using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_16
{
    class Class1
    {
        public void Bigger()

        {
         //   int z;
            int x;
            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

           if (x % 2 == 0)
            {
                Console.WriteLine("The number is even ");
            }

            if (x % 2 != 0)
            {
                Console.WriteLine("The number is odd ");
            }

            int y;
            Console.Write("Enter a number: ");
            y = Convert.ToInt32(Console.ReadLine());

            int z = y + x;
            
            Console.WriteLine($"The answer is {z}");
        }
    }
}


