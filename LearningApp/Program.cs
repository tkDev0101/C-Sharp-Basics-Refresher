// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace LearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Life Tracker App!");
            Console.Write("Enter your character's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your character's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Create a new character using the Character class
            Character player = new Character(name, age);

            // Show the character's initial stats
            player.ShowStats();

            Console.WriteLine("You're now ready to begin your journey!");
        }
    }
}

