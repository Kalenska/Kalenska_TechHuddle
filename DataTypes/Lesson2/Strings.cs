﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2
{
    class Strings
    {
        public static void Excercise1()
        //Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        //ok
        {
            Console.WriteLine("Input a string");
            string str = (Console.ReadLine());

            char first = str[0];
            char last = str[str.Length - 1];
            Console.WriteLine(last + str.Substring(1, str.Length - 2) + first);
        }

        public static string Exercise()
        //other solution to the first task 
        {
            Console.WriteLine("Input a string");
            string str = Console.ReadLine();

            char first = str[0];
            string last = str.Substring(str.Length - 1);
            return last + str.Substring(1, str.Length - 2) + first;
        }


        public static void Excercise2()
        //Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
        {
            while (true)
            {

                {
                    Console.WriteLine("Input any word or sentense - length 1 or more");
                    string inputString = (Console.ReadLine());

                    char first = inputString[0];
                    Console.WriteLine(first + inputString + first);
                }
            }
        }


        public static void Excercise3()
        //Write a C# program to reverse the words of a sentence.
        {
            while (true)
            {

                {
                    Console.WriteLine("Input any word or sentense");
                    string inputString = (Console.ReadLine());

                    string resultString = string.Join(" ", inputString.Split(' ')
                        .Select(x => new string(x.Reverse().ToArray())));

                    Console.WriteLine(resultString);
                }
            }

        }

        public static void Excercise4()
        //Write a C# program to check if a given string contains ‘c’ character between 1 and 3 times.
        {
            while (true)
            {

                {
                    Console.WriteLine("Input a string.");
                    string inputString = Console.ReadLine();

                    var count = inputString.Count(s => s == 'c');
                    Console.WriteLine("Test if the string containc 'c' character 1 or 3 times");
                    Console.WriteLine(count >= 1 && count <= 3);
                }
            }
        }

        public static void Excercise5()
        //Write a C# Sharp program that takes a character as input and check the input (lowercase) is a letter, a digit, or any other symbol.        
        {
            while (true)
            {

                {
                    
                    Console.WriteLine("Input a character.");
                    char inputString = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("Is lower: " + char.IsLower(inputString));
                    Console.WriteLine("Is letter: " + char.IsLetter(inputString));
                    Console.WriteLine("Is digit: " + char.IsDigit(inputString));
                    Console.WriteLine("Is symbol: " + char.IsSymbol(inputString));

                }
            }
        }
    }
}
