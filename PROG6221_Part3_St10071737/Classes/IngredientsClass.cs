using System;

namespace PROG6221_Part3_St10071737.Classes
{
    public class IngredientsClass
    {

        /// <summary>
        /// Property to store the name of an ingredient.
        /// </summary>
        public string _IngredientName { get; set; } = String.Empty;

        public string IngredientName
        {
            get { return _IngredientName; }
            set { _IngredientName = value; }
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Property to store the quantity of an ingredient.
        /// </summary>
        public double IngredientQuantity { get; set; } = 0;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Property to store the ingredient unit of measure.
        /// </summary>
        public string IngredientUoM { get; set; } = String.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Property to store the ingredient unit of measure and quantity. 
        /// </summary>
        public double IngredientCalories { get; set; } = 0;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Property to store the ingredient unit of measure and quantity. 
        /// </summary>
        public string IngredientFoodGroup { get; set; } = String.Empty;
        //___________________________________________________________________________________________________________
        /// <summary>
        /// Constructor for the ingredients class.
        /// </summary>
        /// <param name="IN">Name of the ingredient.</param>
        /// <param name="IQ">Quantity of the ingredient.</param>
        /// <param name="IUoM">Unit of measure of the ingredient.</param>
        /// <param name="IC">calories of the ingredient.</param>
        /// <param name="IFG">Food group  of the ingredient.</param>
        /// <returns>
        /// An instance of the ingredients class.
        /// </returns>
        public IngredientsClass(string IN, int IQ, string IUoM, double IC, string IFG)
        {
            this.IngredientName = IN;
            this.IngredientQuantity = IQ;
            this.IngredientUoM = IUoM;
            this.IngredientCalories = IC;
            this.IngredientFoodGroup = IFG;
        }
        //___________________________________________________________________________________________________________
        /// <summary>
        /// Constructor for the IngredientsClass class. 
        /// </summary>
        /// <returns>
        /// Nothing. 
        /// </returns>
        public IngredientsClass()
        {
        }
        //___________________________________________________________________________________________________________

        public double GetCalories()
        {
            return this.IngredientCalories;
        }

        //___________________________________________________________________________________________________________

        public override string ToString()
        {
            return this.IngredientQuantity + " " + this.IngredientUoM + " of " + this.IngredientName +
                "\r\n( Food group: " + this.IngredientFoodGroup + ", Calories: " + this.IngredientCalories;
        }

    }
}
//____________________________________EOF_________________________________________________________________________
