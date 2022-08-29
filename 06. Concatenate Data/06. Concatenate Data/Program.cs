using System;

namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading the inputs from the user
            //1.name of the architect
            string nameOfTheArchitect = Console.ReadLine();
            //2.Number of all projects
            int numberOfProjects = int.Parse(Console.ReadLine());
            //Logical solving of the problem
            int individualProjectTime = 3;
            int timeForAllProjects = numberOfProjects * individualProjectTime;
            //Printing the final result one the console
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");
            
        }
    }
}
