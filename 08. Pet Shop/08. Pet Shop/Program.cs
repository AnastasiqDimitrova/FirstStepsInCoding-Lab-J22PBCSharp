using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading the input from the user
            //1. number of food pakcs for dog typ => int
            int dogFoodCount = int.Parse(Console.ReadLine());
            //2. Number of food pakcs for cats typ => int
            int catFoodCount = int.Parse(Console.ReadLine());
            //Price for single food
            double singleDogFoodPrice = 2.5;
            //Price for single cat
            double singleCatFoodPrice = 4;
            //Logical part for solving the problem
            double totalPriceForDogFood = dogFoodCount * singleDogFoodPrice;
            double totalPriceForCatFood = catFoodCount * singleCatFoodPrice;
            double totalPrice = totalPriceForDogFood + totalPriceForCatFood;
            //Print the final result on the console
            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
