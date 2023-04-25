// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class RecipeApplication
{
    private List<Ingredient> ingredients;
    private List<string> steps;

    // Constructor that initializes the ingredient and steps lists
    public RecipeApplication()
    {
        ingredients = new List<Ingredient>();
        steps = new List<string>();
    }

    // Add an ingredient to the recipe
    public void AddIngredient(string name, double quantity, string unit)
    {
        Ingredient ingredient = new Ingredient(name, quantity, unit);
        ingredients.Add(ingredient);
    }

    // Add a step to the recipe
    public void AddStep(string description)
    {
        steps.Add(description);
    }

    // Display the recipe
    public void DisplayRecipe()
    {
        Console.WriteLine("Recipe:");
        Console.WriteLine("Ingredients:");
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
        }

        Console.WriteLine("Steps:");
        int stepNumber = 1;
        foreach (string step in steps)
        {
            Console.WriteLine($"{stepNumber}. {step}");
            stepNumber++;
        }
    }

    // Scale the recipe by a factor
    public void ScaleRecipe(double factor)
    {
        foreach (Ingredient ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    // Reset the recipe quantities to their original values
    public void ResetQuantities()
    {
        foreach (Ingredient ingredient in ingredients)
        {
            ingredient.ResetQuantity();
        }
    }

    // Clear the recipe
    public void ClearRecipe()
    {
        ingredients.Clear();
        steps.Clear();
    }
}

class Ingredient
{
    public string Name { get; }
    public double Quantity { get; set; }
    public string Unit { get; }

    // Constructor that initializes the name, quantity, and unit properties
    public Ingredient(string name, double quantity, string unit)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }

    // Reset the quantity of the ingredient to its original value
    public void ResetQuantity()
    {
        Quantity /= 2;
    }
}
