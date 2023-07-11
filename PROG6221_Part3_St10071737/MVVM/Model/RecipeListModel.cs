using PROG6221_Part3_St10071737.Classes;
using System.Collections.ObjectModel;

namespace PROG6221_Part3_St10071737.MVVM.Model
{
    public class RecipeListModel
    {
        private static ObservableCollection<RecipeClass> recipeList = new ObservableCollection<RecipeClass>();
        //___________________________________________________________________________________________________________

        public RecipeListModel()
        {
        }
        //___________________________________________________________________________________________________________

        public static void AddRecipe(RecipeClass recipe)
        {
            recipeList.Add(recipe);
        }
        //___________________________________________________________________________________________________________

        public static ObservableCollection<RecipeClass> ReturnRecipes()
        {
            return recipeList;
        }
        //___________________________________________________________________________________________________________

        public static void ClearRecipes(RecipeClass recipe)
        {
            recipeList.Remove(recipe);
        }
        //___________________________________________________________________________________________________________

    }
}
//____________________________________EOF_________________________________________________________________________