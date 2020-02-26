using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Calculations
    {

        public static void Calculation()
        {
            //Task 1 
            Console.WriteLine("Enter 3 numbers - a, b and c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sum = (a + b * c);
            Console.WriteLine("(-a + b * c)= " + sum);

            //Task2
            Console.WriteLine("Enter another 3 numbers - d, e and f");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            double sum1 = ((d + e) % f);
            Console.WriteLine("(d + e) % f)= " + sum1);

            //Task 3 
            Console.WriteLine("Enter another 4 numbers - g, h, i and j");
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int sum2 = (g + h * i / j);
            Console.WriteLine("g + h * i / j)= " + sum2);

            //Task 4
            Console.WriteLine("Add 6 numbers");
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double sum3 = k + l / m * n - o % p; 
            Console.WriteLine("k + l / m * n - o % p)= " + sum3);
        }
    }
}
