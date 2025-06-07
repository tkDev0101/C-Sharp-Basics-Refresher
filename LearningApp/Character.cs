using System;

namespace LearningApp
{
    // This class represents the Player's character in the game
    public class Character
    {
        // Properties (variables that belong to the Character)
        public string Name { get; set; }
        public int Age { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; }


        // Constructor - called when we create a new Character
        public Character(string name, int age)
        {
            Name = name;
            Age = age;
            Energy = 100;  // start full of energy
            Health = 100;  // start healthy
        }

        // A method to display character stats
        public void ShowStats()
        {
            Console.WriteLine("\n--- Character Stats ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Energy: {Energy}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine("------------------------\n");
        }
    }
}
