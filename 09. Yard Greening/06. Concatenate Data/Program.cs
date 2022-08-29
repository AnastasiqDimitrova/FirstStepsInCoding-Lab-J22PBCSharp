using System;

namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ana";
            string lastName = "Dimitrova";
            int age = 30;
            string town = "Sofia";

            Console.WriteLine($ "You are {firstName} {lastName}, a {age} - years old person from {town}.");
        }
    }
}
