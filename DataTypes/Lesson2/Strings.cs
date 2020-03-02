using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2
{
    class Strings
    {
        public static void Excercise1()
        //?
        {
        }

        public static void Excercise2()
        //?
        {
        }

        public static void Excercise3()
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
    }
}
