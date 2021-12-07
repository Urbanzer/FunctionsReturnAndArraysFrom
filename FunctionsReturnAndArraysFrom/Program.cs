using System;

namespace FunctionsReturnAndArraysFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomFilm();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");
        }

        private static void DisplayRandomFilm()
        {
            string[] films = { "horror", "comedy", "sci-fi", "drama" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, films.Length);

            string randomFilm = films[randomIndex];
            Console.WriteLine($"Computer picked: {randomFilm}");
        }
    }
}
