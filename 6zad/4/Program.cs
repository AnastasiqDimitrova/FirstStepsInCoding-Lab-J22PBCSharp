using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int readPagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hoursForRead = pages / readPagesPerHour;
            int daysForRead = hoursForRead / days;
            Console.WriteLine(daysForRead);
        }
    }
}
