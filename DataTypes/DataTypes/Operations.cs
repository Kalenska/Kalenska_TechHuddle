﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Operations
    {
        public void Operation()
        {
            int r;
            int x;
            int y;

            int height;
            int side;

            //Operations 1 
            Console.WriteLine("Enter first number?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number?");
            int b = int.Parse(Console.ReadLine());
            double result1 = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
            Console.WriteLine("(a + B)^2 is: " + result1);

            //Operations 2 
            Console.WriteLine("Enter any number number?");
            r = int.Parse(Console.ReadLine());
            double result2 = Math.PI * r;
            double result3 = Math.Pow(result2, 2);
            Console.WriteLine("(Pi*Your number)^2 is: " + result3);

            //Operations 3 
            Console.WriteLine("Enter first number?");
            a = int.Parse(Console.ReadLine());
#pragma warning disable CS1718 // Comparison made to same variable
            Console.WriteLine(a % 2 == 0);
#pragma warning restore CS1718 // Comparison made to same variable
            Console.WriteLine(a % 2 != 0);

            //Operations 4 
            Console.WriteLine("Enter first number - x?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number - y?");
            y = int.Parse(Console.ReadLine());
            double result5 = Math.Pow(x, y);
            Console.WriteLine("x^y is: " + result5);

            //Operation 5
            Console.WriteLine("Enter number of a height of triangle?");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side of triange?");
            side = int.Parse(Console.ReadLine());
            double result6 = height * side / 2;
            Console.WriteLine("The are of the triange is: " + result6);

        }
    }
}