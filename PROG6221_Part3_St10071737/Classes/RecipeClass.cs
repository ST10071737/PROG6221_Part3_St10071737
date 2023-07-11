using System;
using System.Collections.ObjectModel;

namespace PROG6221_Part3_St10071737.Classes
{
    public class RecipeClass
    {
        /// <summary>
        /// Stores the name of a recipe.
        /// </summary>
        public String RecipeName = String.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Creates a new instance of the IngredientsClass class.
        /// </summary>
        public IngredientsClass IngredientsHere;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Creates a new instance of the StepsClass class.
        /// </summary>
        public StepsClass StepsHere = new StepsClass();
        //___________________________________________________________________________________________________________

        public double RecipeScale { get; set; } = 1.0;

        /// <summary>
        /// Represents an List of IngredientsClass objects.
        /// </summary>
        public ObservableCollection<IngredientsClass> IngredientsList { get; set; } = new ObservableCollection<IngredientsClass>();
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Represents an List of StepsClass objects.
        /// </summary>
        public ObservableCollection<StepsClass> StepsList { get; set; } = new ObservableCollection<StepsClass>();
        //___________________________________________________________________________________________________________

        public RecipeClass()
        {
        }

        //___________________________________________________________________________________________________________

        public double TotalCalories()
        {
            double totalCalories = 0;

            foreach (IngredientsClass ingredients in IngredientsList)
            {
                totalCalories += ingredients.GetCalories();
            }
            return totalCalories * this.RecipeScale;
        }
        //___________________________________________________________________________________________________________

        public String PrintIngredients()
        {
            var Print = "";
            foreach (IngredientsClass ingredients in IngredientsList)
            {
                Print += ingredients.ToString() + "\r\n\r\n";
            }
            return Print;
        }

        //___________________________________________________________________________________________________________
        public String PrintSteps()
        {
            var Print = "";
            var count = 1;
            foreach (StepsClass step in StepsList)
            {
                Print += "Step " + count + "\r\n" + step.ToString() + "\r\n\r\n";
                count++;
            }
            return Print;
        }

        //___________________________________________________________________________________________________________

        public override string ToString()
        {
            return this.RecipeName;
        }
        //___________________________________________________________________________________________________________

        public RecipeClass CreteScaledRecipe(double scale)
        {
            RecipeClass scaledRecipe = new RecipeClass
            {
                RecipeName = this.RecipeName,
                RecipeScale = scale,
            };

            foreach (IngredientsClass ingredients in this.IngredientsList)
            {
                IngredientsClass ScaledIngredient = new IngredientsClass
                {
                    IngredientName = ingredients.IngredientName,
                    IngredientQuantity = ingredients.IngredientQuantity * scale,
                    IngredientUoM = ingredients.IngredientUoM,
                    IngredientCalories = ingredients.IngredientCalories,
                    IngredientFoodGroup = ingredients.IngredientFoodGroup,
                };

                scaledRecipe.IngredientsList.Add(ScaledIngredient);
            }

            foreach (StepsClass step in this.StepsList)
            {
                scaledRecipe.StepsList.Add(step);
            }

            return scaledRecipe;
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________