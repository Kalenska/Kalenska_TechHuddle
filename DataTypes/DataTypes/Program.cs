using System;

namespace DataTypes
{
    class Program
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

            //Problem 1 
            Console.WriteLine("Name: " + firstName + " " + lastName + ", " + "Address: " + city + ", " + street + " " + houseNumber);

            //Problem 2
            Console.WriteLine("Name: " + firstName + " " + lastName + ", " + "Age: " + age);
            Console.WriteLine("University: " + university);


        }
    }
}
