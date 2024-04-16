using st10066249_POE_Part1;

 class Program
{
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            Console.ForegroundColor
           = ConsoleColor.Blue; // foreground colour changed
            Console.WriteLine("Enter the details for the recipe:"); 

            // Try-Catch for number of ingredients
            try
            {
                Console.Write("Number of ingredients: ");
                int numOfIngredients = int.Parse(Console.ReadLine());

                for (int i = 0; i < numOfIngredients; i++)
                {
                    Console.Write("Ingredient name: ");
                    string name = Console.ReadLine();
                    Console.Write("Quantity: ");
                    double quantity = double.Parse(Console.ReadLine());
                    Console.Write("Unit: ");
                    string unit = Console.ReadLine();
                    recipe.AddIngredient(name, quantity, unit);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number for the number of ingredients.");
            }

            // Try-Catch for number of steps
            try
            {
                Console.Write("Number of steps: ");
                int numOfSteps = int.Parse(Console.ReadLine());

                for (int i = 0; i < numOfSteps; i++)
                {
                    Console.Write($"Step {i + 1}: ");
                    string description = Console.ReadLine();
                    recipe.AddStep(description);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number for the number of steps.");
            }

            recipe.DisplayRecipe();

            Console.WriteLine("Enter a scaling factor (0.5, 2, or 3):");
            double factor = double.Parse(Console.ReadLine());
            recipe.ScaleRecipe(factor);
            recipe.DisplayRecipe(); // factor scaled

            Console.WriteLine("Do you want to reset quantities to original values? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                recipe.ResetQuantities(factor);
                recipe.DisplayRecipe();
            }

            Console.WriteLine("Do you want to clear all data and enter a new recipe? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                recipe.ClearRecipe();
                Main(args); // Restart the application to enter a new recipe
            }
        }
    }
// code attribution : Troelsen, Andrew, and Philip Japikse. Pro C# 10 with .NET 6. Apress, 11 Aug. 2022.