﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to see if it exists in our list or not: \n");
            int input = int.Parse(Console.ReadLine());

            Answer(Check(input));
            Console.ReadLine();
        }

        static bool Check(int input)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            bool containsornot = false;
            foreach (var item in List)
            {
                if (item == input)
                {
                    containsornot = true;
                }
            }
            return containsornot;
        }

        static void Answer(bool input)
        {
            if (input)
            {
                Console.WriteLine("\nHuurray! You have a match!");
            }
            else
            {
                Console.WriteLine("\nNooo! No matches this time!");
            }
        }
    }
}
