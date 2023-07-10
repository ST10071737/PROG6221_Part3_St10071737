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

        public override string ToString()
        {
            return this.RecipeName;
        }
        //___________________________________________________________________________________________________________
    }
}
