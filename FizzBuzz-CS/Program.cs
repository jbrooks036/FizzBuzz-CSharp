﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write(i + " ");
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }
    }
}
