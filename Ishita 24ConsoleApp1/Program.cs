﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_24ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nCheck whether a character is alphabet or not and if so, check for case :\n");
            Console.Write("-----------------------------------------------------------------------------\n");
            Console.Write("Input a character: ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nThe character is uppercase.\n");
                }
                else
                {
                    Console.WriteLine("\nThe character is lowercase.\n");
                }
            }
            else
            {
                Console.WriteLine("\nThe entered character is not an alphabetic character.\n");
            }
        }
    }
}
    