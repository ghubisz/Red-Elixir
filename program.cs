using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <Recipe> recipes = new List <Recipe> ();

        while (true)
        {
            Console.WriteLine("Recipes App");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipes");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    AddRecipe(recipes);
                    break;
                case 2:
                    ViewRecipes(recipes);
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    return;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddRecipe(List<Recipe> recipes)
    {
        Console.WriteLine("Add Recipe");
        Console.Write("Enter recipe name: ");
        string name = Console.ReadLine();
        Console.Write("Enter recipe description: ");
        string description = Console.ReadLine();

        Recipe recipe = new Recipe(name, description);
        recipes.Add(recipe);

        Console.WriteLine("Recipe added successfully!");
    }

    static void ViewRecipes(List<Recipe> recipes)
    {
        Console.WriteLine("View Recipes");

        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes found.");
            return;
        }

        foreach (Recipe recipe in recipes)
        {
            Console.WriteLine("Name: "+ recipe.Name);
            Console.WriteLine("Desciption: "+ recipe.Desciption);
            Console.WriteLine();
        }
    }
}

class Recipe
{
    public string Name {get; set;}
    public string Desciption {get; set;}

    public Recipe(string name, string description)
    {
        Name = name;
        Desciption = description;
    }
}