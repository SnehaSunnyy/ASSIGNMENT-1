﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STAR_A_
    {
        public static void Main()
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
