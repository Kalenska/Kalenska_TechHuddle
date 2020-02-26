using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Calculations
    {

        public static void Excercise1()
        {
            Equation1();
            Equation2();
            Equation3();
            Equation4();
        }
            private static void Equation1()
            { 
                //Task 1 
                Console.WriteLine("Enter 3 numbers - a, b and c");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                double sum = (a + b * c);
                Console.WriteLine("a + b * c = " + sum);
            }

            private static void Equation2()
            {
                //Task2
                Console.WriteLine("Enter another 3 numbers - a, b and c");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                double sum1 = (a + b % c);
                Console.WriteLine("a + b % c = " + sum1);
            }

            private static void Equation3()
            {
                //Task 3 
                Console.WriteLine("Enter another 4 numbers - a, b, c and d");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                int sum2 = (a + b * c / d);
                Console.WriteLine("a + b * c / d = " + sum2);
            }

            private static void Equation4()
            {
                //Task 4
                Console.WriteLine("Add 6 numbers");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());
                int f = int.Parse(Console.ReadLine());
                double sum3 = a + b / c * d - e % f;
                Console.WriteLine("a + b / c * d - e % f = " + sum3);
            }

        public static void Excercise2()
        {
           int a,b,temp;

          Console.WriteLine("Input the First Number");
          a = int.Parse(Console.ReadLine());
          Console.WriteLine("Input the Second Number");
          b = int.Parse(Console.ReadLine());
          Console.WriteLine("The first number is {0} and the second number is {1} ", a, b);
          //Swap two numbers
          temp = a;
          a = b;
          b = temp;
          Console.WriteLine("The values after swaping are {0} and {1}", a, b);
          Console.ReadKey();
        }
    }
 }
