using PROG6221_Part3_St10071737.Classes;
using System.Collections.ObjectModel;

namespace PROG6221_Part3_St10071737.MVVM.Model
{
    public class RecipeListModel
    {
        private static ObservableCollection<RecipeClass> recipeList = new ObservableCollection<RecipeClass>();

        public RecipeListModel()
        {
        }

        public static void AddRecipe(RecipeClass recipe)
        {
            recipeList.Add(recipe);
        }
        public static ObservableCollection<RecipeClass> ReturnRecipes()
        {
            return recipeList;
        }

        public static void ClearRecipes(RecipeClass recipe)
        {
            recipeList.Remove(recipe);
        }
    }
}
