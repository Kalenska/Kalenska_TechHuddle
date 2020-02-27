using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Conditions
    {
        public static void Excercise1()
        {
            while (true)
            {
                Console.WriteLine("Input first integer");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Input second integer");
                int y = int.Parse(Console.ReadLine());

                if (x < 0 && y >= 0)
                {
                    Console.WriteLine("Check if one is negative and one is positive: True");
                }
                if (x >= 0 && y < 0)
                {
                    Console.WriteLine("Check if one is negative and one is positive: True");
                }
                else if (x >= 0 && y >= 0 && x <= 0 && y <= 0) 
                {
                    Console.WriteLine("Check if one is negative and one is positive: False");
                }
            }
        }

        public static void Excercise2()
        {
            while (true)
            {
                Console.WriteLine("Input first integer");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Input second integer");
                double y = double.Parse(Console.ReadLine());

                double absolute = (x - y);
                double abslValue = Math.Abs(absolute);
                Console.WriteLine(abslValue);

                if (x > y)
                {
                    double doubleAbsolute = (abslValue * 2);
                    Console.WriteLine(doubleAbsolute);
                }


            }
        }


























    }
}
