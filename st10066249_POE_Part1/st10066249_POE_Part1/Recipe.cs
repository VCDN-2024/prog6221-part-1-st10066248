using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10066249_POE_Part1
{
    
        class Recipe
        {

            public List<Ingredient> Ingredients { get; set; }
            public List<RecipeStep> Steps { get; set; }

            public Recipe()
            {
                Ingredients = new List<Ingredient>();
                Steps = new List<RecipeStep>();
            }

            public void AddIngredient(string name, double quantity, string unit)
            {
                Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
            }

            public void AddStep(string description)
            {
                Steps.Add(new RecipeStep { Description = description });
            }

            public void DisplayRecipe()
            {
                Console.WriteLine("Recipe:");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                }
                Console.WriteLine("Steps:");
                int stepNumber = 1;
                foreach (var step in Steps)
                {
                    Console.WriteLine($"{stepNumber}. {step.Description}");
                    stepNumber++;
                }
            }

            public void ScaleRecipe(double factor)
            {
                foreach (var ingredient in Ingredients)
                {
                    ingredient.Quantity *= factor;
                }
            } // looping through to change the scale 

            public void ResetQuantities(double factor)
            {
                foreach (var ingredient in Ingredients)
                {
                    ingredient.Quantity /= factor;
                } // looping through to change back to the orginal
            }

            public void ClearRecipe()
            {
                Ingredients.Clear();
                Steps.Clear();
            }
        }

    }

