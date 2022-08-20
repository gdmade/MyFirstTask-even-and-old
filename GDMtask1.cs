using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTask
{
    public class GDMtask1
    {
        //Print all odd and even Numbers between 1 and 35.
        
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Odd Numbers :");
            for (i = 1; i <= 35; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nEven Numbers: ");
            for(i = 1; i <=35; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}