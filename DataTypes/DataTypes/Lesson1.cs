using System;

namespace Homework
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string lastName = "Petkov";
            string city = "Sofia";
            string street = "Bul. Bulgaria";
            string houseNumber = "N5";

            int age = 20;
            string university = "Sofia University";

            int a = 3;
            int b = 2;
            int r = 5;

            //Problem 1 
            Console.WriteLine("Name: " + firstName + " " + lastName + ", " + "Address: " + city + ", " + street + " " + houseNumber);

            //Problem 2
            Console.WriteLine("Name: " + firstName + " " + lastName + ", " + "Age: " + age);
            Console.WriteLine("University: " + university);

            //Calculations: The first line contains the sum of the two numbers.
            int sum = a + b;
            Console.WriteLine(sum);

            //Calculations: The second line contains the difference of the two numbers (first - second).
            int modulus = a % b;
            Console.WriteLine(modulus);

            //Calculations: The third line contains the product of the two numbers.
            int product = a * b;
            Console.WriteLine(product);

            //Operations 1 - square root (solution1) 
            double sqRoot = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
            Console.WriteLine(sqRoot);

            //Operations 1 - square root (solution2) 
            double sqRoot1 = Math.Pow(a + b, 2);
            Console.WriteLine(sqRoot1);

            //Operations 2 - Pi; r=5
            double sumTotal = Math.Pow(Math.PI * r, 2);
            Console.WriteLine(sumTotal);



        }
    }
    
}
