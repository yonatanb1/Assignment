
using System;

namespace Program
{
    class prog
    {
        static void Main(String[] args)
        {
            int number;
             
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("please enter a number:");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter a number:");
                number = Int32.Parse(Console.ReadLine());
                if (number >i)
            {
                Console.WriteLine(number +" is greater " );
            }else if (number <i)
            {
                Console.WriteLine(number + " is lesser  ");
            }
            else
            {
                    Console.WriteLine(number + "is equal  "  );
                        }
            }
            Console.ReadKey();

        }
    }
}