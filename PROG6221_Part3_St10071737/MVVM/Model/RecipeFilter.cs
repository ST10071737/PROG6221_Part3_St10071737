using PROG6221_Part3_St10071737.Classes;
using System.Collections.ObjectModel;

namespace PROG6221_Part3_St10071737.MVVM.Model
{
    internal class RecipeFilter
    {
        private string IngredientFilter = string.Empty;
        //___________________________________________________________________________________________________________

        private string FoodGroupFilter = string.Empty;
        //___________________________________________________________________________________________________________

        private double MaxCalorieFilter = 0.0;
        //___________________________________________________________________________________________________________

        public RecipeFilter(string IngredientFilter, string foodGroupFilter, double maxCalorieFilter)
        {
            this.IngredientFilter= IngredientFilter;
            this.FoodGroupFilter= foodGroupFilter;
            this.MaxCalorieFilter= maxCalorieFilter;
        }
        //___________________________________________________________________________________________________________

        public ObservableCollection<RecipeClass> FilteredRecipeList(ObservableCollection<RecipeClass> recipeClassList)
        {
            var filtered = new ObservableCollection<RecipeClass>();

           

            foreach (var recipe in recipeClassList)
            {

                bool ingredintsFilter = true;
                bool foodGroupFilter = true;
                bool maxCalorieFilter = true;

                if (!this.MaxCalorieFilter.Equals(0.0))
                {
                    maxCalorieFilter = recipe.TotalCalories() <= this.MaxCalorieFilter;
                }

                foreach (var ingredient in recipe.IngredientsList)
                {
                    if (!this.FoodGroupFilter.Equals(string.Empty))
                    {
                        foodGroupFilter = ingredient.IngredientFoodGroup.Equals(this.FoodGroupFilter);
                    }
                    if (!string.IsNullOrEmpty(this.IngredientFilter))
                    {
                        ingredintsFilter = ingredient.IngredientName.ToUpper().Equals(this.IngredientFilter.ToUpper());
                    }
                }

                if(ingredintsFilter &&  foodGroupFilter && maxCalorieFilter) 
                {
                    filtered.Add(recipe);
                }
            }

            return filtered;
        }

    }
}
//____________________________________EOF_________________________________________________________________________