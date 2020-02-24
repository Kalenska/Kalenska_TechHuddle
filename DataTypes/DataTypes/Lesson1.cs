using System;

namespace Homework
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string city;
            string street;
            string houseNumber;
            string age;
            string university;

            int a;
            int b;
            int r;


            //Problem 1 
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("Where city are you from?");
            city = Console.ReadLine();

            Console.WriteLine("Enter your street?");
            street = Console.ReadLine();

            Console.WriteLine("Which is your house number");
            houseNumber = Console.ReadLine();

            string response = ("Your Name is " + firstName + " " + lastName + " and your address is " + city + ", " + street + " " + houseNumber);
            Console.WriteLine(response);

            //Problem 2
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            Console.WriteLine("Enter your university?");
            university = Console.ReadLine();

            string response1 = ("Your Name is " + firstName + " " + lastName + " Age: " + age);
            string response2 = ("University: " + university);
            Console.WriteLine(response1);
            Console.WriteLine(response2);

            //Calculations: The first line contains the sum of the two numbers.
            int sum = a + b;
            Console.WriteLine(sum);

            //Calculations: The second line contains the difference of the two numbers (first - second).
            int modulus = a - b;
            Console.WriteLine(modulus);

            //Calculations: The third line contains the product of the two numbers.
            int product = a * b;
            Console.WriteLine(product);

            //operations 1
            double result1 = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
            Console.WriteLine(result1);

            //Operations 2
            double rToPower2 = Math.Pow(r, 2);
            double result2 = Math.PI * rToPower2;
            Console.WriteLine(result2);


            //Operations 3 - T or F 
            Console.WriteLine(a == 3);
            Console.WriteLine(a != 3);

            //Operations 4
            double result2 = Math.Pow(x, y);
            Console.WriteLine(result2);

            //Operations 5 
            int area = (height * side) / 2;
            Console.WriteLine(area);






        }
    }
    
}
