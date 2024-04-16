using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10066249_POE_Part1
{
    internal class Recipe
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

    }
}
