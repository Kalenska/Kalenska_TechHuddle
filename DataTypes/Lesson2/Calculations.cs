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
            int a, b, temp;

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
        }

        public static void Excercise3()
        {
            int a, b, c;
            Console.WriteLine("Input the first number to multiply");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply");
            c = int.Parse(Console.ReadLine());
            int result = a * b * c;
            Console.WriteLine("The multiplication of the three numbers is: " + result);
        }

        public static void Excercise4()
        {
            int a, b, c, d;
            Console.WriteLine("Enter the First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the four number:");
            d = int.Parse(Console.ReadLine());

            double avg = (a + b + c + d) / 4;
            Console.WriteLine("The average of the numbers is: " + avg);
        }

        public static void Excercise5()
        {
            double tempCelsius;

            Console.WriteLine("Enter the amount of celsius:");
            tempCelsius = double.Parse(Console.ReadLine());

            //Convert C to K 
            double tempKelvin = (tempCelsius + 273.15);
            Console.WriteLine(tempKelvin);

            //Convert C to F 
            double tempFahrenheit = (tempCelsius * 1.8) + 32;
            Console.WriteLine("Fahrenheit: " + tempFahrenheit);
        }

        public static void Excercise6()
        {
            Console.WriteLine("Enter any number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 3 == 0 || a % 7 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        public static void Excercise7()
        {
            Console.WriteLine("Input a first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < 100 && b > 200)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void Excercise8()
        {

            Console.WriteLine("Input a first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a third number");
            int c = Convert.ToInt32(Console.ReadLine());

            int maxNumber = Math.Max(Math.Max(a,b),c);
            Console.WriteLine("Largest of three: " + maxNumber);

            int minNumber = Math.Min(Math.Min(a, b), c);
            Console.WriteLine("Lowest of three: " + minNumber);
        }

        public static void Excercise9()
        //Get century - Not correct ...
        {
            Console.WriteLine("Enter the desired year");
            int y = 0;
            for (; !Int32.TryParse(Console.ReadLine(), out y);) { }
            y = Math.Abs(y);
            int basecentury = 0;
            basecentury = Convert.ToInt32(Math.Truncate((double)y / 100));

            Console.WriteLine("Result: " + basecentury + "Century");
        }


        public static void Excercise10()
        {
            Console.WriteLine("Enter radius");
            int a = Convert.ToInt32(Console.ReadLine());

            //Volume
            double volumeNumber = (4 * Math.PI * Math.Pow(a, 3) / 3);
            Console.WriteLine("Volume: " + volumeNumber);

            //Surface
            double surfaceNumber = (4 * Math.PI * Math.Pow(a, 2));
            Console.WriteLine("Surface: " + surfaceNumber);
        }

        public static void Excercise11()
        {
            int co1, co2;

            Console.Write("\n\n");
            Console.Write("Find the quadrant in which the coordinate point lies:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value for X coordinate :");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            co2 = Convert.ToInt32(Console.ReadLine());

         
        }
    }
}

   

