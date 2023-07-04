using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG6221_Part3_St10071737.MVVM.View;

namespace PROG6221_Part3_St10071737.Classes
{
    internal class RecipeClass
    {
        /// <summary>
        /// Stores the name of a recipe.
        /// </summary>
        private String RecipeName = String.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Creates a new instance of the IngredientsClass class.
        /// </summary>
        private IngredientsClass IngredientsHere;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Creates a new instance of the StepsClass class.
        /// </summary>
        private StepsClass StepsHere = new StepsClass();
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Represents an List of IngredientsClass objects.
        /// </summary>
        private List<IngredientsClass> IngredientsList;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Represents an List of StepsClass objects.
        /// </summary>
        private List<StepsClass> StepsList;
        //___________________________________________________________________________________________________________


    }
}
