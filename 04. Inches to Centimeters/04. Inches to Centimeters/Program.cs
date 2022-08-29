using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading the input from the user
            double number = double.Parse(Console.ReadLine());
            //Logical conversion
            double inches = 2.54;
            double centimeters = number * inches;
            //Printing the on the console
            Console.WriteLine(centimeters);
        }
    }
}
